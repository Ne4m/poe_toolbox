using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deti_Poe_ToolBox
{
    internal class JStructure_New
    {

        public class Rootobject
        {
            public Line[] lines { get; set; }
            public Currencydetail[] currencyDetails { get; set; }
            public Language language { get; set; }
        }

        public class Language
        {
            public string name { get; set; }
            public Translations translations { get; set; }
        }

        public class Translations
        {
        }

        public class Line
        {
            public string currencyTypeName { get; set; }
            public Pay pay { get; set; }
            public Receive receive { get; set; }
            public Paysparkline paySparkLine { get; set; }
            public Receivesparkline receiveSparkLine { get; set; }
            public float chaosEquivalent { get; set; }
            public Lowconfidencepaysparkline lowConfidencePaySparkLine { get; set; }
            public Lowconfidencereceivesparkline lowConfidenceReceiveSparkLine { get; set; }
            public string detailsId { get; set; }
        }

        public class Pay
        {
            public int id { get; set; }
            public int league_id { get; set; }
            public int pay_currency_id { get; set; }
            public int get_currency_id { get; set; }
            public DateTime sample_time_utc { get; set; }
            public int count { get; set; }
            public float value { get; set; }
            public int data_point_count { get; set; }
            public bool includes_secondary { get; set; }
            public int listing_count { get; set; }
        }

        public class Receive
        {
            public int id { get; set; }
            public int league_id { get; set; }
            public int pay_currency_id { get; set; }
            public int get_currency_id { get; set; }
            public DateTime sample_time_utc { get; set; }
            public int count { get; set; }
            public float value { get; set; }
            public int data_point_count { get; set; }
            public bool includes_secondary { get; set; }
            public int listing_count { get; set; }
        }

        public class Paysparkline
        {
            public float?[] data { get; set; }
            public float totalChange { get; set; }
        }

        public class Receivesparkline
        {
            public float[] data { get; set; }
            public float totalChange { get; set; }
        }

        public class Lowconfidencepaysparkline
        {
            public float?[] data { get; set; }
            public float totalChange { get; set; }
        }

        public class Lowconfidencereceivesparkline
        {
            public float[] data { get; set; }
            public float totalChange { get; set; }
        }

        public class Currencydetail
        {
            public int id { get; set; }
            public string icon { get; set; }
            public string name { get; set; }
            public string tradeId { get; set; }
        }

    }
}
