
namespace AccesoDatos
{
    partial class frmBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboPersona = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datoTiempo = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE A LA PERSONA";
            // 
            // comboPersona
            // 
            this.comboPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPersona.FormattingEnabled = true;
            this.comboPersona.Location = new System.Drawing.Point(263, 97);
            this.comboPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPersona.Name = "comboPersona";
            this.comboPersona.Size = new System.Drawing.Size(384, 24);
            this.comboPersona.TabIndex = 1;
            this.comboPersona.SelectedIndexChanged += new System.EventHandler(this.btnMostrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datoTiempo);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1055, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la persona";
            // 
            // datoTiempo
            // 
            this.datoTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datoTiempo.Location = new System.Drawing.Point(479, 239);
            this.datoTiempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datoTiempo.MaxDate = new System.DateTime(2021, 12, 21, 0, 0, 0, 0);
            this.datoTiempo.MinDate = new System.DateTime(1794, 5, 13, 0, 0, 0, 0);
            this.datoTiempo.Name = "datoTiempo";
            this.datoTiempo.Size = new System.Drawing.Size(400, 22);
            this.datoTiempo.TabIndex = 21;
            this.datoTiempo.Value = new System.DateTime(2021, 12, 21, 0, 0, 0, 0);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(479, 289);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(400, 22);
            this.txtPeso.TabIndex = 20;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(479, 187);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(400, 22);
            this.txtNombres.TabIndex = 18;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(479, 135);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(400, 22);
            this.txtApellidos.TabIndex = 17;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(479, 85);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(400, 22);
            this.txtCedula.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "PESO EN KILOGRAMOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "FECHA DE NACIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "NOMBRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "APELLIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "CEDULA DE LA PERSONA";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(736, 62);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 60);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboPersona);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuscar";
            this.Text = "Busqueda de informacion";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DateTimePicker datoTiempo;
    }
}