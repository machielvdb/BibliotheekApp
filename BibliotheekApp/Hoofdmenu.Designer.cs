namespace BibliotheekApp
{
    partial class Hoofdmenu
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
            this.btnBoekenOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoekenOverzicht
            // 
            this.btnBoekenOverzicht.Location = new System.Drawing.Point(12, 12);
            this.btnBoekenOverzicht.Name = "btnBoekenOverzicht";
            this.btnBoekenOverzicht.Size = new System.Drawing.Size(132, 23);
            this.btnBoekenOverzicht.TabIndex = 1;
            this.btnBoekenOverzicht.Text = "Boeken overzicht";
            this.btnBoekenOverzicht.UseVisualStyleBackColor = true;
            this.btnBoekenOverzicht.Click += new System.EventHandler(this.btnBoekenOverzicht_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 46);
            this.Controls.Add(this.btnBoekenOverzicht);
            this.Name = "Hoofdmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoekenOverzicht;
    }
}

