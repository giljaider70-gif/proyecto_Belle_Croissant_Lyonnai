using Microsoft.Data.SqlClient;
using Mis_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Belle
{
    public partial class Recuperacion_de_contraseña : Form
    {
        private int idUsuarioActual = 0;


        public Recuperacion_de_contraseña()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Recuperacion_de_contraseña_Load);

            lblSecurityQuestion.Enabled = false;       // o la etiqueta de la pregunta
            textrespuesta.Enabled = false;
            btncheck.Enabled = false; // el botón de validar respuesta

            // Paso 3 (Nueva contraseña)
            textnuevacontraseña.Enabled = false;
            textconfirmar.Enabled = false;
            btncontraseña.Enabled = false;
        }

        public Recuperacion_de_contraseña(int idusuario) : this()
        {
            this.idUsuarioActual = idusuario;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Recuperacion_de_contraseña_Load(object sender, EventArgs e)
        {
            // 1. Al iniciar, inhabilitamos la sección de la nueva contraseña
            textnuevacontraseña.Enabled = false;
            textconfirmar.Enabled = false;
            btncontraseña.Enabled = false;

            // 2. Traemos la pregunta de seguridad del usuario a la etiqueta
            CargarPreguntaSeguridad();

        }

        private void CargarPreguntaSeguridad()
        {
            PreguntaSeguridadDAO preguntaDao = new PreguntaSeguridadDAO();
            // Aquí obtienes el texto de la pregunta asociada a este idUsuarioActual
            string pregunta = preguntaDao.ObtenerPreguntaPorUsuario(idUsuarioActual);
            lblSecurityQuestion.Text = pregunta;
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            string respuesta = textrespuesta.Text;

            if (string.IsNullOrWhiteSpace(respuesta))
            {
                MessageBox.Show("Por favor ingresa tu respuesta de seguridad.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioDAO dao = new UsuarioDAO();
            bool esCorrecta = dao.ValidarRespuestaSeguridad(idUsuarioActual, respuesta);

            if (esCorrecta)
            {
                MessageBox.Show("¡Respuesta correcta! Ahora puedes ingresar tu nueva contraseña.", "Verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Habilitamos los controles para la nueva contraseña
                textnuevacontraseña.Enabled = true;
                textconfirmar.Enabled = true;
                btncontraseña.Enabled = true;

                // Bloqueamos la respuesta para que no la modifiquen
                textrespuesta.Enabled = false;
                btncheck.Enabled = false;
            }
            else
            {
                MessageBox.Show("La respuesta de seguridad es incorrecta.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncontraseña_Click(object sender, EventArgs e)
        {
            string pass1 = textnuevacontraseña.Text;
            string pass2 = textconfirmar.Text;

            if (string.IsNullOrWhiteSpace(pass1) || string.IsNullOrWhiteSpace(pass2))
            {
                MessageBox.Show("Debes completar ambos campos de contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden. Verifícalas bien.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioDAO dao = new UsuarioDAO();
            bool cambiado = dao.ActualizarContrasena(idUsuarioActual, pass1);

            if (cambiado)
            {
                MessageBox.Show("¡Contraseña actualizada con éxito! Redirigiendo al inicio de sesión...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 1. Instanciamos y mostramos el Login
                Form1 login = new Form1();
                login.Show();

                // 2. Cerramos la ventana de recuperación
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un problema al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string correo = textEmail.Text.Trim(); // Asegúrate de que tu TextBox de email se llame así

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor ingresa tu correo electrónico.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Usamos el método de UsuarioDAO para buscar el ID
            UsuarioDAO dao = new UsuarioDAO();
            idUsuarioActual = dao.ObtenerIdPorCorreo(correo);

            // 3. Verificamos si existe
            if (idUsuarioActual > 0)
            {
                // Cargas la pregunta del usuario recién encontrado
                CargarPreguntaSeguridad();

                MessageBox.Show("Usuario encontrado. Responde tu pregunta de seguridad.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textEmail.Enabled = false;
                buttonConfirmar.Enabled = false;

                textrespuesta.Enabled = true;
                btncheck.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontró ningún usuario con ese correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
