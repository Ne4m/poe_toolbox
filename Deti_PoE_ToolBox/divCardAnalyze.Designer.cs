namespace Deti_Poe_ToolBox
{
    partial class divCardAnalyze
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
            this.divCards_low = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lowTierlbl = new System.Windows.Forms.Label();
            this.medTierlbl = new System.Windows.Forms.Label();
            this.divCards_med = new System.Windows.Forms.RichTextBox();
            this.highTierlbl = new System.Windows.Forms.Label();
            this.divCards_high = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // divCards_low
            // 
            this.divCards_low.Location = new System.Drawing.Point(12, 33);
            this.divCards_low.Name = "divCards_low";
            this.divCards_low.Size = new System.Drawing.Size(700, 146);
            this.divCards_low.TabIndex = 0;
            this.divCards_low.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lowTierlbl
            // 
            this.lowTierlbl.AutoSize = true;
            this.lowTierlbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.lowTierlbl.ForeColor = System.Drawing.Color.Silver;
            this.lowTierlbl.Location = new System.Drawing.Point(290, 17);
            this.lowTierlbl.Name = "lowTierlbl";
            this.lowTierlbl.Size = new System.Drawing.Size(124, 13);
            this.lowTierlbl.TabIndex = 2;
            this.lowTierlbl.Text = "LOW TIER CARDS < 2c";
            // 
            // medTierlbl
            // 
            this.medTierlbl.AutoSize = true;
            this.medTierlbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.medTierlbl.ForeColor = System.Drawing.Color.Silver;
            this.medTierlbl.Location = new System.Drawing.Point(290, 195);
            this.medTierlbl.Name = "medTierlbl";
            this.medTierlbl.Size = new System.Drawing.Size(125, 13);
            this.medTierlbl.TabIndex = 4;
            this.medTierlbl.Text = "MID TIER CARDS < 10c";
            // 
            // divCards_med
            // 
            this.divCards_med.Location = new System.Drawing.Point(12, 211);
            this.divCards_med.Name = "divCards_med";
            this.divCards_med.Size = new System.Drawing.Size(700, 146);
            this.divCards_med.TabIndex = 3;
            this.divCards_med.Text = "";
            // 
            // highTierlbl
            // 
            this.highTierlbl.AutoSize = true;
            this.highTierlbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.highTierlbl.ForeColor = System.Drawing.Color.Silver;
            this.highTierlbl.Location = new System.Drawing.Point(290, 372);
            this.highTierlbl.Name = "highTierlbl";
            this.highTierlbl.Size = new System.Drawing.Size(132, 13);
            this.highTierlbl.TabIndex = 6;
            this.highTierlbl.Text = "HIGH TIER CARDS > 10c";
            // 
            // divCards_high
            // 
            this.divCards_high.Location = new System.Drawing.Point(12, 388);
            this.divCards_high.Name = "divCards_high";
            this.divCards_high.Size = new System.Drawing.Size(700, 146);
            this.divCards_high.TabIndex = 5;
            this.divCards_high.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 146);
            this.button2.TabIndex = 7;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 146);
            this.button3.TabIndex = 8;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(719, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 146);
            this.button4.TabIndex = 9;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // divCardAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(757, 551);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.highTierlbl);
            this.Controls.Add(this.divCards_high);
            this.Controls.Add(this.medTierlbl);
            this.Controls.Add(this.divCards_med);
            this.Controls.Add(this.lowTierlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divCards_low);
            this.Name = "divCardAnalyze";
            this.Text = "Div Cards Analyze For Item Filters";
            this.Load += new System.EventHandler(this.divCardAnalyze_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox divCards_low;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lowTierlbl;
        private System.Windows.Forms.Label medTierlbl;
        private System.Windows.Forms.RichTextBox divCards_med;
        private System.Windows.Forms.Label highTierlbl;
        private System.Windows.Forms.RichTextBox divCards_high;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}