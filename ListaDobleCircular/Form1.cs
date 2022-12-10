using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleCircular
{
    public partial class Form1 : Form
    {
        Lista miLista = new Lista();

        public Form1()
        {
            InitializeComponent();
        }
        //Lista nueva= new Lista();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Nodo n= new Nodo();
            n.Dato = int.Parse(txtdato.Text);
            miLista.Agregar(n);
            
            //txtdato.Clear
            miLista.ImprimirPU();
            txtdato.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtdato.Text);
            miLista.Eliminar(dato);
            miLista.ImprimirPU();
            txtdato.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dato = 0;
            try
            { dato = int.Parse(txtdato.Text); }
            catch
            { }
            if (miLista.Buscar(dato))
            {
                MessageBox.Show("Encontrado");
                return;
            }
            MessageBox.Show("No encontrado");
            txtdato.Clear();
        }
        
    }
}
