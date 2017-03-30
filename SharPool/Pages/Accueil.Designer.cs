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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.gridRecherche = new MetroFramework.Controls.MetroGrid();
            this.Siret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entreprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ajouter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimé = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_rechercher = new MetroFramework.Controls.MetroTextBox();
            this.bnt_rechercher = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.sharPoolDataSet = new SharPool.SharPoolDataSet();
            this.entrepriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrepriseTableAdapter = new SharPool.SharPoolDataSetTableAdapters.EntrepriseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharPoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(433, 540);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(197, 58);
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
            this.gridRecherche.AllowUserToResizeRows = false;
            this.gridRecherche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRecherche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRecherche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRecherche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecherche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Siret,
            this.Entreprise,
            this.Voir,
            this.Modifier,
            this.Ajouter,
            this.Supprimé});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRecherche.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridRecherche.EnableHeadersVisualStyles = false;
            this.gridRecherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRecherche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRecherche.Location = new System.Drawing.Point(31, 286);
            this.gridRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridRecherche.Name = "gridRecherche";
            this.gridRecherche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecherche.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridRecherche.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRecherche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRecherche.Size = new System.Drawing.Size(988, 209);
            this.gridRecherche.TabIndex = 1;
            this.gridRecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // Siret
            // 
            this.Siret.HeaderText = "Siret";
            this.Siret.Name = "Siret";
            // 
            // Entreprise
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Entreprise.DefaultCellStyle = dataGridViewCellStyle2;
            this.Entreprise.HeaderText = "Entreprise";
            this.Entreprise.Name = "Entreprise";
            // 
            // Voir
            // 
            this.Voir.HeaderText = "Voir";
            this.Voir.Name = "Voir";
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            // 
            // Ajouter
            // 
            this.Ajouter.HeaderText = "Ajouter";
            this.Ajouter.Name = "Ajouter";
            // 
            // Supprimé
            // 
            this.Supprimé.HeaderText = "Supprimé";
            this.Supprimé.Name = "Supprimé";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_rechercher
            // 
            // 
            // 
            // 
            this.tbx_rechercher.CustomButton.Image = null;
            this.tbx_rechercher.CustomButton.Location = new System.Drawing.Point(1260, 1);
            this.tbx_rechercher.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_rechercher.CustomButton.Name = "";
            this.tbx_rechercher.CustomButton.Size = new System.Drawing.Size(55, 50);
            this.tbx_rechercher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_rechercher.CustomButton.TabIndex = 1;
            this.tbx_rechercher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_rechercher.CustomButton.UseSelectable = true;
            this.tbx_rechercher.CustomButton.Visible = false;
            this.tbx_rechercher.Lines = new string[] {
        "Recherche"};
            this.tbx_rechercher.Location = new System.Drawing.Point(32, 209);
            this.tbx_rechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_rechercher.MaxLength = 32767;
            this.tbx_rechercher.Name = "tbx_rechercher";
            this.tbx_rechercher.PasswordChar = '\0';
            this.tbx_rechercher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_rechercher.SelectedText = "";
            this.tbx_rechercher.SelectionLength = 0;
            this.tbx_rechercher.SelectionStart = 0;
            this.tbx_rechercher.ShortcutsEnabled = true;
            this.tbx_rechercher.Size = new System.Drawing.Size(987, 43);
            this.tbx_rechercher.TabIndex = 3;
            this.tbx_rechercher.Text = "Recherche";
            this.tbx_rechercher.UseSelectable = true;
            this.tbx_rechercher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_rechercher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bnt_rechercher
            // 
            this.bnt_rechercher.ActiveControl = null;
            this.bnt_rechercher.Location = new System.Drawing.Point(904, 209);
            this.bnt_rechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_rechercher.Name = "bnt_rechercher";
            this.bnt_rechercher.Size = new System.Drawing.Size(115, 43);
            this.bnt_rechercher.TabIndex = 4;
            this.bnt_rechercher.Text = "Rechercher";
            this.bnt_rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnt_rechercher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bnt_rechercher.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(773, 124);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(245, 54);
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
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 626);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.bnt_rechercher);
            this.Controls.Add(this.tbx_rechercher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridRecherche);
            this.Controls.Add(this.metroTile1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Accueil";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Recherche entreprise";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRecherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharPoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Siret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entreprise;
        private System.Windows.Forms.DataGridViewButtonColumn Voir;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Ajouter;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimé;
    }
}