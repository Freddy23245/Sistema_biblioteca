namespace Sistemas_Biblioteca
{
    partial class Prestamos
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_prestamo = new System.Windows.Forms.TextBox();
            this.txt_id_alumno = new System.Windows.Forms.TextBox();
            this.txt_alumno = new System.Windows.Forms.TextBox();
            this.txt_libro = new System.Windows.Forms.TextBox();
            this.txt_id_libro = new System.Windows.Forms.TextBox();
            this.dtp_max_prest = new System.Windows.Forms.DateTimePicker();
            this.dt_prestamo = new System.Windows.Forms.DataGridView();
            this.btn_traer_libro = new System.Windows.Forms.Button();
            this.btn_traer_alumno = new System.Windows.Forms.Button();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_prestamo = new System.Windows.Forms.DateTimePicker();
            this.btn_deuda = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(9, 244);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(92, 30);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(120, 244);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(92, 30);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libro a Prestar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Maxima:";
            // 
            // txt_id_prestamo
            // 
            this.txt_id_prestamo.Location = new System.Drawing.Point(9, 6);
            this.txt_id_prestamo.Name = "txt_id_prestamo";
            this.txt_id_prestamo.Size = new System.Drawing.Size(100, 20);
            this.txt_id_prestamo.TabIndex = 7;
            // 
            // txt_id_alumno
            // 
            this.txt_id_alumno.Location = new System.Drawing.Point(96, 35);
            this.txt_id_alumno.Name = "txt_id_alumno";
            this.txt_id_alumno.Size = new System.Drawing.Size(41, 20);
            this.txt_id_alumno.TabIndex = 8;
            // 
            // txt_alumno
            // 
            this.txt_alumno.Location = new System.Drawing.Point(157, 35);
            this.txt_alumno.Name = "txt_alumno";
            this.txt_alumno.Size = new System.Drawing.Size(100, 20);
            this.txt_alumno.TabIndex = 9;
            // 
            // txt_libro
            // 
            this.txt_libro.Location = new System.Drawing.Point(194, 85);
            this.txt_libro.Name = "txt_libro";
            this.txt_libro.Size = new System.Drawing.Size(100, 20);
            this.txt_libro.TabIndex = 11;
            // 
            // txt_id_libro
            // 
            this.txt_id_libro.Location = new System.Drawing.Point(133, 85);
            this.txt_id_libro.Name = "txt_id_libro";
            this.txt_id_libro.Size = new System.Drawing.Size(41, 20);
            this.txt_id_libro.TabIndex = 10;
            // 
            // dtp_max_prest
            // 
            this.dtp_max_prest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_max_prest.Location = new System.Drawing.Point(132, 191);
            this.dtp_max_prest.MinDate = new System.DateTime(2019, 1, 18, 0, 0, 0, 0);
            this.dtp_max_prest.Name = "dtp_max_prest";
            this.dtp_max_prest.Size = new System.Drawing.Size(107, 20);
            this.dtp_max_prest.TabIndex = 13;
            this.dtp_max_prest.Value = new System.DateTime(2022, 4, 24, 0, 0, 0, 0);
            // 
            // dt_prestamo
            // 
            this.dt_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_prestamo.Location = new System.Drawing.Point(373, 62);
            this.dt_prestamo.Name = "dt_prestamo";
            this.dt_prestamo.Size = new System.Drawing.Size(700, 288);
            this.dt_prestamo.TabIndex = 14;
            this.dt_prestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_prestamo_CellContentClick);
            this.dt_prestamo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_prestamo_CellContentDoubleClick);
            // 
            // btn_traer_libro
            // 
            this.btn_traer_libro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_traer_libro.Location = new System.Drawing.Point(309, 85);
            this.btn_traer_libro.Name = "btn_traer_libro";
            this.btn_traer_libro.Size = new System.Drawing.Size(39, 23);
            this.btn_traer_libro.TabIndex = 15;
            this.btn_traer_libro.Text = "...";
            this.btn_traer_libro.UseVisualStyleBackColor = false;
            this.btn_traer_libro.Click += new System.EventHandler(this.btn_traer_libro_Click);
            // 
            // btn_traer_alumno
            // 
            this.btn_traer_alumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_traer_alumno.Location = new System.Drawing.Point(272, 32);
            this.btn_traer_alumno.Name = "btn_traer_alumno";
            this.btn_traer_alumno.Size = new System.Drawing.Size(39, 23);
            this.btn_traer_alumno.TabIndex = 16;
            this.btn_traer_alumno.Text = "...";
            this.btn_traer_alumno.UseVisualStyleBackColor = false;
            this.btn_traer_alumno.Click += new System.EventHandler(this.btn_traer_alumno_Click);
            // 
            // btn_retornar
            // 
            this.btn_retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retornar.Location = new System.Drawing.Point(237, 244);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(92, 30);
            this.btn_retornar.TabIndex = 17;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.UseVisualStyleBackColor = true;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(384, 362);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(112, 23);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Prestamo;";
            // 
            // dtp_prestamo
            // 
            this.dtp_prestamo.Enabled = false;
            this.dtp_prestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_prestamo.Location = new System.Drawing.Point(157, 142);
            this.dtp_prestamo.Name = "dtp_prestamo";
            this.dtp_prestamo.Size = new System.Drawing.Size(100, 20);
            this.dtp_prestamo.TabIndex = 12;
            // 
            // btn_deuda
            // 
            this.btn_deuda.Location = new System.Drawing.Point(662, 361);
            this.btn_deuda.Name = "btn_deuda";
            this.btn_deuda.Size = new System.Drawing.Size(75, 23);
            this.btn_deuda.TabIndex = 19;
            this.btn_deuda.Text = "Deuda";
            this.btn_deuda.UseVisualStyleBackColor = true;
            this.btn_deuda.Click += new System.EventHandler(this.btn_deuda_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pendiente",
            "Retornado"});
            this.comboBox1.Location = new System.Drawing.Point(562, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mostrar Por:";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_deuda);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_retornar);
            this.Controls.Add(this.btn_traer_alumno);
            this.Controls.Add(this.btn_traer_libro);
            this.Controls.Add(this.dt_prestamo);
            this.Controls.Add(this.dtp_max_prest);
            this.Controls.Add(this.dtp_prestamo);
            this.Controls.Add(this.txt_libro);
            this.Controls.Add(this.txt_id_libro);
            this.Controls.Add(this.txt_alumno);
            this.Controls.Add(this.txt_id_alumno);
            this.Controls.Add(this.txt_id_prestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_prestamo;
        private System.Windows.Forms.TextBox txt_id_alumno;
        private System.Windows.Forms.TextBox txt_alumno;
        private System.Windows.Forms.TextBox txt_libro;
        private System.Windows.Forms.TextBox txt_id_libro;
        private System.Windows.Forms.DateTimePicker dtp_max_prest;
        private System.Windows.Forms.DataGridView dt_prestamo;
        private System.Windows.Forms.Button btn_traer_libro;
        private System.Windows.Forms.Button btn_traer_alumno;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_prestamo;
        private System.Windows.Forms.Button btn_deuda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}