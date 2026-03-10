namespace proyecto_con_base_de_datos
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 54);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "example@gmail.com";
            textBox1.Size = new Size(488, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 87);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "contraseña";
            textBox2.Size = new Size(488, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 61);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(49, 130);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 2;
            button1.Text = "iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 172);
            label3.Name = "label3";
            label3.Size = new Size(209, 20);
            label3.TabIndex = 4;
            label3.Text = "¿No tienes cuenta? ¡registrate!";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 172);
            label4.Name = "label4";
            label4.Size = new Size(234, 20);
            label4.TabIndex = 5;
            label4.Text = "¿no te acuerdas de tu contraseña?";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 201);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
