using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRecetas
{
    public partial class FormRecetas : Form
    {
        public FormRecetas()
        {
            InitializeComponent();




        }
        Dictionary<string, string> receta3 = new Dictionary<string, string>();
        private void btnNuevaRe_Click(object sender, EventArgs e)
        {
            string nombreReceta = txtNombre.Text;

            string ingredienteReceta = txtIngredientes.Text;

            if (nombreReceta != "" && ingredienteReceta != "")
            {
                List<Dictionary<string, string>> receta = new List<Dictionary<string, string>>();



                receta.Add(nombreReceta);
                receta.Add(ingredienteReceta);


                receta3.Add("Nombre", nombreReceta);
                receta3.Add("ingredientes",ingredienteReceta);
                printdgvLista();
            }











        }
        public void printdgvLista() { 








        }
    }
}
