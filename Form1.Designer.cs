namespace AimCecSpect
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spectacleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billeterieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billeterieDataSet = new AimCecSpect.BilleterieDataSet();
            this.spectacleTableAdapter = new AimCecSpect.BilleterieDataSetTableAdapters.SpectacleTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesRéservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idSpectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDispoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Annulation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSpectacleDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.lieuDataGridViewTextBoxColumn,
            this.nbPlacesDispoDataGridViewTextBoxColumn,
            this.Reservation,
            this.Annulation});
            this.dataGridView1.DataSource = this.spectacleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpectacles_CellContentClick);
            // 
            // spectacleBindingSource
            // 
            this.spectacleBindingSource.DataMember = "Spectacle";
            this.spectacleBindingSource.DataSource = this.billeterieDataSetBindingSource;
            // 
            // billeterieDataSetBindingSource
            // 
            this.billeterieDataSetBindingSource.DataSource = this.billeterieDataSet;
            this.billeterieDataSetBindingSource.Position = 0;
            // 
            // billeterieDataSet
            // 
            this.billeterieDataSet.DataSetName = "BilleterieDataSet";
            this.billeterieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spectacleTableAdapter
            // 
            this.spectacleTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRéservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesRéservationsToolStripMenuItem
            // 
            this.mesRéservationsToolStripMenuItem.Name = "mesRéservationsToolStripMenuItem";
            this.mesRéservationsToolStripMenuItem.Size = new System.Drawing.Size(313, 41);
            this.mesRéservationsToolStripMenuItem.Text = "Voir mes informations";
            this.mesRéservationsToolStripMenuItem.Click += new System.EventHandler(this.mesRéservationsToolStripMenuItem_Click);
            // 
            // idSpectacleDataGridViewTextBoxColumn
            // 
            this.idSpectacleDataGridViewTextBoxColumn.DataPropertyName = "idSpectacle";
            this.idSpectacleDataGridViewTextBoxColumn.HeaderText = "idSpectacle";
            this.idSpectacleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSpectacleDataGridViewTextBoxColumn.Name = "idSpectacleDataGridViewTextBoxColumn";
            this.idSpectacleDataGridViewTextBoxColumn.Visible = false;
            this.idSpectacleDataGridViewTextBoxColumn.Width = 125;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lieuDataGridViewTextBoxColumn
            // 
            this.lieuDataGridViewTextBoxColumn.DataPropertyName = "lieu";
            this.lieuDataGridViewTextBoxColumn.HeaderText = "Lieu";
            this.lieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lieuDataGridViewTextBoxColumn.Name = "lieuDataGridViewTextBoxColumn";
            this.lieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbPlacesDispoDataGridViewTextBoxColumn
            // 
            this.nbPlacesDispoDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesDispo";
            this.nbPlacesDispoDataGridViewTextBoxColumn.HeaderText = "Places Disponibles";
            this.nbPlacesDispoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbPlacesDispoDataGridViewTextBoxColumn.Name = "nbPlacesDispoDataGridViewTextBoxColumn";
            this.nbPlacesDispoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Reservation
            // 
            this.Reservation.HeaderText = "Reservation";
            this.Reservation.MinimumWidth = 6;
            this.Reservation.Name = "Reservation";
            this.Reservation.Text = "Reserver";
            this.Reservation.ToolTipText = "Reserver";
            this.Reservation.UseColumnTextForButtonValue = true;
            this.Reservation.Width = 125;
            // 
            // Annulation
            // 
            this.Annulation.HeaderText = "Annulation";
            this.Annulation.MinimumWidth = 6;
            this.Annulation.Name = "Annulation";
            this.Annulation.Text = "Annuler";
            this.Annulation.UseColumnTextForButtonValue = true;
            this.Annulation.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "LES SPECTACLES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource billeterieDataSetBindingSource;
        private BilleterieDataSet billeterieDataSet;
        private System.Windows.Forms.BindingSource spectacleBindingSource;
        private BilleterieDataSetTableAdapters.SpectacleTableAdapter spectacleTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesRéservationsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDispoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Reservation;
        private System.Windows.Forms.DataGridViewButtonColumn Annulation;
        private System.Windows.Forms.Label label1;
    }
}

