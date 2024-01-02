namespace AimCecSpect
{
    partial class Reservation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billeterieDataSet = new AimCecSpect.BilleterieDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new AimCecSpect.BilleterieDataSetTableAdapters.UtilisateurTableAdapter();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiqueReservationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.historiqueReservationsDataGridViewTextBoxColumn,
            this.motDePasseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilisateurBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(155, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // billeterieDataSet
            // 
            this.billeterieDataSet.DataSetName = "BilleterieDataSet";
            this.billeterieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "Utilisateur";
            this.utilisateurBindingSource.DataSource = this.billeterieDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "idUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "idUser";
            this.idUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.Visible = false;
            this.idUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // historiqueReservationsDataGridViewTextBoxColumn
            // 
            this.historiqueReservationsDataGridViewTextBoxColumn.DataPropertyName = "historiqueReservations";
            this.historiqueReservationsDataGridViewTextBoxColumn.HeaderText = "historiqueReservations";
            this.historiqueReservationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.historiqueReservationsDataGridViewTextBoxColumn.Name = "historiqueReservationsDataGridViewTextBoxColumn";
            this.historiqueReservationsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.historiqueReservationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // motDePasseDataGridViewTextBoxColumn
            // 
            this.motDePasseDataGridViewTextBoxColumn.DataPropertyName = "motDePasse";
            this.motDePasseDataGridViewTextBoxColumn.HeaderText = "motDePasse";
            this.motDePasseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motDePasseDataGridViewTextBoxColumn.Name = "motDePasseDataGridViewTextBoxColumn";
            this.motDePasseDataGridViewTextBoxColumn.Visible = false;
            this.motDePasseDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "MES RESERVATIONS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeterieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BilleterieDataSet billeterieDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BilleterieDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiqueReservationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}