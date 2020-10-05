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
            this.btnNieuwBoek = new System.Windows.Forms.Button();
            this.btnNieuweAuteur = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnNieuweUitgever = new System.Windows.Forms.Button();
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
            // btnNieuwBoek
            // 
            this.btnNieuwBoek.Location = new System.Drawing.Point(12, 41);
            this.btnNieuwBoek.Name = "btnNieuwBoek";
            this.btnNieuwBoek.Size = new System.Drawing.Size(131, 23);
            this.btnNieuwBoek.TabIndex = 2;
            this.btnNieuwBoek.Text = "Nieuw boek";
            this.btnNieuwBoek.UseVisualStyleBackColor = true;
            this.btnNieuwBoek.Click += new System.EventHandler(this.btnNieuwBoek_Click);
            // 
            // btnNieuweAuteur
            // 
            this.btnNieuweAuteur.Location = new System.Drawing.Point(12, 70);
            this.btnNieuweAuteur.Name = "btnNieuweAuteur";
            this.btnNieuweAuteur.Size = new System.Drawing.Size(131, 23);
            this.btnNieuweAuteur.TabIndex = 3;
            this.btnNieuweAuteur.Text = "Nieuwe auteur";
            this.btnNieuweAuteur.UseVisualStyleBackColor = true;
            this.btnNieuweAuteur.Click += new System.EventHandler(this.btnNieuweAuteur_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.Location = new System.Drawing.Point(14, 100);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(130, 23);
            this.btnGenre.TabIndex = 4;
            this.btnGenre.Text = "Nieuw genre";
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnNieuweUitgever
            // 
            this.btnNieuweUitgever.Location = new System.Drawing.Point(14, 129);
            this.btnNieuweUitgever.Name = "btnNieuweUitgever";
            this.btnNieuweUitgever.Size = new System.Drawing.Size(130, 23);
            this.btnNieuweUitgever.TabIndex = 5;
            this.btnNieuweUitgever.Text = "Nieuwe uitgever";
            this.btnNieuweUitgever.UseVisualStyleBackColor = true;
            this.btnNieuweUitgever.Click += new System.EventHandler(this.btnNieuweUitgever_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 223);
            this.Controls.Add(this.btnNieuweUitgever);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.btnNieuweAuteur);
            this.Controls.Add(this.btnNieuwBoek);
            this.Controls.Add(this.btnBoekenOverzicht);
            this.Name = "Hoofdmenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoekenOverzicht;
        private System.Windows.Forms.Button btnNieuwBoek;
        private System.Windows.Forms.Button btnNieuweAuteur;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnNieuweUitgever;
    }
}

