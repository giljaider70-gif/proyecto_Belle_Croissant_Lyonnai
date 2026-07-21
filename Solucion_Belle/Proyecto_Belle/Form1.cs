using Mis_Clases;


namespace Proyecto_Belle
{

    public partial class Form1 : Form
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacion_de_contraseña recuperacion = new Recuperacion_de_contraseña();
            recuperacion.Show();
            this.Hide();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {

            Registrarse registro = new Registrarse();
            registro.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textemail.Text) || string.IsNullOrWhiteSpace(textcontraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Traemos los datos que el usuario escribió en la interfaz
                string correo = textemail.Text.Trim();
                string contrasena = textcontraseña.Text.Trim();

                // 3. Llamamos al método de la base de datos
                Usuario usuarioObtenido = usuarioDAO.ValidarLogin(correo, contrasena);

                // 4. Si el usuario existe (no es null), el login es correcto
                if (usuarioObtenido != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Perfil perfil = new Perfil(correo);
                    perfil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña ingresados son incorrectos. Por favor, verifique sus datos.",
                                    "Error de Autenticación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    this.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}

