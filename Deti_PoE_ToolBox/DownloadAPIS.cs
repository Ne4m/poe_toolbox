using Deti_PoE_ToolBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deti_PoE_ToolBox
{

    class DownloadAPIS
    {


        public string league;

        public string getLeagueInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://api.poe.watch/leagues");
                return info;
            }
        }

        public string getCurrencyInfo()
        {
            Form1 frm = new Form1();

            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/Data/currencyoverview?league=" + league + "&type=Currency");
                return info;
            }
        }

        public string getFragmentsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/currencyoverview?type=Fragment&league=" + league);
                return info;
            }
        }

        public string getSeedInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Seed&league=" + league);
                return info;
            }
        }

        public string getDeliriumOrbInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=DeliriumOrb&league=" + league);
                return info;
            }
        }

        public string getOilsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Oil&league=" + league);
                return info;
            }
        }

        public string getIncubatorInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Incubator&league=" + league);
                return info;
            }
        }

        public string getScarabInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Scarab&league=" + league);
                return info;
            }
        }

        public string getFossilsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Fossil&league=" + league);
                return info;
            }
        }

        public string getResonatorsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Resonator&league=" + league);
                return info;
            }
        }

        public string getEssencesInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Essence&league=" + league);
                return info;
            }
        }

        public string getCardsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=DivinationCard&league=" + league);
                return info;
            }
        }

        public string getPropheciesInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Prophecy&league=" + league);
                return info;
            }
        }

        public string getGemsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=SkillGem&league=" + league);
                return info;
            }
        }

        public string getBaseTypesInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=BaseType&league=" + league);
                return info;
            }
        }

        public string getEnchantsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=HelmetEnchant&league=" + league);
                return info;
            }
        }

        public string getUniqueMapsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=UniqueMap&league=" + league);
                return info;
            }
        }

        public string getMapsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Map&league=" + league);
                return info;
            }
        }

        public string getJewelsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=UniqueJewel&league=" + league);
                return info;
            }
        }

        public string getFlasksInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=UniqueFlask&league=" + league);
                return info;
            }
        }

        public string getWeaponsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=UniqueWeapon&league=" + league);
                return info;
            }
        }

        public string getArmoursInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=UniqueArmour&league=" + league);
                return info;
            }
        }

        public string getAccessoryInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=UniqueAccessory&league=" + league);
                return info;
            }
        }

        public string getBeastsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Beast&league=" + league);
                return info;
            }
        }

        public string getUniqueBeastsInfo()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string info = webClient.DownloadString("https://poe.ninja/api/data/itemoverview?type=Beast&league=" + league);
                return info;
            }
        }
    }
}
