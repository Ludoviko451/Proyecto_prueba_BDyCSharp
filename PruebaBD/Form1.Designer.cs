namespace PruebaBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_conectar = new Button();
            DESCONECTARSE = new Button();
            grid_datos = new DataGridView();
            btn_consultar = new Button();
            label1 = new Label();
            txt_pais = new TextBox();
            btn_agregar = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_paisAgregar = new TextBox();
            txt_nombreAgregar = new TextBox();
            btn_eliminar = new Button();
            btn_actualizar = new Button();
            txt_nuevoNombre = new TextBox();
            txt_nuevoPais = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Picturebox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grid_datos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picturebox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_conectar
            // 
            btn_conectar.Location = new Point(139, 40);
            btn_conectar.Name = "btn_conectar";
            btn_conectar.Size = new Size(110, 55);
            btn_conectar.TabIndex = 0;
            btn_conectar.Text = "CONECTARSE";
            btn_conectar.UseVisualStyleBackColor = true;
            btn_conectar.Click += btn_conectar_Click;
            // 
            // DESCONECTARSE
            // 
            DESCONECTARSE.Location = new Point(139, 101);
            DESCONECTARSE.Name = "DESCONECTARSE";
            DESCONECTARSE.Size = new Size(110, 60);
            DESCONECTARSE.TabIndex = 1;
            DESCONECTARSE.Text = "DESCONECTARSE";
            DESCONECTARSE.UseVisualStyleBackColor = true;
            DESCONECTARSE.Click += DESCONECTARSE_Click;
            // 
            // grid_datos
            // 
            grid_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_datos.Location = new Point(344, 40);
            grid_datos.Name = "grid_datos";
            grid_datos.Size = new Size(413, 204);
            grid_datos.TabIndex = 2;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(139, 167);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(110, 48);
            btn_consultar.TabIndex = 3;
            btn_consultar.Text = "CONSULTAR";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 228);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Pais:";
            label1.Click += label1_Click;
            // 
            // txt_pais
            // 
            txt_pais.Location = new Point(139, 246);
            txt_pais.Name = "txt_pais";
            txt_pais.Size = new Size(100, 23);
            txt_pais.TabIndex = 5;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(139, 282);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(100, 49);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 316);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 316);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "Pais:";
            label3.Click += label3_Click;
            // 
            // txt_paisAgregar
            // 
            txt_paisAgregar.Location = new Point(600, 334);
            txt_paisAgregar.Name = "txt_paisAgregar";
            txt_paisAgregar.Size = new Size(100, 23);
            txt_paisAgregar.TabIndex = 9;
            // 
            // txt_nombreAgregar
            // 
            txt_nombreAgregar.Location = new Point(388, 334);
            txt_nombreAgregar.Name = "txt_nombreAgregar";
            txt_nombreAgregar.Size = new Size(100, 23);
            txt_nombreAgregar.TabIndex = 10;
            txt_nombreAgregar.TextChanged += txt_nombreAgregar_TextChanged;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(139, 337);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(100, 54);
            btn_eliminar.TabIndex = 11;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(139, 397);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(100, 54);
            btn_actualizar.TabIndex = 12;
            btn_actualizar.Text = "ACTUALIZAR";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // txt_nuevoNombre
            // 
            txt_nuevoNombre.Location = new Point(388, 394);
            txt_nuevoNombre.Name = "txt_nuevoNombre";
            txt_nuevoNombre.Size = new Size(100, 23);
            txt_nuevoNombre.TabIndex = 16;
            // 
            // txt_nuevoPais
            // 
            txt_nuevoPais.Location = new Point(600, 394);
            txt_nuevoPais.Name = "txt_nuevoPais";
            txt_nuevoPais.Size = new Size(100, 23);
            txt_nuevoPais.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 376);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Nuevo Pais:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 376);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 13;
            label5.Text = "Nuevo Nombre:";
            label5.Click += label5_Click;
            // 
            // Picturebox1
            // 
            Picturebox1.Image = Properties.Resources.off;
            Picturebox1.Location = new Point(12, 25);
            Picturebox1.Name = "Picturebox1";
            Picturebox1.Size = new Size(100, 102);
            Picturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Picturebox1.TabIndex = 17;
            Picturebox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.gifPrueba;
            pictureBox2.Location = new Point(12, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(pictureBox2);
            Controls.Add(Picturebox1);
            Controls.Add(txt_nuevoNombre);
            Controls.Add(txt_nuevoPais);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_eliminar);
            Controls.Add(txt_nombreAgregar);
            Controls.Add(txt_paisAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_agregar);
            Controls.Add(txt_pais);
            Controls.Add(label1);
            Controls.Add(btn_consultar);
            Controls.Add(grid_datos);
            Controls.Add(DESCONECTARSE);
            Controls.Add(btn_conectar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grid_datos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picturebox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_conectar;
        private Button DESCONECTARSE;
        private DataGridView grid_datos;
        private Button btn_consultar;
        private Label label1;
        private TextBox txt_pais;
        private Button btn_agregar;
        private Label label2;
        private Label label3;
        private TextBox txt_paisAgregar;
        private TextBox txt_nombreAgregar;
        private Button btn_eliminar;
        private Button btn_actualizar;
        private TextBox txt_nuevoNombre;
        private TextBox txt_nuevoPais;
        private Label label4;
        private Label label5;
        private PictureBox Picturebox1;
        private PictureBox pictureBox2;
    }
}
