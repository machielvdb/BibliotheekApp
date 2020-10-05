namespace BibliotheekApp
{
    partial class NieuwBoek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbPaginas = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.cbAuteur = new System.Windows.Forms.ComboBox();
            this.cbUitgever = new System.Windows.Forms.ComboBox();
            this.btnAddAuteur = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.lbAuteurs = new System.Windows.Forms.ListBox();
            this.btnVerwijderGenre = new System.Windows.Forms.Button();
            this.btnVerwijderAuteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auteur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aantal pagina\'s:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Score: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Uitgever: ";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(97, 6);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(193, 20);
            this.tbTitel.TabIndex = 5;
            // 
            // tbPaginas
            // 
            this.tbPaginas.Location = new System.Drawing.Point(98, 81);
            this.tbPaginas.Name = "tbPaginas";
            this.tbPaginas.Size = new System.Drawing.Size(193, 20);
            this.tbPaginas.TabIndex = 7;
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(98, 105);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(193, 20);
            this.tbScore.TabIndex = 8;
            // 
            // cbAuteur
            // 
            this.cbAuteur.FormattingEnabled = true;
            this.cbAuteur.Location = new System.Drawing.Point(98, 56);
            this.cbAuteur.Name = "cbAuteur";
            this.cbAuteur.Size = new System.Drawing.Size(193, 21);
            this.cbAuteur.TabIndex = 9;
            // 
            // cbUitgever
            // 
            this.cbUitgever.FormattingEnabled = true;
            this.cbUitgever.Location = new System.Drawing.Point(98, 129);
            this.cbUitgever.Name = "cbUitgever";
            this.cbUitgever.Size = new System.Drawing.Size(193, 21);
            this.cbUitgever.TabIndex = 10;
            // 
            // btnAddAuteur
            // 
            this.btnAddAuteur.Location = new System.Drawing.Point(297, 54);
            this.btnAddAuteur.Name = "btnAddAuteur";
            this.btnAddAuteur.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuteur.TabIndex = 11;
            this.btnAddAuteur.Text = "Add";
            this.btnAddAuteur.UseVisualStyleBackColor = true;
            this.btnAddAuteur.Click += new System.EventHandler(this.btnAddAuteur_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(297, 30);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 12;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(17, 180);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(369, 23);
            this.btnOpslaan.TabIndex = 13;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genre: ";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(98, 32);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(193, 21);
            this.cbGenre.TabIndex = 15;
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(392, 6);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(143, 69);
            this.lbGenres.TabIndex = 16;
            // 
            // lbAuteurs
            // 
            this.lbAuteurs.FormattingEnabled = true;
            this.lbAuteurs.Location = new System.Drawing.Point(392, 105);
            this.lbAuteurs.Name = "lbAuteurs";
            this.lbAuteurs.Size = new System.Drawing.Size(143, 69);
            this.lbAuteurs.TabIndex = 17;
            // 
            // btnVerwijderGenre
            // 
            this.btnVerwijderGenre.Location = new System.Drawing.Point(392, 79);
            this.btnVerwijderGenre.Name = "btnVerwijderGenre";
            this.btnVerwijderGenre.Size = new System.Drawing.Size(143, 23);
            this.btnVerwijderGenre.TabIndex = 18;
            this.btnVerwijderGenre.Text = "Verwijder";
            this.btnVerwijderGenre.UseVisualStyleBackColor = true;
            this.btnVerwijderGenre.Click += new System.EventHandler(this.btnVerwijderGenre_Click);
            // 
            // btnVerwijderAuteur
            // 
            this.btnVerwijderAuteur.Location = new System.Drawing.Point(392, 180);
            this.btnVerwijderAuteur.Name = "btnVerwijderAuteur";
            this.btnVerwijderAuteur.Size = new System.Drawing.Size(143, 23);
            this.btnVerwijderAuteur.TabIndex = 19;
            this.btnVerwijderAuteur.Text = "Verwijder";
            this.btnVerwijderAuteur.UseVisualStyleBackColor = true;
            this.btnVerwijderAuteur.Click += new System.EventHandler(this.btnVerwijderAuteur_Click);
            // 
            // NieuwBoek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 217);
            this.Controls.Add(this.btnVerwijderAuteur);
            this.Controls.Add(this.btnVerwijderGenre);
            this.Controls.Add(this.lbAuteurs);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnAddAuteur);
            this.Controls.Add(this.cbUitgever);
            this.Controls.Add(this.cbAuteur);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbPaginas);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NieuwBoek";
            this.Text = "NieuwBoek";
            this.Load += new System.EventHandler(this.NieuwBoek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.TextBox tbPaginas;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.ComboBox cbAuteur;
        private System.Windows.Forms.ComboBox cbUitgever;
        private System.Windows.Forms.Button btnAddAuteur;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.ListBox lbAuteurs;
        private System.Windows.Forms.Button btnVerwijderGenre;
        private System.Windows.Forms.Button btnVerwijderAuteur;
    }
}