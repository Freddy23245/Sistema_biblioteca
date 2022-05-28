namespace Sistemas_Biblioteca
{
    partial class Libros
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
            this.txt_idlibro = new System.Windows.Forms.TextBox();
            this.txt_id_autor = new System.Windows.Forms.TextBox();
            this.txt_nombre_autor = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_id_genero = new System.Windows.Forms.TextBox();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.txt_id_editorial = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dtp_añop = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_traer_autor = new System.Windows.Forms.Button();
            this.btn_traer_gen = new System.Windows.Forms.Button();
            this.btn_traer_edit = new System.Windows.Forms.Button();
            this.dt_libro = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_libro)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idlibro
            // 
            this.txt_idlibro.Location = new System.Drawing.Point(570, 421);
            this.txt_idlibro.Name = "txt_idlibro";
            this.txt_idlibro.Size = new System.Drawing.Size(100, 20);
            this.txt_idlibro.TabIndex = 0;
            // 
            // txt_id_autor
            // 
            this.txt_id_autor.Location = new System.Drawing.Point(99, 151);
            this.txt_id_autor.Name = "txt_id_autor";
            this.txt_id_autor.Size = new System.Drawing.Size(44, 20);
            this.txt_id_autor.TabIndex = 1;
            // 
            // txt_nombre_autor
            // 
            this.txt_nombre_autor.Location = new System.Drawing.Point(163, 151);
            this.txt_nombre_autor.Name = "txt_nombre_autor";
            this.txt_nombre_autor.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_autor.TabIndex = 2;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(163, 196);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_genero.TabIndex = 4;
            // 
            // txt_id_genero
            // 
            this.txt_id_genero.Location = new System.Drawing.Point(99, 196);
            this.txt_id_genero.Name = "txt_id_genero";
            this.txt_id_genero.Size = new System.Drawing.Size(44, 20);
            this.txt_id_genero.TabIndex = 3;
            // 
            // txt_editorial
            // 
            this.txt_editorial.Location = new System.Drawing.Point(163, 239);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(100, 20);
            this.txt_editorial.TabIndex = 6;
            // 
            // txt_id_editorial
            // 
            this.txt_id_editorial.Location = new System.Drawing.Point(99, 239);
            this.txt_id_editorial.Name = "txt_id_editorial";
            this.txt_id_editorial.Size = new System.Drawing.Size(44, 20);
            this.txt_id_editorial.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 35);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // dtp_añop
            // 
            this.dtp_añop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_añop.Location = new System.Drawing.Point(166, 69);
            this.dtp_añop.Name = "dtp_añop";
            this.dtp_añop.Size = new System.Drawing.Size(114, 20);
            this.dtp_añop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Editorial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Año De Publicacion:";
            // 
            // btn_traer_autor
            // 
            this.btn_traer_autor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_traer_autor.ForeColor = System.Drawing.Color.Black;
            this.btn_traer_autor.Location = new System.Drawing.Point(280, 148);
            this.btn_traer_autor.Name = "btn_traer_autor";
            this.btn_traer_autor.Size = new System.Drawing.Size(42, 23);
            this.btn_traer_autor.TabIndex = 16;
            this.btn_traer_autor.Text = "...";
            this.btn_traer_autor.UseVisualStyleBackColor = false;
            this.btn_traer_autor.Click += new System.EventHandler(this.btn_traer_autor_Click);
            // 
            // btn_traer_gen
            // 
            this.btn_traer_gen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_traer_gen.Location = new System.Drawing.Point(280, 193);
            this.btn_traer_gen.Name = "btn_traer_gen";
            this.btn_traer_gen.Size = new System.Drawing.Size(42, 23);
            this.btn_traer_gen.TabIndex = 17;
            this.btn_traer_gen.Text = "...";
            this.btn_traer_gen.UseVisualStyleBackColor = false;
            this.btn_traer_gen.Click += new System.EventHandler(this.btn_traer_gen_Click);
            // 
            // btn_traer_edit
            // 
            this.btn_traer_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_traer_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traer_edit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_traer_edit.Location = new System.Drawing.Point(280, 236);
            this.btn_traer_edit.Name = "btn_traer_edit";
            this.btn_traer_edit.Size = new System.Drawing.Size(42, 23);
            this.btn_traer_edit.TabIndex = 18;
            this.btn_traer_edit.Text = "...";
            this.btn_traer_edit.UseVisualStyleBackColor = false;
            this.btn_traer_edit.Click += new System.EventHandler(this.btn_traer_edit_Click);
            // 
            // dt_libro
            // 
            this.dt_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_libro.Location = new System.Drawing.Point(328, 12);
            this.dt_libro.Name = "dt_libro";
            this.dt_libro.Size = new System.Drawing.Size(509, 395);
            this.dt_libro.TabIndex = 19;
            this.dt_libro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_libro_CellContentClick);
            this.dt_libro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_libro_CellContentDoubleClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(9, 312);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(91, 26);
            this.btn_agregar.TabIndex = 20;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(110, 312);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(91, 26);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(221, 312);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(91, 26);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 453);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dt_libro);
            this.Controls.Add(this.btn_traer_edit);
            this.Controls.Add(this.btn_traer_gen);
            this.Controls.Add(this.btn_traer_autor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_añop);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.txt_id_editorial);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.txt_id_genero);
            this.Controls.Add(this.txt_nombre_autor);
            this.Controls.Add(this.txt_id_autor);
            this.Controls.Add(this.txt_idlibro);
            this.Name = "Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_libro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idlibro;
        private System.Windows.Forms.TextBox txt_id_autor;
        private System.Windows.Forms.TextBox txt_nombre_autor;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_id_genero;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.TextBox txt_id_editorial;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DateTimePicker dtp_añop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_traer_autor;
        private System.Windows.Forms.Button btn_traer_gen;
        private System.Windows.Forms.Button btn_traer_edit;
        private System.Windows.Forms.DataGridView dt_libro;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}