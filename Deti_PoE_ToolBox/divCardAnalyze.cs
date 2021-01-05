using Deti_PoE_ToolBox;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace Deti_Poe_ToolBox
{
    public partial class divCardAnalyze : Form
    {
        public System.Drawing.Color BorderColor { get; set; }

        public string league;
        DownloadAPIS dlapi = new DownloadAPIS();
        public string pogey;

        public string[] blackList = {
            "Lantador's Lost Love",
            "The Lover",
            "Destined to Crumble",
            "Struck by Lightning",
            "The Carrion Crow",
            "The Inoculated",
            "The King's Blade",
            "The Surgeon",
            "The Calling",
            "The Siren",
            "The Twins",
            "The Sigil",
            "The Metalsmith's Gift",
            "Turn the Other Cheek",
            "The Wolf's Shadow"
        };

        public divCardAnalyze()
        {
            InitializeComponent();
        }

        public class Cards
        {
            public List<CardsLines> lines { get; set; }
            public class CardsLines
            {
                public string name;
                public double chaosValue;
                public double exaltedValue;
                public string stackSize;
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


        private void divCardAnalyze_Load(object sender, EventArgs e)
        {
            lowTierlbl.BackColor = Color.FromArgb(255, 192, 192, 192);
            lowTierlbl.ForeColor = Color.FromArgb(255, 46, 46, 46);
            lowTierlbl.BorderStyle = BorderStyle.FixedSingle;

            medTierlbl.BackColor = Color.FromArgb(255, 201, 147, 255);
            medTierlbl.ForeColor = Color.FromArgb(255, 46, 46, 46);
            medTierlbl.BorderStyle = BorderStyle.FixedSingle;

            highTierlbl.BackColor = Color.FromArgb(255, 128, 0, 255);
            highTierlbl.ForeColor = Color.FromArgb(255, 46, 46, 46);
            highTierlbl.BorderStyle = BorderStyle.FixedSingle;

            generateInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
        }

        private void generateInfo()
        {
            var pogu = JsonConvert.DeserializeObject<Cards>(getCardsInfo());

            foreach (var c in pogu.lines)
            {
                if (!blackList.Contains(c.name))
                {

                    if (c.chaosValue < 2)
                    {
                        divCards_low.Text += "\"" + c.name + "\"" + " ";
                    }

                    if (c.chaosValue >= 2 && c.chaosValue < 10)
                    {
                        divCards_med.Text += "\"" + c.name + "\"" + " ";
                    }

                    if (c.chaosValue >= 10)
                    {
                        divCards_high.Text += "\"" + c.name + "\"" + " ";
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(divCards_low.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(divCards_med.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(divCards_high.Text);
        }
    }
}
