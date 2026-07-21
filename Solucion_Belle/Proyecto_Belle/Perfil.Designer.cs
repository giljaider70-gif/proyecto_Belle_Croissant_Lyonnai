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
            groupBox1 = new GroupBox();
            button3 = new Button();
            listView2 = new ListView();
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnactualizarfoto = new Button();
            btneditar = new Button();
            btnsalir = new Button();
            label6 = new Label();
            pictureperfil = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureperfil).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 60);
            label1.Name = "label1";
            label1.Size = new Size(65, 16);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 118);
            label2.Name = "label2";
            label2.Size = new Size(61, 16);
            label2.TabIndex = 1;
            label2.Text = "last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 179);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 2;
            label3.Text = "Email adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 238);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 3;
            label4.Text = "Phone number";
            // 
            // textnumero
            // 
            textnumero.Location = new Point(129, 234);
            textnumero.Name = "textnumero";
            textnumero.Size = new Size(177, 27);
            textnumero.TabIndex = 4;
            // 
            // textemail
            // 
            textemail.Location = new Point(129, 171);
            textemail.Name = "textemail";
            textemail.Size = new Size(177, 27);
            textemail.TabIndex = 5;
            // 
            // textapellido
            // 
            textapellido.Location = new Point(129, 112);
            textapellido.Name = "textapellido";
            textapellido.Size = new Size(177, 27);
            textapellido.TabIndex = 6;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(129, 52);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(177, 27);
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
            checkemail.Location = new Point(383, 247);
            checkemail.Name = "checkemail";
            checkemail.Size = new Size(86, 20);
            checkemail.TabIndex = 8;
            checkemail.Text = "checkBox1";
            checkemail.UseVisualStyleBackColor = true;
            // 
            // radiopreferido
            // 
            radiopreferido.AutoSize = true;
            radiopreferido.Location = new Point(510, 213);
            radiopreferido.Name = "radiopreferido";
            radiopreferido.Size = new Size(97, 20);
            radiopreferido.TabIndex = 9;
            radiopreferido.TabStop = true;
            radiopreferido.Text = "radioButton1";
            radiopreferido.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(646, 213);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(97, 20);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 183);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(334, 23);
            button3.Name = "button3";
            button3.Size = new Size(28, 34);
            button3.TabIndex = 2;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(14, 96);
            listView2.Name = "listView2";
            listView2.Size = new Size(314, 24);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(14, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(314, 24);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(391, 176);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 213);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 13;
            label5.Text = "preferred delivery";
            // 
            // btnactualizarfoto
            // 
            btnactualizarfoto.Location = new Point(397, 185);
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
            label6.Location = new Point(358, 9);
            label6.Name = "label6";
            label6.Size = new Size(103, 35);
            label6.TabIndex = 17;
            label6.Text = "Profile";
            // 
            // pictureperfil
            // 
            pictureperfil.Location = new Point(394, 47);
            pictureperfil.Name = "pictureperfil";
            pictureperfil.Size = new Size(266, 122);
            pictureperfil.TabIndex = 18;
            pictureperfil.TabStop = false;
            pictureperfil.Click += pictureperfil_Click;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(pictureperfil);
            Controls.Add(label6);
            Controls.Add(btnsalir);
            Controls.Add(btneditar);
            Controls.Add(btnactualizarfoto);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureperfil).EndInit();
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
        private GroupBox groupBox1;
        private ListView listView1;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btnactualizarfoto;
        private Button btneditar;
        private ListView listView2;
        private Button button3;
        private Button btnsalir;
        private Label label6;
        private PictureBox pictureperfil;
    }
}