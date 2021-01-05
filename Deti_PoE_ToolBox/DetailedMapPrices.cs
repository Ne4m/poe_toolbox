using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace Deti_PoE_ToolBox
{
    public partial class DetailedMapPrices : Form
    {
        public DetailedMapPrices()
        {
            InitializeComponent();
            
        }

        DownloadAPIS dlapi = new DownloadAPIS();

        public double AlchPrice;
        public double ChiselPrice;
        public int mapTierValue = 1;
        public string league;

        private void DetailedMapPrices_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TopMost = true;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;

            

            dlapi.league = league;

            var currencyStuff = JsonConvert.DeserializeObject<JStructure.Currencies>(dlapi.getCurrencyInfo());

            foreach (var c in currencyStuff.lines)
            {
                if (c.currencyTypeName == "Orb of Alchemy") { AlchPrice = c.chaosEquivalent; }
                if (c.currencyTypeName == "Cartographer's Chisel") { ChiselPrice = c.chaosEquivalent; }
            }

            /*MessageBox.Show("Alchemy price : " + AlchPrice);
            MessageBox.Show("Chisel price : " + ChiselPrice);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var stuff2 = JsonConvert.DeserializeObject<JStructure.Maps>(dlapi.getMapsInfo());

                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Tier");
                listView1.Columns.Add("Chaos Value");
                listView1.Columns.Add("Alchemy Value");
                listView1.Columns.Add("Chisel Value");

                foreach (var c in stuff2.lines)
                {
                    if (c.mapTier == mapTierValue)
                    {
                        ListViewItem test = new ListViewItem(c.name);
                        test.SubItems.Add(c.mapTier.ToString());
                        test.SubItems.Add(c.chaosValue.ToString());
                        test.SubItems.Add(String.Format("{0:0.00}", (c.chaosValue/AlchPrice)));
                        test.SubItems.Add(String.Format("{0:0.00}", (c.chaosValue / ChiselPrice)));
                        listView1.Items.Add(test);
                    }
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
            
            
        }

        private void tierSelect_TextChanged(object sender, EventArgs e)
        {
            if (tierSelect.Text == "Tier 1")
            {
                mapTierValue = 1;
            }
            if (tierSelect.Text == "Tier 2")
            {
                mapTierValue = 2;
            }
            if (tierSelect.Text == "Tier 3")
            {
                mapTierValue = 3;
            }
            if (tierSelect.Text == "Tier 4")
            {
                mapTierValue = 4;
            }
            if (tierSelect.Text == "Tier 5")
            {
                mapTierValue = 5;
            }
            if (tierSelect.Text == "Tier 6")
            {
                mapTierValue = 6;
            }
            if (tierSelect.Text == "Tier 7")
            {
                mapTierValue = 7;
            }
            if (tierSelect.Text == "Tier 8")
            {
                mapTierValue = 8;
            }
            if (tierSelect.Text == "Tier 9")
            {
                mapTierValue = 9;
            }
            if (tierSelect.Text == "Tier 10")
            {
                mapTierValue = 10;
            }
            if (tierSelect.Text == "Tier 11")
            {
                mapTierValue = 11;
            }
            if (tierSelect.Text == "Tier 12")
            {
                mapTierValue = 12;
            }
            if (tierSelect.Text == "Tier 13")
            {
                mapTierValue = 13;
            }
            if (tierSelect.Text == "Tier 14")
            {
                mapTierValue = 14;
            }
            if (tierSelect.Text == "Tier 15")
            {
                mapTierValue = 15;
            }
            if (tierSelect.Text == "Tier 16")
            {
                mapTierValue = 16;
            }
        }
    }
}
