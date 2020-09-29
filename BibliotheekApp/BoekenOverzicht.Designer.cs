namespace BibliotheekApp
{
    partial class BoekenOverzicht
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
            this.lblUitgave = new System.Windows.Forms.Label();
            this.lblUitgever = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.cbFilterParam = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbBoeken = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblUitgave
            // 
            this.lblUitgave.AutoSize = true;
            this.lblUitgave.Location = new System.Drawing.Point(11, 208);
            this.lblUitgave.Name = "lblUitgave";
            this.lblUitgave.Size = new System.Drawing.Size(44, 13);
            this.lblUitgave.TabIndex = 20;
            this.lblUitgave.Text = "Uitgave";
            // 
            // lblUitgever
            // 
            this.lblUitgever.AutoSize = true;
            this.lblUitgever.Location = new System.Drawing.Point(11, 185);
            this.lblUitgever.Name = "lblUitgever";
            this.lblUitgever.Size = new System.Drawing.Size(47, 13);
            this.lblUitgever.TabIndex = 19;
            this.lblUitgever.Text = "Uitgever";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(11, 162);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(47, 13);
            this.lblPaginas.TabIndex = 18;
            this.lblPaginas.Text = "Pagina\'s";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(11, 139);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "Genre";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(11, 116);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 16;
            this.lblTitel.Text = "Titel";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(11, 92);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(38, 13);
            this.lblAuteur.TabIndex = 15;
            this.lblAuteur.Text = "Auteur";
            // 
            // cbFilterParam
            // 
            this.cbFilterParam.FormattingEnabled = true;
            this.cbFilterParam.Location = new System.Drawing.Point(11, 39);
            this.cbFilterParam.Name = "cbFilterParam";
            this.cbFilterParam.Size = new System.Drawing.Size(137, 21);
            this.cbFilterParam.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(11, 66);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(137, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(11, 12);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(137, 21);
            this.cbFilter.TabIndex = 12;
            // 
            // lbBoeken
            // 
            this.lbBoeken.FormattingEnabled = true;
            this.lbBoeken.Location = new System.Drawing.Point(154, 12);
            this.lbBoeken.Name = "lbBoeken";
            this.lbBoeken.Size = new System.Drawing.Size(206, 225);
            this.lbBoeken.TabIndex = 11;
            this.lbBoeken.SelectedIndexChanged += new System.EventHandler(this.lbBoeken_SelectedIndexChanged);
            // 
            // BoekenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 250);
            this.Controls.Add(this.lblUitgave);
            this.Controls.Add(this.lblUitgever);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.cbFilterParam);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbBoeken);
            this.Name = "BoekenOverzicht";
            this.Text = "BoekenOverzicht";
            this.Load += new System.EventHandler(this.BoekenOverzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUitgave;
        private System.Windows.Forms.Label lblUitgever;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.ComboBox cbFilterParam;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ListBox lbBoeken;
    }
}