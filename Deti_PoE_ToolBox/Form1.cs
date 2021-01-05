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
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Runtime.InteropServices;
using Deti_Poe_ToolBox;
using System.Net;
using System.Web.Helpers;


/* 
 * 05.01.2021
 * Merged into Github No Longer Using This --
 * 
 * /* Changelog v0.83 - 17.09.2020
 * Added Support for Heist League
 * 
 * 
 * Changelog v0.82a - 27.07.2020
 * Slight UI Redesign
 * Added support for Seeds
 * Disabled Automatic League Detection Due To a Rare Bug.
 * 
 * Changelog v0.82 - 23.03.2020
 * Added Div Card Analyzer to help item filters.
 * 
 * 
 * Changelog v0.81 - 23.03.2020
 * Added Automated League Detection.
 * Added Support for Delirium League
 * League Selection Is Now Fully Operative.
 * Added Dynamic Title Change Based On Software Version & League Name
 * Minor Code Cleanup
 * 
 * 
 * Changelog v0.8 - 19.12.2019
 * Added 3.9 New Influence BaseTypes to the Advanced Item Checker
 * 
 * 
 * Changelog v0.7 - 14.09.2019
 * League Selection Is Partially Operative Now (HC League Does Not Work)
 * 
 * 
 * Changelog v0.6d - 08.03.2019
 * Started adding League selection (50% done)
 * 
 * 
 * Changelog v0.6c - 13.01.2019
 * Added Bestiary Rare and Unique Beasts Info
 * 
 * 
 * ChangeLog v0.6b - 02.01.2019
 * Improved BaseChecker tool algorithm
 * Fixed BaseChecker tool rarity search.
 * 
 * ChangeLog v0.6a - 28.12.2018
 * Fixed an issue with unidentified items were not picking up correctly in BaseChecker tool
 * 
 * ChangeLog v0.6 - 28.12.2018
 * Added Item Level Price Checker for Shaper - Elder - Normal Bases
 * 
 * 
 * 
 * To-Do List - Last Updated : 21.12.2018
 * Price Checker For Corrupted/6 Linked/Coloured Bases
 * For 6 Linked try to learn how many "-" in the Sockets: line and "-" number + 1 will give linked number (Sockets: G-B-R-G-R-B )
 * For Coloured Bases How many R-G-B in Sockets Line:
 * Corrupted = 1, Corrupted = 0 in Poe.Trade link
 * 
 * */
