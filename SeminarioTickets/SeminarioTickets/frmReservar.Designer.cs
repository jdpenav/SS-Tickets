namespace SeminarioTickets
{
    partial class frmReservar
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxUbi = new System.Windows.Forms.ComboBox();
            this.ubicacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet = new SeminarioTickets.SeminarioTicketsDataSet();
            this.ubicacionesBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet1 = new SeminarioTickets.SeminarioTicketsDataSet1();
            this.ubicacionesBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.UbicacionesTableAdapter();
            this.ubicacionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesTableAdapter1 = new SeminarioTickets.SeminarioTicketsDataSet1TableAdapters.UbicacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(356, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 70;
            this.label6.Text = "Ubicacion";
            // 
            // cmbxUbi
            // 
            this.cmbxUbi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ubicacionesBindingSource1, "ZonaUbc", true));
            this.cmbxUbi.DataSource = this.ubicacionesBindingSource7;
            this.cmbxUbi.DisplayMember = "ZonaUbc";
            this.cmbxUbi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxUbi.FormattingEnabled = true;
            this.cmbxUbi.Location = new System.Drawing.Point(360, 293);
            this.cmbxUbi.Name = "cmbxUbi";
            this.cmbxUbi.Size = new System.Drawing.Size(269, 29);
            this.cmbxUbi.TabIndex = 5;
            this.cmbxUbi.ValueMember = "IdUbc";
            // 
            // ubicacionesBindingSource1
            // 
            this.ubicacionesBindingSource1.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource1.DataSource = this.seminarioTicketsDataSetBindingSource;
            // 
            // seminarioTicketsDataSetBindingSource
            // 
            this.seminarioTicketsDataSetBindingSource.DataSource = this.seminarioTicketsDataSet;
            this.seminarioTicketsDataSetBindingSource.Position = 0;
            // 
            // seminarioTicketsDataSet
            // 
            this.seminarioTicketsDataSet.DataSetName = "SeminarioTicketsDataSet";
            this.seminarioTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubicacionesBindingSource7
            // 
            this.ubicacionesBindingSource7.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource7.DataSource = this.seminarioTicketsDataSet1;
            // 
            // seminarioTicketsDataSet1
            // 
            this.seminarioTicketsDataSet1.DataSetName = "SeminarioTicketsDataSet1";
            this.seminarioTicketsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubicacionesBindingSource6
            // 
            this.ubicacionesBindingSource6.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource6.DataSource = this.seminarioTicketsDataSet1BindingSource;
            // 
            // seminarioTicketsDataSet1BindingSource
            // 
            this.seminarioTicketsDataSet1BindingSource.DataSource = this.seminarioTicketsDataSet1;
            this.seminarioTicketsDataSet1BindingSource.Position = 0;
            // 
            // ubicacionesBindingSource5
            // 
            this.ubicacionesBindingSource5.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource5.DataSource = this.seminarioTicketsDataSet1BindingSource;
            // 
            // ubicacionesBindingSource4
            // 
            this.ubicacionesBindingSource4.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource4.DataSource = this.seminarioTicketsDataSet1;
            // 
            // ubicacionesBindingSource3
            // 
            this.ubicacionesBindingSource3.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource3.DataSource = this.seminarioTicketsDataSet1BindingSource;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Location = new System.Drawing.Point(540, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 48);
            this.btnRegresar.TabIndex = 68;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnReservar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservar.Image = global::SeminarioTickets.Properties.Resources.bill_4477__1_;
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservar.Location = new System.Drawing.Point(238, 390);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(176, 107);
            this.btnReservar.TabIndex = 67;
            this.btnReservar.Text = "Facturar";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(31, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 66;
            this.label5.Text = "Datos del Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFem);
            this.groupBox1.Controls.Add(this.rdbMasc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.groupBox1.Location = new System.Drawing.Point(36, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(19, 56);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(107, 26);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Femenino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(19, 26);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(110, 26);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(356, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "Correo (opcional)";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(361, 211);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtCorreo.MaxLength = 35;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(269, 28);
            this.txtCorreo.TabIndex = 4;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(356, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 63;
            this.label4.Text = "Telefono (opcional)";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(361, 134);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(269, 28);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label9.Location = new System.Drawing.Point(31, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 60;
            this.label9.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(36, 211);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 28);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(36, 134);
            this.txtDni.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtDni.MaxLength = 13;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(269, 28);
            this.txtDni.TabIndex = 1;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.seminarioTicketsDataSetBindingSource;
            // 
            // ubicacionesTableAdapter
            // 
            this.ubicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ubicacionesBindingSource2
            // 
            this.ubicacionesBindingSource2.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource2.DataSource = this.seminarioTicketsDataSet;
            // 
            // ubicacionesTableAdapter1
            // 
            this.ubicacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(681, 526);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxUbi);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar";
            this.Load += new System.EventHandler(this.frmReservar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxUbi;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.BindingSource seminarioTicketsDataSetBindingSource;
        private SeminarioTicketsDataSet seminarioTicketsDataSet;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private SeminarioTicketsDataSetTableAdapters.UbicacionesTableAdapter ubicacionesTableAdapter;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource1;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource2;
        private System.Windows.Forms.BindingSource seminarioTicketsDataSet1BindingSource;
        private SeminarioTicketsDataSet1 seminarioTicketsDataSet1;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource3;
        private SeminarioTicketsDataSet1TableAdapters.UbicacionesTableAdapter ubicacionesTableAdapter1;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource4;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource5;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource6;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource7;
    }
}