namespace Proyecto_Belle
{
    partial class Registrarse
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
            textemail = new TextBox();
            textcontraseña = new TextBox();
            textrespuesta = new TextBox();
            btncancelar = new Button();
            btnregistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checksuscripcion = new CheckBox();
            combopregunta = new ComboBox();
            textconfirmarcontraseña = new TextBox();
            textnombre = new TextBox();
            textapellido = new TextBox();
            SuspendLayout();
            // 
            // textemail
            // 
            textemail.Location = new Point(137, 251);
            textemail.Name = "textemail";
            textemail.Size = new Size(320, 32);
            textemail.TabIndex = 2;
            // 
            // textcontraseña
            // 
            textcontraseña.Location = new Point(640, 109);
            textcontraseña.Name = "textcontraseña";
            textcontraseña.Size = new Size(320, 32);
            textcontraseña.TabIndex = 3;
            // 
            // textrespuesta
            // 
            textrespuesta.Location = new Point(640, 323);
            textrespuesta.Name = "textrespuesta";
            textrespuesta.Size = new Size(320, 32);
            textrespuesta.TabIndex = 6;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(640, 397);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(194, 55);
            btncancelar.TabIndex = 7;
            btncancelar.Text = "cancel";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(255, 397);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(202, 55);
            btnregistrar.TabIndex = 8;
            btnregistrar.Text = "register";
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 28.75F, FontStyle.Bold);
            label1.Location = new Point(432, 23);
            label1.Name = "label1";
            label1.Size = new Size(222, 61);
            label1.TabIndex = 9;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 117);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 10;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 187);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 11;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 112);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 199);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 13;
            label5.Text = "Confirm password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 259);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 14;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 270);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 15;
            label7.Text = "Security question";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(578, 332);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 16;
            label8.Text = "Anwser";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(128, 318);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 17;
            // 
            // checksuscripcion
            // 
            checksuscripcion.AutoSize = true;
            checksuscripcion.Location = new Point(261, 332);
            checksuscripcion.Name = "checksuscripcion";
            checksuscripcion.Size = new Size(196, 24);
            checksuscripcion.TabIndex = 18;
            checksuscripcion.Text = "Subscribe to mailing list";
            checksuscripcion.UseVisualStyleBackColor = true;
            // 
            // combopregunta
            // 
            combopregunta.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combopregunta.FormattingEnabled = true;
            combopregunta.Location = new Point(640, 262);
            combopregunta.Name = "combopregunta";
            combopregunta.Size = new Size(320, 28);
            combopregunta.TabIndex = 19;
            // 
            // textconfirmarcontraseña
            // 
            textconfirmarcontraseña.Location = new Point(640, 187);
            textconfirmarcontraseña.Name = "textconfirmarcontraseña";
            textconfirmarcontraseña.Size = new Size(320, 32);
            textconfirmarcontraseña.TabIndex = 20;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(137, 109);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(320, 32);
            textnombre.TabIndex = 21;
            // 
            // textapellido
            // 
            textapellido.Location = new Point(137, 187);
            textapellido.Name = "textapellido";
            textapellido.Size = new Size(320, 32);
            textapellido.TabIndex = 22;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 480);
            Controls.Add(textapellido);
            Controls.Add(textnombre);
            Controls.Add(textconfirmarcontraseña);
            Controls.Add(combopregunta);
            Controls.Add(checksuscripcion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnregistrar);
            Controls.Add(btncancelar);
            Controls.Add(textrespuesta);
            Controls.Add(textcontraseña);
            Controls.Add(textemail);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registrarse";
            Text = "Registrarse";
            Load += Registrarse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textemail;
        private TextBox textcontraseña;
        private TextBox textrespuesta;
        private Button btncancelar;
        private Button btnregistrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checksuscripcion;
        private ComboBox combopregunta;
        private TextBox textconfirmarcontraseña;
        private TextBox textnombre;
        private TextBox textapellido;
    }
}