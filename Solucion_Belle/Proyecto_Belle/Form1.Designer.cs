namespace Proyecto_Belle
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
            textemail = new TextBox();
            textcontraseña = new TextBox();
            btnlogin = new Button();
            btnregistro = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textemail
            // 
            textemail.Location = new Point(240, 190);
            textemail.Name = "textemail";
            textemail.Size = new Size(232, 27);
            textemail.TabIndex = 0;
            // 
            // textcontraseña
            // 
            textcontraseña.Location = new Point(240, 263);
            textcontraseña.Name = "textcontraseña";
            textcontraseña.Size = new Size(232, 27);
            textcontraseña.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(240, 326);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(119, 25);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "log in";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnregistro
            // 
            btnregistro.Location = new Point(365, 326);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(107, 25);
            btnregistro.TabIndex = 3;
            btnregistro.Text = "register";
            btnregistro.UseVisualStyleBackColor = true;
            btnregistro.Click += btnregistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 193);
            label1.Name = "label1";
            label1.Size = new Size(37, 16);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 272);
            label2.Name = "label2";
            label2.Size = new Size(60, 16);
            label2.TabIndex = 5;
            label2.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 39F);
            label3.Location = new Point(214, 62);
            label3.Name = "label3";
            label3.Size = new Size(258, 70);
            label3.TabIndex = 6;
            label3.Text = "Welcome!";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(240, 299);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 16);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "forget your password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnregistro);
            Controls.Add(btnlogin);
            Controls.Add(textcontraseña);
            Controls.Add(textemail);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textemail;
        private TextBox textcontraseña;
        private Button btnlogin;
        private Button btnregistro;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
