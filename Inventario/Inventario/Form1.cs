﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario inv = new Inventario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            inv.agregar(txtCodigo.Text, txtNombre.Text, int.Parse(txtCantidad.Text), double.Parse(txtPrecio.Text));
            limpiarCajas();
        }

        private void limpiarCajas()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            inv.borrar(txtBorrar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto busqueda = inv.buscar(txtBuscar.Text);
            if(busqueda == null)
            {
                MessageBox.Show("El producto no existe");
            }else
            {
                txtNombre.Text = busqueda.getNombre();
                txtCodigo.Text = busqueda.getCodigo();
                txtCantidad.Text = busqueda.getCantidad().ToString();
                txtPrecio.Text = busqueda.getPrecio().ToString();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            inv.insertar(int.Parse(txtPosicion.Text), txtCodigo.Text, txtNombre.Text, int.Parse(txtCantidad.Text), double.Parse(txtPrecio.Text));
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inv.reporte();            
        }
    }
}
