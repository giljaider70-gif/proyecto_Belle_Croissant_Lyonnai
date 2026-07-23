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
    public partial class Agregardireccion : Form
    {
        public Agregardireccion()
        {
            InitializeComponent();
            Cargar_Paisies();
            Cargar_Ciudad();

        }

        Usuario usuario = new Usuario();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Direccion direccion = new Direccion();
        DireccionDAO direccionDAO = new DireccionDAO();
        Pais pais = new Pais();

        public void Cargar_Paisies()
        {
            PaisDAO paisDAO = new PaisDAO();
            List<Pais> pais_que_cargara_los_datos = paisDAO.Mostra_Pais();

            combopais.DataSource = pais_que_cargara_los_datos;
            combopais.DisplayMember = "NombrePais";
            combociudad.ValueMember = "IdPais";

            combopais.SelectedIndex = -1;
        }

        public void Cargar_Ciudad()
        {
            CiudadDAO ciudad = new CiudadDAO();
            List<Ciudad> lista_ciudad = ciudad.Mostra_Ciudad();

            combociudad.DataSource = lista_ciudad;
            combociudad.DisplayMember = "Nombre";
            combociudad.ValueMember = "IdCiudad";

            combociudad.SelectedIndex = -1;
        }








        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
