using LaComida.Controllers;
using LaComida.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            

            BtnTurorial.Enabled = false;
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreReceta.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de una receta antes de buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnTurorial.Enabled = false;
                return;
            }

            lstIngredientes.Items.Clear();
            var nombreReceta = txtNombreReceta.Text;
            var receta = _recetaController.ObtenerReceta(nombreReceta);

            if (receta != null)
            {
                lblNombre.Text = receta.Nombre;
                txtInstrucciones.Text = receta.Instrucciones;
                picImagen.Load(receta.ImagenUrl);

                for (int i = 0; i < receta.Ingredientes.Count; i++)
                {
                    var ingrediente = receta.Ingredientes[i];
                    var medida = receta.Medidas[i];
                    lstIngredientes.Items.Add($"{ingrediente} - {medida}");
                }
                BtnTurorial.Enabled = !string.IsNullOrEmpty(receta.TutorialUrl);
            }
            else
            {
                MessageBox.Show("Receta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnTurorial.Enabled = false;
            }
        }

        private void BtnTurorial_Click(object sender, EventArgs e)
        {
            var receta = _recetaController.ObtenerReceta(txtNombreReceta.Text.Trim());

            if (receta != null && !string.IsNullOrEmpty(receta.TutorialUrl))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = receta.TutorialUrl,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No hay tutorial disponible para esta receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}


