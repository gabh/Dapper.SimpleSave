﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace Dapper.SimpleSave.Tests.RealisticDtos
{
    [Table("[gen].COUNTRY_ENUM"), ReferenceData]
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
}
