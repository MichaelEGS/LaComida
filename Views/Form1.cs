using LaComida.Controllers;
using LaComida.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaComida
{
    public partial class Form1 : Form
    {
        private readonly RecetaController _recetaController;
        public Form1()
        {
            InitializeComponent();
            var recetaService = new RecetaService();
            _recetaController = new RecetaController(recetaService);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var nombreReceta = txtNombreReceta.Text;
            var receta = _recetaController.ObtenerReceta(nombreReceta);

            if (receta != null)
            {
                lblNombre.Text = receta.Nombre;
                lstIngredientes.DataSource = receta.Ingredientes;
                txtInstrucciones.Text = receta.Instrucciones;
                picImagen.Load(receta.ImagenUrl);
            }
            else
            {
                MessageBox.Show("Receta no encontrada");
            }
        }
    }
}
