using System;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using PS.Mothership.Core.Common.Template.Gen;

namespace PS.Mothership.Core.Common.Template.Gen
{
    
    [DataContract]
    public enum GenCountryEnum : int
    {
       [Description("None")][EnumMember]None = 0,
       [Description("Afghanistan")][EnumMember]Afghanistan = 1,
       [Description("Albania")][EnumMember]Albania = 2,
       [Description("Algeria")][EnumMember]Algeria = 3,
       [Description("American Samoa")][EnumMember]AmericanSamoa = 4,
       [Description("Andorra")][EnumMember]Andorra = 5,
       [Description("Angola")][EnumMember]Angola = 6,
       [Description("Anguilla")][EnumMember]Anguilla = 7,
       [Description("Antarctica")][EnumMember]Antarctica = 8,
       [Description("Antigua and Barbuda")][EnumMember]AntiguaandBarbuda = 9,
       [Description("Argentina")][EnumMember]Argentina = 10,
       [Description("Armenia")][EnumMember]Armenia = 11,
       [Description("Aruba")][EnumMember]Aruba = 12,
       [Description("Australia")][EnumMember]Australia = 13,
       [Description("Austria")][EnumMember]Austria = 14,
       [Description("Azerbaijan")][EnumMember]Azerbaijan = 15,
       [Description("Bahamas")][EnumMember]Bahamas = 16,
       [Description("Bahrain")][EnumMember]Bahrain = 17,
       [Description("Bangladesh")][EnumMember]Bangladesh = 18,
       [Description("Barbados")][EnumMember]Barbados = 19,
       [Description("Belarus")][EnumMember]Belarus = 20,
       [Description("Belgium")][EnumMember]Belgium = 21,
       [Description("Belize")][EnumMember]Belize = 22,
       [Description("Benin")][EnumMember]Benin = 23,
       [Description("Bermuda")][EnumMember]Bermuda = 24,
       [Description("Bhutan")][EnumMember]Bhutan = 25,
       [Description("Bolivia")][EnumMember]Bolivia = 26,
       [Description("Bosnia and Herzegovina")][EnumMember]BosniaandHerzegovina = 27,
       [Description("Botswana")][EnumMember]Botswana = 28,
       [Description("Brazil")][EnumMember]Brazil = 29,
       [Description("British Indian Ocean Territory")][EnumMember]BritishIndianOceanTerritory = 30,
       [Description("British Virgin Islands")][EnumMember]BritishVirginIslands = 31,
       [Description("Brunei")][EnumMember]Brunei = 32,
       [Description("Bulgaria")][EnumMember]Bulgaria = 33,
       [Description("Burkina Faso")][EnumMember]BurkinaFaso = 34,
       [Description("Burma (Myanmar)")][EnumMember]BurmaMyanmar = 35,
       [Description("Burundi")][EnumMember]Burundi = 36,
       [Description("Cambodia")][EnumMember]Cambodia = 37,
       [Description("Cameroon")][EnumMember]Cameroon = 38,
       [Description("Canada")][EnumMember]Canada = 39,
       [Description("Cape Verde")][EnumMember]CapeVerde = 40,
       [Description("Cayman Islands")][EnumMember]CaymanIslands = 41,
       [Description("Central African Republic")][EnumMember]CentralAfricanRepublic = 42,
       [Description("Chad")][EnumMember]Chad = 43,
       [Description("Chile")][EnumMember]Chile = 44,
       [Description("China")][EnumMember]China = 45,
       [Description("Christmas Island")][EnumMember]ChristmasIsland = 46,
       [Description("Cocos (Keeling) Islands")][EnumMember]CocosKeelingIslands = 47,
       [Description("Colombia")][EnumMember]Colombia = 48,
       [Description("Comoros")][EnumMember]Comoros = 49,
       [Description("Cook Islands")][EnumMember]CookIslands = 50,
       [Description("Costa Rica")][EnumMember]CostaRica = 51,
       [Description("Croatia")][EnumMember]Croatia = 52,
       [Description("Cuba")][EnumMember]Cuba = 53,
       [Description("Cyprus")][EnumMember]Cyprus = 54,
       [Description("Czech Republic")][EnumMember]CzechRepublic = 55,
       [Description("Democratic Republic of the Congo")][EnumMember]DemocraticRepublicoftheCongo = 56,
       [Description("Denmark")][EnumMember]Denmark = 57,
       [Description("Djibouti")][EnumMember]Djibouti = 58,
       [Description("Dominica")][EnumMember]Dominica = 59,
       [Description("Dominican Republic")][EnumMember]DominicanRepublic = 60,
       [Description("Ecuador")][EnumMember]Ecuador = 61,
       [Description("Egypt")][EnumMember]Egypt = 62,
       [Description("El Salvador")][EnumMember]ElSalvador = 63,
       [Description("Equatorial Guinea")][EnumMember]EquatorialGuinea = 64,
       [Description("Eritrea")][EnumMember]Eritrea = 65,
       [Description("Estonia")][EnumMember]Estonia = 66,
       [Description("Ethiopia")][EnumMember]Ethiopia = 67,
       [Description("Falkland Islands")][EnumMember]FalklandIslands = 68,
       [Description("Faroe Islands")][EnumMember]FaroeIslands = 69,
       [Description("Fiji")][EnumMember]Fiji = 70,
       [Description("Finland")][EnumMember]Finland = 71,
       [Description("France")][EnumMember]France = 72,
       [Description("French Polynesia")][EnumMember]FrenchPolynesia = 73,
       [Description("Gabon")][EnumMember]Gabon = 74,
       [Description("Gambia")][EnumMember]Gambia = 75,
       [Description("Gaza Strip")][EnumMember]GazaStrip = 76,
       [Description("Georgia")][EnumMember]Georgia = 77,
       [Description("Germany")][EnumMember]Germany = 78,
       [Description("Ghana")][EnumMember]Ghana = 79,
       [Description("Gibraltar")][EnumMember]Gibraltar = 80,
       [Description("Greece")][EnumMember]Greece = 81,
       [Description("Greenland")][EnumMember]Greenland = 82,
       [Description("Grenada")][EnumMember]Grenada = 83,
       [Description("Guam")][EnumMember]Guam = 84,
       [Description("Guatemala")][EnumMember]Guatemala = 85,
       [Description("Guinea")][EnumMember]Guinea = 86,
       [Description("Guinea-Bissau")][EnumMember]GuineaBissau = 87,
       [Description("Guyana")][EnumMember]Guyana = 88,
       [Description("Haiti")][EnumMember]Haiti = 89,
       [Description("Holy See (Vatican City)")][EnumMember]HolySeeVaticanCity = 90,
       [Description("Honduras")][EnumMember]Honduras = 91,
       [Description("Hong Kong")][EnumMember]HongKong = 92,
       [Description("Hungary")][EnumMember]Hungary = 93,
       [Description("Iceland")][EnumMember]Iceland = 94,
       [Description("India")][EnumMember]India = 95,
       [Description("Indonesia")][EnumMember]Indonesia = 96,
       [Description("Iran")][EnumMember]Iran = 97,
       [Description("Iraq")][EnumMember]Iraq = 98,
       [Description("Ireland")][EnumMember]Ireland = 99,
       [Description("Isle of Man")][EnumMember]IsleofMan = 100,
       [Description("Israel")][EnumMember]Israel = 101,
       [Description("Italy")][EnumMember]Italy = 102,
       [Description("Ivory Coast")][EnumMember]IvoryCoast = 103,
       [Description("Jamaica")][EnumMember]Jamaica = 104,
       [Description("Japan")][EnumMember]Japan = 105,
       [Description("Jersey")][EnumMember]Jersey = 106,
       [Description("Jordan")][EnumMember]Jordan = 107,
       [Description("Kazakhstan")][EnumMember]Kazakhstan = 108,
       [Description("Kenya")][EnumMember]Kenya = 109,
       [Description("Kiribati")][EnumMember]Kiribati = 110,
       [Description("Kuwait")][EnumMember]Kuwait = 112,
       [Description("Kyrgyzstan")][EnumMember]Kyrgyzstan = 113,
       [Description("Laos")][EnumMember]Laos = 114,
       [Description("Latvia")][EnumMember]Latvia = 115,
       [Description("Lebanon")][EnumMember]Lebanon = 116,
       [Description("Lesotho")][EnumMember]Lesotho = 117,
       [Description("Liberia")][EnumMember]Liberia = 118,
       [Description("Libya")][EnumMember]Libya = 119,
       [Description("Liechtenstein")][EnumMember]Liechtenstein = 120,
       [Description("Lithuania")][EnumMember]Lithuania = 121,
       [Description("Luxembourg")][EnumMember]Luxembourg = 122,
       [Description("Macau")][EnumMember]Macau = 123,
       [Description("Macedonia")][EnumMember]Macedonia = 124,
       [Description("Madagascar")][EnumMember]Madagascar = 125,
       [Description("Malawi")][EnumMember]Malawi = 126,
       [Description("Malaysia")][EnumMember]Malaysia = 127,
       [Description("Maldives")][EnumMember]Maldives = 128,
       [Description("Mali")][EnumMember]Mali = 129,
       [Description("Malta")][EnumMember]Malta = 130,
       [Description("Marshall Islands")][EnumMember]MarshallIslands = 131,
       [Description("Mauritania")][EnumMember]Mauritania = 132,
       [Description("Mauritius")][EnumMember]Mauritius = 133,
       [Description("Mayotte")][EnumMember]Mayotte = 134,
       [Description("Mexico")][EnumMember]Mexico = 135,
       [Description("Micronesia")][EnumMember]Micronesia = 136,
       [Description("Moldova")][EnumMember]Moldova = 137,
       [Description("Monaco")][EnumMember]Monaco = 138,
       [Description("Mongolia")][EnumMember]Mongolia = 139,
       [Description("Montenegro")][EnumMember]Montenegro = 140,
       [Description("Montserrat")][EnumMember]Montserrat = 141,
       [Description("Morocco")][EnumMember]Morocco = 142,
       [Description("Mozambique")][EnumMember]Mozambique = 143,
       [Description("Namibia")][EnumMember]Namibia = 144,
       [Description("Nauru")][EnumMember]Nauru = 145,
       [Description("Nepal")][EnumMember]Nepal = 146,
       [Description("Netherlands")][EnumMember]Netherlands = 147,
       [Description("Netherlands Antilles")][EnumMember]NetherlandsAntilles = 148,
       [Description("New Caledonia")][EnumMember]NewCaledonia = 149,
       [Description("New Zealand")][EnumMember]NewZealand = 150,
       [Description("Nicaragua")][EnumMember]Nicaragua = 151,
       [Description("Niger")][EnumMember]Niger = 152,
       [Description("Nigeria")][EnumMember]Nigeria = 153,
       [Description("Niue")][EnumMember]Niue = 154,
       [Description("Norfolk Island")][EnumMember]NorfolkIsland = 155,
       [Description("North Korea")][EnumMember]NorthKorea = 156,
       [Description("Northern Mariana Islands")][EnumMember]NorthernMarianaIslands = 157,
       [Description("Norway")][EnumMember]Norway = 158,
       [Description("Oman")][EnumMember]Oman = 159,
       [Description("Pakistan")][EnumMember]Pakistan = 160,
       [Description("Palau")][EnumMember]Palau = 161,
       [Description("Panama")][EnumMember]Panama = 162,
       [Description("Papua New Guinea")][EnumMember]PapuaNewGuinea = 163,
       [Description("Paraguay")][EnumMember]Paraguay = 164,
       [Description("Peru")][EnumMember]Peru = 165,
       [Description("Philippines")][EnumMember]Philippines = 166,
       [Description("Pitcairn Islands")][EnumMember]PitcairnIslands = 167,
       [Description("Poland")][EnumMember]Poland = 168,
       [Description("Portugal")][EnumMember]Portugal = 169,
       [Description("Puerto Rico")][EnumMember]PuertoRico = 170,
       [Description("Qatar")][EnumMember]Qatar = 171,
       [Description("Republic of the Congo")][EnumMember]RepublicoftheCongo = 172,
       [Description("Romania")][EnumMember]Romania = 173,
       [Description("Russia")][EnumMember]Russia = 174,
       [Description("Rwanda")][EnumMember]Rwanda = 175,
       [Description("Saint Barthelemy")][EnumMember]SaintBarthelemy = 176,
       [Description("Saint Helena")][EnumMember]SaintHelena = 177,
       [Description("Saint Kitts and Nevis")][EnumMember]SaintKittsandNevis = 178,
       [Description("Saint Lucia")][EnumMember]SaintLucia = 179,
       [Description("Saint Martin")][EnumMember]SaintMartin = 180,
       [Description("Saint Pierre and Miquelon")][EnumMember]SaintPierreandMiquelon = 181,
       [Description("Saint Vincent and the Grenadines")][EnumMember]SaintVincentandtheGrenadines = 182,
       [Description("Samoa")][EnumMember]Samoa = 183,
       [Description("San Marino")][EnumMember]SanMarino = 184,
       [Description("Sao Tome and Principe")][EnumMember]SaoTomeandPrincipe = 185,
       [Description("Saudi Arabia")][EnumMember]SaudiArabia = 186,
       [Description("Senegal")][EnumMember]Senegal = 187,
       [Description("Serbia")][EnumMember]Serbia = 188,
       [Description("Seychelles")][EnumMember]Seychelles = 189,
       [Description("Sierra Leone")][EnumMember]SierraLeone = 190,
       [Description("Singapore")][EnumMember]Singapore = 191,
       [Description("Slovakia")][EnumMember]Slovakia = 192,
       [Description("Slovenia")][EnumMember]Slovenia = 193,
       [Description("Solomon Islands")][EnumMember]SolomonIslands = 194,
       [Description("Somalia")][EnumMember]Somalia = 195,
       [Description("South Africa")][EnumMember]SouthAfrica = 196,
       [Description("South Korea")][EnumMember]SouthKorea = 197,
       [Description("Spain")][EnumMember]Spain = 198,
       [Description("Sri Lanka")][EnumMember]SriLanka = 199,
       [Description("Sudan")][EnumMember]Sudan = 200,
       [Description("Suriname")][EnumMember]Suriname = 201,
       [Description("Svalbard")][EnumMember]Svalbard = 202,
       [Description("Swaziland")][EnumMember]Swaziland = 203,
       [Description("Sweden")][EnumMember]Sweden = 204,
       [Description("Switzerland")][EnumMember]Switzerland = 205,
       [Description("Syria")][EnumMember]Syria = 206,
       [Description("Taiwan")][EnumMember]Taiwan = 207,
       [Description("Tajikistan")][EnumMember]Tajikistan = 208,
       [Description("Tanzania")][EnumMember]Tanzania = 209,
       [Description("Thailand")][EnumMember]Thailand = 210,
       [Description("Timor-Leste")][EnumMember]TimorLeste = 211,
       [Description("Togo")][EnumMember]Togo = 212,
       [Description("Tokelau")][EnumMember]Tokelau = 213,
       [Description("Tonga")][EnumMember]Tonga = 214,
       [Description("Trinidad and Tobago")][EnumMember]TrinidadandTobago = 215,
       [Description("Tunisia")][EnumMember]Tunisia = 216,
       [Description("Turkey")][EnumMember]Turkey = 217,
       [Description("Turkmenistan")][EnumMember]Turkmenistan = 218,
       [Description("Turks and Caicos Islands")][EnumMember]TurksandCaicosIslands = 219,
       [Description("Tuvalu")][EnumMember]Tuvalu = 220,
       [Description("Uganda")][EnumMember]Uganda = 221,
       [Description("Ukraine")][EnumMember]Ukraine = 222,
       [Description("United Arab Emirates")][EnumMember]UnitedArabEmirates = 223,
       [Description("United Kingdom")][EnumMember]UnitedKingdom = 224,
       [Description("United States")][EnumMember]UnitedStates = 225,
       [Description("Uruguay")][EnumMember]Uruguay = 226,
       [Description("US Virgin Islands")][EnumMember]USVirginIslands = 227,
       [Description("Uzbekistan")][EnumMember]Uzbekistan = 228,
       [Description("Vanuatu")][EnumMember]Vanuatu = 229,
       [Description("Venezuela")][EnumMember]Venezuela = 230,
       [Description("Vietnam")][EnumMember]Vietnam = 231,
       [Description("Wallis and Futuna")][EnumMember]WallisandFutuna = 232,
       [Description("Western Sahara")][EnumMember]WesternSahara = 234,
       [Description("Yemen")][EnumMember]Yemen = 235,
       [Description("Zambia")][EnumMember]Zambia = 236,
       [Description("Zimbabwe")][EnumMember]Zimbabwe = 237,
        
    }    
    
