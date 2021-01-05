using System;

namespace Deti_PoE_ToolBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.getCurrency = new System.Windows.Forms.Button();
            this.getAccessory = new System.Windows.Forms.Button();
            this.getSize = new System.Windows.Forms.Button();
            this.accessoryArray = new System.Windows.Forms.Button();
            this.currencyArray = new System.Windows.Forms.Button();
            this.fossilsArray = new System.Windows.Forms.Button();
            this.mapsArray = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.divcardAnalyzer_bttn = new System.Windows.Forms.Button();
            this.deliriumOrbArray = new System.Windows.Forms.Button();
            this.oilsTypesArray = new System.Windows.Forms.Button();
            this.incubatorsArray = new System.Windows.Forms.Button();
            this.leagueBox = new System.Windows.Forms.ComboBox();
            this.chooseLeagueLabel = new System.Windows.Forms.Label();
            this.uniqueBeastsArray = new System.Windows.Forms.Button();
            this.beastsArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemLevelPriceCheckButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.weaponsArray = new System.Windows.Forms.Button();
            this.armoursArray = new System.Windows.Forms.Button();
            this.flasksArray = new System.Windows.Forms.Button();
            this.jewelsArray = new System.Windows.Forms.Button();
            this.uniqueMapsArray = new System.Windows.Forms.Button();
            this.helmEnchantsArray = new System.Windows.Forms.Button();
            this.scarabsTypesArray = new System.Windows.Forms.Button();
            this.gemsArray = new System.Windows.Forms.Button();
            this.propheciesArray = new System.Windows.Forms.Button();
            this.cardsArray = new System.Windows.Forms.Button();
            this.essencesArray = new System.Windows.Forms.Button();
            this.resonatorsArray = new System.Windows.Forms.Button();
            this.fragmentsArray = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currencyList1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.list2QuantityBox = new System.Windows.Forms.TextBox();
            this.currencyList2 = new System.Windows.Forms.ComboBox();
            this.list1QuantityBox = new System.Windows.Forms.TextBox();
            this.currencyResultBox = new System.Windows.Forms.TextBox();
            this.seedsArray = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox1.Location = new System.Drawing.Point(15, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(668, 197);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // getCurrency
            // 
            this.getCurrency.Enabled = false;
            this.getCurrency.Location = new System.Drawing.Point(1042, 312);
            this.getCurrency.Name = "getCurrency";
            this.getCurrency.Size = new System.Drawing.Size(75, 23);
            this.getCurrency.TabIndex = 1;
            this.getCurrency.Text = "Currency";
            this.getCurrency.UseVisualStyleBackColor = true;
            this.getCurrency.Visible = false;
            this.getCurrency.Click += new System.EventHandler(this.getCurrency_Click);
            // 
            // getAccessory
            // 
            this.getAccessory.Enabled = false;
            this.getAccessory.Location = new System.Drawing.Point(1025, 357);
            this.getAccessory.Name = "getAccessory";
            this.getAccessory.Size = new System.Drawing.Size(75, 23);
            this.getAccessory.TabIndex = 2;
            this.getAccessory.Text = "Accessory";
            this.getAccessory.UseVisualStyleBackColor = true;
            this.getAccessory.Visible = false;
            this.getAccessory.Click += new System.EventHandler(this.getAccessory_Click);
            // 
            // getSize
            // 
            this.getSize.Location = new System.Drawing.Point(1012, 181);
            this.getSize.Name = "getSize";
            this.getSize.Size = new System.Drawing.Size(75, 23);
            this.getSize.TabIndex = 3;
            this.getSize.Text = "Size";
            this.getSize.UseVisualStyleBackColor = true;
            this.getSize.Visible = false;
            this.getSize.Click += new System.EventHandler(this.getSize_Click);
            // 
            // accessoryArray
            // 
            this.accessoryArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accessoryArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.accessoryArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.accessoryArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.accessoryArray.Location = new System.Drawing.Point(806, 245);
            this.accessoryArray.Name = "accessoryArray";
            this.accessoryArray.Size = new System.Drawing.Size(108, 23);
            this.accessoryArray.TabIndex = 6;
            this.accessoryArray.TabStop = false;
            this.accessoryArray.Text = "Accessory";
            this.accessoryArray.UseVisualStyleBackColor = false;
            this.accessoryArray.Click += new System.EventHandler(this.accessoryArray_Click);
            // 
            // currencyArray
            // 
            this.currencyArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currencyArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.currencyArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.currencyArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.currencyArray.Location = new System.Drawing.Point(688, 45);
            this.currencyArray.Name = "currencyArray";
            this.currencyArray.Size = new System.Drawing.Size(108, 23);
            this.currencyArray.TabIndex = 7;
            this.currencyArray.Text = "Currency";
            this.currencyArray.UseVisualStyleBackColor = false;
            this.currencyArray.Click += new System.EventHandler(this.currencyArray_Click);
            // 
            // fossilsArray
            // 
            this.fossilsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fossilsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.fossilsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.fossilsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.fossilsArray.Location = new System.Drawing.Point(689, 195);
            this.fossilsArray.Name = "fossilsArray";
            this.fossilsArray.Size = new System.Drawing.Size(108, 23);
            this.fossilsArray.TabIndex = 9;
            this.fossilsArray.Text = "Fossils";
            this.fossilsArray.UseVisualStyleBackColor = false;
            this.fossilsArray.Click += new System.EventHandler(this.fossilsArray_Click);
            // 
            // mapsArray
            // 
            this.mapsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mapsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.mapsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.mapsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.mapsArray.Location = new System.Drawing.Point(806, 145);
            this.mapsArray.Name = "mapsArray";
            this.mapsArray.Size = new System.Drawing.Size(108, 23);
            this.mapsArray.TabIndex = 10;
            this.mapsArray.Text = "Maps";
            this.mapsArray.UseVisualStyleBackColor = false;
            this.mapsArray.Click += new System.EventHandler(this.mapsArray_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.seedsArray);
            this.groupBox1.Controls.Add(this.divcardAnalyzer_bttn);
            this.groupBox1.Controls.Add(this.deliriumOrbArray);
            this.groupBox1.Controls.Add(this.oilsTypesArray);
            this.groupBox1.Controls.Add(this.incubatorsArray);
            this.groupBox1.Controls.Add(this.leagueBox);
            this.groupBox1.Controls.Add(this.chooseLeagueLabel);
            this.groupBox1.Controls.Add(this.uniqueBeastsArray);
            this.groupBox1.Controls.Add(this.beastsArray);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemLevelPriceCheckButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.searchLbl);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.weaponsArray);
            this.groupBox1.Controls.Add(this.armoursArray);
            this.groupBox1.Controls.Add(this.flasksArray);
            this.groupBox1.Controls.Add(this.jewelsArray);
            this.groupBox1.Controls.Add(this.uniqueMapsArray);
            this.groupBox1.Controls.Add(this.helmEnchantsArray);
            this.groupBox1.Controls.Add(this.scarabsTypesArray);
            this.groupBox1.Controls.Add(this.gemsArray);
            this.groupBox1.Controls.Add(this.propheciesArray);
            this.groupBox1.Controls.Add(this.cardsArray);
            this.groupBox1.Controls.Add(this.essencesArray);
            this.groupBox1.Controls.Add(this.resonatorsArray);
            this.groupBox1.Controls.Add(this.fragmentsArray);
            this.groupBox1.Controls.Add(this.testBox);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.accessoryArray);
            this.groupBox1.Controls.Add(this.currencyArray);
            this.groupBox1.Controls.Add(this.fossilsArray);
            this.groupBox1.Controls.Add(this.mapsArray);
            this.groupBox1.Location = new System.Drawing.Point(0, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 644);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragEnter);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // divcardAnalyzer_bttn
            // 
            this.divcardAnalyzer_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.divcardAnalyzer_bttn.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.divcardAnalyzer_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.divcardAnalyzer_bttn.Location = new System.Drawing.Point(689, 476);
            this.divcardAnalyzer_bttn.Name = "divcardAnalyzer_bttn";
            this.divcardAnalyzer_bttn.Size = new System.Drawing.Size(227, 70);
            this.divcardAnalyzer_bttn.TabIndex = 47;
            this.divcardAnalyzer_bttn.Text = "Div Card Analyzer";
            this.divcardAnalyzer_bttn.UseVisualStyleBackColor = false;
            this.divcardAnalyzer_bttn.Click += new System.EventHandler(this.divcardAnalyzer_bttn_Click);
            // 
            // deliriumOrbArray
            // 
            this.deliriumOrbArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deliriumOrbArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.deliriumOrbArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.deliriumOrbArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.deliriumOrbArray.Location = new System.Drawing.Point(688, 70);
            this.deliriumOrbArray.Name = "deliriumOrbArray";
            this.deliriumOrbArray.Size = new System.Drawing.Size(108, 23);
            this.deliriumOrbArray.TabIndex = 46;
            this.deliriumOrbArray.Text = "Delirium Orbs";
            this.deliriumOrbArray.UseVisualStyleBackColor = false;
            this.deliriumOrbArray.Click += new System.EventHandler(this.deliriumOrbArray_Click);
            // 
            // oilsTypesArray
            // 
            this.oilsTypesArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oilsTypesArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.oilsTypesArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.oilsTypesArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.oilsTypesArray.Location = new System.Drawing.Point(689, 120);
            this.oilsTypesArray.Name = "oilsTypesArray";
            this.oilsTypesArray.Size = new System.Drawing.Size(108, 23);
            this.oilsTypesArray.TabIndex = 45;
            this.oilsTypesArray.Text = "Oils";
            this.oilsTypesArray.UseVisualStyleBackColor = false;
            this.oilsTypesArray.Click += new System.EventHandler(this.oilsTypesArray_Click);
            // 
            // incubatorsArray
            // 
            this.incubatorsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incubatorsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.incubatorsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.incubatorsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.incubatorsArray.Location = new System.Drawing.Point(689, 145);
            this.incubatorsArray.Name = "incubatorsArray";
            this.incubatorsArray.Size = new System.Drawing.Size(108, 23);
            this.incubatorsArray.TabIndex = 44;
            this.incubatorsArray.Text = "Incubators";
            this.incubatorsArray.UseVisualStyleBackColor = false;
            this.incubatorsArray.Click += new System.EventHandler(this.incubatorsArray_Click);
            // 
            // leagueBox
            // 
            this.leagueBox.FormattingEnabled = true;
            this.leagueBox.Location = new System.Drawing.Point(681, 17);
            this.leagueBox.Name = "leagueBox";
            this.leagueBox.Size = new System.Drawing.Size(121, 21);
            this.leagueBox.TabIndex = 43;
            this.leagueBox.SelectedIndexChanged += new System.EventHandler(this.leagueBox_SelectedIndexChanged);
            // 
            // chooseLeagueLabel
            // 
            this.chooseLeagueLabel.AutoSize = true;
            this.chooseLeagueLabel.ForeColor = System.Drawing.Color.Black;
            this.chooseLeagueLabel.Location = new System.Drawing.Point(597, 20);
            this.chooseLeagueLabel.Name = "chooseLeagueLabel";
            this.chooseLeagueLabel.Size = new System.Drawing.Size(82, 13);
            this.chooseLeagueLabel.TabIndex = 42;
            this.chooseLeagueLabel.Text = "Choose League";
            // 
            // uniqueBeastsArray
            // 
            this.uniqueBeastsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uniqueBeastsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.uniqueBeastsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.uniqueBeastsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.uniqueBeastsArray.Location = new System.Drawing.Point(806, 295);
            this.uniqueBeastsArray.Name = "uniqueBeastsArray";
            this.uniqueBeastsArray.Size = new System.Drawing.Size(108, 23);
            this.uniqueBeastsArray.TabIndex = 41;
            this.uniqueBeastsArray.Text = "Unique Beasts";
            this.uniqueBeastsArray.UseVisualStyleBackColor = false;
            this.uniqueBeastsArray.Visible = false;
            this.uniqueBeastsArray.Click += new System.EventHandler(this.uniqueBeastsArray_Click);
            // 
            // beastsArray
            // 
            this.beastsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.beastsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.beastsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.beastsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.beastsArray.Location = new System.Drawing.Point(806, 270);
            this.beastsArray.Name = "beastsArray";
            this.beastsArray.Size = new System.Drawing.Size(108, 23);
            this.beastsArray.TabIndex = 40;
            this.beastsArray.Text = "Beasts";
            this.beastsArray.UseVisualStyleBackColor = false;
            this.beastsArray.Click += new System.EventHandler(this.beastsArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(682, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Deti Poe ToolBox v0.81";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemLevelPriceCheckButton
            // 
            this.itemLevelPriceCheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.itemLevelPriceCheckButton.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.itemLevelPriceCheckButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.itemLevelPriceCheckButton.Location = new System.Drawing.Point(689, 400);
            this.itemLevelPriceCheckButton.Name = "itemLevelPriceCheckButton";
            this.itemLevelPriceCheckButton.Size = new System.Drawing.Size(227, 70);
            this.itemLevelPriceCheckButton.TabIndex = 38;
            this.itemLevelPriceCheckButton.Text = "Item Level Price Checker";
            this.itemLevelPriceCheckButton.UseVisualStyleBackColor = false;
            this.itemLevelPriceCheckButton.Click += new System.EventHandler(this.itemLevelPriceCheckButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.button1.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.button1.Location = new System.Drawing.Point(689, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 70);
            this.button1.TabIndex = 32;
            this.button1.Text = "Advanced Currency Conversion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.ForeColor = System.Drawing.Color.Black;
            this.searchLbl.Location = new System.Drawing.Point(12, 22);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(41, 13);
            this.searchLbl.TabIndex = 37;
            this.searchLbl.Text = "Search";
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 501);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chaos Value";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Exalted Value";
            this.columnHeader3.Width = 80;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(59, 19);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(324, 20);
            this.txt_Search.TabIndex = 33;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // weaponsArray
            // 
            this.weaponsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.weaponsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.weaponsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.weaponsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.weaponsArray.Location = new System.Drawing.Point(806, 220);
            this.weaponsArray.Name = "weaponsArray";
            this.weaponsArray.Size = new System.Drawing.Size(108, 23);
            this.weaponsArray.TabIndex = 24;
            this.weaponsArray.Text = "Unique Weapons";
            this.weaponsArray.UseVisualStyleBackColor = false;
            this.weaponsArray.Click += new System.EventHandler(this.weaponsArray_Click);
            // 
            // armoursArray
            // 
            this.armoursArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.armoursArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.armoursArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.armoursArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.armoursArray.Location = new System.Drawing.Point(806, 95);
            this.armoursArray.Name = "armoursArray";
            this.armoursArray.Size = new System.Drawing.Size(108, 23);
            this.armoursArray.TabIndex = 23;
            this.armoursArray.Text = "Unique Armours";
            this.armoursArray.UseVisualStyleBackColor = false;
            this.armoursArray.Click += new System.EventHandler(this.armoursArray_Click);
            // 
            // flasksArray
            // 
            this.flasksArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flasksArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.flasksArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.flasksArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.flasksArray.Location = new System.Drawing.Point(806, 195);
            this.flasksArray.Name = "flasksArray";
            this.flasksArray.Size = new System.Drawing.Size(108, 23);
            this.flasksArray.TabIndex = 22;
            this.flasksArray.Text = "Unique Flasks";
            this.flasksArray.UseVisualStyleBackColor = false;
            this.flasksArray.Click += new System.EventHandler(this.flasksArray_Click);
            // 
            // jewelsArray
            // 
            this.jewelsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jewelsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.jewelsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.jewelsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.jewelsArray.Location = new System.Drawing.Point(806, 170);
            this.jewelsArray.Name = "jewelsArray";
            this.jewelsArray.Size = new System.Drawing.Size(108, 23);
            this.jewelsArray.TabIndex = 21;
            this.jewelsArray.Text = "Unique Jewels";
            this.jewelsArray.UseVisualStyleBackColor = false;
            this.jewelsArray.Click += new System.EventHandler(this.jewelsArray_Click);
            // 
            // uniqueMapsArray
            // 
            this.uniqueMapsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uniqueMapsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.uniqueMapsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.uniqueMapsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.uniqueMapsArray.Location = new System.Drawing.Point(806, 120);
            this.uniqueMapsArray.Name = "uniqueMapsArray";
            this.uniqueMapsArray.Size = new System.Drawing.Size(108, 23);
            this.uniqueMapsArray.TabIndex = 20;
            this.uniqueMapsArray.Text = "Unique Maps";
            this.uniqueMapsArray.UseVisualStyleBackColor = false;
            this.uniqueMapsArray.Click += new System.EventHandler(this.uniqueMapsArray_Click);
            // 
            // helmEnchantsArray
            // 
            this.helmEnchantsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helmEnchantsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.helmEnchantsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.helmEnchantsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.helmEnchantsArray.Location = new System.Drawing.Point(689, 95);
            this.helmEnchantsArray.Name = "helmEnchantsArray";
            this.helmEnchantsArray.Size = new System.Drawing.Size(108, 23);
            this.helmEnchantsArray.TabIndex = 19;
            this.helmEnchantsArray.Text = "Helm Enchants";
            this.helmEnchantsArray.UseVisualStyleBackColor = false;
            this.helmEnchantsArray.Click += new System.EventHandler(this.helmEnchantsArray_Click);
            // 
            // scarabsTypesArray
            // 
            this.scarabsTypesArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scarabsTypesArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.scarabsTypesArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.scarabsTypesArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.scarabsTypesArray.Location = new System.Drawing.Point(689, 170);
            this.scarabsTypesArray.Name = "scarabsTypesArray";
            this.scarabsTypesArray.Size = new System.Drawing.Size(108, 23);
            this.scarabsTypesArray.TabIndex = 18;
            this.scarabsTypesArray.Text = "Scarabs";
            this.scarabsTypesArray.UseVisualStyleBackColor = false;
            this.scarabsTypesArray.Click += new System.EventHandler(this.scarabsTypesArray_Click);
            // 
            // gemsArray
            // 
            this.gemsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gemsArray.Location = new System.Drawing.Point(806, 94);
            this.gemsArray.Name = "gemsArray";
            this.gemsArray.Size = new System.Drawing.Size(107, 23);
            this.gemsArray.TabIndex = 17;
            this.gemsArray.Text = "Gems";
            this.gemsArray.UseVisualStyleBackColor = true;
            this.gemsArray.Click += new System.EventHandler(this.gemsArray_Click);
            // 
            // propheciesArray
            // 
            this.propheciesArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.propheciesArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.propheciesArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.propheciesArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.propheciesArray.Location = new System.Drawing.Point(689, 295);
            this.propheciesArray.Name = "propheciesArray";
            this.propheciesArray.Size = new System.Drawing.Size(108, 23);
            this.propheciesArray.TabIndex = 16;
            this.propheciesArray.Text = "Prophecies";
            this.propheciesArray.UseVisualStyleBackColor = false;
            this.propheciesArray.Click += new System.EventHandler(this.propheciesArray_Click);
            // 
            // cardsArray
            // 
            this.cardsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cardsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.cardsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.cardsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.cardsArray.Location = new System.Drawing.Point(689, 270);
            this.cardsArray.Name = "cardsArray";
            this.cardsArray.Size = new System.Drawing.Size(108, 23);
            this.cardsArray.TabIndex = 15;
            this.cardsArray.Text = "Div. Cards";
            this.cardsArray.UseVisualStyleBackColor = false;
            this.cardsArray.Click += new System.EventHandler(this.cardsArray_Click);
            // 
            // essencesArray
            // 
            this.essencesArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.essencesArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.essencesArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.essencesArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.essencesArray.Location = new System.Drawing.Point(688, 245);
            this.essencesArray.Name = "essencesArray";
            this.essencesArray.Size = new System.Drawing.Size(108, 23);
            this.essencesArray.TabIndex = 14;
            this.essencesArray.Text = "Essences";
            this.essencesArray.UseVisualStyleBackColor = false;
            this.essencesArray.Click += new System.EventHandler(this.essencesArray_Click);
            // 
            // resonatorsArray
            // 
            this.resonatorsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resonatorsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.resonatorsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.resonatorsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.resonatorsArray.Location = new System.Drawing.Point(689, 220);
            this.resonatorsArray.Name = "resonatorsArray";
            this.resonatorsArray.Size = new System.Drawing.Size(108, 23);
            this.resonatorsArray.TabIndex = 13;
            this.resonatorsArray.Text = "Resonators";
            this.resonatorsArray.UseVisualStyleBackColor = false;
            this.resonatorsArray.Click += new System.EventHandler(this.resonatorsArray_Click);
            // 
            // fragmentsArray
            // 
            this.fragmentsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fragmentsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.fragmentsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.fragmentsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.fragmentsArray.Location = new System.Drawing.Point(806, 70);
            this.fragmentsArray.Name = "fragmentsArray";
            this.fragmentsArray.Size = new System.Drawing.Size(108, 23);
            this.fragmentsArray.TabIndex = 12;
            this.fragmentsArray.Text = "Fragments";
            this.fragmentsArray.UseVisualStyleBackColor = false;
            this.fragmentsArray.Click += new System.EventHandler(this.fragmentsArray_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(400, 56);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(282, 197);
            this.testBox.TabIndex = 11;
            this.testBox.Text = "";
            this.testBox.Visible = false;
            // 
            // listView2
            // 
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(834, 223);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(308, 382);
            this.listView2.TabIndex = 36;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.currencyList1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.testButton);
            this.groupBox2.Controls.Add(this.list2QuantityBox);
            this.groupBox2.Controls.Add(this.currencyList2);
            this.groupBox2.Controls.Add(this.list1QuantityBox);
            this.groupBox2.Controls.Add(this.currencyResultBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(738, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 168);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversion Software Version 7.0";
            this.groupBox2.Visible = false;
            // 
            // currencyList1
            // 
            this.currencyList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currencyList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyList1.FormattingEnabled = true;
            this.currencyList1.Items.AddRange(new object[] {
            "Mirror of Kalandra",
            "Mirror Shard",
            "Blessing of Chayula",
            "Exalted Orb",
            "Chaos Orb",
            "Ancient Orb",
            "Harbinger\'s Orb",
            "Divine Orb",
            "Orb of Annulment",
            "Blessing of Esh",
            "Exalted Shard",
            "Blessing of Uul-Netol",
            "Master Cartographer\'s Sextant",
            "Blessing of Xoph",
            "Journeyman Cartographer\'s Sextant",
            "Blessing of Tul",
            "Engineer\'s Orb",
            "Vaal Orb",
            "Splinter of Chayula",
            "Apprentice Cartographer\'s Sextant",
            "Orb of Horizons",
            "Annulment Shard",
            "Gemcutter\'s Prism",
            "Orb of Regret",
            "Orb of Alchemy",
            "Regal Orb",
            "Splinter of Xoph",
            "Orb of Binding",
            "Cartographer\'s Chisel",
            "Orb of Scouring",
            "Orb of Fusing",
            "Silver Coin",
            "Perandus Coin",
            "Blessed Orb",
            "Glassblower\'s Bauble",
            "Orb of Chance",
            "Splinter of Esh",
            "Splinter of Uul-Netol",
            "Chromatic Orb",
            "Orb of Alteration",
            "Jeweller\'s Orb",
            "Splinter of Tul",
            "Orb of Augmentation",
            "Blacksmith\'s Whetstone",
            "Armourer\'s Scrap",
            "Orb of Transmutation",
            "Portal Scroll"});
            this.currencyList1.Location = new System.Drawing.Point(37, 31);
            this.currencyList1.Name = "currencyList1";
            this.currencyList1.Size = new System.Drawing.Size(98, 21);
            this.currencyList1.TabIndex = 26;
            this.currencyList1.SelectedIndexChanged += new System.EventHandler(this.currencyList1_SelectedIndexChanged);
            this.currencyList1.TextChanged += new System.EventHandler(this.currencyList1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "------>";
            // 
            // testButton
            // 
            this.testButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testButton.Location = new System.Drawing.Point(97, 110);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(100, 23);
            this.testButton.TabIndex = 25;
            this.testButton.Text = "Convert";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // list2QuantityBox
            // 
            this.list2QuantityBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.list2QuantityBox.BackColor = System.Drawing.Color.Lime;
            this.list2QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list2QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list2QuantityBox.ForeColor = System.Drawing.Color.Black;
            this.list2QuantityBox.Location = new System.Drawing.Point(109, 84);
            this.list2QuantityBox.Name = "list2QuantityBox";
            this.list2QuantityBox.ReadOnly = true;
            this.list2QuantityBox.Size = new System.Drawing.Size(77, 20);
            this.list2QuantityBox.TabIndex = 30;
            this.list2QuantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list2QuantityBox.TextChanged += new System.EventHandler(this.list2QuantityBox_TextChanged);
            // 
            // currencyList2
            // 
            this.currencyList2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currencyList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyList2.FormattingEnabled = true;
            this.currencyList2.Items.AddRange(new object[] {
            "Mirror of Kalandra",
            "Mirror Shard",
            "Blessing of Chayula",
            "Exalted Orb",
            "Chaos Orb",
            "Ancient Orb",
            "Harbinger\'s Orb",
            "Divine Orb",
            "Orb of Annulment",
            "Blessing of Esh",
            "Exalted Shard",
            "Blessing of Uul-Netol",
            "Master Cartographer\'s Sextant",
            "Blessing of Xoph",
            "Journeyman Cartographer\'s Sextant",
            "Blessing of Tul",
            "Engineer\'s Orb",
            "Vaal Orb",
            "Splinter of Chayula",
            "Apprentice Cartographer\'s Sextant",
            "Orb of Horizons",
            "Annulment Shard",
            "Gemcutter\'s Prism",
            "Orb of Regret",
            "Orb of Alchemy",
            "Regal Orb",
            "Splinter of Xoph",
            "Orb of Binding",
            "Cartographer\'s Chisel",
            "Orb of Scouring",
            "Orb of Fusing",
            "Silver Coin",
            "Perandus Coin",
            "Blessed Orb",
            "Glassblower\'s Bauble",
            "Orb of Chance",
            "Splinter of Esh",
            "Splinter of Uul-Netol",
            "Chromatic Orb",
            "Orb of Alteration",
            "Jeweller\'s Orb",
            "Splinter of Tul",
            "Orb of Augmentation",
            "Blacksmith\'s Whetstone",
            "Armourer\'s Scrap",
            "Orb of Transmutation",
            "Portal Scroll"});
            this.currencyList2.Location = new System.Drawing.Point(164, 31);
            this.currencyList2.Name = "currencyList2";
            this.currencyList2.Size = new System.Drawing.Size(98, 21);
            this.currencyList2.TabIndex = 27;
            this.currencyList2.SelectedIndexChanged += new System.EventHandler(this.currencyList2_SelectedIndexChanged);
            // 
            // list1QuantityBox
            // 
            this.list1QuantityBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.list1QuantityBox.Location = new System.Drawing.Point(72, 58);
            this.list1QuantityBox.Name = "list1QuantityBox";
            this.list1QuantityBox.Size = new System.Drawing.Size(34, 20);
            this.list1QuantityBox.TabIndex = 29;
            this.list1QuantityBox.TextChanged += new System.EventHandler(this.list1QuantityBox_TextChanged);
            // 
            // currencyResultBox
            // 
            this.currencyResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currencyResultBox.Location = new System.Drawing.Point(193, 58);
            this.currencyResultBox.Name = "currencyResultBox";
            this.currencyResultBox.Size = new System.Drawing.Size(34, 20);
            this.currencyResultBox.TabIndex = 28;
            // 
            // seedsArray
            // 
            this.seedsArray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.seedsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(44)))), ((int)(((byte)(23)))));
            this.seedsArray.Font = new System.Drawing.Font("Fontin", 9F, System.Drawing.FontStyle.Bold);
            this.seedsArray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(170)))), ((int)(((byte)(104)))));
            this.seedsArray.Location = new System.Drawing.Point(806, 45);
            this.seedsArray.Name = "seedsArray";
            this.seedsArray.Size = new System.Drawing.Size(108, 23);
            this.seedsArray.TabIndex = 48;
            this.seedsArray.Text = "Seeds";
            this.seedsArray.UseVisualStyleBackColor = false;
            this.seedsArray.Click += new System.EventHandler(this.seedsArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.getSize);
            this.Controls.Add(this.getAccessory);
            this.Controls.Add(this.getCurrency);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deti Poe ToolBox 0.81 League: Delirium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button getCurrency;
        private System.Windows.Forms.Button getAccessory;
        private System.Windows.Forms.Button getSize;
        private System.Windows.Forms.Button accessoryArray;
        private System.Windows.Forms.Button currencyArray;
        private System.Windows.Forms.Button fossilsArray;
        private System.Windows.Forms.Button mapsArray;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox testBox;
        private System.Windows.Forms.Button helmEnchantsArray;
        private System.Windows.Forms.Button scarabsTypesArray;
        private System.Windows.Forms.Button gemsArray;
        private System.Windows.Forms.Button propheciesArray;
        private System.Windows.Forms.Button cardsArray;
        private System.Windows.Forms.Button essencesArray;
        private System.Windows.Forms.Button resonatorsArray;
        private System.Windows.Forms.Button fragmentsArray;
        private System.Windows.Forms.Button weaponsArray;
        private System.Windows.Forms.Button armoursArray;
        private System.Windows.Forms.Button flasksArray;
        private System.Windows.Forms.Button jewelsArray;
        private System.Windows.Forms.Button uniqueMapsArray;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox list2QuantityBox;
        private System.Windows.Forms.TextBox list1QuantityBox;
        private System.Windows.Forms.TextBox currencyResultBox;
        private System.Windows.Forms.ComboBox currencyList2;
        private System.Windows.Forms.ComboBox currencyList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button itemLevelPriceCheckButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uniqueBeastsArray;
        private System.Windows.Forms.Button beastsArray;
        private System.Windows.Forms.Label chooseLeagueLabel;
        public System.Windows.Forms.ComboBox leagueBox;
        private System.Windows.Forms.Button incubatorsArray;
        private System.Windows.Forms.Button oilsTypesArray;
        private System.Windows.Forms.Button deliriumOrbArray;
        private System.Windows.Forms.Button divcardAnalyzer_bttn;
        private System.Windows.Forms.Button seedsArray;
    }
}

