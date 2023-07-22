
namespace SeminarioTickets
{
    partial class FrmHistorial
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
            this.FacturasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SeminarioTicketsDataSet1 = new SeminarioTickets.SeminarioTicketsDataSet1();
            this.vistaReporteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.FacturasDetalleTableAdapter = new SeminarioTickets.SeminarioTicketsDataSet1TableAdapters.FacturasDetalleTableAdapter();
            this.vistaReporteFacturaTableAdapter = new SeminarioTickets.SeminarioTicketsDataSet1TableAdapters.vistaReporteFacturaTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMiHistorial = new System.Windows.Forms.Button();
            this.btnHistorialC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeminarioTicketsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaReporteFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturasDetalleBindingSource
            // 
            this.FacturasDetalleBindingSource.DataMember = "FacturasDetalle";
            this.FacturasDetalleBindingSource.DataSource = this.SeminarioTicketsDataSet1;
            // 
            // SeminarioTicketsDataSet1
            // 
            this.SeminarioTicketsDataSet1.DataSetName = "SeminarioTicketsDataSet1";
            this.SeminarioTicketsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaReporteFacturaBindingSource
            // 
            this.vistaReporteFacturaBindingSource.DataMember = "vistaReporteFactura";
            this.vistaReporteFacturaBindingSource.DataSource = this.SeminarioTicketsDataSet1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 36);
            this.label8.TabIndex = 65;
            this.label8.Text = "HISTORIAL DE FACTURACION";
            // 
            // FacturasDetalleTableAdapter
            // 
            this.FacturasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // vistaReporteFacturaTableAdapter
            // 
            this.vistaReporteFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::SeminarioTickets.Properties.Resources._4115230_cancel_close_cross_delete_114048;
            this.btnCerrar.Location = new System.Drawing.Point(680, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 53);
            this.btnCerrar.TabIndex = 67;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(708, 268);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(632, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 53);
            this.button1.TabIndex = 70;
            this.button1.Text = "📃";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMiHistorial
            // 
            this.btnMiHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMiHistorial.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiHistorial.ForeColor = System.Drawing.Color.White;
            this.btnMiHistorial.Location = new System.Drawing.Point(103, 85);
            this.btnMiHistorial.Margin = new System.Windows.Forms.Padding(5);
            this.btnMiHistorial.Name = "btnMiHistorial";
            this.btnMiHistorial.Size = new System.Drawing.Size(111, 35);
            this.btnMiHistorial.TabIndex = 72;
            this.btnMiHistorial.Text = "Mi Historial";
            this.btnMiHistorial.UseVisualStyleBackColor = false;
            this.btnMiHistorial.Click += new System.EventHandler(this.btnMiHistorial_Click);
            // 
            // btnHistorialC
            // 
            this.btnHistorialC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnHistorialC.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialC.ForeColor = System.Drawing.Color.White;
            this.btnHistorialC.Location = new System.Drawing.Point(12, 85);
            this.btnHistorialC.Margin = new System.Windows.Forms.Padding(5);
            this.btnHistorialC.Name = "btnHistorialC";
            this.btnHistorialC.Size = new System.Drawing.Size(81, 35);
            this.btnHistorialC.TabIndex = 73;
            this.btnHistorialC.Text = "Historial ";
            this.btnHistorialC.UseVisualStyleBackColor = false;
            this.btnHistorialC.Click += new System.EventHandler(this.btnHistorialC_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnHistorialC);
            this.Controls.Add(this.btnMiHistorial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label8);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeminarioTicketsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaReporteFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource FacturasDetalleBindingSource;
        private SeminarioTicketsDataSet1 SeminarioTicketsDataSet1;
        private System.Windows.Forms.BindingSource vistaReporteFacturaBindingSource;
        private SeminarioTicketsDataSet1TableAdapters.FacturasDetalleTableAdapter FacturasDetalleTableAdapter;
        private SeminarioTicketsDataSet1TableAdapters.vistaReporteFacturaTableAdapter vistaReporteFacturaTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMiHistorial;
        private System.Windows.Forms.Button btnHistorialC;
    }
}