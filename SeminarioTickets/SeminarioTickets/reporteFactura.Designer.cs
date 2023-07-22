
namespace SeminarioTickets
{
    partial class reporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SeminarioTicketsDataSet1 = new SeminarioTickets.SeminarioTicketsDataSet1();
            this.vistaReporteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaReporteFacturaTableAdapter = new SeminarioTickets.SeminarioTicketsDataSet1TableAdapters.vistaReporteFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SeminarioTicketsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaReporteFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::SeminarioTickets.Properties.Resources._4115230_cancel_close_cross_delete_114048;
            this.btnCerrar.Location = new System.Drawing.Point(680, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 37);
            this.btnCerrar.TabIndex = 68;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "ReporteFacturas";
            reportDataSource1.Value = this.vistaReporteFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SeminarioTickets.ReporteHistorialFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 368);
            this.reportViewer1.TabIndex = 69;
            this.reportViewer1.ZoomPercent = 120;
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
            // vistaReporteFacturaTableAdapter
            // 
            this.vistaReporteFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // reporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteFactura";
            this.Load += new System.EventHandler(this.reporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeminarioTicketsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaReporteFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vistaReporteFacturaBindingSource;
        private SeminarioTicketsDataSet1 SeminarioTicketsDataSet1;
        private SeminarioTicketsDataSet1TableAdapters.vistaReporteFacturaTableAdapter vistaReporteFacturaTableAdapter;
    }
}