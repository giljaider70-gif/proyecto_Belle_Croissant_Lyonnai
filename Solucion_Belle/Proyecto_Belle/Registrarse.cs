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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            // 1. Instanciamos tu clase DAO
            PreguntaSeguridadDAO preguntaDAO = new PreguntaSeguridadDAO();

            try
            {
                // 2. Llamamos al  método exacto de ( Obtener_PreguntasSeguridad(); )
                List<PreguntaSeguridad> listaPreguntas = preguntaDAO.Obtener_PreguntasSeguridad();

                // 3. Le pasamos la lista de objetos al ComboBox
                combopregunta.DataSource = listaPreguntas;

                // 4. Le decimos qué propiedades de tu clase debe usar
                combopregunta.DisplayMember = "Pregunta";   // Lo que el usuario lee en el combo
                combopregunta.ValueMember = "IdPregunta";   // El número interno (1, 2, 3...) que guardaremos

                // 5. Lo dejamos vacío por defecto para obligar al usuario a q escoja una de las opciones 
                combopregunta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las preguntas de seguridad: " + ex.Message,
                                "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN: Revisar que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(textnombre.Text) ||
                string.IsNullOrWhiteSpace(textapellido.Text) ||
                string.IsNullOrWhiteSpace(textemail.Text) ||
                string.IsNullOrWhiteSpace(textcontraseña.Text) ||
                string.IsNullOrWhiteSpace(textconfirmarcontraseña.Text) ||
                string.IsNullOrWhiteSpace(textrespuesta.Text) ||
                combopregunta.SelectedValue == null)
            {
                MessageBox.Show("Por favor, llena todos los campos del formulario.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución para que no intente registrar
            }

            // 2. VALIDACIÓN: Verificar que las contraseñas coincidan
            if (textcontraseña.Text != textconfirmarcontraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtalo de nuevo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 3. CAPTURAR DATOS: Tomamos los valores de tus controles
                string nombre = textnombre.Text.Trim();
                string apellido = textapellido.Text.Trim();
                string correo = textemail.Text.Trim();
                string contraseña = textcontraseña.Text; // En texto plano como querías para pruebas
                string respuesta = textrespuesta.Text.Trim();

                // Convertimos el SelectedValue del ComboBox a entero para el idpregunta
                int idpregunta = Convert.ToInt32(combopregunta.SelectedValue);

                // 4. EJECUTAR REGISTRO: Instanciamos tu DAO y llamamos al método
                UsuarioDAO v_usuarioDAO = new UsuarioDAO();
                bool registroExitoso = v_usuarioDAO.RegistrarUsuario(nombre, apellido, correo, contraseña, idpregunta, respuesta);

                if (registroExitoso)
                {
                    MessageBox.Show("¡Usuario registrado con éxito!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: Aquí puedes limpiar los TextBox o cerrar este formulario
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Si el DAO atrapa un error en la base de datos, saltará aquí
                MessageBox.Show(ex.Message, "Error en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método opcional para dejar los campos limpios después de registrar
        private void LimpiarCampos()
        {
            textnombre.Clear();
            textapellido.Clear();
            textemail.Clear();
            textcontraseña.Clear();
            textconfirmarcontraseña.Clear();
            textrespuesta.Clear();
            combopregunta.SelectedIndex = -1; // Desselecciona la pregunta
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
