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
            this.billeterieDataSet = new AimCecSpect.BilleterieDataSet();
            this.billeterieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spectacleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spectacleTableAdapter = new AimCecSpect.BilleterieDataSetTableAdapters.SpectacleTableAdapter();
            this.idSpectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDispoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).BeginInit();
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
            this.Reservation});
            this.dataGridView1.DataSource = this.spectacleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpectacles_CellContentClick);
            // 
            // billeterieDataSet
            // 
            this.billeterieDataSet.DataSetName = "BilleterieDataSet";
            this.billeterieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billeterieDataSetBindingSource
            // 
            this.billeterieDataSetBindingSource.DataSource = this.billeterieDataSet;
            this.billeterieDataSetBindingSource.Position = 0;
            // 
            // spectacleBindingSource
            // 
            this.spectacleBindingSource.DataMember = "Spectacle";
            this.spectacleBindingSource.DataSource = this.billeterieDataSetBindingSource;
            // 
            // spectacleTableAdapter
            // 
            this.spectacleTableAdapter.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource billeterieDataSetBindingSource;
        private BilleterieDataSet billeterieDataSet;
        private System.Windows.Forms.BindingSource spectacleBindingSource;
        private BilleterieDataSetTableAdapters.SpectacleTableAdapter spectacleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDispoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Reservation;
    }
}

