using System;
using System.Runtime.Serialization;
using KentekenApi.Net.Overheid.Wrappers;

namespace KentekenApi.Net.Overheid.Model
{
    [DataContract]
    public class KentekenView
    {
        [DataMember(Name = "aantalcilinders", EmitDefaultValue = false)]
        public int AantalCilinders { get; set; }

        [DataMember(Name = "aantalzitplaatsen", EmitDefaultValue = false)]
        public int AantalZitplaatsen { get; set; }

        [DataMember(Name = "bpm", EmitDefaultValue = false)]
        public int Bpm { get; set; }

        [DataMember(Name = "catalogusprijs", EmitDefaultValue = false)]
        public int Catalogusprijs { get; set; }

        [DataMember(Name = "cilinderinhoud", EmitDefaultValue = false)]
        public int Cilinderinhoud { get; set; }

        [DataMember(Name = "datumaanvangtenaamstelling", EmitDefaultValue = false)]
        public DateTime DatumAanvangTenaamstelling { get; set; }

        [DataMember(Name = "datumeersteafgiftenederland", EmitDefaultValue = false)]
        public DateTime DatumEersteAfgifteNederland { get; set; }

        [DataMember(Name = "datumeerstetoelating", EmitDefaultValue = false)]
        public DateTime DatumEersteToelating { get; set; }

        [DataMember(Name = "eerstekleur", EmitDefaultValue = false)]
        public string EersteKleur { get; set; }

        [DataMember(Name = "g3installatie", EmitDefaultValue = false)]
        public string G3Installatie { get; set; }

        [DataMember(Name = "handelsbenaming", EmitDefaultValue = false)]
        public string Handelsbenaming { get; set; }

        [DataMember(Name = "hoofdbrandstof", EmitDefaultValue = false)]
        public string Hoofdbrandstof { get; set; }

        [DataMember(Name = "inrichting", EmitDefaultValue = false)]
        public string Inrichting { get; set; }

        [DataMember(Name = "kenteken", EmitDefaultValue = false)]
        public string Kenteken { get; set; }

        [DataMember(Name = "massaleegvoertuig", EmitDefaultValue = false)]
        public int MassaLeegVoertuig { get; set; }

        [DataMember(Name = "massarijklaar", EmitDefaultValue = false)]
        public int MassaRijklaar { get; set; }

        [DataMember(Name = "merk", EmitDefaultValue = false)]
        public string Merk { get; set; }

        [DataMember(Name = "milieuclassificatie", EmitDefaultValue = false)]
        public string Milieuclassificatie { get; set; }

        [DataMember(Name = "nevenbrandstof", EmitDefaultValue = false)]
        public string Nevenbrandstof { get; set; }

        [DataMember(Name = "retrofitroetfilter", EmitDefaultValue = false)]
        public string RetrofitRoetfilter { get; set; }

        [DataMember(Name = "toegestanemaximummassavoertuig", EmitDefaultValue = false)]
        public int ToegestaneMaximumMassaVoertuig { get; set; }

        [DataMember(Name = "tweedekleur", EmitDefaultValue = false)]
        public string TweedeKleur { get; set; }

        [DataMember(Name = "vermogen", EmitDefaultValue = false)]
        public int Vermogen { get; set; }

        [DataMember(Name = "vervaldatumapk", EmitDefaultValue = false)]
        public DateTime VervaldatumApk { get; set; }

        [DataMember(Name = "voertuigsoort", EmitDefaultValue = false)]
        public string Voertuigsoort { get; set; }

        [DataMember(Name = "wachtopkeuren", EmitDefaultValue = false)]
        public string WachtOpKeuren { get; set; }

        [DataMember(Name = "wamverzekerdgeregistreerd", EmitDefaultValue = false)]
        public string WamVerzekerdGeregistreerd { get; set; }

        [DataMember(Name = "zuinigheidslabel", EmitDefaultValue = false)]
        public string Zuinigheidslabel { get; set; }

        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public HalNavigator Links { get; set; }
    }
}