namespace Deti_PoE_ToolBox
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        Form2 form2 = new Form2();
        DownloadAPIS dlapi = new DownloadAPIS();
        

        public double ChaosExaltedRate;
        public double orbChaosValue;
        public string newinput;
        public string lastclicked;
        public string league;// = "Heist";
        private string version = "0.84";
        public static string jsonpath = "currency.json";
        public dynamic myJsonData;

        public void getLeagueInfo()
        {
            var jsonReturn = JsonConvert.DeserializeObject<List<JStructure.LeagueInfo>>(dlapi.getLeagueInfo());


            this.league = jsonReturn[2].name;

            for (int i=0; i<jsonReturn.Count; i++)
            {
                Console.WriteLine(jsonReturn[i].name);
                leagueBox.Items.Add(jsonReturn[i].name);
            }
            
        }

        public void GetCurrencyPrice(string orbName)
        {
            
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Currencies>(dlapi.getCurrencyInfo());

            foreach (var c in jsonReturn.lines)
            {
                if (c.currencyTypeName == orbName) { orbChaosValue = c.chaosEquivalent; }
            }

        }

        public void getChaosExaltedRate()
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Currencies>(dlapi.getCurrencyInfo());

            foreach (var c in jsonReturn.lines)
            {
                if (c.currencyTypeName == "Exalted Orb") { ChaosExaltedRate = c.chaosEquivalent; }
            }
        }
      



        private static void CopySelectedItems(ListView source, ListView target)
        {

            foreach (ListViewItem item in source.Items)
            {
                target.Columns.Add("i");
                target.Items.Add((ListViewItem)item.Clone());
            }
        }

        private static void ReturnSelectedItems(ListView source, ListView target)
        {

            foreach (ListViewItem item in source.Items)
            {
                target.Items.Add((ListViewItem)item.Clone());
            }
        }

        public void sendLastClickedButton()
        {

        }
            
        public void updateTitle(string getLeague)
        {
            this.Text = "Deti PoE ToolBox " + version + " League: " + getLeague;

            label2.Text = "Deti PoE ToolBox " + version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLeagueInfo();
            //leagueBox.Items.Add(league);
            //leagueBox.Items.Add("Hardcore " + league);
            //leagueBox.Items.Add("Standard");
            //leagueBox.Items.Add("Hardcore");

            updateTitle(league);
            leagueBox.Text = league;
            getChaosExaltedRate();

        }

        #region unnecessary codes

        private void getCurrency_Click(object sender, EventArgs e)
        {

          
        }

        private void getAccessory_Click(object sender, EventArgs e)
        {
            
        }

        private void getSize_Click(object sender, EventArgs e)
        {
            

        }
        #endregion

        #region Click Methods Starts
        private void currencyArray_Click(object sender, EventArgs e) // Double.Parse() System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo String to double
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Currencies>(dlapi.getCurrencyInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                //if (c.currencyTypeName == "Exalted Orb") { ChaosExaltedRate = c.chaosEquivalent; }
                richTextBox1.Text = richTextBox1.Text + c.currencyTypeName + ": " + c.chaosEquivalent + " c / " + String.Format("{0:0.00}", (c.chaosEquivalent/ ChaosExaltedRate)) + " Ex\n";

                ListViewItem test = new ListViewItem(c.currencyTypeName);
                test.SubItems.Add(c.chaosEquivalent.ToString());
                test.SubItems.Add( String.Format("{0:0.00}", (c.chaosEquivalent / ChaosExaltedRate)) );
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Console.WriteLine("Exalted Chaos Rate is: " + ChaosExaltedRate);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);

        }

        private void fragmentsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Fragments>(dlapi.getFragmentsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");               

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.currencyTypeName + ": " + c.chaosEquivalent + " c / " + String.Format("{0:0.00}", (c.chaosEquivalent / ChaosExaltedRate)) + " Ex\n";

                ListViewItem test = new ListViewItem(c.currencyTypeName);
                test.SubItems.Add(c.chaosEquivalent.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.chaosEquivalent / ChaosExaltedRate)));
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void fossilsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Fossils>(dlapi.getFossilsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description"); 

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.explicitModifiers[0].text);
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void resonatorsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Resonators>(dlapi.getResonatorsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }
    
        private void essencesArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Essences>(dlapi.getEssencesInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.explicitModifiers[0].text);
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void cardsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Cards>(dlapi.getCardsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Stack Size");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.stackSize);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void propheciesArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Prophecies>(dlapi.getPropheciesInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.prophecyText);
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }


        private void gemsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Gems>(dlapi.getGemsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 379;
            testBox.Visible = true;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Level");
            listView1.Columns.Add("Quality");
            listView1.Columns.Add("Corrupt");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");


            foreach (var c in jsonReturn.lines)
            {

             /*   if (c.variant == "21/23c")
                {
                    testBox.Text = testBox.Text + " [" + c.variant + "] " + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                }
                else
                {
                }
            */

                richTextBox1.Text = richTextBox1.Text + " [" + c.variant + "] " + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";
            ListViewItem test = new ListViewItem(c.name);
            test.SubItems.Add(c.gemLevel.ToString());
            test.SubItems.Add(c.gemQuality.ToString());
            if (c.corrupted == true) { test.SubItems.Add("Yes"); }
            else { test.SubItems.Add("No"); }
            test.SubItems.Add(c.chaosValue.ToString());
            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
            listView1.Items.Add(test);
                
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void scarabsTypesArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Scarabs>(dlapi.getScarabInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.explicitModifiers[0].text);
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void helmEnchantsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.HelmEnchants>(dlapi.getEnchantsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void uniqueMapsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.UniqueMaps>(dlapi.getUniqueMapsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Tier");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + "T" + c.mapTier + " " + c.name + " " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.mapTier.ToString());
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }



        private void mapsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Maps>(dlapi.getMapsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Tier");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + "T" + c.mapTier + " " + c.name + " " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.mapTier.ToString());
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);

            DetailedMapPrices detailedMapPrices = new DetailedMapPrices();
            detailedMapPrices.league = this.league;
            detailedMapPrices.Show();
            detailedMapPrices.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailedMapPrices.TopMost = true;
            
        }

        private void jewelsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Jewels>(dlapi.getJewelsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void flasksArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Flasks>(dlapi.getFlasksInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Relic");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");


            foreach (var c in jsonReturn.lines)
            {
                if (c.itemClass == 9) // RELIC ITEMCLASS ID
                {
                    richTextBox1.Text = richTextBox1.Text + c.name + " [R] " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";
                }
                if (c.itemClass == 3) // NON-RELIC ITEMCLASS ID
                {
                    richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";
                }

                ListViewItem test = new ListViewItem(c.name);
                if (c.itemClass == 9) { test.SubItems.Add("Yes"); }
                else { test.SubItems.Add("No"); }
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void weaponsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Weapons>(dlapi.getWeaponsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 379;
            testBox.Visible = true;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Relic");
            listView1.Columns.Add("Links");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            GetUserInput getInput = new GetUserInput();
            DialogResult result = getInput.ShowDialog();

            if (result == DialogResult.OK)
            {
                newinput = getInput.sendInput;

                if (newinput == "Definitely6")
                {
                    foreach (var c in jsonReturn.lines)
                    {
                        if (c.links == 6)
                        {
                            ListViewItem test = new ListViewItem(c.name);
                            if (c.itemClass == 9) { test.SubItems.Add("Yes"); }
                            else { test.SubItems.Add("No"); }
                            test.SubItems.Add(c.links.ToString());
                            test.SubItems.Add(c.chaosValue.ToString());
                            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                            listView1.Items.Add(test);
                        }
                    }
                }
                if (newinput == "Not6")
                {
                    foreach (var c in jsonReturn.lines)
                    {
                        if (c.links < 6)
                        {
                            ListViewItem test = new ListViewItem(c.name);
                            if (c.itemClass == 9) { test.SubItems.Add("Yes"); }
                            else { test.SubItems.Add("No"); }
                            test.SubItems.Add(c.links.ToString());
                            test.SubItems.Add(c.chaosValue.ToString());
                            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                            listView1.Items.Add(test);
                        }
                    }
                }
            }


            /*if (c.itemClass == 9) // RELIC ITEMCLASS ID
            {
                if (c.links == 6)
                {
                    testBox.Text = testBox.Text + "[" + c.links + "L] " + c.name + " [R] " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "[" + c.links + "L] " + c.name + " [R] " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";
                }
            }
            else
                if (c.itemClass == 3)
            {
                if (c.links == 6)
                {
                    testBox.Text = testBox.Text + "[" + c.links + "L] " + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "[" + c.links + "L] " + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";
                }
            }*/

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void armoursArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Armours>(dlapi.getArmoursInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 379;
            testBox.Visible = true;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Relic");
            listView1.Columns.Add("Links");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            GetUserInput getInput = new GetUserInput();
            DialogResult result = getInput.ShowDialog();

            if (result == DialogResult.OK)
            {
                newinput = getInput.sendInput;

                if (newinput == "Definitely6")
                {
                    foreach (var c in jsonReturn.lines)
                    {
                        if (c.links == 6)
                        {
                            ListViewItem test = new ListViewItem(c.name);
                            if (c.itemClass == 9) { test.SubItems.Add("Yes"); }
                            else { test.SubItems.Add("No"); }
                            test.SubItems.Add(c.links.ToString());
                            test.SubItems.Add(c.chaosValue.ToString());
                            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                            listView1.Items.Add(test);
                        }
                    }
                }
                if (newinput == "Not6")
                {
                    foreach (var c in jsonReturn.lines)
                    {
                        if (c.links < 6)
                        {
                            ListViewItem test = new ListViewItem(c.name);
                            if (c.itemClass == 9) { test.SubItems.Add("Yes"); }
                            else { test.SubItems.Add("No"); }
                            test.SubItems.Add(c.links.ToString());
                            test.SubItems.Add(c.chaosValue.ToString());
                            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                            listView1.Items.Add(test);
                        }
                    }
                }
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);

            /* 
             {
                 if (c.itemClass == 9) // RELIC ITEMCLASS ID
                 if (c.itemClass == 3) // NON-RELIC ITEMCLASS ID

             }*/

        }

        private void accessoryArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Accessories>(dlapi.getAccessoryInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Relic");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");

            foreach (var c in jsonReturn.lines)
            {
                if (c.itemClass == 9) // RELIC ITEMCLASS ID
                {
                    richTextBox1.Text = richTextBox1.Text + c.name + " [R] " + c.chaosValue + " c / " + String.Format("{0:0.00}", (c.chaosValue / ChaosExaltedRate)) + " Ex\n";

                }
                else
                if (c.itemClass == 3) // NON-RELIC ITEMCLASS ID
                {
                    richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", (c.chaosValue / ChaosExaltedRate)) + " Ex\n";

                }

                ListViewItem test = new ListViewItem(c.name);
                if (c.itemClass == 9) { test.SubItems.Add("Yes"); }
                else { test.SubItems.Add("No"); }
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }






        #endregion Click Methods End

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (currencyList2.Text == "Chaos Orb")
            {
                double quantityMultiplier1;
                quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                GetCurrencyPrice(currencyList1.Text);
                currencyResultBox.Text = String.Format("{0:0.00}", (quantityMultiplier1 * orbChaosValue).ToString()) + " C";
            }
            else
            if (currencyList1.Text == "Chaos Orb")
            {
                if (list2QuantityBox.Text != string.Empty)
                {
                    double quantityMultiplier1;
                    int chaosValue = 1;
                    double secondaryChaosValue;
                    quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                    GetCurrencyPrice(currencyList2.Text);
                    secondaryChaosValue = orbChaosValue;

                    currencyResultBox.Text = String.Format("{0:0.00}", ((quantityMultiplier1 * chaosValue) / secondaryChaosValue).ToString()) + " C";
                }
                else
                {
                    MessageBox.Show("Choose a currency to convert!", "List is Empty!");
                }
            }
            else
            {
                if (list2QuantityBox.Text != string.Empty)
                    { 
                        double quantityMultiplier1;
                        double secondaryChaosValue;
                        GetCurrencyPrice(currencyList1.Text);
                        secondaryChaosValue = orbChaosValue;
                        quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                        GetCurrencyPrice(currencyList2.Text);

                        currencyResultBox.Text = String.Format("{0:0.00}", ((quantityMultiplier1 * secondaryChaosValue)/ orbChaosValue).ToString()) + " C";
                    }
                    else
                    {
                        MessageBox.Show("Choose a currency to convert!", "List is Empty!");
                    }
            }
        }

        private void currencyList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { currencyList1.Select(0, 0); }));
        }

        private void list2QuantityBox_TextChanged(object sender, EventArgs e)
        {



        }

        private void currencyList1_TextChanged(object sender, EventArgs e)
        {
            try
            { 
            if (currencyList1.Text != "Chaos Orb")
            {
                if (list1QuantityBox.Text == string.Empty)
                {
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (orbChaosValue).ToString()) + " C";
                }
                else
                {
                    double quantityMultiplier1;
                    quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (quantityMultiplier1 * orbChaosValue).ToString()) + " C";
                }
            }
            else
            {
                if (list1QuantityBox.Text == string.Empty)
                {
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (orbChaosValue).ToString()) + " C";
                }
                else
                {
                    double quantityMultiplier1;
                    quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (quantityMultiplier1).ToString()) + " C";
                }
            }
            }
            catch
            {

            }
        }

        private void list1QuantityBox_TextChanged(object sender, EventArgs e)
        {
            try
            { 
            if (currencyList1.Text != "Chaos Orb")
            { 
                if (list1QuantityBox.Text == string.Empty)
                {
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (orbChaosValue).ToString()) + " C";
                }
                else
                {
                    double quantityMultiplier1;
                    quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (quantityMultiplier1 * orbChaosValue).ToString()) + " C";
                }
            }
            else
            {
                if (list1QuantityBox.Text == string.Empty)
                {
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (orbChaosValue).ToString()) + " C";
                }
                else
                {
                    double quantityMultiplier1;
                    quantityMultiplier1 = Double.Parse(list1QuantityBox.Text);
                    GetCurrencyPrice(currencyList1.Text);
                    list2QuantityBox.Text = String.Format("{0:0.00}", (quantityMultiplier1).ToString()) + " C";
                }
            }
            }
            catch
            {

            }
        }

        private void currencyList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { currencyList1.Select(0, 0); }));
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            if (txt_Search.Text != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().Contains(txt_Search.Text.ToLower()))
                    {
                        //item.Selected = true;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }

                }
                /*(listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }*/
            }
           else
            {
                // currencyArray_Click(sender, e);

                listView1.Items.Clear();
                ReturnSelectedItems(listView2, listView1);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdvencedConversionForm advForm = new AdvencedConversionForm();
            advForm.Show();
            advForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            advForm.TopMost = true;
            advForm.league = this.league;
            //this.WindowState = FormWindowState.Minimized;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string content = listView1.Items[listView1.SelectedIndices[0]].Text;
            content = content.Replace(" ", "+");

            //http://poe.trade/search?league=Standart&name=Chaos+Orb&online=x&want=
            System.Diagnostics.Process.Start("http://poe.trade/search?league=" + league + "&online=x&want=" + "&name=" + content);
        }

        private void itemLevelPriceCheckButton_Click(object sender, EventArgs e)
        {
            AdvancedBaseChecker advBase = new AdvancedBaseChecker();
            advBase.Show();
            advBase.league = this.league;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Form3 changelog = new Form3();


            MessageBox.Show("Latest " + changelog.logTxt.Text, "Deti Poe ToolBox Release " + version);
        }

        private void beastsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Beasts>(dlapi.getBeastsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.variant);
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void uniqueBeastsArray_Click(object sender, EventArgs e)
        {
            //ImportAsync();
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.uniqueBeasts>(dlapi.getUniqueBeastsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.variant);
                listView1.Items.Add(test);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }


        private void leagueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmpLeague = league;

            if (leagueBox.Text == league)
            {
                // Default League Do Nothing
                tmpLeague = league;
            }
            else if (leagueBox.Text == "Standard")
            {
                tmpLeague = "Standard";
            }
            else if (leagueBox.Text == "Hardcore")
            {
                tmpLeague = "Hardcore";
            }
            else
            {
                tmpLeague = "Hardcore%20" + league;
            }

            dlapi.league = tmpLeague;

            listView1.Items.Clear();
            listView1.Columns.Clear();

            if (tmpLeague.Contains("Hardcore%20"))
            {
                tmpLeague = "Hardcore " + league;
            }

            updateTitle(tmpLeague);

        }

        private void incubatorsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Scarabs>(dlapi.getIncubatorInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description"); //                 test.SubItems.Add(c.explicitModifiers[0].text);

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.explicitModifiers[0].text);
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void oilsTypesArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Scarabs>(dlapi.getOilsInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            //  listView1.Columns.Add("Description");                 test.SubItems.Add(c.explicitModifiers[0].text);

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));

                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        private void deliriumOrbArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Scarabs>(dlapi.getDeliriumOrbInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            foreach (var c in jsonReturn.lines)
            {
                richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                ListViewItem test = new ListViewItem(c.name);
                test.SubItems.Add(c.chaosValue.ToString());
                test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                test.SubItems.Add(c.explicitModifiers[0].text);
                listView1.Items.Add(test);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void divcardAnalyzer_bttn_Click(object sender, EventArgs e)
        {
            divCardAnalyze div = new divCardAnalyze();
            div.FormBorderStyle = FormBorderStyle.FixedSingle;
            div.TopMost = true;
            div.league = dlapi.league;
            div.Show();
        }

        public float getSeedValue(string seedName, bool biggerSeventySix)
        {
            float price = 0;

            // GET ITEM DATA FROM API
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.pathofexile.com/api/trade/search/" + league);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                StreamReader sr = new StreamReader(jsonpath);
                string json = sr.ReadToEnd();

                dynamic myJson = Json.Decode(json);
                myJson.query.type = seedName;

                json = Json.Encode(myJson);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                myJsonData = Json.Decode(result);
            }

            if (myJsonData != null)
            {

                var sb = new System.Text.StringBuilder();
                var sb2 = new System.Text.StringBuilder();

                //Console.WriteLine("ID : " + ourData.id);
                //Console.WriteLine("Result : ");


                int counter = 0;
                foreach (var c in myJsonData.result)
                {
                    if (counter < 10)
                    {
                        sb.Append(c + ',');

                        //sb2.Append(c + ',');
                    }

                    counter++;

                }



                string jsonString = sb.ToString();
                jsonString = jsonString.Remove(jsonString.Length - 1);



                string createURL = "https://www.pathofexile.com/api/trade/fetch/" + jsonString + "?query=" + myJsonData.id;



                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;


                Console.WriteLine("Processing...");
                string dlJSON = wc.DownloadString(createURL);
                System.Threading.Thread.Sleep(2500);

                var stuff = JsonConvert.DeserializeObject<seedsJS.Rootobject>(dlJSON);

                // c.item.properties[2].values[0][0].ToString() => SEED LEVEL


                if (biggerSeventySix == false)
                {
                    foreach (var c in stuff.result)
                    {
                        if (Convert.ToInt32(c.item.properties[2].values[0][0]) < 76)
                        {

                            if (c.listing.price.currency != "chaos")
                            {
                                if (c.listing.price.currency == "alch")
                                {
                                    GetCurrencyPrice("Orb of Alchemy");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                                else if (c.listing.price.currency == "alt")
                                {
                                    GetCurrencyPrice("Orb of Alteration");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                                else if (c.listing.price.currency == "exa")
                                {
                                    GetCurrencyPrice("Exalted Orb");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                                else if (c.listing.price.currency == "chis")
                                {
                                    GetCurrencyPrice("Cartographer's Chisel");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                            }


                        }

                        price += c.listing.price.amount;

                    }
                }
                else if (biggerSeventySix == true)
                {
                    foreach (var c in stuff.result)
                    {
                        if (Convert.ToInt32(c.item.properties[2].values[0][0]) >= 76)
                        {

                            if (c.listing.price.currency != "chaos")
                            {
                                if (c.listing.price.currency == "alch")
                                {
                                    GetCurrencyPrice("Orb of Alchemy");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                                else if (c.listing.price.currency == "alt")
                                {
                                    GetCurrencyPrice("Orb of Alteration");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                                else if (c.listing.price.currency == "exa")
                                {
                                    GetCurrencyPrice("Exalted Orb");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                                else if (c.listing.price.currency == "chis")
                                {
                                    GetCurrencyPrice("Cartographer's Chisel");
                                    c.listing.price.amount *= Convert.ToSingle(orbChaosValue);
                                }
                            }

                            //Console.WriteLine(c.item.typeLine + " " + c.listing.price.amount + " " + c.listing.price.currency);
                        }

                        price += c.listing.price.amount;

                    }

                }

                //Console.WriteLine("AVG Value is: " + (price / 10));

            }



            return (price / 10);
        }

        private void seedsArray_Click(object sender, EventArgs e)
        {
            var jsonReturn = JsonConvert.DeserializeObject<JStructure.Seeds>(dlapi.getSeedInfo());
            richTextBox1.Clear();
            richTextBox1.Width = 667;
            testBox.Visible = false;

            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Level");
            listView1.Columns.Add("Tier");
            listView1.Columns.Add("Chaos Value");
            listView1.Columns.Add("Exalted Value");
            listView1.Columns.Add("Description");

            getSeedInput getInput = new getSeedInput();
            DialogResult result = getInput.ShowDialog();

            if (result == DialogResult.OK)
            {
                newinput = getInput.sendInput;

                if (newinput == "less")
                {
                    foreach (var c in jsonReturn.lines)
                    {
                        if (c.levelRequired < 76)
                        { 
                            richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                            ListViewItem test = new ListViewItem(c.name);
                            test.SubItems.Add(c.levelRequired.ToString());
                            test.SubItems.Add(c.mapTier.ToString());
                            test.SubItems.Add(c.chaosValue.ToString());
                            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                            test.SubItems.Add(c.explicitModifiers[0].text);
                            listView1.Items.Add(test);
                        }
                    }
                }
                else
                {
                    foreach (var c in jsonReturn.lines)
                    {
                        if (c.levelRequired >= 76)
                        {
                            richTextBox1.Text = richTextBox1.Text + c.name + ": " + c.chaosValue + " c / " + String.Format("{0:0.00}", c.exaltedValue) + " Ex\n";

                            ListViewItem test = new ListViewItem(c.name);
                            test.SubItems.Add(c.levelRequired.ToString());
                            test.SubItems.Add(c.mapTier.ToString());
                            test.SubItems.Add(c.chaosValue.ToString());
                            test.SubItems.Add(String.Format("{0:0.00}", (c.exaltedValue)));
                            test.SubItems.Add(c.explicitModifiers[0].text);
                            listView1.Items.Add(test);
                        }
                    }
                }
            }


            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.Items.Clear();
            CopySelectedItems(listView1, listView2);

        }
    }
    }

