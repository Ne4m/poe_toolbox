namespace Deti_PoE_ToolBox
{
    partial class Form3
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
            this.logTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // logTxt
            // 
            this.logTxt.Location = new System.Drawing.Point(12, 12);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(776, 416);
            this.logTxt.TabIndex = 0;
            this.logTxt.Text = "/* Changelog v0.82a - 27.07.2020\n * Slight UI Redesign\n * Added support for Seeds" +
    "\n * Disabled Automatic League Detection Due To a Rare Bug.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logTxt);
            this.Name = "Form3";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox logTxt;
    }
}