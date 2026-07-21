using Mis_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Proyecto_Belle
{
    public partial class Perfil : Form
    {

        UsuarioDAO usuarioDAO = new UsuarioDAO();


        bool modoEdicion = false;

        string correoUsuarioActual;
        public Perfil(string correoQueInicioSesion)
        {
            InitializeComponent();

            // Guarda el correo que recuperamos
            this.correoUsuarioActual = correoQueInicioSesion;


            CargarDatos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void CargarDatos()
        {
            // Traemos el usuario completo usando el correo
            Usuario usuario = usuarioDAO.ObtenerUsuarioPorCorreo(correoUsuarioActual);

            if (usuario != null)
            {
                // Llenamos tus TextBox
                textnombre.Text = usuario.nombre;
                textapellido.Text = usuario.apellido;
                textemail.Text = usuario.Correo;
                textnumero.Text = usuario.Telefono;

                if (usuario.FotoPerfil != null)
                {
                    using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
                    {
                        pictureperfil.Image = Image.FromStream(ms);
                    }
                }
            }

            // Bloqueamos los campos para que arranquen en modo lectura
            textnombre.ReadOnly = true;
            textapellido.ReadOnly = true;
            textemail.ReadOnly = true;
            textnumero.ReadOnly = true;

        }


        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (!modoEdicion)
            {
                // PASO 1: Habilitar edición
                textnombre.ReadOnly = false;
                textapellido.ReadOnly = false;
                textemail.ReadOnly = false;
                textnumero.ReadOnly = false;

                btneditar.Text = "Guardar";
                modoEdicion = true;
            }
            else
            {
                // PASO 2: Guardar cambios en la Base de Datos
                bool exito = usuarioDAO.ActualizarUsuario(
                    correoUsuarioActual,
                    textnombre.Text.Trim(),
                    textapellido.Text.Trim(),
                    textemail.Text.Trim(),
                    textnumero.Text.Trim()
                );

                if (exito)
                {
                    MessageBox.Show("Perfil actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si cambió el correo, actualizamos la variable de sesión
                    correoUsuarioActual = textemail.Text.Trim();

                    // Volvemos a bloquear los campos
                    textnombre.ReadOnly = true;
                    textapellido.ReadOnly = true;
                    textemail.ReadOnly = true;
                    textnumero.ReadOnly = true;

                    btneditar.Text = "Editar";
                    modoEdicion = false;
                }
                else
                {
                    MessageBox.Show("No se pudieron guardar los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureperfil_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                pictureperfil.Image = Image.FromFile(ofd.FileName);

               
                byte[] foto = File.ReadAllBytes(ofd.FileName);
                bool exito = usuarioDAO.ActualizarFotoPerfil(correoUsuarioActual, foto);

                if (exito)
                {
                    MessageBox.Show("Foto de perfil actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la foto.");
                }
            }
        }
    }
}
