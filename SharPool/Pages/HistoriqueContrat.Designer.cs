namespace SharPool.Pages
{
    partial class HistoriqueContrat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriqueContrat));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.grid_contrat = new MetroFramework.Controls.MetroGrid();
            this.grid_apprenti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_tuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_appreciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contrat)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(308, 446);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(416, 54);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Ajouter contrat";
            this.metroTile1.UseSelectable = true;
            // 
            // grid_contrat
            // 
            this.grid_contrat.AllowUserToResizeRows = false;
            this.grid_contrat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_contrat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_contrat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_contrat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_contrat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_contrat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_contrat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_apprenti,
            this.grid_tuteur,
            this.grid_date_debut,
            this.grid_date_fin,
            this.grid_appreciation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_contrat.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_contrat.EnableHeadersVisualStyles = false;
            this.grid_contrat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_contrat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_contrat.Location = new System.Drawing.Point(31, 282);
            this.grid_contrat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_contrat.Name = "grid_contrat";
            this.grid_contrat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_contrat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_contrat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grid_contrat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_contrat.Size = new System.Drawing.Size(965, 126);
            this.grid_contrat.TabIndex = 1;
            // 
            // grid_apprenti
            // 
            this.grid_apprenti.HeaderText = "Apprenti";
            this.grid_apprenti.Name = "grid_apprenti";
            // 
            // grid_tuteur
            // 
            this.grid_tuteur.HeaderText = "Tuteur";
            this.grid_tuteur.Name = "grid_tuteur";
            // 
            // grid_date_debut
            // 
            this.grid_date_debut.HeaderText = "Date début";
            this.grid_date_debut.Name = "grid_date_debut";
            // 
            // grid_date_fin
            // 
            this.grid_date_fin.HeaderText = "Date fin";
            this.grid_date_fin.Name = "grid_date_fin";
            // 
            // grid_appreciation
            // 
            this.grid_appreciation.HeaderText = "Appréciation";
            this.grid_appreciation.Name = "grid_appreciation";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 135);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Entreprise";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(81, 192);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Adresse";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(335, 192);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Adresse";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(335, 135);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Adresse";
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.Location = new System.Drawing.Point(31, 471);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(159, 28);
            this.metroLink1.TabIndex = 44;
            this.metroLink1.Text = "Retour";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // HistoriqueContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 528);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grid_contrat);
            this.Controls.Add(this.metroTile1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistoriqueContrat";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "HistoriqueContrat";
            ((System.ComponentModel.ISupportInitialize)(this.grid_contrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroGrid grid_contrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_apprenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_tuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_date_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_appreciation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}