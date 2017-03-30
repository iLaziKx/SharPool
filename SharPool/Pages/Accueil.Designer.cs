namespace SharPool
{
    partial class Accueil
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.gridRecherche = new MetroFramework.Controls.MetroGrid();
            this.tbx_rechercher = new MetroFramework.Controls.MetroTextBox();
            this.bnt_rechercher = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.sharPoolDataSet = new SharPool.SharPoolDataSet();
            this.entrepriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrepriseTableAdapter = new SharPool.SharPoolDataSetTableAdapters.EntrepriseTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Siret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entreprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ajouter = new System.Windows.Forms.DataGridViewImageColumn();
            this.Supprimé = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharPoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(325, 439);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(148, 47);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Archivage";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // gridRecherche
            // 
            this.gridRecherche.AllowUserToAddRows = false;
            this.gridRecherche.AllowUserToDeleteRows = false;
            this.gridRecherche.AllowUserToResizeRows = false;
            this.gridRecherche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRecherche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRecherche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRecherche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecherche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Siret,
            this.Entreprise,
            this.Voir,
            this.Modifier,
            this.Ajouter,
            this.Supprimé});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRecherche.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridRecherche.EnableHeadersVisualStyles = false;
            this.gridRecherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRecherche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRecherche.Location = new System.Drawing.Point(23, 232);
            this.gridRecherche.Name = "gridRecherche";
            this.gridRecherche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecherche.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridRecherche.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRecherche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRecherche.Size = new System.Drawing.Size(741, 170);
            this.gridRecherche.TabIndex = 1;
            this.gridRecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // tbx_rechercher
            // 
            // 
            // 
            // 
            this.tbx_rechercher.CustomButton.Image = null;
            this.tbx_rechercher.CustomButton.Location = new System.Drawing.Point(706, 1);
            this.tbx_rechercher.CustomButton.Name = "";
            this.tbx_rechercher.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbx_rechercher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_rechercher.CustomButton.TabIndex = 1;
            this.tbx_rechercher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_rechercher.CustomButton.UseSelectable = true;
            this.tbx_rechercher.CustomButton.Visible = false;
            this.tbx_rechercher.Lines = new string[] {
        "Recherche"};
            this.tbx_rechercher.Location = new System.Drawing.Point(24, 170);
            this.tbx_rechercher.MaxLength = 32767;
            this.tbx_rechercher.Name = "tbx_rechercher";
            this.tbx_rechercher.PasswordChar = '\0';
            this.tbx_rechercher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_rechercher.SelectedText = "";
            this.tbx_rechercher.SelectionLength = 0;
            this.tbx_rechercher.SelectionStart = 0;
            this.tbx_rechercher.ShortcutsEnabled = true;
            this.tbx_rechercher.Size = new System.Drawing.Size(740, 35);
            this.tbx_rechercher.TabIndex = 3;
            this.tbx_rechercher.Text = "Recherche";
            this.tbx_rechercher.UseSelectable = true;
            this.tbx_rechercher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_rechercher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bnt_rechercher
            // 
            this.bnt_rechercher.ActiveControl = null;
            this.bnt_rechercher.Location = new System.Drawing.Point(678, 170);
            this.bnt_rechercher.Name = "bnt_rechercher";
            this.bnt_rechercher.Size = new System.Drawing.Size(86, 35);
            this.bnt_rechercher.TabIndex = 4;
            this.bnt_rechercher.Text = "Rechercher";
            this.bnt_rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnt_rechercher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bnt_rechercher.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(580, 101);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(184, 43);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Ajouter entreprise";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // sharPoolDataSet
            // 
            this.sharPoolDataSet.DataSetName = "SharPoolDataSet";
            this.sharPoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entrepriseBindingSource
            // 
            this.entrepriseBindingSource.DataMember = "Entreprise";
            this.entrepriseBindingSource.DataSource = this.sharPoolDataSet;
            // 
            // entrepriseTableAdapter
            // 
            this.entrepriseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Voir";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 117;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Modifier";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 117;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Supprimé";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 117;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Supprimé";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.Width = 117;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Siret
            // 
            this.Siret.HeaderText = "Siret";
            this.Siret.Name = "Siret";
            // 
            // Entreprise
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Entreprise.DefaultCellStyle = dataGridViewCellStyle6;
            this.Entreprise.HeaderText = "Entreprise";
            this.Entreprise.Name = "Entreprise";
            // 
            // Voir
            // 
            this.Voir.HeaderText = "Voir";
            this.Voir.Image = global::SharPool.Properties.Resources.tab_afficher;
            this.Voir.Name = "Voir";
            this.Voir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Image = global::SharPool.Properties.Resources.tab_modifier;
            this.Modifier.Name = "Modifier";
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ajouter
            // 
            this.Ajouter.HeaderText = "Ajouter";
            this.Ajouter.Image = global::SharPool.Properties.Resources.tab_ajouter;
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Supprimé
            // 
            this.Supprimé.HeaderText = "Supprimé";
            this.Supprimé.Image = global::SharPool.Properties.Resources.tab_supprimer;
            this.Supprimé.Name = "Supprimé";
            this.Supprimé.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 509);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.bnt_rechercher);
            this.Controls.Add(this.tbx_rechercher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridRecherche);
            this.Controls.Add(this.metroTile1);
            this.Name = "Accueil";
            this.Text = "Recherche entreprise";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRecherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharPoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroGrid gridRecherche;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbx_rechercher;
        private MetroFramework.Controls.MetroTile bnt_rechercher;
        private MetroFramework.Controls.MetroTile metroTile2;
        private SharPoolDataSet sharPoolDataSet;
        private System.Windows.Forms.BindingSource entrepriseBindingSource;
        private SharPoolDataSetTableAdapters.EntrepriseTableAdapter entrepriseTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entreprise;
        private System.Windows.Forms.DataGridViewImageColumn Voir;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewImageColumn Ajouter;
        private System.Windows.Forms.DataGridViewImageColumn Supprimé;
    }
}