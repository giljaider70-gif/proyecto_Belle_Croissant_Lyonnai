namespace Proyecto_Belle
{
    partial class Perfil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textnumero = new TextBox();
            textemail = new TextBox();
            textapellido = new TextBox();
            textnombre = new TextBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            checkemail = new CheckBox();
            radiopreferido = new RadioButton();
            radioButton2 = new RadioButton();
            buttondirrecion = new Button();
            label5 = new Label();
            btnactualizarfoto = new Button();
            btneditar = new Button();
            btnsalir = new Button();
            label6 = new Label();
            pictureperfil = new PictureBox();
            datagregardireccion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureperfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagregardireccion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 118);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 179);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Email adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 238);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone number";
            // 
            // textnumero
            // 
            textnumero.Location = new Point(129, 234);
            textnumero.Name = "textnumero";
            textnumero.Size = new Size(177, 32);
            textnumero.TabIndex = 4;
            // 
            // textemail
            // 
            textemail.Location = new Point(129, 171);
            textemail.Name = "textemail";
            textemail.Size = new Size(177, 32);
            textemail.TabIndex = 5;
            // 
            // textapellido
            // 
            textapellido.Location = new Point(129, 112);
            textapellido.Name = "textapellido";
            textapellido.Size = new Size(177, 32);
            textapellido.TabIndex = 6;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(129, 52);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(177, 32);
            textnombre.TabIndex = 7;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // checkemail
            // 
            checkemail.AutoSize = true;
            checkemail.Enabled = false;
            checkemail.Location = new Point(383, 247);
            checkemail.Name = "checkemail";
            checkemail.Size = new Size(195, 24);
            checkemail.TabIndex = 8;
            checkemail.Text = "subscribe to mailing list";
            checkemail.UseVisualStyleBackColor = true;
            // 
            // radiopreferido
            // 
            radiopreferido.AutoSize = true;
            radiopreferido.Location = new Point(530, 211);
            radiopreferido.Name = "radiopreferido";
            radiopreferido.Size = new Size(77, 24);
            radiopreferido.TabIndex = 9;
            radiopreferido.TabStop = true;
            radiopreferido.Text = "pickup";
            radiopreferido.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(651, 211);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Delivelivery";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // buttondirrecion
            // 
            buttondirrecion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondirrecion.Location = new Point(12, 488);
            buttondirrecion.Name = "buttondirrecion";
            buttondirrecion.Size = new Size(102, 34);
            buttondirrecion.TabIndex = 2;
            buttondirrecion.Text = "+";
            buttondirrecion.UseVisualStyleBackColor = true;
            buttondirrecion.Click += buttondirrecion_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 213);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 13;
            label5.Text = "preferred delivery";
            // 
            // btnactualizarfoto
            // 
            btnactualizarfoto.Location = new Point(491, 180);
            btnactualizarfoto.Name = "btnactualizarfoto";
            btnactualizarfoto.Size = new Size(75, 25);
            btnactualizarfoto.TabIndex = 14;
            btnactualizarfoto.Text = "Upload";
            btnactualizarfoto.UseVisualStyleBackColor = true;
            btnactualizarfoto.Click += btnactualizarfoto_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(683, 47);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 25);
            btneditar.TabIndex = 15;
            btneditar.Text = "Edit";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click_1;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(683, 91);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 25);
            btnsalir.TabIndex = 16;
            btnsalir.Text = "log out";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 9);
            label6.Name = "label6";
            label6.Size = new Size(128, 44);
            label6.TabIndex = 17;
            label6.Text = "Profile";
            // 
            // pictureperfil
            // 
            pictureperfil.Location = new Point(456, 47);
            pictureperfil.Name = "pictureperfil";
            pictureperfil.Size = new Size(172, 122);
            pictureperfil.TabIndex = 18;
            pictureperfil.TabStop = false;
            pictureperfil.Click += pictureperfil_Click;
            // 
            // datagregardireccion
            // 
            datagregardireccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagregardireccion.Location = new Point(12, 330);
            datagregardireccion.Name = "datagregardireccion";
            datagregardireccion.RowHeadersWidth = 51;
            datagregardireccion.Size = new Size(391, 152);
            datagregardireccion.TabIndex = 12;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(buttondirrecion);
            Controls.Add(pictureperfil);
            Controls.Add(label6);
            Controls.Add(btnsalir);
            Controls.Add(btneditar);
            Controls.Add(btnactualizarfoto);
            Controls.Add(label5);
            Controls.Add(datagregardireccion);
            Controls.Add(radioButton2);
            Controls.Add(radiopreferido);
            Controls.Add(checkemail);
            Controls.Add(textnombre);
            Controls.Add(textapellido);
            Controls.Add(textemail);
            Controls.Add(textnumero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Perfil";
            Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureperfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagregardireccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textnumero;
        private TextBox textemail;
        private TextBox textapellido;
        private TextBox textnombre;
        private ImageList imageList1;
        private ImageList imageList2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private CheckBox checkemail;
        private RadioButton radiopreferido;
        private RadioButton radioButton2;
        private ListView listView1;
        private Label label5;
        private Button btnactualizarfoto;
        private Button btneditar;
        private ListView listView2;
        private Button buttondirrecion;
        private Button btnsalir;
        private Label label6;
        private PictureBox pictureperfil;
        private DataGridView datagregardireccion;
    }
}