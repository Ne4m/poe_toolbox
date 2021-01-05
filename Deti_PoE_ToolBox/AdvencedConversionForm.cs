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
//using System.Globalization;

namespace Deti_PoE_ToolBox
{
    public partial class AdvencedConversionForm : Form
    {

        public AdvencedConversionForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
        }

        DownloadAPIS dlapi = new DownloadAPIS();
        Form1 forma = new Form1();

        public double orbChaosValue;
        public double orbValue_1;
        public double orbValue_2;
        public string getCurrencyName_1;
        public string getCurrencyName_2;
        public double quantity_1;
        public int currencyID;
        public string league = "Standard";

        public PictureBox latestOne;
        public PictureBox latestOne_2;

        public void GetCurrencyPrice(string orbName)
        {

            dlapi.league = league;

            if (orbName.Contains("Breachstone"))
            {
                var stuff2 = JsonConvert.DeserializeObject<JStructure.Currencies>(dlapi.getFragmentsInfo());
                foreach (var c in stuff2.lines)
                {
                    if (c.currencyTypeName == orbName) { orbChaosValue = c.chaosEquivalent; }
                }
            }
            else
            {
                var stuff2 = JsonConvert.DeserializeObject<JStructure.Currencies>(dlapi.getCurrencyInfo());
                foreach (var c in stuff2.lines)
                {
                    if (c.currencyTypeName == orbName) { orbChaosValue = c.chaosEquivalent; }
                }
            }

        }

        public void SetClickedCurrency_1(PictureBox currencyButton, string currencyName)
        {

            try
            {
                latestOne.BackColor = Color.Transparent;
                textBox1.Visible = false;

            }
            catch
            {

            }

            if ((Color)currencyButton.BackColor == Color.Transparent)  // SELECTED
            {
                currencyButton.Tag = Color.Green;
                currencyButton.BackColor = Color.Green;
                getCurrencyName_1 = currencyName;
                GetCurrencyPrice(getCurrencyName_1);
                if (getCurrencyName_1 == "Chaos Orb")
                {
                    orbValue_1 = 1;
                }
                else
                { 
                    orbValue_1 = orbChaosValue;
                }
                textBox1.Visible = true;
                label1.Text = getCurrencyName_1;
                textBox1.Clear();
                textBox1.Focus();

            }
            else  // NOT SELECTED
            {

                /* currencyButton.Tag = Color.Transparent;
                 currencyButton.BackColor = Color.Transparent;
                 textBox2.Text = getCurrencyName_1 + " Un-Selected";*/


            }



        }

        public void SetClickedCurrency_2(PictureBox currencyButton, string currencyName)
        {
            try
            {
                latestOne_2.BackColor = Color.Transparent;
            }
            catch
            {

            }

            if ((Color)currencyButton.BackColor == Color.Transparent)  // SELECTED
            {
                currencyButton.Tag = Color.Green;
                currencyButton.BackColor = Color.Green;
                getCurrencyName_2 = currencyName;
                GetCurrencyPrice(getCurrencyName_2);

                if (getCurrencyName_2 == "Chaos Orb")
                {
                    orbValue_2 = 1;
                }
                else
                {
                    orbValue_2 = orbChaosValue;
                }

                label3.Text = getCurrencyName_2;
            }
            else  // NOT SELECTED
            {

                /* currencyButton.Tag = Color.Transparent;
                 currencyButton.BackColor = Color.Transparent;
                 textBox2.Text = getCurrencyName_1 + " Un-Selected";*/


            }
        }

