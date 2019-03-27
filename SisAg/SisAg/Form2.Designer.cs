namespace SisAg
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox_misCultivos = new System.Windows.Forms.ComboBox();
            this.label_misCultivos = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.cuanto_regar_Btn = new System.Windows.Forms.Button();
            this.textBox_CuantoRegar = new System.Windows.Forms.TextBox();
            this.cuanto_abonar_Btn = new System.Windows.Forms.Button();
            this.textBox_cuanto_abonar = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_generar_reporte = new System.Windows.Forms.Button();
            this.label_exito_estimado = new System.Windows.Forms.Label();
            this.Seleccionar_cultivo = new System.Windows.Forms.Label();
            this.comboBox_cultivos = new System.Windows.Forms.ComboBox();
            this.registrar_btn = new System.Windows.Forms.Button();
            this.textBox_terreno = new System.Windows.Forms.TextBox();
            this.label_terreno = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_fecha_siembra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_imagenCrecimiento = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenCrecimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_misCultivos
            // 
            this.comboBox_misCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_misCultivos.FormattingEnabled = true;
            this.comboBox_misCultivos.Location = new System.Drawing.Point(190, 305);
            this.comboBox_misCultivos.Name = "comboBox_misCultivos";
            this.comboBox_misCultivos.Size = new System.Drawing.Size(157, 24);
            this.comboBox_misCultivos.TabIndex = 0;
            this.comboBox_misCultivos.SelectedIndexChanged += new System.EventHandler(this.comboBox_misCultivos_SelectedIndexChanged);
            // 
            // label_misCultivos
            // 
            this.label_misCultivos.AutoSize = true;
            this.label_misCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_misCultivos.Location = new System.Drawing.Point(130, 309);
            this.label_misCultivos.Name = "label_misCultivos";
            this.label_misCultivos.Size = new System.Drawing.Size(54, 17);
            this.label_misCultivos.TabIndex = 1;
            this.label_misCultivos.Text = "Cultivo:";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(24, 369);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(206, 325);
            this.descripcion.TabIndex = 3;
            this.descripcion.Text = "";
            // 
            // cuanto_regar_Btn
            // 
            this.cuanto_regar_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuanto_regar_Btn.Location = new System.Drawing.Point(667, 305);
            this.cuanto_regar_Btn.Name = "cuanto_regar_Btn";
            this.cuanto_regar_Btn.Size = new System.Drawing.Size(132, 25);
            this.cuanto_regar_Btn.TabIndex = 4;
            this.cuanto_regar_Btn.Text = "¿Cuanto regar?";
            this.cuanto_regar_Btn.UseVisualStyleBackColor = true;
            this.cuanto_regar_Btn.Click += new System.EventHandler(this.cuanto_regar_Btn_Click);
            // 
            // textBox_CuantoRegar
            // 
            this.textBox_CuantoRegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CuantoRegar.Location = new System.Drawing.Point(815, 307);
            this.textBox_CuantoRegar.Name = "textBox_CuantoRegar";
            this.textBox_CuantoRegar.Size = new System.Drawing.Size(119, 23);
            this.textBox_CuantoRegar.TabIndex = 5;
            // 
            // cuanto_abonar_Btn
            // 
            this.cuanto_abonar_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuanto_abonar_Btn.Location = new System.Drawing.Point(998, 306);
            this.cuanto_abonar_Btn.Name = "cuanto_abonar_Btn";
            this.cuanto_abonar_Btn.Size = new System.Drawing.Size(132, 25);
            this.cuanto_abonar_Btn.TabIndex = 6;
            this.cuanto_abonar_Btn.Text = "¿Cuanto abonar?";
            this.cuanto_abonar_Btn.UseVisualStyleBackColor = true;
            this.cuanto_abonar_Btn.Click += new System.EventHandler(this.cuanto_abonar_Btn_Click);
            // 
            // textBox_cuanto_abonar
            // 
            this.textBox_cuanto_abonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cuanto_abonar.Location = new System.Drawing.Point(1147, 308);
            this.textBox_cuanto_abonar.Name = "textBox_cuanto_abonar";
            this.textBox_cuanto_abonar.Size = new System.Drawing.Size(124, 23);
            this.textBox_cuanto_abonar.TabIndex = 7;
            this.textBox_cuanto_abonar.TextChanged += new System.EventHandler(this.textBox_cuanto_abonar_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(523, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_generar_reporte
            // 
            this.button_generar_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generar_reporte.Location = new System.Drawing.Point(667, 675);
            this.button_generar_reporte.Name = "button_generar_reporte";
            this.button_generar_reporte.Size = new System.Drawing.Size(371, 29);
            this.button_generar_reporte.TabIndex = 11;
            this.button_generar_reporte.Text = "Generar reporte";
            this.button_generar_reporte.UseVisualStyleBackColor = true;
            // 
            // label_exito_estimado
            // 
            this.label_exito_estimado.AutoSize = true;
            this.label_exito_estimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exito_estimado.Location = new System.Drawing.Point(395, 309);
            this.label_exito_estimado.Name = "label_exito_estimado";
            this.label_exito_estimado.Size = new System.Drawing.Size(107, 17);
            this.label_exito_estimado.TabIndex = 12;
            this.label_exito_estimado.Text = "Éxito estimado: ";
            // 
            // Seleccionar_cultivo
            // 
            this.Seleccionar_cultivo.AutoSize = true;
            this.Seleccionar_cultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccionar_cultivo.Location = new System.Drawing.Point(130, 227);
            this.Seleccionar_cultivo.Name = "Seleccionar_cultivo";
            this.Seleccionar_cultivo.Size = new System.Drawing.Size(54, 17);
            this.Seleccionar_cultivo.TabIndex = 13;
            this.Seleccionar_cultivo.Text = "Cultivo:";
            // 
            // comboBox_cultivos
            // 
            this.comboBox_cultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cultivos.FormattingEnabled = true;
            this.comboBox_cultivos.Items.AddRange(new object[] {
            "Maíz",
            "Jitomate",
            "Chile Serrano"});
            this.comboBox_cultivos.Location = new System.Drawing.Point(190, 224);
            this.comboBox_cultivos.Name = "comboBox_cultivos";
            this.comboBox_cultivos.Size = new System.Drawing.Size(157, 24);
            this.comboBox_cultivos.TabIndex = 14;
            // 
            // registrar_btn
            // 
            this.registrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar_btn.Location = new System.Drawing.Point(1109, 219);
            this.registrar_btn.Name = "registrar_btn";
            this.registrar_btn.Size = new System.Drawing.Size(162, 32);
            this.registrar_btn.TabIndex = 19;
            this.registrar_btn.Text = "Registrar";
            this.registrar_btn.UseVisualStyleBackColor = true;
            this.registrar_btn.Click += new System.EventHandler(this.registrar_btn_Click);
            // 
            // textBox_terreno
            // 
            this.textBox_terreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_terreno.Location = new System.Drawing.Point(998, 221);
            this.textBox_terreno.Name = "textBox_terreno";
            this.textBox_terreno.Size = new System.Drawing.Size(74, 23);
            this.textBox_terreno.TabIndex = 18;
            // 
            // label_terreno
            // 
            this.label_terreno.AutoSize = true;
            this.label_terreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_terreno.Location = new System.Drawing.Point(793, 227);
            this.label_terreno.Name = "label_terreno";
            this.label_terreno.Size = new System.Drawing.Size(199, 17);
            this.label_terreno.TabIndex = 17;
            this.label_terreno.Text = "Dimensiones del terreno (m2):";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(523, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label_fecha_siembra
            // 
            this.label_fecha_siembra.AutoSize = true;
            this.label_fecha_siembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_siembra.Location = new System.Drawing.Point(395, 227);
            this.label_fecha_siembra.Name = "label_fecha_siembra";
            this.label_fecha_siembra.Size = new System.Drawing.Size(129, 17);
            this.label_fecha_siembra.TabIndex = 15;
            this.label_fecha_siembra.Text = "Fecha de siembra: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nuevo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Consultar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(24, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1247, 2);
            this.label3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(24, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1247, 2);
            this.label4.TabIndex = 24;
            // 
            // pictureBox_imagenCrecimiento
            // 
            this.pictureBox_imagenCrecimiento.Location = new System.Drawing.Point(236, 369);
            this.pictureBox_imagenCrecimiento.Name = "pictureBox_imagenCrecimiento";
            this.pictureBox_imagenCrecimiento.Size = new System.Drawing.Size(169, 325);
            this.pictureBox_imagenCrecimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_imagenCrecimiento.TabIndex = 23;
            this.pictureBox_imagenCrecimiento.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisAg.Properties.Resources.sisag_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1371, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 274);
            this.dataGridView1.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_imagenCrecimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrar_btn);
            this.Controls.Add(this.textBox_terreno);
            this.Controls.Add(this.label_terreno);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_fecha_siembra);
            this.Controls.Add(this.comboBox_cultivos);
            this.Controls.Add(this.Seleccionar_cultivo);
            this.Controls.Add(this.label_exito_estimado);
            this.Controls.Add(this.button_generar_reporte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_cuanto_abonar);
            this.Controls.Add(this.cuanto_abonar_Btn);
            this.Controls.Add(this.textBox_CuantoRegar);
            this.Controls.Add(this.cuanto_regar_Btn);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label_misCultivos);
            this.Controls.Add(this.comboBox_misCultivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Mis cultivos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenCrecimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_misCultivos;
        private System.Windows.Forms.Label label_misCultivos;
        private System.Windows.Forms.RichTextBox descripcion;
        private System.Windows.Forms.Button cuanto_regar_Btn;
        private System.Windows.Forms.TextBox textBox_CuantoRegar;
        private System.Windows.Forms.Button cuanto_abonar_Btn;
        private System.Windows.Forms.TextBox textBox_cuanto_abonar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_generar_reporte;
        private System.Windows.Forms.Label label_exito_estimado;
        private System.Windows.Forms.Label Seleccionar_cultivo;
        private System.Windows.Forms.ComboBox comboBox_cultivos;
        private System.Windows.Forms.Button registrar_btn;
        private System.Windows.Forms.TextBox textBox_terreno;
        private System.Windows.Forms.Label label_terreno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_fecha_siembra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_imagenCrecimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}