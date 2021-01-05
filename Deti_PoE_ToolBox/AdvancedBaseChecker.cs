using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Deti_PoE_ToolBox
{
    public partial class AdvancedBaseChecker : Form
    {
        public AdvancedBaseChecker()
        {
            InitializeComponent();

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;

        }

        public int lineNumber = 0;
        public string itemName;
        public int itemLevel;
        public string league;

        public void runPoeTrade(string itemName, int itemLevel, int isShapered, int isEldered , string itemRarity ) // corrupted = 0;
        {
            itemName = itemName.Replace(" ", "+");
            //http://poe.trade/search?league=Betrayal&name=Ring&online=x&want=&ilvl_min=84&shaper=1&elder=0&corrupted=1
            System.Diagnostics.Process.Start("http://poe.trade/search?league=" + league + "&name=" + itemName + "&online=x&want=&ilvl_min=" + itemLevel + "&shaper=" + isShapered + "&elder=" + isEldered + "&corrupted=0" + "&rarity=" + itemRarity);
        }

        public void runPoeTrade2(string itemName, int itemLevel, string influenceString, int hasInfluence, string itemRarity) // corrupted = 0;
        {
            itemName = itemName.Replace(" ", "+");
            //http://poe.trade/search?league=Betrayal&name=Ring&online=x&want=&ilvl_min=84&shaper=1&elder=0&corrupted=1
            //System.Diagnostics.Process.Start("http://poe.trade/search?league=" + league + "&name=" + itemName + "&online=x&want=&ilvl_min=" + itemLevel + "&shaper=" + isShapered + "&elder=" + isEldered + "&corrupted=0" + "&rarity=" + itemRarity);
            System.Diagnostics.Process.Start("http://poe.trade/search?league=" + league + "&name=" + itemName + "&online=x&want=&ilvl_min=" + itemLevel + "&" + influenceString + "=" + hasInfluence + "&corrupted=0" + "&rarity=" + itemRarity);
            //textBox1.Text = "http://poe.trade/search?league=" + league + "&name=" + itemName + "&online=x&want=&ilvl_min=" + itemLevel + "&" + influenceString + "=" + hasInfluence + "&corrupted=0" + "&rarity=" + itemRarity;
        }

        // warlord - hunter - crusader - redeemer
        // http://poe.trade/search?league=Metamorph&name=Ring&online=x&want=&ilvl_min=70&warlord=1

        public static int ConvertToInt(String input)
        {
            // Replace everything that is no a digit.
            String inputCleaned = Regex.Replace(input, "[^0-9]", "");

            int value = 0;

            // Tries to parse the int, returns false on failure.
            if (int.TryParse(inputCleaned, out value))
            {
                // The result from parsing can be safely returned.
                return value;
            }

            return 0; // Or any other default value.
        }

        private void checkButton_Click(object sender, EventArgs e)
        {


            int counter = 0;
            int shapered = 0;
            int eldered = 0;
            int hasInfluence = 0;
            string influenceType = "KEREM";

            string itemBaseRarity = "Normal";

            foreach (var match in itemBox.Lines)
            {
                

                //if (!match.Contains("Unidentified"))

                if (match.Contains("Item Level"))
                {
                    lineNumber = counter;
                }

                if (match.Contains("Shaper Item"))
                {
                    shapered = 1;
                    eldered = 0;

                    hasInfluence = 1;
                    influenceType = "shaper";
                }

                if (match.Contains("Elder Item"))
                {
                    eldered = 1;
                    shapered = 0;

                    hasInfluence = 1;
                    influenceType = "elder";
                }

                if (match.Contains("Warlord Item"))
                {
                    eldered = 1;
                    shapered = 0;

                    hasInfluence = 1;
                    influenceType = "warlord";
                }

                if (match.Contains("Redeemer Item"))
                {
                    eldered = 1;
                    shapered = 0;

                    hasInfluence = 1;
                    influenceType = "redeemer";
                }

                if (match.Contains("Hunter Item"))
                {
                    eldered = 1;
                    shapered = 0;

                    hasInfluence = 1;
                    influenceType = "hunter";
                }


                if (match.Contains("Crusader Item"))
                {
                    eldered = 1;
                    shapered = 0;

                    hasInfluence = 1;
                    influenceType = "crusader";
                }


                if (itemBox.Text.Contains("Rarity: Unique"))
                {
                    itemBaseRarity = "unique";
                }
                else
                {
                    itemBaseRarity = "non_unique";
                }


                counter++;
            }

           

            if (itemBox.Text.Contains("Unidentified") || itemBox.Text.Contains("Rarity: Normal") || itemBox.Text.Contains("Rarity: Magic"))
            {
                itemName = itemBox.Lines[1];
            }
            else
            {
                itemName = itemBox.Lines[2];
            }

            
            /*Console.WriteLine(counter);
            Console.WriteLine(lineNumber);

            Console.WriteLine(itemBox.Lines[lineNumber]);

            Console.WriteLine(ConvertToInt(itemBox.Lines[lineNumber]));*/

            itemLevel = ConvertToInt(itemBox.Lines[lineNumber]);


            //runPoeTrade(itemName, itemLevel, shapered, eldered, itemBaseRarity);
            runPoeTrade2(itemName, itemLevel, influenceType, hasInfluence, itemBaseRarity);

        }

        private void AdvancedBaseChecker_Load(object sender, EventArgs e)
        {
            
        }

        private void itemBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkButton.PerformClick();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            itemBox.Clear();
            itemBox.Focus();
        }
    }
}