        #region Poe trade Currency IDS
        public int setCurrencyID(string currencyName)
        {
            if (currencyName == "Orb of Alteration")
            {
                return 1;
            }
            if (currencyName == "Orb of Fusing")
            {
                return 2;
            }
            if (currencyName == "Orb of Alchemy")
            {
                return 3;
            }
            if (currencyName == "Chaos Orb")
            {
                return 4;
            }
            if (currencyName == "Gemcutter's Prism")
            {
                return 5;
            }
            if (currencyName == "Exalted Orb")
            {
                return 6;
            }
            if (currencyName == "Chromatic Orb")
            {
                return 7;
            }
            if (currencyName == "Jeweller's Orb")
            {
                return 8;
            }
            if (currencyName == "Orb of Chance")
            {
                return 9;
            }
            if (currencyName == "Cartographer's Chisel")
            {
                return 10;
            }
            if (currencyName == "Orb of Scouring")
            {
                return 11;
            }
            if (currencyName == "Blessed Orb")
            {
                return 12;
            }
            if (currencyName == "Orb of Regret")
            {
                return 13;
            }
            if (currencyName == "Regal Orb")
            {
                return 14;
            }
            if (currencyName == "Divine Orb")
            {
                return 15;
            }
            if (currencyName == "Vaal Orb")
            {
                return 16;
            }
            if (currencyName == "Scroll of Wisdom")
            {
                return 17;
            }
            if (currencyName == "Portal Scroll")
            {
                return 18;
            }
            if (currencyName == "Armourer's Scrap")
            {
                return 19;
            }
            if (currencyName == "Blacksmith's Whetstone")
            {
                return 20;
            }
            if (currencyName == "Glassblower's Bauble")
            {
                return 21;
            }
            if (currencyName == "Orb of Transmutation")
            {
                return 22;
            }
            if (currencyName == "Orb of Augmentation")
            {
                return 23;
            }
            if (currencyName == "Mirror of Kalandra")
            {
                return 24;
            }
            if (currencyName == "Eternal Orb")
            {
                return 25;
            }
            if (currencyName == "Perandus Coin")
            {
                return 26;
            }
            if (currencyName == "Silver Coin")
            {
                return 27;
            }
            if (currencyName == "Sacrifice at Dusk")
            {
                return 28;
            }
            if (currencyName == "Sacrifice at Midnight")
            {
                return 29;
            }
            if (currencyName == "Sacrifice at Dawn")
            {
                return 30;
            }
            if (currencyName == "Sacrifice at Noon")
            {
                return 31;
            }
            if (currencyName == "Mortal Grief")
            {
                return 32;
            }
            if (currencyName == "Mortal Rage")
            {
                return 33;
            }
            if (currencyName == "Mortal Hope")
            {
                return 34;
            }
            if (currencyName == "Mortal Ignorance")
            {
                return 35;
            }
            if (currencyName == "Eber's Key")
            {
                return 36;
            }
            if (currencyName == "Yriel's Key")
            {
                return 37;
            }
            if (currencyName == "Inya's Key")
            {
                return 38;
            }
            if (currencyName == "Volkuur's Key")
            {
                return 39;
            }
            if (currencyName == "Offering to the Goddess")
            {
                return 40;
            }
            if (currencyName == "Fragment of the Hydra")
            {
                return 41;
            }
            if (currencyName == "Fragment of the Phoenix")
            {
                return 42;
            }
            if (currencyName == "Fragment of the Minotaur")
            {
                return 43;
            }
            if (currencyName == "Fragment of the Chimera")
            {
                return 44;
            }
            if (currencyName == "Apprentice Cartographer's Sextant")
            {
                return 45;
            }
            if (currencyName == "Journeyman Cartographer's Sextant")
            {
                return 46;
            }
            if (currencyName == "Master Cartographer's Sextant")
            {
                return 47;
            }
            if (currencyName == "Sacrifice Set")
            {
                return 48;
            }
            if (currencyName == "Mortal Set")
            {
                return 49;
            }
            if (currencyName == "Pale Court Set")
            {
                return 50;
            }
            if (currencyName == "Shaper Set")
            {
                return 51;
            }
            if (currencyName == "Splinter of Xoph")
            {
                return 52;
            }
            if (currencyName == "Splinter of Tul")
            {
                return 53;
            }
            if (currencyName == "Splinter of Esh")
            {
                return 54;
            }
            if (currencyName == "Splinter of Uul-Netol")
            {
                return 55;
            }
            if (currencyName == "Splinter of Chayula")
            {
                return 56;
            }
            if (currencyName == "Blessing of Xoph")
            {
                return 57;
            }
            if (currencyName == "Blessing of Tul")
            {
                return 58;
            }
            if (currencyName == "Blessing of Esh")
            {
                return 59;
            }
            if (currencyName == "Blessing of Uul-Netol")
            {
                return 60;
            }
            if (currencyName == "Blessing of Chayula")
            {
                return 61;
            }
            if (currencyName == "Xoph's Breachstone")
            {
                return 62;
            }
            if (currencyName == "Tul's Breachstone")
            {
                return 63;
            }
            if (currencyName == "Esh's Breachstone")
            {
                return 64;
            }
            if (currencyName == "Uul-Netol's Breachstone")
            {
                return 65;
            }
            if (currencyName == "Chayula's Breachstone")
            {
                return 66;
            }

            else
                return 0;
            // to be continued with updates
        }
        #endregion

