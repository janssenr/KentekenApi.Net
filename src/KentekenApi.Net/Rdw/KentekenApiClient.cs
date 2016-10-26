using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using KentekenApi.Net.Helpers;
using KentekenApi.Net.Rdw.Model;
using KentekenApi.Net.Rdw.Wrappers;

namespace KentekenApi.Net.Rdw
{
    public class KentekenApiClient
    {
        public string EndpointUrl { get; set; }
        public string HeaderKey { get; set; }
        public string AppToken { get; set; }

        public KentekenApiClient(string appToken)
        {
            EndpointUrl = "https://opendata.rdw.nl/resource/m9d7-ebf2.json";
            HeaderKey = "X-App-Token";
            AppToken = appToken;
        }

        public ResultWrapper GetKenteken(Dictionary<string, string> filters)
        {
            var headers = new WebHeaderCollection
            {
                {HeaderKey, AppToken}
            };

            var parameters = new Dictionary<string, string>();
            foreach (var key in filters.Keys)
            {
                parameters.Add(key, filters[key]);
            }

            var queryString = string.Join("&",
                parameters.Select(
                    p =>
                        string.IsNullOrEmpty(p.Value)
                            ? Uri.EscapeDataString(p.Key)
                            : string.Format("{0}={1}", Uri.EscapeDataString(p.Key),
                                Uri.EscapeDataString(p.Value))));
            var url = EndpointUrl + "?" + queryString;
            var response = DoRestCall(url, "GET", headers);
            return JsonHelper.Deserialize<ResultWrapper>(response, new DateTimeFormat("dd/MM/yyyy"));
        }

        private string DoRestCall(string url, string method, WebHeaderCollection headers = null, string contentType = null, byte[] data = null)
        {
            var req = WebRequest.Create(url);
            req.Method = method;
            if (headers != null)
            {
                foreach (var key in headers.AllKeys)
                {
                    req.Headers.Add(key, headers[key]);
                }
            }
            if (method.ToUpper() != "GET" && data != null)
            {
                req.ContentType = contentType;
                req.ContentLength = data.Length;
                using (Stream stream = req.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }

            string responseValue = string.Empty;
            try
            {
                using (var response = (HttpWebResponse)req.GetResponse())
                {
                    //_responseHeaders = response.Headers;
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (var reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                                reader.Close();
                            }
                            responseStream.Close();
                        }
                    }
                    response.Close();
                }
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;
                //_responseHeaders = response.Headers;
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                            reader.Close();
                        }
                        responseStream.Close();
                    }
                }
                response.Close();
                var exception = JsonHelper.Deserialize<CouldNotParseResponseException>(responseValue);

                switch ((int)response.StatusCode)
                {
                    case (int)HttpStatusCode.BadRequest: //400
                    case (int)HttpStatusCode.Unauthorized: //401
                    case (int)HttpStatusCode.Forbidden: //403
                    case (int)HttpStatusCode.NotFound: //404
                    case (int)HttpStatusCode.UnsupportedMediaType: //415
                    case (int)HttpStatusCode.InternalServerError: //500
                        throw new Exception(exception.Message);
                    default:
                        throw new Exception(exception.Message);
                }
            }
            return responseValue;
        }
    }
}
