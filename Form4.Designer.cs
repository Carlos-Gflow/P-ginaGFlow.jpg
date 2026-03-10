namespace proyecto_con_base_de_datos
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            label7 = new Label();
            label4 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            textBox8 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 229);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 25;
            label7.Text = "correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 130);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 22;
            label4.Text = "dni";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(599, 226);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(189, 27);
            textBox7.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 196);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 24;
            label6.Text = "direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 97);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 21;
            label3.Text = "2 apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 163);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 23;
            label5.Text = "telefono";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(599, 193);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 27);
            textBox6.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 19;
            label2.Text = "1 apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 16;
            label1.Text = "nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(599, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(599, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(599, 160);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(599, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(599, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 27);
            textBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(657, 276);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 26;
            button1.Text = "Registrar/Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Correo, DNI, Telefono });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(494, 338);
            dataGridView1.TabIndex = 27;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "primer_apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // DNI
            // 
            DNI.DataPropertyName = "DNI";
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.Width = 125;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 52);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(132, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // button3
            // 
            button3.Location = new Point(657, 311);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 29;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnEliminar_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 12);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Filtro de Busqueda";
            textBox8.Size = new Size(494, 27);
            textBox8.TabIndex = 30;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(657, 346);
            button2.Name = "button2";
            button2.Size = new Size(131, 29);
            button2.TabIndex = 31;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEditar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(520, 346);
            button4.Name = "button4";
            button4.Size = new Size(131, 29);
            button4.TabIndex = 32;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 404);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label4;
        private TextBox textBox7;
        private Label label6;
        private Label label3;
        private Label label5;
        private TextBox textBox6;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox8;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Telefono;
        private Button button4;
    }
}