        private void AdvencedConversionForm_Load(object sender, EventArgs e)
        {

        }

        #region Upper Group Box (1) Start Region
   

        private void AlterationButton_1_Click(object sender, EventArgs e)
        {

            SetClickedCurrency_1(AlterationButton_1,"Orb of Alteration");
            latestOne = AlterationButton_1;
        }

        private void FusingButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(FusingButton_1, "Orb of Fusing");
            latestOne = FusingButton_1;
        }

        private void AlchemyButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(AlchemyButton_1, "Orb of Alchemy");
            latestOne = AlchemyButton_1;
        }

        private void ChaosButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ChaosButton_1, "Chaos Orb");
            latestOne = ChaosButton_1;
        }

        private void GemCutterButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(GemCutterButton_1, "Gemcutter's Prism");
            latestOne = GemCutterButton_1;
        }

        private void ExaltedButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ExaltedButton_1, "Exalted Orb");
            latestOne = ExaltedButton_1;
        }

        private void ChromaticButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ChromaticButton_1, "Chromatic Orb");
            latestOne = ChromaticButton_1;
        }

        private void JewellersButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(JewellersButton_1, "Jeweller's Orb");
            latestOne = JewellersButton_1;
        }

        private void ChanceButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ChanceButton_1, "Orb of Chance");
            latestOne = ChanceButton_1;
        }

        private void ChiselButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ChiselButton_1, "Cartographer's Chisel");
            latestOne = ChiselButton_1;
        }

        private void ScouringButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ScouringButton_1, "Orb of Scouring");
            latestOne = ScouringButton_1;
        }

        private void BlessedOrbButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(BlessedOrbButton_1, "Blessed Orb");
            latestOne = BlessedOrbButton_1;
        }

        private void RegretButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(RegretButton_1, "Orb of Regret");
            latestOne = RegretButton_1;
        }

        private void RegalButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(RegalButton_1, "Regal Orb");
            latestOne = RegalButton_1;
        }

        private void DivineButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(DivineButton_1, "Divine Orb");
            latestOne = DivineButton_1;
        }

        private void VaalOrbButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(VaalOrbButton_1, "Vaal Orb");
            latestOne = VaalOrbButton_1;
        }

        private void WisdomButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(WisdomButton_1, "Scroll of Wisdom");
            latestOne = WisdomButton_1;
        }

        private void PortalButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(PortalButton_1, "Portal Scroll");
            latestOne = PortalButton_1;
        }

        private void ArmourersButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ArmourersButton_1, "Armourer's Scrap");
            latestOne = ArmourersButton_1;
        }

        private void BlackSmithButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(BlackSmithButton_1, "Blacksmith's Whetstone");
            latestOne = BlackSmithButton_1;
        }

        private void GlassblowerButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(GlassblowerButton_1, "Glassblower's Bauble");
            latestOne = GlassblowerButton_1;
        }

        private void TransmutationButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(TransmutationButton_1, "Orb of Transmutation");
            latestOne = TransmutationButton_1;
        }

        private void AugmentationButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(AugmentationButton_1, "Orb of Augmentation");
            latestOne = AugmentationButton_1;
        }

        private void MirrorButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(MirrorButton_1, "Mirror of Kalandra");
            latestOne = MirrorButton_1;
        }

        private void PerandusCoinButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(PerandusCoinButton_1, "Perandus Coin");
            latestOne = PerandusCoinButton_1;
        }

        private void SilverCoinButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(SilverCoinButton_1, "Silver Coin");
            latestOne = SilverCoinButton_1;
        }

        private void MasterSextantButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(MasterSextantButton_1, "Master Cartographer's Sextant");
            latestOne = MasterSextantButton_1;
        }

        private void JourneymanSextantButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(JourneymanSextantButton_1, "Journeyman Cartographer's Sextant");
            latestOne = JourneymanSextantButton_1;
        }

        private void ApprenticeSextantButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ApprenticeSextantButton_1, "Apprentice Cartographer's Sextant");
            latestOne = ApprenticeSextantButton_1;
        }

        private void XophSplinterButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(XophSplinterButton_1, "Splinter of Xoph");
            latestOne = XophSplinterButton_1;
        }

        private void TulSplinterButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(TulSplinterButton_1, "Splinter of Tul");
            latestOne = TulSplinterButton_1;
        }

        private void EshSplinterButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(EshSplinterButton_1, "Splinter of Esh");
            latestOne = EshSplinterButton_1;
        }

        private void UulNetolSplinterButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(UulNetolSplinterButton_1, "Splinter of Uul-Netol");
            latestOne = UulNetolSplinterButton_1;
        }

        private void ChayulaSplinter_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ChayulaSplinter_1, "Splinter of Chayula");
            latestOne = ChayulaSplinter_1;
        }

        private void XophButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(XophButton_1, "Xoph's Breachstone");
            latestOne = XophButton_1;
        }

        private void TulButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(TulButton_1, "Tul's Breachstone");
            latestOne = TulButton_1;
        }

        private void EshButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(EshButton_1, "Esh's Breachstone");
            latestOne = EshButton_1;
        }

        private void UulNetolButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(UulNetolButton_1, "Uul-Netol's Breachstone");
            latestOne = UulNetolButton_1;
        }

        private void ChayulaButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ChayulaButton_1, "Chayula's Breachstone");
            latestOne = ChayulaButton_1;
        }

        private void AnnulmentButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(AnnulmentButton_1, "Orb of Annulment");
            latestOne = AnnulmentButton_1;
        }

        private void BindingButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(BindingButton_1, "Orb of Binding");
            latestOne = BindingButton_1;
        }

        private void HorizonOrbButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(HorizonOrbButton_1, "Orb of Horizon");
            latestOne = HorizonOrbButton_1;
        }

        private void HarbingerOrbButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(HarbingerOrbButton_1, "Harbinger's Orb");
            latestOne = HarbingerOrbButton_1;
        }

        private void EngineersOrbButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(EngineersOrbButton_1, "Engineer's Orb");
            latestOne = EngineersOrbButton_1;
        }

        private void AncientOrbButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(AncientOrbButton_1, "Ancient Orb");
            latestOne = AncientOrbButton_1;
        }

        private void AnnulmentShardButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(AnnulmentShardButton_1, "Annulment Shard");
            latestOne = AnnulmentShardButton_1;
        }

        private void ExaltedShard_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(ExaltedShard_1, "Exalted Shard");
            latestOne = ExaltedShard_1;
        }

        private void HarbingerOrbShardButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(HarbingerOrbShardButton_1, "Harbinger's Shard");
            latestOne = HarbingerOrbShardButton_1;
        }

        private void MirrorShardButton_1_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_1(MirrorShardButton_1, "Mirror Shard");
            latestOne = MirrorShardButton_1;
        }


        #endregion

        #region Group Box (2) Start Region
        

        private void AlterationButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(AlterationButton_2, "Orb of Alteration");
            latestOne_2 = AlterationButton_2;
        }

        private void FusingButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(FusingButton_2, "Orb of Fusing");
            latestOne_2 = FusingButton_2;
        }

        private void AlchemyButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(AlchemyButton_2, "Orb of Alchemy");
            latestOne_2 = AlchemyButton_2;
        }

        private void ChaosButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ChaosButton_2, "Chaos Orb");
            latestOne_2 = ChaosButton_2;
        }

        private void GemCutterButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(GemCutterButton_2, "Gemcutter's Prism");
            latestOne_2 = GemCutterButton_2;
        }

        private void ExaltedButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ExaltedButton_2, "Exalted Orb");
            latestOne_2 = ExaltedButton_2;
        }

        private void ChromaticButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ChromaticButton_2, "Chromatic Orb");
            latestOne_2 = ChromaticButton_2;
        }

        private void JewellersButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(JewellersButton_2, "Jeweller's Orb");
            latestOne_2 = JewellersButton_2;
        }

        private void ChanceButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ChanceButton_2, "Orb of Chance");
            latestOne_2 = ChanceButton_2;
        }

        private void ChiselButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ChiselButton_2, "Cartographer's Chisel");
            latestOne_2 = ChiselButton_2;
        }


        private void ScouringButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ScouringButton_2, "Orb of Scouring");
            latestOne_2 = ScouringButton_2;
        }

        private void BlessedOrbButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(BlessedOrbButton_2, "Blessed Orb");
            latestOne_2 = BlessedOrbButton_2;
        }

        private void RegretButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(RegretButton_2, "Orb of Regret");
            latestOne_2 = RegretButton_2;
        }

        private void RegalButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(RegalButton_2, "Regal Orb");
            latestOne_2 = RegalButton_2;
        }

        private void DivineButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(DivineButton_2, "Divine Orb");
            latestOne_2 = DivineButton_2;
        }

        private void VaalOrbButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(VaalOrbButton_2, "Vaal Orb");
            latestOne_2 = VaalOrbButton_2;
        }

        private void WisdomButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(WisdomButton_2, "Scroll of Wisdom");
            latestOne_2 = WisdomButton_2;
        }

        private void PortalButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(PortalButton_2, "Portal Scroll");
            latestOne_2 = PortalButton_2;
        }

        private void ArmourersButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ArmourersButton_2, "Armourer's Scrap");
            latestOne_2 = ArmourersButton_2;
        }

        private void BlackSmithButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(BlackSmithButton_2, "Blacksmith's Whetstone");
            latestOne_2 = BlackSmithButton_2;
        }

        private void GlassblowerButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(GlassblowerButton_2, "Glassblower's Bauble");
            latestOne_2 = GlassblowerButton_2;
        }

        private void TransmutationButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(TransmutationButton_2, "Orb of Transmutation");
            latestOne_2 = TransmutationButton_2;
        }

        private void AugmentationButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(AugmentationButton_2, "Orb of Augmentation");
            latestOne_2 = AugmentationButton_2;
        }

        private void MirrorButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(MirrorButton_2, "Mirror of Kalandra");
            latestOne_2 = MirrorButton_2;
        }

        private void PerandusCoinButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(PerandusCoinButton_2, "Perandus Coin");
            latestOne_2 = PerandusCoinButton_2;
        }

        private void SilverCoinButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(SilverCoinButton_2, "Silver Coin");
            latestOne_2 = SilverCoinButton_2;
        }

        private void MasterSextantButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(MasterSextantButton_2, "Master Cartographer's Sextant");
            latestOne_2 = MasterSextantButton_2;
        }

        private void JourneymanSextantButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(JourneymanSextantButton_2, "Journeyman Cartographer's Sextant");
            latestOne_2 = JourneymanSextantButton_2;
        }

        private void ApprenticeSextantButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ApprenticeSextantButton_2, "Apprentice Cartographer's Sextant");
            latestOne_2 = ApprenticeSextantButton_2;
        }

        private void XophSplinterButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(XophSplinterButton_2, "Splinter of Xoph");
            latestOne_2 = XophSplinterButton_2;
        }

        private void TulSplinterButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(TulSplinterButton_2, "Splinter of Tul");
            latestOne_2 = TulSplinterButton_2;
        }

        private void EshSplinterButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(EshSplinterButton_2, "Splinter of Esh");
            latestOne_2 = EshSplinterButton_2;
        }

        private void UulNetolSplinterButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(UulNetolSplinterButton_2, "Splinter of Uul-Netol");
            latestOne_2 = UulNetolSplinterButton_2;
        }

        private void ChayulaSplinter_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ChayulaSplinter_2, "Splinter of Chayula");
            latestOne_2 = ChayulaSplinter_2;
        }

        private void XophButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(XophButton_2, "Xoph's Breachstone");
            latestOne_2 = XophButton_2;
        }

        private void TulButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(TulButton_2, "Tul's Breachstone");
            latestOne_2 = TulButton_2;
        }

        private void EshButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(EshButton_2, "Esh's Breachstone");
            latestOne_2 = EshButton_2;
        }

        private void UulNetolButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(UulNetolButton_2, "Uul-Netol's Breachstone");
            latestOne_2 = UulNetolButton_2;
        }

        private void ChayulaButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ChayulaButton_2, "Chayula's Breachstone");
            latestOne_2 = ChayulaButton_2;
        }

        private void AnnulmentButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(AnnulmentButton_2, "Orb of Annulment");
            latestOne_2 = AnnulmentButton_2;
        }

        private void BindingButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(BindingButton_2, "Orb of Binding");
            latestOne_2 = BindingButton_2;
        }

        private void HorizonOrbButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(HorizonOrbButton_2, "Orb of Horizon");
            latestOne_2 = HorizonOrbButton_2;
        }

        private void HarbingerOrbButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(HarbingerOrbButton_2, "Harbinger's Orb");
            latestOne_2 = HarbingerOrbButton_2;
        }

        private void EngineersOrbButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(EngineersOrbButton_2, "Engineer's Orb");
            latestOne_2 = EngineersOrbButton_2;
        }

        private void AncientOrbButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(AncientOrbButton_2, "Ancient Orb");
            latestOne_2 = AncientOrbButton_2;
        }

        private void AnnulmentShardButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(AnnulmentShardButton_2, "Annulment Shard");
            latestOne_2 = AnnulmentShardButton_2;
        }

        private void ExaltedShard_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(ExaltedShard_2, "Exalted Shard");
            latestOne_2 = ExaltedShard_2;
        }

        private void HarbingerOrbShardButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(HarbingerOrbShardButton_2, "Harbinger's Shard");
            latestOne_2 = HarbingerOrbShardButton_2;
        }

        private void MirrorShardButton_2_Click(object sender, EventArgs e)
        {
            SetClickedCurrency_2(MirrorShardButton_2, "Mirror Shard");
            latestOne_2 = MirrorShardButton_2;
        }
        #endregion

        private void testButton_Click(object sender, EventArgs e)
        {
            test2.Enabled = true;

            if (textBox1.Text == String.Empty)
            {
                quantity_1 = 1;
            }
            else
            {
                quantity_1 = Double.Parse(textBox1.Text);
            }
            

            label1.Text = getCurrencyName_1;
            label3.Text = String.Format("{0:0.0}",(quantity_1 * orbValue_1) / (orbValue_2)) + " " + getCurrencyName_2;
        }

        private void test2_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32((quantity_1 * orbValue_1) / (orbValue_2));

            //http://currency.poe.trade/search?league=Betrayal&online=x&stock=&want=3&have=4

            /* DialogResult dr = MessageBox.Show("Check for specific stock? Might not find results","Mood Test", MessageBoxButtons.YesNo);
             switch (dr)
             {
                 case DialogResult.Yes:
                     System.Diagnostics.Process.Start("http://currency.poe.trade/search?league=Betrayal&online=x&" + "&stock=" + stock + "&want=" + setCurrencyID(getCurrencyName_2) + "&have=" + setCurrencyID(getCurrencyName_1));

                     break;
                 case DialogResult.No:
                     System.Diagnostics.Process.Start("http://currency.poe.trade/search?league=Betrayal&online=x&" + "&want=" + setCurrencyID(getCurrencyName_2) + "&have=" + setCurrencyID(getCurrencyName_1));

                     break;
             }*/

            System.Diagnostics.Process.Start("http://currency.poe.trade/search?league=" + league + "&online=x&" + "&want=" + setCurrencyID(getCurrencyName_2) + "&have=" + setCurrencyID(getCurrencyName_1));


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdvencedConversionForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            e.Cancel = true;
            
        }
    }


}
