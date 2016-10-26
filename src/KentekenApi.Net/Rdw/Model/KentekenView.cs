using System;
using System.Runtime.Serialization;

namespace KentekenApi.Net.Rdw.Model
{
    [DataContract]
    public class KentekenView
    {
        [DataMember(Name = "aantal_cilinders", EmitDefaultValue = false)]
        public int AantalCilinders { get; set; }

        [DataMember(Name = "aantal_deuren", EmitDefaultValue = false)]
        public int AantalDeuren { get; set; }

        [DataMember(Name = "aantal_wielen", EmitDefaultValue = false)]
        public int AantalWielen { get; set; }

        [DataMember(Name = "afstand_hart_koppeling_tot_achterzijde_voertuig", EmitDefaultValue = false)]
        public int AfstandHartKoppelingTotAchterzijdeVoertuig { get; set; }

        [DataMember(Name = "afstand_voorzijde_voertuig_tot_hart_koppeling", EmitDefaultValue = false)]
        public int AfstandVoorzijdeVoertuigTotHartKoppeling { get; set; }

        [DataMember(Name = "api_gekentekende_voertuigen_assen", EmitDefaultValue = false)]
        public string ApiGekentekendeVoertuigenAssen { get; set; }

        [DataMember(Name = "api_gekentekende_voertuigen_brandstof", EmitDefaultValue = false)]
        public string ApiGekentekendeVoertuigenBrandstof { get; set; }

        [DataMember(Name = "api_gekentekende_voertuigen_carrosserie", EmitDefaultValue = false)]
        public string ApiGekentekendeVoertuigenCarrosserie { get; set; }

        [DataMember(Name = "api_gekentekende_voertuigen_carrosserie_specifiek", EmitDefaultValue = false)]
        public string ApiGekentekendeVoertuigenCarrosserieSpecifiek { get; set; }

        [DataMember(Name = "api_gekentekende_voertuigen_voertuigklasse", EmitDefaultValue = false)]
        public string ApiGekentekendeVoertuigenVoertuigklasse { get; set; }

        [DataMember(Name = "breedte", EmitDefaultValue = false)]
        public int Breedte { get; set; }

        [DataMember(Name = "cilinderinhoud", EmitDefaultValue = false)]
        public int Cilinderinhoud { get; set; }

        [DataMember(Name = "datum_eerste_afgifte_nederland", EmitDefaultValue = false)]
        public DateTime DatumEersteAfgifteNederland { get; set; }

        [DataMember(Name = "datum_eerste_toelating", EmitDefaultValue = false)]
        public DateTime DatumEersteToelating { get; set; }

        [DataMember(Name = "datum_tenaamstelling", EmitDefaultValue = false)]
        public DateTime DatumTenaamstelling { get; set; }

        [DataMember(Name = "eerste_kleur", EmitDefaultValue = false)]
        public string EersteKleur { get; set; }

        [DataMember(Name = "europese_uitvoeringcategorie_toevoeging", EmitDefaultValue = false)]
        public string EuropeseUitvoeringcategorieToevoeging { get; set; }

        [DataMember(Name = "europese_voertuigcategorie", EmitDefaultValue = false)]
        public string EuropeseVoertuigcategorie { get; set; }

        [DataMember(Name = "europese_voertuigcategorie_toevoeging", EmitDefaultValue = false)]
        public string EuropeseVoertuigcategorieToevoeging { get; set; }

        [DataMember(Name = "export_indicator", EmitDefaultValue = false)]
        public string ExportIndicator { get; set; }

        [DataMember(Name = "handelsbenaming", EmitDefaultValue = false)]
        public string Handelsbenaming { get; set; }

        [DataMember(Name = "inrichting", EmitDefaultValue = false)]
        public string Inrichting { get; set; }

        [DataMember(Name = "kenteken", EmitDefaultValue = false)]
        public string Kenteken { get; set; }

        [DataMember(Name = "lengte", EmitDefaultValue = false)]
        public int Lengte { get; set; }

        [DataMember(Name = "massa_ledig_voertuig", EmitDefaultValue = false)]
        public int MassaLedigVoertuig { get; set; }

        [DataMember(Name = "massa_rijklaar", EmitDefaultValue = false)]
        public int MassaRijklaar { get; set; }

        [DataMember(Name = "maximale_constructiesnelheid_brom_snorfiets", EmitDefaultValue = false)]
        public int MaximaleConstructiesnelheidBromSnorfiets { get; set; }

        [DataMember(Name = "merk", EmitDefaultValue = false)]
        public string Merk { get; set; }

        [DataMember(Name = "openstaande_terugroepactie_indicator", EmitDefaultValue = false)]
        public string OpenstaandeTerugroepactieIndicator { get; set; }

        [DataMember(Name = "plaats_chassisnummer", EmitDefaultValue = false)]
        public string PlaatsChassisnummer { get; set; }

        [DataMember(Name = "technische_max_massa_voertuig", EmitDefaultValue = false)]
        public int TechnischeMaxMassaVoertuig { get; set; }

        [DataMember(Name = "toegestane_maximum_massa_voertuig", EmitDefaultValue = false)]
        public int ToegestaneMaximumMassaVoertuig { get; set; }

        [DataMember(Name = "tweede_kleur", EmitDefaultValue = false)]
        public string TweedeKleur { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "typegoedkeuringsnummer", EmitDefaultValue = false)]
        public string Typegoedkeuringsnummer { get; set; }

        [DataMember(Name = "uitvoering", EmitDefaultValue = false)]
        public string Uitvoering { get; set; }

        [DataMember(Name = "variant", EmitDefaultValue = false)]
        public string Variant { get; set; }

        [DataMember(Name = "vermogen_brom_snorfiets", EmitDefaultValue = false)]
        public double VermogenBromSnorfiets { get; set; }

        [DataMember(Name = "vermogen_massarijklaar", EmitDefaultValue = false)]
        public double VermogenMassarijklaar { get; set; }

        [DataMember(Name = "voertuigsoort", EmitDefaultValue = false)]
        public string Voertuigsoort { get; set; }

        [DataMember(Name = "volgnummer_wijziging_eu_typegoedkeuring", EmitDefaultValue = false)]
        public string VolgnummerWijzigingEuTypegoedkeuring { get; set; }

        [DataMember(Name = "wacht_op_keuren", EmitDefaultValue = false)]
        public string WachtOpKeuren { get; set; }

        [DataMember(Name = "wam_verzekerd", EmitDefaultValue = false)]
        public string WamVerzekerd { get; set; }

        [DataMember(Name = "wielbasis", EmitDefaultValue = false)]
        public int Wielbasis { get; set; }
    }
}
