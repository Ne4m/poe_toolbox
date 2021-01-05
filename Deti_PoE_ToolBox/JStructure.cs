using Deti_PoE_ToolBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 
 * "currencyTypeName": "Mirror of Kalandra",
      "pay": {
        "id": 0,
        "league_id": 46,
        "pay_currency_id": 22,
        "get_currency_id": 1,
        "sample_time_utc": "2018-10-18T23:30:24.1883249Z",
        "count": 22,
        "value": 0.00003742274797752809,
        "data_point_count": 1,
        "includes_secondary": true
      },
      "*/


namespace Deti_PoE_ToolBox
{
    class JStructure
    {
        //public class LeagueInfo
        //{
        //    public int id { get; set; }
        //    public string name { get; set; }
        //    public string display { get; set; }
        //    public bool hardcore { get; set; }
        //    public bool upcoming { get; set; }
        //    public bool active { get; set; }
        //    public bool @event { get; set; }
        //    public bool challenge { get; set; }
        //    public DateTime start { get; set; }
        //    public DateTime? end { get; set; }
        //}


        public class LeagueInfo
        {
            public string name { get; set; }
            public DateTime start_date { get; set; }
            public DateTime end_date { get; set; }
        }


        public class Currencies
        {
            public List<CurrencyLines> lines { get; set; }
            // public CurrencyLines.PayLines pay { get; set; }

            public class CurrencyLines
            {
                public string currencyTypeName;
                public double chaosEquivalent;

                /*public class PayLines
                {
                    public string id;
                    public string league_id;
                }*/
            }
        }

        public class Fragments
        {
            public List<FragmentsLines> lines { get; set; }
            public class FragmentsLines
            {
                public string currencyTypeName;
                public double chaosEquivalent;
            }
        }

        public class Seeds
        {
            public List<SeedsLines> lines { get; set; }
            public class SeedsLines
            {
                public class ExplicitModifier
                {
                    public string text { get; set; }
                    public bool optional { get; set; }
                }


                public string name;
                public double chaosValue;
                public double exaltedValue;
                public int levelRequired;
                public int mapTier;
                public IList<ExplicitModifier> explicitModifiers { get; set; }
            }
        }



        public class DeliriumOrb
        {
            public List<DeliriumOrbLines> lines { get; set; }
            public class DeliriumOrbLines
            {
                public string currencyTypeName;
                public double chaosEquivalent;
            }


        }



        public class Fossils
        {
            public List<FossilsLines> lines { get; set; }

            public class FossilsLines
            {
                public class ExplicitModifier
                {
                    public string text { get; set; }
                    public bool optional { get; set; }
                }


                public string name;
                public double chaosValue;
                public double exaltedValue;
                public IList<ExplicitModifier> explicitModifiers { get; set; }

            }
        }

        public class Scarabs
        {
            public List<ScarabLines> lines { get; set; }



            public class ScarabLines
            {
                public class ExplicitModifier
                {
                    public string text { get; set; }
                    public bool optional { get; set; }
                }

                public string name;
                public double chaosValue;
                public double exaltedValue;
                public IList<ExplicitModifier> explicitModifiers { get; set; }
            }
        }

        public class Resonators
        {
            public List<ResonatorsLines> lines { get; set; }

            public class ResonatorsLines
            {
                public class ExplicitModifier
                {
                    public string text { get; set; }
                    public bool optional { get; set; }
                }

                public string name;
                public double chaosValue;
                public double exaltedValue;
                public IList<ExplicitModifier> explicitModifiers { get; set; }
            }

        }

        public class Essences
        {
            public List<EssencesLines> lines { get; set; }
            public class EssencesLines
            {

                public class ExplicitModifier
                {
                    public string text { get; set; }
                    public bool optional { get; set; }
                }

                public string name;
                public double chaosValue;
                public double exaltedValue;

                public IList<ExplicitModifier> explicitModifiers { get; set; }
            }
        }

        public class Cards
        {
            public List<CardsLines> lines { get; set; }
            public class CardsLines
            {
                public class ExplicitModifier
                {
                    public string text { get; set; }
                    public bool optional { get; set; }
                }

                public string name;
                public double chaosValue;
                public double exaltedValue;
                public string stackSize;

                public IList<ExplicitModifier> explicitModifiers { get; set; }
            }
        }

        public class Prophecies
        {
            public List<PropheciesLines> lines { get; set; }
            public class PropheciesLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
                public string prophecyText;
            }
        }

        public class Gems
        {
            public List<GemsLines> lines { get; set; }
            public class GemsLines
            {
                public string name;
                public string variant;
                public bool corrupted;
                public int gemLevel;
                public int gemQuality;
                public double chaosValue;
                public double exaltedValue;

            }
        }

        public class BaseTypes
        {
            public List<BaseTypesLines> lines { get; set; }
            public class BaseTypesLines
            {
                public string name;
                public string levelRequired;
                public string baseType;
                public string variant; //shaper elder
                public double chaosValue;
                public double exaltedValue;
            }
        }

        public class HelmEnchants
        {
            public List<HelmEnchantsLines> lines { get; set; }
            public class HelmEnchantsLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
            }
        }

        public class UniqueMaps
        {
            public List<UniqueMapsLines> lines { get; set; }
            public class UniqueMapsLines
            {
                public string name;
                public int mapTier;
                public double chaosValue;
                public double exaltedValue;
            }
        }

        public class Maps
        {
            public List<MapLines> lines { get; set; }
            public class MapLines
            {
                public string name;
                public int mapTier;
                public double chaosValue;
                public double exaltedValue;
            }
        }

        public class Jewels
        {
            public List<JewelsLines> lines { get; set; }
            public class JewelsLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
            }
        }

        public class Flasks
        {
            public List<FlasksLines> lines { get; set; }
            public class FlasksLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
                public int itemClass;
            }
        }

        public class Weapons
        {
            public List<WeaponsLines> lines { get; set; }
            public class WeaponsLines
            {
                public string name;
                public int links;
                public double chaosValue;
                public double exaltedValue;
                public int itemClass;
            }
        }

        public class Armours
        {
            public List<ArmoursLines> lines { get; set; }
            public class ArmoursLines
            {
                public string name;
                public int links;
                public double chaosValue;
                public double exaltedValue;
                public int itemClass;
            }
        }

        public class Accessories
        {
            public List<AccessoryLines> lines { get; set; }

            public class AccessoryLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
                public string itemType;
                public int itemClass;
            }
        }

        public class Beasts
        {
            public List<BeastsLines> lines { get; set; }

            public class BeastsLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
                public string variant;

            }
        }

        public class uniqueBeasts
        {
            public List<uniqueBeastsLines> lines { get; set; }

            public class uniqueBeastsLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
                public string variant;

            }
        }


    }
}
