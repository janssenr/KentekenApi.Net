using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using KentekenApi.Net.Helpers;
using KentekenApi.Net.Overheid.Model;
using KentekenApi.Net.Overheid.Wrappers;

namespace KentekenApi.Net.Overheid
{
    public class KentekenApiClient
    {
        public string EndpointUrl { get; set; }
        public string HeaderKey { get; set; }
        public string ApiKey { get; set; }

        public KentekenApiClient(string apiKey)
        {
            EndpointUrl = "http://overheid.io/api/voertuiggegevens/";
            HeaderKey = "ovio-api-key";
            ApiKey = apiKey;
        }

        public KentekenView GetKenteken(string kenteken)
        {
            var headers = new WebHeaderCollection
            {
                {HeaderKey, ApiKey}
            };

            var url = EndpointUrl + kenteken + "/";
            var response = DoRestCall(url, "GET", headers);
            return JsonHelper.Deserialize<KentekenView>(response, new DateTimeFormat("yyyy-MM-ddTHH:mm:sszzz"));
        }

        public ApiHalResultWrapper GetKentekens(Dictionary<string, string> filters)
        {
            var headers = new WebHeaderCollection
            {
                {HeaderKey, ApiKey}
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
            return JsonHelper.Deserialize<ApiHalResultWrapper>(response, new DateTimeFormat("yyyy-MM-ddTHH:mm:sszzz"));
        }

        public ApiHalResultWrapper GetKentekens(string query, string[] queryFields, string[] fields)
        {
            var headers = new WebHeaderCollection
            {
                {HeaderKey, ApiKey}
            };

            var parameters = new List<KeyValuePair<string, string>> {new KeyValuePair<string, string>("query", query)};
            foreach (var queryField in queryFields)
            {
                parameters.Add(new KeyValuePair<string, string>("queryfields[]", queryField));
            }
            foreach (var field in fields)
            {
                parameters.Add(new KeyValuePair<string, string>("fields[]", field));
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
            return JsonHelper.Deserialize<ApiHalResultWrapper>(response, new DateTimeFormat("yyyy-MM-ddTHH:mm:sszzz"));
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
