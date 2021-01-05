namespace Deti_PoE_ToolBox
{
    partial class AdvancedBaseChecker
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
            this.itemBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(22, 38);
            this.itemBox.Multiline = true;
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(336, 361);
            this.itemBox.TabIndex = 0;
            this.itemBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemBox_KeyDown);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(22, 405);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(176, 30);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check Item";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ctrl+C ingame item and Paste below";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(205, 406);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(153, 29);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 463);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(679, 20);
            this.textBox1.TabIndex = 4;
            // 
            // AdvancedBaseChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 452);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.itemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdvancedBaseChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedBaseChecker";
            this.Load += new System.EventHandler(this.AdvancedBaseChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textBox1;
    }
}