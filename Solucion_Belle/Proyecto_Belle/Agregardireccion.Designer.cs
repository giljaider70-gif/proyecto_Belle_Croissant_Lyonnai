namespace Proyecto_Belle
{
    partial class Agregardireccion
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
            textdireccion = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            btnagregar = new Button();
            btncancelar = new Button();
            label4 = new Label();
            textcodigopostal = new TextBox();
            combopais = new ComboBox();
            combociudad = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textdireccion
            // 
            textdireccion.Location = new Point(225, 228);
            textdireccion.Name = "textdireccion";
            textdireccion.Size = new Size(125, 27);
            textdireccion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 235);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "direccion";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(217, 337);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkespreferido";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(444, 189);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 29);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "btnagregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(444, 261);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(94, 29);
            btncancelar.TabIndex = 9;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 291);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 11;
            label4.Text = "codigogostal";
            // 
            // textcodigopostal
            // 
            textcodigopostal.Location = new Point(225, 288);
            textcodigopostal.Name = "textcodigopostal";
            textcodigopostal.Size = new Size(125, 27);
            textcodigopostal.TabIndex = 10;
            // 
            // combopais
            // 
            combopais.FormattingEnabled = true;
            combopais.Location = new Point(220, 100);
            combopais.Name = "combopais";
            combopais.Size = new Size(130, 28);
            combopais.TabIndex = 12;
            // 
            // combociudad
            // 
            combociudad.FormattingEnabled = true;
            combociudad.Location = new Point(217, 169);
            combociudad.Name = "combociudad";
            combociudad.Size = new Size(130, 28);
            combociudad.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 177);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 14;
            label1.Text = "ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 103);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 15;
            label2.Text = "pais";
            // 
            // Agregardireccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combociudad);
            Controls.Add(combopais);
            Controls.Add(label4);
            Controls.Add(textcodigopostal);
            Controls.Add(btncancelar);
            Controls.Add(btnagregar);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textdireccion);
            Name = "Agregardireccion";
            Text = "Agregardireccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textdireccion;
        private Label label3;
        private CheckBox checkBox1;
        private Button btnagregar;
        private Button btncancelar;
        private Label label4;
        private TextBox textcodigopostal;
        private ComboBox combopais;
        private ComboBox combociudad;
        private Label label1;
        private Label label2;
    }
}