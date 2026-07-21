namespace Proyecto_Belle
{
    partial class Recuperacion_de_contraseña
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
            label1 = new Label();
            label2 = new Label();
            textrespuesta = new TextBox();
            lblSecurityQuestion = new Label();
            textnuevacontraseña = new TextBox();
            label4 = new Label();
            textconfirmar = new TextBox();
            label5 = new Label();
            btncontraseña = new Button();
            btncheck = new Button();
            label6 = new Label();
            btncancel = new Button();
            label3 = new Label();
            textEmail = new TextBox();
            buttonConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F);
            label1.Location = new Point(322, 118);
            label1.Name = "label1";
            label1.Size = new Size(170, 26);
            label1.TabIndex = 0;
            label1.Text = "security question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 184);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 1;
            label2.Text = "Awnser";
            // 
            // textrespuesta
            // 
            textrespuesta.Location = new Point(370, 177);
            textrespuesta.Name = "textrespuesta";
            textrespuesta.Size = new Size(147, 30);
            textrespuesta.TabIndex = 2;
            // 
            // lblSecurityQuestion
            // 
            lblSecurityQuestion.AutoSize = true;
            lblSecurityQuestion.Location = new Point(322, 147);
            lblSecurityQuestion.Name = "lblSecurityQuestion";
            lblSecurityQuestion.Size = new Size(266, 18);
            lblSecurityQuestion.TabIndex = 3;
            lblSecurityQuestion.Text = "aqui aparece la pregunta de seguriadad";
            // 
            // textnuevacontraseña
            // 
            textnuevacontraseña.Location = new Point(715, 120);
            textnuevacontraseña.Name = "textnuevacontraseña";
            textnuevacontraseña.Size = new Size(137, 30);
            textnuevacontraseña.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 128);
            label4.Name = "label4";
            label4.Size = new Size(103, 18);
            label4.TabIndex = 4;
            label4.Text = "New password";
            // 
            // textconfirmar
            // 
            textconfirmar.Location = new Point(715, 181);
            textconfirmar.Name = "textconfirmar";
            textconfirmar.Size = new Size(137, 30);
            textconfirmar.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 188);
            label5.Name = "label5";
            label5.Size = new Size(123, 18);
            label5.TabIndex = 6;
            label5.Text = "confirm password";
            // 
            // btncontraseña
            // 
            btncontraseña.Location = new Point(620, 244);
            btncontraseña.Name = "btncontraseña";
            btncontraseña.Size = new Size(232, 43);
            btncontraseña.TabIndex = 8;
            btncontraseña.Text = "set password";
            btncontraseña.UseVisualStyleBackColor = true;
            btncontraseña.Click += btncontraseña_Click;
            // 
            // btncheck
            // 
            btncheck.Location = new Point(322, 244);
            btncheck.Name = "btncheck";
            btncheck.Size = new Size(195, 43);
            btncheck.TabIndex = 9;
            btncheck.Text = "check";
            btncheck.UseVisualStyleBackColor = true;
            btncheck.Click += btncheck_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(199, 24);
            label6.Name = "label6";
            label6.Size = new Size(315, 39);
            label6.TabIndex = 10;
            label6.Text = "Recover password";
            // 
            // btncancel
            // 
            btncancel.Location = new Point(380, 355);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(137, 53);
            btncancel.TabIndex = 11;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F);
            label3.Location = new Point(30, 139);
            label3.Name = "label3";
            label3.Size = new Size(62, 26);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(30, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(137, 30);
            textEmail.TabIndex = 13;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(44, 244);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(195, 43);
            buttonConfirmar.TabIndex = 14;
            buttonConfirmar.Text = "confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // Recuperacion_de_contraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 420);
            Controls.Add(buttonConfirmar);
            Controls.Add(textEmail);
            Controls.Add(label3);
            Controls.Add(btncancel);
            Controls.Add(label6);
            Controls.Add(btncheck);
            Controls.Add(btncontraseña);
            Controls.Add(textconfirmar);
            Controls.Add(label5);
            Controls.Add(textnuevacontraseña);
            Controls.Add(label4);
            Controls.Add(lblSecurityQuestion);
            Controls.Add(textrespuesta);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Yu Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Recuperacion_de_contraseña";
            Text = "Recuperacion_de_contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textrespuesta;
        private Label lblSecurityQuestion;
        private TextBox textnuevacontraseña;
        private Label label4;
        private TextBox textconfirmar;
        private Label label5;
        private Button btncontraseña;
        private Button btncheck;
        private Label label6;
        private Button btncancel;
        private Label label3;
        private TextBox textEmail;
        private Button buttonConfirmar;
    }
}