using LaComida.Controllers;
using LaComida.Services;
using LaComida.Views;
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

namespace LaComida
{
    public partial class Form1 : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        private readonly RecetaController _recetaController;
        public Form1()
        {
            InitializeComponent();
            var recetaService = new RecetaService();
            _recetaController = new RecetaController(recetaService);
            //LoadTema();
            //UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            //SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }

        //private void LoadTema()
        //{
        //    throw new NotImplementedException();
        //}


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstIngredientes.Items.Clear();
            var nombreReceta = txtNombreReceta.Text;
            var receta = _recetaController.ObtenerReceta(nombreReceta);

            if (receta != null)
            {
                lblNombre.Text = receta.Nombre;
                //lstIngredientes.DataSource = receta.Ingredientes;
                txtInstrucciones.Text = receta.Instrucciones;
                picImagen.Load(receta.ImagenUrl);

                for (int i = 0; i < receta.Ingredientes.Count; i++)
                {
                    var ingrediente = receta.Ingredientes[i];
                    var medida = receta.Medidas[i];
                    lstIngredientes.Items.Add($"{ingrediente} - {medida}");
                }
            }
            else
            {
                MessageBox.Show("Receta no encontrada");
            }
        }
        //private void LoadTema()
        //{
        //    var themeColor = TemaWindows.GetAccentColor();//Windows Accent Color
        //    var lightColor = ControlPaint.Light(themeColor);
        //    var darkColor = ControlPaint.Dark(themeColor);
        //    //panelBarra.BackColor = themeColor;
        //    panelFondo.BackColor = lightColor;
        //    //panelLine.BackColor = lightColor;
        //    //picImagen.BorderColor = themeColor;
        //    lblNombre.ForeColor = lightColor;
        //    btnBuscar.BackColor = darkColor;
        //    //Buttons
        //    foreach (Button button in this.Controls.OfType<Button>())
        //    {
        //        button.BackColor = themeColor;
        //    }
        //    foreach (Button button in this.panelFondo.Controls.OfType<Button>())
        //    {
        //        button.FlatAppearance.MouseOverBackColor = themeColor;
        //        button.FlatAppearance.MouseDownBackColor = lightColor;
        //    }
        //}
        //private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        //{
        //    if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
        //    {
        //        LoadTema();
        //    }
        //}
        //private void Form_Disposed(object sender, EventArgs e)
        //{
        //    SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        //}
    }
}