    public class GenCountry
    {
        public int EnumValue {get;set;}
		public string EnumName {get;set;}
		public string EnumDescription {get;set;}
		public int CountryKey {get;set;}
		public string AlphaCountryCode {get;set;}
		public string NumericCountryCode {get;set;}
		public string TelephoneCountryCode {get;set;}
		public bool IsFraudWatch {get;set;}
		public GenRecStatusEnum RecStatusKey {get;set;}
		public int CurrencyCodeKey {get;set;}
		public string DisplayName {get;set;}
    }

    /// <summary>
    /// This class is mainly for using the extended properties of Enum
    /// </summary>
    public static class GenCountryCollection
    {
        private static List<GenCountry> _list; 
        public static List<GenCountry> GenCountryList
        {
            get
            {
                if (_list == null)
                {   
                        _list = new List<GenCountry>
                        {
                            new GenCountry
							{
								EnumValue = 0,
								EnumName = "None",
								EnumDescription = "None",
								CountryKey = 0,
								AlphaCountryCode = "NON",
								NumericCountryCode = "0  ",
								TelephoneCountryCode = "0",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)3,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 1,
								EnumName = "Afghanistan",
								EnumDescription = "Afghanistan",
								CountryKey = 1,
								AlphaCountryCode = "AFG",
								NumericCountryCode = "004",
								TelephoneCountryCode = "93",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 2,
								EnumName = "Albania",
								EnumDescription = "Albania",
								CountryKey = 2,
								AlphaCountryCode = "ALB",
								NumericCountryCode = "008",
								TelephoneCountryCode = "355",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 3,
								EnumName = "Algeria",
								EnumDescription = "Algeria",
								CountryKey = 3,
								AlphaCountryCode = "DZA",
								NumericCountryCode = "012",
								TelephoneCountryCode = "213",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 4,
								EnumName = "AmericanSamoa",
								EnumDescription = "American Samoa",
								CountryKey = 4,
								AlphaCountryCode = "ASM",
								NumericCountryCode = "016",
								TelephoneCountryCode = "1684",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 5,
								EnumName = "Andorra",
								EnumDescription = "Andorra",
								CountryKey = 5,
								AlphaCountryCode = "AND",
								NumericCountryCode = "020",
								TelephoneCountryCode = "376",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 6,
								EnumName = "Angola",
								EnumDescription = "Angola",
								CountryKey = 6,
								AlphaCountryCode = "AGO",
								NumericCountryCode = "024",
								TelephoneCountryCode = "244",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 7,
								EnumName = "Anguilla",
								EnumDescription = "Anguilla",
								CountryKey = 7,
								AlphaCountryCode = "AIA",
								NumericCountryCode = "660",
								TelephoneCountryCode = "1264",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 8,
								EnumName = "Antarctica",
								EnumDescription = "Antarctica",
								CountryKey = 8,
								AlphaCountryCode = "ATA",
								NumericCountryCode = "010",
								TelephoneCountryCode = "672",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 9,
								EnumName = "AntiguaandBarbuda",
								EnumDescription = "Antigua and Barbuda",
								CountryKey = 9,
								AlphaCountryCode = "ATG",
								NumericCountryCode = "028",
								TelephoneCountryCode = "1268",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 10,
								EnumName = "Argentina",
								EnumDescription = "Argentina",
								CountryKey = 10,
								AlphaCountryCode = "ARG",
								NumericCountryCode = "032",
								TelephoneCountryCode = "54",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 11,
								EnumName = "Armenia",
								EnumDescription = "Armenia",
								CountryKey = 11,
								AlphaCountryCode = "ARM",
								NumericCountryCode = "051",
								TelephoneCountryCode = "374",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 12,
								EnumName = "Aruba",
								EnumDescription = "Aruba",
								CountryKey = 12,
								AlphaCountryCode = "ABW",
								NumericCountryCode = "533",
								TelephoneCountryCode = "297",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 13,
								EnumName = "Australia",
								EnumDescription = "Australia",
								CountryKey = 13,
								AlphaCountryCode = "AUS",
								NumericCountryCode = "036",
								TelephoneCountryCode = "61",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 14,
								EnumName = "Austria",
								EnumDescription = "Austria",
								CountryKey = 14,
								AlphaCountryCode = "AUT",
								NumericCountryCode = "040",
								TelephoneCountryCode = "43",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 15,
								EnumName = "Azerbaijan",
								EnumDescription = "Azerbaijan",
								CountryKey = 15,
								AlphaCountryCode = "AZE",
								NumericCountryCode = "031",
								TelephoneCountryCode = "994",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 16,
								EnumName = "Bahamas",
								EnumDescription = "Bahamas",
								CountryKey = 16,
								AlphaCountryCode = "BHS",
								NumericCountryCode = "044",
								TelephoneCountryCode = "1242",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 17,
								EnumName = "Bahrain",
								EnumDescription = "Bahrain",
								CountryKey = 17,
								AlphaCountryCode = "BHR",
								NumericCountryCode = "048",
								TelephoneCountryCode = "973",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 18,
								EnumName = "Bangladesh",
								EnumDescription = "Bangladesh",
								CountryKey = 18,
								AlphaCountryCode = "BGD",
								NumericCountryCode = "050",
								TelephoneCountryCode = "880",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 19,
								EnumName = "Barbados",
								EnumDescription = "Barbados",
								CountryKey = 19,
								AlphaCountryCode = "BRB",
								NumericCountryCode = "052",
								TelephoneCountryCode = "1246",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 20,
								EnumName = "Belarus",
								EnumDescription = "Belarus",
								CountryKey = 20,
								AlphaCountryCode = "BLR",
								NumericCountryCode = "112",
								TelephoneCountryCode = "375",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 21,
								EnumName = "Belgium",
								EnumDescription = "Belgium",
								CountryKey = 21,
								AlphaCountryCode = "BEL",
								NumericCountryCode = "056",
								TelephoneCountryCode = "32",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 22,
								EnumName = "Belize",
								EnumDescription = "Belize",
								CountryKey = 22,
								AlphaCountryCode = "BLZ",
								NumericCountryCode = "084",
								TelephoneCountryCode = "501",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 23,
								EnumName = "Benin",
								EnumDescription = "Benin",
								CountryKey = 23,
								AlphaCountryCode = "BEN",
								NumericCountryCode = "204",
								TelephoneCountryCode = "229",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 24,
								EnumName = "Bermuda",
								EnumDescription = "Bermuda",
								CountryKey = 24,
								AlphaCountryCode = "BMU",
								NumericCountryCode = "060",
								TelephoneCountryCode = "1441",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 25,
								EnumName = "Bhutan",
								EnumDescription = "Bhutan",
								CountryKey = 25,
								AlphaCountryCode = "BTN",
								NumericCountryCode = "064",
								TelephoneCountryCode = "975",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 26,
								EnumName = "Bolivia",
								EnumDescription = "Bolivia",
								CountryKey = 26,
								AlphaCountryCode = "BOL",
								NumericCountryCode = "068",
								TelephoneCountryCode = "591",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 27,
								EnumName = "BosniaandHerzegovina",
								EnumDescription = "Bosnia and Herzegovina",
								CountryKey = 27,
								AlphaCountryCode = "BIH",
								NumericCountryCode = "070",
								TelephoneCountryCode = "387",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 28,
								EnumName = "Botswana",
								EnumDescription = "Botswana",
								CountryKey = 28,
								AlphaCountryCode = "BWA",
								NumericCountryCode = "072",
								TelephoneCountryCode = "267",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 29,
								EnumName = "Brazil",
								EnumDescription = "Brazil",
								CountryKey = 29,
								AlphaCountryCode = "BRA",
								NumericCountryCode = "076",
								TelephoneCountryCode = "55",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 30,
								EnumName = "BritishIndianOceanTerritory",
								EnumDescription = "British Indian Ocean Territory",
								CountryKey = 30,
								AlphaCountryCode = "IOT",
								NumericCountryCode = "086",
								TelephoneCountryCode = "0",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 31,
								EnumName = "BritishVirginIslands",
								EnumDescription = "British Virgin Islands",
								CountryKey = 31,
								AlphaCountryCode = "VGB",
								NumericCountryCode = "092",
								TelephoneCountryCode = "1284",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 32,
								EnumName = "Brunei",
								EnumDescription = "Brunei",
								CountryKey = 32,
								AlphaCountryCode = "BRN",
								NumericCountryCode = "096",
								TelephoneCountryCode = "673",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 33,
								EnumName = "Bulgaria",
								EnumDescription = "Bulgaria",
								CountryKey = 33,
								AlphaCountryCode = "BGR",
								NumericCountryCode = "100",
								TelephoneCountryCode = "359",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 34,
								EnumName = "BurkinaFaso",
								EnumDescription = "Burkina Faso",
								CountryKey = 34,
								AlphaCountryCode = "BFA",
								NumericCountryCode = "854",
								TelephoneCountryCode = "226",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 35,
								EnumName = "BurmaMyanmar",
								EnumDescription = "Burma (Myanmar)",
								CountryKey = 35,
								AlphaCountryCode = "MMR",
								NumericCountryCode = "104",
								TelephoneCountryCode = "95",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 36,
								EnumName = "Burundi",
								EnumDescription = "Burundi",
								CountryKey = 36,
								AlphaCountryCode = "BDI",
								NumericCountryCode = "108",
								TelephoneCountryCode = "257",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 37,
								EnumName = "Cambodia",
								EnumDescription = "Cambodia",
								CountryKey = 37,
								AlphaCountryCode = "KHM",
								NumericCountryCode = "116",
								TelephoneCountryCode = "855",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 38,
								EnumName = "Cameroon",
								EnumDescription = "Cameroon",
								CountryKey = 38,
								AlphaCountryCode = "CMR",
								NumericCountryCode = "120",
								TelephoneCountryCode = "237",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 39,
								EnumName = "Canada",
								EnumDescription = "Canada",
								CountryKey = 39,
								AlphaCountryCode = "CAN",
								NumericCountryCode = "124",
								TelephoneCountryCode = "1",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 40,
								EnumName = "CapeVerde",
								EnumDescription = "Cape Verde",
								CountryKey = 40,
								AlphaCountryCode = "CPV",
								NumericCountryCode = "132",
								TelephoneCountryCode = "238",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 41,
								EnumName = "CaymanIslands",
								EnumDescription = "Cayman Islands",
								CountryKey = 41,
								AlphaCountryCode = "CYM",
								NumericCountryCode = "136",
								TelephoneCountryCode = "1345",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 42,
								EnumName = "CentralAfricanRepublic",
								EnumDescription = "Central African Republic",
								CountryKey = 42,
								AlphaCountryCode = "CAF",
								NumericCountryCode = "140",
								TelephoneCountryCode = "236",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 43,
								EnumName = "Chad",
								EnumDescription = "Chad",
								CountryKey = 43,
								AlphaCountryCode = "TCD",
								NumericCountryCode = "148",
								TelephoneCountryCode = "235",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 44,
								EnumName = "Chile",
								EnumDescription = "Chile",
								CountryKey = 44,
								AlphaCountryCode = "CHL",
								NumericCountryCode = "152",
								TelephoneCountryCode = "56",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 45,
								EnumName = "China",
								EnumDescription = "China",
								CountryKey = 45,
								AlphaCountryCode = "CHN",
								NumericCountryCode = "156",
								TelephoneCountryCode = "86",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 46,
								EnumName = "ChristmasIsland",
								EnumDescription = "Christmas Island",
								CountryKey = 46,
								AlphaCountryCode = "CXR",
								NumericCountryCode = "162",
								TelephoneCountryCode = "61",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 47,
								EnumName = "CocosKeelingIslands",
								EnumDescription = "Cocos (Keeling) Islands",
								CountryKey = 47,
								AlphaCountryCode = "CCK",
								NumericCountryCode = "166",
								TelephoneCountryCode = "61",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 48,
								EnumName = "Colombia",
								EnumDescription = "Colombia",
								CountryKey = 48,
								AlphaCountryCode = "COL",
								NumericCountryCode = "170",
								TelephoneCountryCode = "57",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 49,
								EnumName = "Comoros",
								EnumDescription = "Comoros",
								CountryKey = 49,
								AlphaCountryCode = "COM",
								NumericCountryCode = "174",
								TelephoneCountryCode = "269",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 50,
								EnumName = "CookIslands",
								EnumDescription = "Cook Islands",
								CountryKey = 50,
								AlphaCountryCode = "COK",
								NumericCountryCode = "184",
								TelephoneCountryCode = "682",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 51,
								EnumName = "CostaRica",
								EnumDescription = "Costa Rica",
								CountryKey = 51,
								AlphaCountryCode = "CRC",
								NumericCountryCode = "188",
								TelephoneCountryCode = "506",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 52,
								EnumName = "Croatia",
								EnumDescription = "Croatia",
								CountryKey = 52,
								AlphaCountryCode = "HRV",
								NumericCountryCode = "191",
								TelephoneCountryCode = "385",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 53,
								EnumName = "Cuba",
								EnumDescription = "Cuba",
								CountryKey = 53,
								AlphaCountryCode = "CUB",
								NumericCountryCode = "192",
								TelephoneCountryCode = "53",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 54,
								EnumName = "Cyprus",
								EnumDescription = "Cyprus",
								CountryKey = 54,
								AlphaCountryCode = "CYP",
								NumericCountryCode = "196",
								TelephoneCountryCode = "357",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 55,
								EnumName = "CzechRepublic",
								EnumDescription = "Czech Republic",
								CountryKey = 55,
								AlphaCountryCode = "CZE",
								NumericCountryCode = "203",
								TelephoneCountryCode = "420",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 56,
								EnumName = "DemocraticRepublicoftheCongo",
								EnumDescription = "Democratic Republic of the Congo",
								CountryKey = 56,
								AlphaCountryCode = "COD",
								NumericCountryCode = "180",
								TelephoneCountryCode = "243",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 57,
								EnumName = "Denmark",
								EnumDescription = "Denmark",
								CountryKey = 57,
								AlphaCountryCode = "DNK",
								NumericCountryCode = "208",
								TelephoneCountryCode = "45",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 58,
								EnumName = "Djibouti",
								EnumDescription = "Djibouti",
								CountryKey = 58,
								AlphaCountryCode = "DJI",
								NumericCountryCode = "262",
								TelephoneCountryCode = "253",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 59,
								EnumName = "Dominica",
								EnumDescription = "Dominica",
								CountryKey = 59,
								AlphaCountryCode = "DMA",
								NumericCountryCode = "212",
								TelephoneCountryCode = "1767",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 60,
								EnumName = "DominicanRepublic",
								EnumDescription = "Dominican Republic",
								CountryKey = 60,
								AlphaCountryCode = "DOM",
								NumericCountryCode = "214",
								TelephoneCountryCode = "1809",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 61,
								EnumName = "Ecuador",
								EnumDescription = "Ecuador",
								CountryKey = 61,
								AlphaCountryCode = "ECU",
								NumericCountryCode = "218",
								TelephoneCountryCode = "593",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 62,
								EnumName = "Egypt",
								EnumDescription = "Egypt",
								CountryKey = 62,
								AlphaCountryCode = "EGY",
								NumericCountryCode = "818",
								TelephoneCountryCode = "20",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 63,
								EnumName = "ElSalvador",
								EnumDescription = "El Salvador",
								CountryKey = 63,
								AlphaCountryCode = "SLV",
								NumericCountryCode = "222",
								TelephoneCountryCode = "503",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 64,
								EnumName = "EquatorialGuinea",
								EnumDescription = "Equatorial Guinea",
								CountryKey = 64,
								AlphaCountryCode = "GNQ",
								NumericCountryCode = "226",
								TelephoneCountryCode = "240",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 65,
								EnumName = "Eritrea",
								EnumDescription = "Eritrea",
								CountryKey = 65,
								AlphaCountryCode = "ERI",
								NumericCountryCode = "232",
								TelephoneCountryCode = "291",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 66,
								EnumName = "Estonia",
								EnumDescription = "Estonia",
								CountryKey = 66,
								AlphaCountryCode = "EST",
								NumericCountryCode = "233",
								TelephoneCountryCode = "372",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 67,
								EnumName = "Ethiopia",
								EnumDescription = "Ethiopia",
								CountryKey = 67,
								AlphaCountryCode = "ETH",
								NumericCountryCode = "231",
								TelephoneCountryCode = "251",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 68,
								EnumName = "FalklandIslands",
								EnumDescription = "Falkland Islands",
								CountryKey = 68,
								AlphaCountryCode = "FLK",
								NumericCountryCode = "238",
								TelephoneCountryCode = "500",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 69,
								EnumName = "FaroeIslands",
								EnumDescription = "Faroe Islands",
								CountryKey = 69,
								AlphaCountryCode = "FRO",
								NumericCountryCode = "234",
								TelephoneCountryCode = "298",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 70,
								EnumName = "Fiji",
								EnumDescription = "Fiji",
								CountryKey = 70,
								AlphaCountryCode = "FJI",
								NumericCountryCode = "242",
								TelephoneCountryCode = "679",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 71,
								EnumName = "Finland",
								EnumDescription = "Finland",
								CountryKey = 71,
								AlphaCountryCode = "FIN",
								NumericCountryCode = "246",
								TelephoneCountryCode = "358",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 72,
								EnumName = "France",
								EnumDescription = "France",
								CountryKey = 72,
								AlphaCountryCode = "FRA",
								NumericCountryCode = "250",
								TelephoneCountryCode = "33",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 73,
								EnumName = "FrenchPolynesia",
								EnumDescription = "French Polynesia",
								CountryKey = 73,
								AlphaCountryCode = "PYF",
								NumericCountryCode = "258",
								TelephoneCountryCode = "689",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 74,
								EnumName = "Gabon",
								EnumDescription = "Gabon",
								CountryKey = 74,
								AlphaCountryCode = "GAB",
								NumericCountryCode = "266",
								TelephoneCountryCode = "241",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 75,
								EnumName = "Gambia",
								EnumDescription = "Gambia",
								CountryKey = 75,
								AlphaCountryCode = "GMB",
								NumericCountryCode = "270",
								TelephoneCountryCode = "220",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 76,
								EnumName = "GazaStrip",
								EnumDescription = "Gaza Strip",
								CountryKey = 76,
								AlphaCountryCode = "GZS",
								NumericCountryCode = "274",
								TelephoneCountryCode = "970",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 77,
								EnumName = "Georgia",
								EnumDescription = "Georgia",
								CountryKey = 77,
								AlphaCountryCode = "GEO",
								NumericCountryCode = "268",
								TelephoneCountryCode = "995",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 78,
								EnumName = "Germany",
								EnumDescription = "Germany",
								CountryKey = 78,
								AlphaCountryCode = "DEU",
								NumericCountryCode = "276",
								TelephoneCountryCode = "49",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 79,
								EnumName = "Ghana",
								EnumDescription = "Ghana",
								CountryKey = 79,
								AlphaCountryCode = "GHA",
								NumericCountryCode = "288",
								TelephoneCountryCode = "233",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 80,
								EnumName = "Gibraltar",
								EnumDescription = "Gibraltar",
								CountryKey = 80,
								AlphaCountryCode = "GIB",
								NumericCountryCode = "292",
								TelephoneCountryCode = "350",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 81,
								EnumName = "Greece",
								EnumDescription = "Greece",
								CountryKey = 81,
								AlphaCountryCode = "GRC",
								NumericCountryCode = "300",
								TelephoneCountryCode = "30",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 82,
								EnumName = "Greenland",
								EnumDescription = "Greenland",
								CountryKey = 82,
								AlphaCountryCode = "GRL",
								NumericCountryCode = "304",
								TelephoneCountryCode = "299",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 83,
								EnumName = "Grenada",
								EnumDescription = "Grenada",
								CountryKey = 83,
								AlphaCountryCode = "GRD",
								NumericCountryCode = "308",
								TelephoneCountryCode = "1473",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 84,
								EnumName = "Guam",
								EnumDescription = "Guam",
								CountryKey = 84,
								AlphaCountryCode = "GUM",
								NumericCountryCode = "316",
								TelephoneCountryCode = "1671",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 85,
								EnumName = "Guatemala",
								EnumDescription = "Guatemala",
								CountryKey = 85,
								AlphaCountryCode = "GTM",
								NumericCountryCode = "320",
								TelephoneCountryCode = "502",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 86,
								EnumName = "Guinea",
								EnumDescription = "Guinea",
								CountryKey = 86,
								AlphaCountryCode = "GIN",
								NumericCountryCode = "324",
								TelephoneCountryCode = "224",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 87,
								EnumName = "GuineaBissau",
								EnumDescription = "Guinea-Bissau",
								CountryKey = 87,
								AlphaCountryCode = "GNB",
								NumericCountryCode = "624",
								TelephoneCountryCode = "245",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 88,
								EnumName = "Guyana",
								EnumDescription = "Guyana",
								CountryKey = 88,
								AlphaCountryCode = "GUY",
								NumericCountryCode = "328",
								TelephoneCountryCode = "592",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 89,
								EnumName = "Haiti",
								EnumDescription = "Haiti",
								CountryKey = 89,
								AlphaCountryCode = "HTI",
								NumericCountryCode = "332",
								TelephoneCountryCode = "509",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 90,
								EnumName = "HolySeeVaticanCity",
								EnumDescription = "Holy See (Vatican City)",
								CountryKey = 90,
								AlphaCountryCode = "VAT",
								NumericCountryCode = "336",
								TelephoneCountryCode = "39",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 91,
								EnumName = "Honduras",
								EnumDescription = "Honduras",
								CountryKey = 91,
								AlphaCountryCode = "HND",
								NumericCountryCode = "340",
								TelephoneCountryCode = "504",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 92,
								EnumName = "HongKong",
								EnumDescription = "Hong Kong",
								CountryKey = 92,
								AlphaCountryCode = "HKG",
								NumericCountryCode = "344",
								TelephoneCountryCode = "852",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 93,
								EnumName = "Hungary",
								EnumDescription = "Hungary",
								CountryKey = 93,
								AlphaCountryCode = "HUN",
								NumericCountryCode = "348",
								TelephoneCountryCode = "36",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 94,
								EnumName = "Iceland",
								EnumDescription = "Iceland",
								CountryKey = 94,
								AlphaCountryCode = "IS ",
								NumericCountryCode = "352",
								TelephoneCountryCode = "354",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 95,
								EnumName = "India",
								EnumDescription = "India",
								CountryKey = 95,
								AlphaCountryCode = "IND",
								NumericCountryCode = "356",
								TelephoneCountryCode = "91",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 96,
								EnumName = "Indonesia",
								EnumDescription = "Indonesia",
								CountryKey = 96,
								AlphaCountryCode = "IDN",
								NumericCountryCode = "360",
								TelephoneCountryCode = "62",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 97,
								EnumName = "Iran",
								EnumDescription = "Iran",
								CountryKey = 97,
								AlphaCountryCode = "IRN",
								NumericCountryCode = "364",
								TelephoneCountryCode = "98",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 98,
								EnumName = "Iraq",
								EnumDescription = "Iraq",
								CountryKey = 98,
								AlphaCountryCode = "IRQ",
								NumericCountryCode = "368",
								TelephoneCountryCode = "964",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 99,
								EnumName = "Ireland",
								EnumDescription = "Ireland",
								CountryKey = 99,
								AlphaCountryCode = "IRL",
								NumericCountryCode = "372",
								TelephoneCountryCode = "353",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 2,
								DisplayName = "ROI"
							},
							new GenCountry
							{
								EnumValue = 100,
								EnumName = "IsleofMan",
								EnumDescription = "Isle of Man",
								CountryKey = 100,
								AlphaCountryCode = "IMN",
								NumericCountryCode = "833",
								TelephoneCountryCode = "44",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 101,
								EnumName = "Israel",
								EnumDescription = "Israel",
								CountryKey = 101,
								AlphaCountryCode = "ISR",
								NumericCountryCode = "376",
								TelephoneCountryCode = "972",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 102,
								EnumName = "Italy",
								EnumDescription = "Italy",
								CountryKey = 102,
								AlphaCountryCode = "ITA",
								NumericCountryCode = "380",
								TelephoneCountryCode = "39",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 103,
								EnumName = "IvoryCoast",
								EnumDescription = "Ivory Coast",
								CountryKey = 103,
								AlphaCountryCode = "CIV",
								NumericCountryCode = "384",
								TelephoneCountryCode = "225",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 104,
								EnumName = "Jamaica",
								EnumDescription = "Jamaica",
								CountryKey = 104,
								AlphaCountryCode = "JAM",
								NumericCountryCode = "388",
								TelephoneCountryCode = "1876",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 105,
								EnumName = "Japan",
								EnumDescription = "Japan",
								CountryKey = 105,
								AlphaCountryCode = "JPN",
								NumericCountryCode = "392",
								TelephoneCountryCode = "81",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 106,
								EnumName = "Jersey",
								EnumDescription = "Jersey",
								CountryKey = 106,
								AlphaCountryCode = "JEY",
								NumericCountryCode = "832",
								TelephoneCountryCode = "44",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 107,
								EnumName = "Jordan",
								EnumDescription = "Jordan",
								CountryKey = 107,
								AlphaCountryCode = "JOR",
								NumericCountryCode = "400",
								TelephoneCountryCode = "962",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 108,
								EnumName = "Kazakhstan",
								EnumDescription = "Kazakhstan",
								CountryKey = 108,
								AlphaCountryCode = "KAZ",
								NumericCountryCode = "398",
								TelephoneCountryCode = "7",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 109,
								EnumName = "Kenya",
								EnumDescription = "Kenya",
								CountryKey = 109,
								AlphaCountryCode = "KEN",
								NumericCountryCode = "404",
								TelephoneCountryCode = "254",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 110,
								EnumName = "Kiribati",
								EnumDescription = "Kiribati",
								CountryKey = 110,
								AlphaCountryCode = "KIR",
								NumericCountryCode = "296",
								TelephoneCountryCode = "686",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 112,
								EnumName = "Kuwait",
								EnumDescription = "Kuwait",
								CountryKey = 112,
								AlphaCountryCode = "KWT",
								NumericCountryCode = "414",
								TelephoneCountryCode = "965",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 113,
								EnumName = "Kyrgyzstan",
								EnumDescription = "Kyrgyzstan",
								CountryKey = 113,
								AlphaCountryCode = "KGZ",
								NumericCountryCode = "417",
								TelephoneCountryCode = "996",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 114,
								EnumName = "Laos",
								EnumDescription = "Laos",
								CountryKey = 114,
								AlphaCountryCode = "LAO",
								NumericCountryCode = "418",
								TelephoneCountryCode = "856",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 115,
								EnumName = "Latvia",
								EnumDescription = "Latvia",
								CountryKey = 115,
								AlphaCountryCode = "LVA",
								NumericCountryCode = "428",
								TelephoneCountryCode = "371",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 116,
								EnumName = "Lebanon",
								EnumDescription = "Lebanon",
								CountryKey = 116,
								AlphaCountryCode = "LBN",
								NumericCountryCode = "422",
								TelephoneCountryCode = "961",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 117,
								EnumName = "Lesotho",
								EnumDescription = "Lesotho",
								CountryKey = 117,
								AlphaCountryCode = "LSO",
								NumericCountryCode = "426",
								TelephoneCountryCode = "266",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 118,
								EnumName = "Liberia",
								EnumDescription = "Liberia",
								CountryKey = 118,
								AlphaCountryCode = "LBR",
								NumericCountryCode = "430",
								TelephoneCountryCode = "231",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 119,
								EnumName = "Libya",
								EnumDescription = "Libya",
								CountryKey = 119,
								AlphaCountryCode = "LBY",
								NumericCountryCode = "434",
								TelephoneCountryCode = "218",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 120,
								EnumName = "Liechtenstein",
								EnumDescription = "Liechtenstein",
								CountryKey = 120,
								AlphaCountryCode = "LIE",
								NumericCountryCode = "438",
								TelephoneCountryCode = "423",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 121,
								EnumName = "Lithuania",
								EnumDescription = "Lithuania",
								CountryKey = 121,
								AlphaCountryCode = "LTU",
								NumericCountryCode = "440",
								TelephoneCountryCode = "370",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 122,
								EnumName = "Luxembourg",
								EnumDescription = "Luxembourg",
								CountryKey = 122,
								AlphaCountryCode = "LUX",
								NumericCountryCode = "442",
								TelephoneCountryCode = "352",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 123,
								EnumName = "Macau",
								EnumDescription = "Macau",
								CountryKey = 123,
								AlphaCountryCode = "MAC",
								NumericCountryCode = "446",
								TelephoneCountryCode = "853",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 124,
								EnumName = "Macedonia",
								EnumDescription = "Macedonia",
								CountryKey = 124,
								AlphaCountryCode = "MKD",
								NumericCountryCode = "807",
								TelephoneCountryCode = "389",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 125,
								EnumName = "Madagascar",
								EnumDescription = "Madagascar",
								CountryKey = 125,
								AlphaCountryCode = "MDG",
								NumericCountryCode = "450",
								TelephoneCountryCode = "261",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 126,
								EnumName = "Malawi",
								EnumDescription = "Malawi",
								CountryKey = 126,
								AlphaCountryCode = "MWI",
								NumericCountryCode = "454",
								TelephoneCountryCode = "265",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 127,
								EnumName = "Malaysia",
								EnumDescription = "Malaysia",
								CountryKey = 127,
								AlphaCountryCode = "MYS",
								NumericCountryCode = "458",
								TelephoneCountryCode = "60",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 128,
								EnumName = "Maldives",
								EnumDescription = "Maldives",
								CountryKey = 128,
								AlphaCountryCode = "MDV",
								NumericCountryCode = "462",
								TelephoneCountryCode = "960",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 129,
								EnumName = "Mali",
								EnumDescription = "Mali",
								CountryKey = 129,
								AlphaCountryCode = "MLI",
								NumericCountryCode = "466",
								TelephoneCountryCode = "223",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 130,
								EnumName = "Malta",
								EnumDescription = "Malta",
								CountryKey = 130,
								AlphaCountryCode = "MLT",
								NumericCountryCode = "470",
								TelephoneCountryCode = "356",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 131,
								EnumName = "MarshallIslands",
								EnumDescription = "Marshall Islands",
								CountryKey = 131,
								AlphaCountryCode = "MHL",
								NumericCountryCode = "584",
								TelephoneCountryCode = "692",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 132,
								EnumName = "Mauritania",
								EnumDescription = "Mauritania",
								CountryKey = 132,
								AlphaCountryCode = "MRT",
								NumericCountryCode = "478",
								TelephoneCountryCode = "222",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 133,
								EnumName = "Mauritius",
								EnumDescription = "Mauritius",
								CountryKey = 133,
								AlphaCountryCode = "MUS",
								NumericCountryCode = "480",
								TelephoneCountryCode = "230",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 134,
								EnumName = "Mayotte",
								EnumDescription = "Mayotte",
								CountryKey = 134,
								AlphaCountryCode = "MYT",
								NumericCountryCode = "175",
								TelephoneCountryCode = "262",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 135,
								EnumName = "Mexico",
								EnumDescription = "Mexico",
								CountryKey = 135,
								AlphaCountryCode = "MEX",
								NumericCountryCode = "484",
								TelephoneCountryCode = "52",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 136,
								EnumName = "Micronesia",
								EnumDescription = "Micronesia",
								CountryKey = 136,
								AlphaCountryCode = "FSM",
								NumericCountryCode = "583",
								TelephoneCountryCode = "691",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 137,
								EnumName = "Moldova",
								EnumDescription = "Moldova",
								CountryKey = 137,
								AlphaCountryCode = "MDA",
								NumericCountryCode = "498",
								TelephoneCountryCode = "373",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 138,
								EnumName = "Monaco",
								EnumDescription = "Monaco",
								CountryKey = 138,
								AlphaCountryCode = "MCO",
								NumericCountryCode = "492",
								TelephoneCountryCode = "377",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 139,
								EnumName = "Mongolia",
								EnumDescription = "Mongolia",
								CountryKey = 139,
								AlphaCountryCode = "MNG",
								NumericCountryCode = "496",
								TelephoneCountryCode = "976",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 140,
								EnumName = "Montenegro",
								EnumDescription = "Montenegro",
								CountryKey = 140,
								AlphaCountryCode = "MNE",
								NumericCountryCode = "499",
								TelephoneCountryCode = "382",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 141,
								EnumName = "Montserrat",
								EnumDescription = "Montserrat",
								CountryKey = 141,
								AlphaCountryCode = "MSR",
								NumericCountryCode = "500",
								TelephoneCountryCode = "1664",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 142,
								EnumName = "Morocco",
								EnumDescription = "Morocco",
								CountryKey = 142,
								AlphaCountryCode = "MAR",
								NumericCountryCode = "504",
								TelephoneCountryCode = "212",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 143,
								EnumName = "Mozambique",
								EnumDescription = "Mozambique",
								CountryKey = 143,
								AlphaCountryCode = "MOZ",
								NumericCountryCode = "508",
								TelephoneCountryCode = "258",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 144,
								EnumName = "Namibia",
								EnumDescription = "Namibia",
								CountryKey = 144,
								AlphaCountryCode = "NAM",
								NumericCountryCode = "516",
								TelephoneCountryCode = "264",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 145,
								EnumName = "Nauru",
								EnumDescription = "Nauru",
								CountryKey = 145,
								AlphaCountryCode = "NRU",
								NumericCountryCode = "520",
								TelephoneCountryCode = "674",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 146,
								EnumName = "Nepal",
								EnumDescription = "Nepal",
								CountryKey = 146,
								AlphaCountryCode = "NPL",
								NumericCountryCode = "524",
								TelephoneCountryCode = "977",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 147,
								EnumName = "Netherlands",
								EnumDescription = "Netherlands",
								CountryKey = 147,
								AlphaCountryCode = "NLD",
								NumericCountryCode = "528",
								TelephoneCountryCode = "31",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 148,
								EnumName = "NetherlandsAntilles",
								EnumDescription = "Netherlands Antilles",
								CountryKey = 148,
								AlphaCountryCode = "ANT",
								NumericCountryCode = "530",
								TelephoneCountryCode = "599",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 149,
								EnumName = "NewCaledonia",
								EnumDescription = "New Caledonia",
								CountryKey = 149,
								AlphaCountryCode = "NCL",
								NumericCountryCode = "540",
								TelephoneCountryCode = "687",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 150,
								EnumName = "NewZealand",
								EnumDescription = "New Zealand",
								CountryKey = 150,
								AlphaCountryCode = "NZL",
								NumericCountryCode = "554",
								TelephoneCountryCode = "64",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 151,
								EnumName = "Nicaragua",
								EnumDescription = "Nicaragua",
								CountryKey = 151,
								AlphaCountryCode = "NIC",
								NumericCountryCode = "558",
								TelephoneCountryCode = "505",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 152,
								EnumName = "Niger",
								EnumDescription = "Niger",
								CountryKey = 152,
								AlphaCountryCode = "NER",
								NumericCountryCode = "562",
								TelephoneCountryCode = "227",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 153,
								EnumName = "Nigeria",
								EnumDescription = "Nigeria",
								CountryKey = 153,
								AlphaCountryCode = "NGA",
								NumericCountryCode = "566",
								TelephoneCountryCode = "234",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 154,
								EnumName = "Niue",
								EnumDescription = "Niue",
								CountryKey = 154,
								AlphaCountryCode = "NIU",
								NumericCountryCode = "570",
								TelephoneCountryCode = "683",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 155,
								EnumName = "NorfolkIsland",
								EnumDescription = "Norfolk Island",
								CountryKey = 155,
								AlphaCountryCode = "NFK",
								NumericCountryCode = "574",
								TelephoneCountryCode = "672",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 156,
								EnumName = "NorthKorea",
								EnumDescription = "North Korea",
								CountryKey = 156,
								AlphaCountryCode = "PRK",
								NumericCountryCode = "408",
								TelephoneCountryCode = "850",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 157,
								EnumName = "NorthernMarianaIslands",
								EnumDescription = "Northern Mariana Islands",
								CountryKey = 157,
								AlphaCountryCode = "MNP",
								NumericCountryCode = "580",
								TelephoneCountryCode = "1670",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 158,
								EnumName = "Norway",
								EnumDescription = "Norway",
								CountryKey = 158,
								AlphaCountryCode = "NOR",
								NumericCountryCode = "578",
								TelephoneCountryCode = "47",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 159,
								EnumName = "Oman",
								EnumDescription = "Oman",
								CountryKey = 159,
								AlphaCountryCode = "OMN",
								NumericCountryCode = "512",
								TelephoneCountryCode = "968",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 160,
								EnumName = "Pakistan",
								EnumDescription = "Pakistan",
								CountryKey = 160,
								AlphaCountryCode = "PAK",
								NumericCountryCode = "586",
								TelephoneCountryCode = "92",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 161,
								EnumName = "Palau",
								EnumDescription = "Palau",
								CountryKey = 161,
								AlphaCountryCode = "PLW",
								NumericCountryCode = "585",
								TelephoneCountryCode = "680",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 162,
								EnumName = "Panama",
								EnumDescription = "Panama",
								CountryKey = 162,
								AlphaCountryCode = "PAN",
								NumericCountryCode = "591",
								TelephoneCountryCode = "507",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 163,
								EnumName = "PapuaNewGuinea",
								EnumDescription = "Papua New Guinea",
								CountryKey = 163,
								AlphaCountryCode = "PNG",
								NumericCountryCode = "598",
								TelephoneCountryCode = "675",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 164,
								EnumName = "Paraguay",
								EnumDescription = "Paraguay",
								CountryKey = 164,
								AlphaCountryCode = "PRY",
								NumericCountryCode = "600",
								TelephoneCountryCode = "595",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 165,
								EnumName = "Peru",
								EnumDescription = "Peru",
								CountryKey = 165,
								AlphaCountryCode = "PER",
								NumericCountryCode = "604",
								TelephoneCountryCode = "51",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 166,
								EnumName = "Philippines",
								EnumDescription = "Philippines",
								CountryKey = 166,
								AlphaCountryCode = "PHL",
								NumericCountryCode = "608",
								TelephoneCountryCode = "63",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 167,
								EnumName = "PitcairnIslands",
								EnumDescription = "Pitcairn Islands",
								CountryKey = 167,
								AlphaCountryCode = "PCN",
								NumericCountryCode = "612",
								TelephoneCountryCode = "870",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 168,
								EnumName = "Poland",
								EnumDescription = "Poland",
								CountryKey = 168,
								AlphaCountryCode = "POL",
								NumericCountryCode = "616",
								TelephoneCountryCode = "48",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 169,
								EnumName = "Portugal",
								EnumDescription = "Portugal",
								CountryKey = 169,
								AlphaCountryCode = "PRT",
								NumericCountryCode = "620",
								TelephoneCountryCode = "351",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 170,
								EnumName = "PuertoRico",
								EnumDescription = "Puerto Rico",
								CountryKey = 170,
								AlphaCountryCode = "PRI",
								NumericCountryCode = "630",
								TelephoneCountryCode = "1",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 171,
								EnumName = "Qatar",
								EnumDescription = "Qatar",
								CountryKey = 171,
								AlphaCountryCode = "QAT",
								NumericCountryCode = "634",
								TelephoneCountryCode = "974",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 172,
								EnumName = "RepublicoftheCongo",
								EnumDescription = "Republic of the Congo",
								CountryKey = 172,
								AlphaCountryCode = "COG",
								NumericCountryCode = "178",
								TelephoneCountryCode = "242",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 173,
								EnumName = "Romania",
								EnumDescription = "Romania",
								CountryKey = 173,
								AlphaCountryCode = "ROU",
								NumericCountryCode = "642",
								TelephoneCountryCode = "40",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 174,
								EnumName = "Russia",
								EnumDescription = "Russia",
								CountryKey = 174,
								AlphaCountryCode = "RUS",
								NumericCountryCode = "643",
								TelephoneCountryCode = "7",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 175,
								EnumName = "Rwanda",
								EnumDescription = "Rwanda",
								CountryKey = 175,
								AlphaCountryCode = "RWA",
								NumericCountryCode = "646",
								TelephoneCountryCode = "250",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 176,
								EnumName = "SaintBarthelemy",
								EnumDescription = "Saint Barthelemy",
								CountryKey = 176,
								AlphaCountryCode = "BLM",
								NumericCountryCode = "652",
								TelephoneCountryCode = "590",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 177,
								EnumName = "SaintHelena",
								EnumDescription = "Saint Helena",
								CountryKey = 177,
								AlphaCountryCode = "SHN",
								NumericCountryCode = "654",
								TelephoneCountryCode = "290",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 178,
								EnumName = "SaintKittsandNevis",
								EnumDescription = "Saint Kitts and Nevis",
								CountryKey = 178,
								AlphaCountryCode = "KNA",
								NumericCountryCode = "659",
								TelephoneCountryCode = "1869",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 179,
								EnumName = "SaintLucia",
								EnumDescription = "Saint Lucia",
								CountryKey = 179,
								AlphaCountryCode = "LCA",
								NumericCountryCode = "662",
								TelephoneCountryCode = "1758",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 180,
								EnumName = "SaintMartin",
								EnumDescription = "Saint Martin",
								CountryKey = 180,
								AlphaCountryCode = "MAF",
								NumericCountryCode = "663",
								TelephoneCountryCode = "1599",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 181,
								EnumName = "SaintPierreandMiquelon",
								EnumDescription = "Saint Pierre and Miquelon",
								CountryKey = 181,
								AlphaCountryCode = "SPM",
								NumericCountryCode = "666",
								TelephoneCountryCode = "508",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 182,
								EnumName = "SaintVincentandtheGrenadines",
								EnumDescription = "Saint Vincent and the Grenadines",
								CountryKey = 182,
								AlphaCountryCode = "VCT",
								NumericCountryCode = "670",
								TelephoneCountryCode = "1784",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 183,
								EnumName = "Samoa",
								EnumDescription = "Samoa",
								CountryKey = 183,
								AlphaCountryCode = "WSM",
								NumericCountryCode = "882",
								TelephoneCountryCode = "685",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 184,
								EnumName = "SanMarino",
								EnumDescription = "San Marino",
								CountryKey = 184,
								AlphaCountryCode = "SMR",
								NumericCountryCode = "674",
								TelephoneCountryCode = "378",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 185,
								EnumName = "SaoTomeandPrincipe",
								EnumDescription = "Sao Tome and Principe",
								CountryKey = 185,
								AlphaCountryCode = "STP",
								NumericCountryCode = "678",
								TelephoneCountryCode = "239",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 186,
								EnumName = "SaudiArabia",
								EnumDescription = "Saudi Arabia",
								CountryKey = 186,
								AlphaCountryCode = "SAU",
								NumericCountryCode = "682",
								TelephoneCountryCode = "966",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 187,
								EnumName = "Senegal",
								EnumDescription = "Senegal",
								CountryKey = 187,
								AlphaCountryCode = "SEN",
								NumericCountryCode = "686",
								TelephoneCountryCode = "221",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 188,
								EnumName = "Serbia",
								EnumDescription = "Serbia",
								CountryKey = 188,
								AlphaCountryCode = "SRB",
								NumericCountryCode = "688",
								TelephoneCountryCode = "381",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 189,
								EnumName = "Seychelles",
								EnumDescription = "Seychelles",
								CountryKey = 189,
								AlphaCountryCode = "SYC",
								NumericCountryCode = "690",
								TelephoneCountryCode = "248",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 190,
								EnumName = "SierraLeone",
								EnumDescription = "Sierra Leone",
								CountryKey = 190,
								AlphaCountryCode = "SLE",
								NumericCountryCode = "694",
								TelephoneCountryCode = "232",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 191,
								EnumName = "Singapore",
								EnumDescription = "Singapore",
								CountryKey = 191,
								AlphaCountryCode = "SGP",
								NumericCountryCode = "702",
								TelephoneCountryCode = "65",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 192,
								EnumName = "Slovakia",
								EnumDescription = "Slovakia",
								CountryKey = 192,
								AlphaCountryCode = "SVK",
								NumericCountryCode = "703",
								TelephoneCountryCode = "421",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 193,
								EnumName = "Slovenia",
								EnumDescription = "Slovenia",
								CountryKey = 193,
								AlphaCountryCode = "SVN",
								NumericCountryCode = "705",
								TelephoneCountryCode = "386",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 194,
								EnumName = "SolomonIslands",
								EnumDescription = "Solomon Islands",
								CountryKey = 194,
								AlphaCountryCode = "SLB",
								NumericCountryCode = "090",
								TelephoneCountryCode = "677",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 195,
								EnumName = "Somalia",
								EnumDescription = "Somalia",
								CountryKey = 195,
								AlphaCountryCode = "SOM",
								NumericCountryCode = "706",
								TelephoneCountryCode = "252",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 196,
								EnumName = "SouthAfrica",
								EnumDescription = "South Africa",
								CountryKey = 196,
								AlphaCountryCode = "ZAF",
								NumericCountryCode = "710",
								TelephoneCountryCode = "27",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 197,
								EnumName = "SouthKorea",
								EnumDescription = "South Korea",
								CountryKey = 197,
								AlphaCountryCode = "KOR",
								NumericCountryCode = "410",
								TelephoneCountryCode = "82",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 198,
								EnumName = "Spain",
								EnumDescription = "Spain",
								CountryKey = 198,
								AlphaCountryCode = "ESP",
								NumericCountryCode = "724",
								TelephoneCountryCode = "34",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 199,
								EnumName = "SriLanka",
								EnumDescription = "Sri Lanka",
								CountryKey = 199,
								AlphaCountryCode = "LKA",
								NumericCountryCode = "144",
								TelephoneCountryCode = "94",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 200,
								EnumName = "Sudan",
								EnumDescription = "Sudan",
								CountryKey = 200,
								AlphaCountryCode = "SDN",
								NumericCountryCode = "729",
								TelephoneCountryCode = "249",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 201,
								EnumName = "Suriname",
								EnumDescription = "Suriname",
								CountryKey = 201,
								AlphaCountryCode = "SUR",
								NumericCountryCode = "740",
								TelephoneCountryCode = "597",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 202,
								EnumName = "Svalbard",
								EnumDescription = "Svalbard",
								CountryKey = 202,
								AlphaCountryCode = "SJM",
								NumericCountryCode = "744",
								TelephoneCountryCode = "0",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 203,
								EnumName = "Swaziland",
								EnumDescription = "Swaziland",
								CountryKey = 203,
								AlphaCountryCode = "SWZ",
								NumericCountryCode = "748",
								TelephoneCountryCode = "268",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 204,
								EnumName = "Sweden",
								EnumDescription = "Sweden",
								CountryKey = 204,
								AlphaCountryCode = "SWE",
								NumericCountryCode = "752",
								TelephoneCountryCode = "46",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 205,
								EnumName = "Switzerland",
								EnumDescription = "Switzerland",
								CountryKey = 205,
								AlphaCountryCode = "CHE",
								NumericCountryCode = "756",
								TelephoneCountryCode = "41",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 206,
								EnumName = "Syria",
								EnumDescription = "Syria",
								CountryKey = 206,
								AlphaCountryCode = "SYR",
								NumericCountryCode = "760",
								TelephoneCountryCode = "963",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 207,
								EnumName = "Taiwan",
								EnumDescription = "Taiwan",
								CountryKey = 207,
								AlphaCountryCode = "TWN",
								NumericCountryCode = "158",
								TelephoneCountryCode = "886",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 208,
								EnumName = "Tajikistan",
								EnumDescription = "Tajikistan",
								CountryKey = 208,
								AlphaCountryCode = "TJK",
								NumericCountryCode = "762",
								TelephoneCountryCode = "992",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 209,
								EnumName = "Tanzania",
								EnumDescription = "Tanzania",
								CountryKey = 209,
								AlphaCountryCode = "TZA",
								NumericCountryCode = "834",
								TelephoneCountryCode = "255",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 210,
								EnumName = "Thailand",
								EnumDescription = "Thailand",
								CountryKey = 210,
								AlphaCountryCode = "THA",
								NumericCountryCode = "764",
								TelephoneCountryCode = "66",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 211,
								EnumName = "TimorLeste",
								EnumDescription = "Timor-Leste",
								CountryKey = 211,
								AlphaCountryCode = "TLS",
								NumericCountryCode = "626",
								TelephoneCountryCode = "670",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 212,
								EnumName = "Togo",
								EnumDescription = "Togo",
								CountryKey = 212,
								AlphaCountryCode = "TGO",
								NumericCountryCode = "768",
								TelephoneCountryCode = "228",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 213,
								EnumName = "Tokelau",
								EnumDescription = "Tokelau",
								CountryKey = 213,
								AlphaCountryCode = "TKL",
								NumericCountryCode = "772",
								TelephoneCountryCode = "690",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 214,
								EnumName = "Tonga",
								EnumDescription = "Tonga",
								CountryKey = 214,
								AlphaCountryCode = "TON",
								NumericCountryCode = "776",
								TelephoneCountryCode = "676",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 215,
								EnumName = "TrinidadandTobago",
								EnumDescription = "Trinidad and Tobago",
								CountryKey = 215,
								AlphaCountryCode = "TTO",
								NumericCountryCode = "780",
								TelephoneCountryCode = "1868",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 216,
								EnumName = "Tunisia",
								EnumDescription = "Tunisia",
								CountryKey = 216,
								AlphaCountryCode = "TUN",
								NumericCountryCode = "788",
								TelephoneCountryCode = "216",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 217,
								EnumName = "Turkey",
								EnumDescription = "Turkey",
								CountryKey = 217,
								AlphaCountryCode = "TUR",
								NumericCountryCode = "792",
								TelephoneCountryCode = "90",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 218,
								EnumName = "Turkmenistan",
								EnumDescription = "Turkmenistan",
								CountryKey = 218,
								AlphaCountryCode = "TKM",
								NumericCountryCode = "795",
								TelephoneCountryCode = "993",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 219,
								EnumName = "TurksandCaicosIslands",
								EnumDescription = "Turks and Caicos Islands",
								CountryKey = 219,
								AlphaCountryCode = "TCA",
								NumericCountryCode = "796",
								TelephoneCountryCode = "1649",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 220,
								EnumName = "Tuvalu",
								EnumDescription = "Tuvalu",
								CountryKey = 220,
								AlphaCountryCode = "TUV",
								NumericCountryCode = "798",
								TelephoneCountryCode = "688",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 221,
								EnumName = "Uganda",
								EnumDescription = "Uganda",
								CountryKey = 221,
								AlphaCountryCode = "UGA",
								NumericCountryCode = "800",
								TelephoneCountryCode = "256",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 222,
								EnumName = "Ukraine",
								EnumDescription = "Ukraine",
								CountryKey = 222,
								AlphaCountryCode = "UKR",
								NumericCountryCode = "804",
								TelephoneCountryCode = "380",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 223,
								EnumName = "UnitedArabEmirates",
								EnumDescription = "United Arab Emirates",
								CountryKey = 223,
								AlphaCountryCode = "ARE",
								NumericCountryCode = "784",
								TelephoneCountryCode = "971",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 224,
								EnumName = "UnitedKingdom",
								EnumDescription = "United Kingdom",
								CountryKey = 224,
								AlphaCountryCode = "GBR",
								NumericCountryCode = "826",
								TelephoneCountryCode = "44",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 1,
								DisplayName = "UK"
							},
							new GenCountry
							{
								EnumValue = 225,
								EnumName = "UnitedStates",
								EnumDescription = "United States",
								CountryKey = 225,
								AlphaCountryCode = "USA",
								NumericCountryCode = "840",
								TelephoneCountryCode = "1",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 226,
								EnumName = "Uruguay",
								EnumDescription = "Uruguay",
								CountryKey = 226,
								AlphaCountryCode = "URY",
								NumericCountryCode = "858",
								TelephoneCountryCode = "598",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 227,
								EnumName = "USVirginIslands",
								EnumDescription = "US Virgin Islands",
								CountryKey = 227,
								AlphaCountryCode = "VIR",
								NumericCountryCode = "850",
								TelephoneCountryCode = "1340",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 228,
								EnumName = "Uzbekistan",
								EnumDescription = "Uzbekistan",
								CountryKey = 228,
								AlphaCountryCode = "UZB",
								NumericCountryCode = "860",
								TelephoneCountryCode = "998",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 229,
								EnumName = "Vanuatu",
								EnumDescription = "Vanuatu",
								CountryKey = 229,
								AlphaCountryCode = "VUT",
								NumericCountryCode = "548",
								TelephoneCountryCode = "678",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 230,
								EnumName = "Venezuela",
								EnumDescription = "Venezuela",
								CountryKey = 230,
								AlphaCountryCode = "VEN",
								NumericCountryCode = "862",
								TelephoneCountryCode = "58",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 231,
								EnumName = "Vietnam",
								EnumDescription = "Vietnam",
								CountryKey = 231,
								AlphaCountryCode = "VNM",
								NumericCountryCode = "704",
								TelephoneCountryCode = "84",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 232,
								EnumName = "WallisandFutuna",
								EnumDescription = "Wallis and Futuna",
								CountryKey = 232,
								AlphaCountryCode = "WLF",
								NumericCountryCode = "876",
								TelephoneCountryCode = "681",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 234,
								EnumName = "WesternSahara",
								EnumDescription = "Western Sahara",
								CountryKey = 234,
								AlphaCountryCode = "ESH",
								NumericCountryCode = "732",
								TelephoneCountryCode = "0",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 235,
								EnumName = "Yemen",
								EnumDescription = "Yemen",
								CountryKey = 235,
								AlphaCountryCode = "YEM",
								NumericCountryCode = "887",
								TelephoneCountryCode = "967",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 236,
								EnumName = "Zambia",
								EnumDescription = "Zambia",
								CountryKey = 236,
								AlphaCountryCode = "ZMB",
								NumericCountryCode = "894",
								TelephoneCountryCode = "260",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
							new GenCountry
							{
								EnumValue = 237,
								EnumName = "Zimbabwe",
								EnumDescription = "Zimbabwe",
								CountryKey = 237,
								AlphaCountryCode = "ZWE",
								NumericCountryCode = "716",
								TelephoneCountryCode = "263",
								IsFraudWatch = false,
								RecStatusKey = (GenRecStatusEnum)1,
								CurrencyCodeKey = 0,
								DisplayName = ""
							},
                        };
                    
                }
                return _list;
            }

        }
    }
   
}
