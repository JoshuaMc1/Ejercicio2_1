using Ejercicio2_1.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1.Modelo
{
    public class Eng
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Spa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nld
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pap
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jam
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Grn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fra
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Aym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Que
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Por
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bjz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kal
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class NativeName
    {
        public Eng eng { get; set; }
        public Spa spa { get; set; }
        public Nld nld { get; set; }
        public Pap pap { get; set; }
        public Jam jam { get; set; }
        public Grn grn { get; set; }
        public Fra fra { get; set; }
        public Hat hat { get; set; }
        public Aym aym { get; set; }
        public Que que { get; set; }
        public Por por { get; set; }
        public Bjz bjz { get; set; }
        public Kal kal { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public NativeName nativeName { get; set; }
    }

    public class XCD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PAB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class USD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TTD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AWG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class FKP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class JMD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ARS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class HTG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class HNL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MXN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class EUR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CUC
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CUP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BMD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BSD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PEN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GTQ
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ANG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class VES
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GYD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BRL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KYD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BZD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SRD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PYG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BOB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CRC
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class DOP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class DKK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CAD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class UYU
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BBD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NIO
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class COP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CLP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Currencies
    {
        public XCD XCD { get; set; }
        public PAB PAB { get; set; }
        public USD USD { get; set; }
        public TTD TTD { get; set; }
        public AWG AWG { get; set; }
        public FKP FKP { get; set; }
        public JMD JMD { get; set; }
        public ARS ARS { get; set; }
        public HTG HTG { get; set; }
        public HNL HNL { get; set; }
        public MXN MXN { get; set; }
        public EUR EUR { get; set; }
        public CUC CUC { get; set; }
        public CUP CUP { get; set; }
        public BMD BMD { get; set; }
        public BSD BSD { get; set; }
        public PEN PEN { get; set; }
        public GTQ GTQ { get; set; }
        public ANG ANG { get; set; }
        public VES VES { get; set; }
        public GYD GYD { get; set; }
        public BRL BRL { get; set; }
        public KYD KYD { get; set; }
        public BZD BZD { get; set; }
        public SRD SRD { get; set; }
        public PYG PYG { get; set; }
        public BOB BOB { get; set; }
        public CRC CRC { get; set; }
        public DOP DOP { get; set; }
        public DKK DKK { get; set; }
        public CAD CAD { get; set; }
        public UYU UYU { get; set; }
        public BBD BBD { get; set; }
        public NIO NIO { get; set; }
        public COP COP { get; set; }
        public CLP CLP { get; set; }
    }

    public class Idd
    {
        public string root { get; set; }
        public IList<string> suffixes { get; set; }
    }

    public class Languages
    {
        public string eng { get; set; }
        public string spa { get; set; }
        public string nld { get; set; }
        public string pap { get; set; }
        public string jam { get; set; }
        public string grn { get; set; }
        public string fra { get; set; }
        public string hat { get; set; }
        public string aym { get; set; }
        public string que { get; set; }
        public string por { get; set; }
        public string bjz { get; set; }
        public string kal { get; set; }
    }

    public class Ara
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bre
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ces
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Deu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Est
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hrv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hun
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ita
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jpn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kor
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Per
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pol
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Rus
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Slk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Swe
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tur
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Urd
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zho
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Translations
    {
        public Ara ara { get; set; }
        public Bre bre { get; set; }
        public Ces ces { get; set; }
        public Cym cym { get; set; }
        public Deu deu { get; set; }
        public Est est { get; set; }
        public Fin fin { get; set; }
        public Fra fra { get; set; }
        public Hrv hrv { get; set; }
        public Hun hun { get; set; }
        public Ita ita { get; set; }
        public Jpn jpn { get; set; }
        public Kor kor { get; set; }
        public Nld nld { get; set; }
        public Per per { get; set; }
        public Pol pol { get; set; }
        public Por por { get; set; }
        public Rus rus { get; set; }
        public Slk slk { get; set; }
        public Spa spa { get; set; }
        public Swe swe { get; set; }
        public Tur tur { get; set; }
        public Urd urd { get; set; }
        public Zho zho { get; set; }
    }

    public class Demonyms
    {
        public Eng eng { get; set; }
        public Fra fra { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }

    public class Car
    {
        public IList<string> signs { get; set; }
        public string side { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class CoatOfArms
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class CapitalInfo
    {
        public IList<double> latlng { get; set; }
    }

    public class PostalCode
    {
        public string format { get; set; }
        public string regex { get; set; }
    }

    public class MRegion
    {
        public Name name { get; set; }
        public IList<string> tld { get; set; }
        public string cca2 { get; set; }
        public string ccn3 { get; set; }
        public string cca3 { get; set; }
        public string cioc { get; set; }
        public bool independent { get; set; }
        public string status { get; set; }
        public bool unMember { get; set; }
        public Currencies currencies { get; set; }
        public Idd idd { get; set; }
        public IList<string> capital { get; set; }
        public IList<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public Languages languages { get; set; }
        public Translations translations { get; set; }
        public IList<double> latlng { get; set; }
        public bool landlocked { get; set; }
        public double area { get; set; }
        public Demonyms demonyms { get; set; }
        public string flag { get; set; }
        public Maps maps { get; set; }
        public int population { get; set; }
        public string fifa { get; set; }
        public Car car { get; set; }
        public IList<string> timezones { get; set; }
        public IList<string> continents { get; set; }
        public Flags flags { get; set; }
        public CoatOfArms coatOfArms { get; set; }
        public string startOfWeek { get; set; }
        public CapitalInfo capitalInfo { get; set; }
        public IList<string> borders { get; set; }
        public PostalCode postalCode { get; set; }
    }
}
