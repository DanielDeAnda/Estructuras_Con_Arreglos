using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalogoVectores
{
    public partial class Form1 : Form
    {
        Registro nuevo = new Registro();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Placa = txtPlacas.Text;
            string Marca = txtMarca.Text;
            string Modelo = txtModelo.Text;
            string Año = txtAño.Text;
            string Telefono = txtTelefono.Text;
            nuevo.Agregar(Placa,Marca,Modelo,Año,Telefono);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nuevo.eliminar(txtPlacas.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string Placa = txtPlacas.Text;
            string Marca = txtMarca.Text;
            string Modelo = txtModelo.Text;
            string Año = txtAño.Text;
            string Telefono = txtTelefono.Text;
            nuevo.insertar(Placa, Marca, Modelo, Año, Telefono);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            txtLista.Text=nuevo.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nuevo.Buscar(txtPlacas.Text);
        }
    }
}
