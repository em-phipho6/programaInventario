﻿using aplicacionInventario4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionInventario4
{
    public partial class FormsInventario : Form
    {
        public Form1 myBaseForm;
        public int cantidadMinima = 10;
        public FormsInventario(Form1 myBaseForm)
        {
            InitializeComponent();
            this.myBaseForm = myBaseForm;
            ProductosDataGridView.CellFormatting += ProductosDataGridView_CellFormatting;
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            FormsAgregarProducto tempAgregarProducto;
            tempAgregarProducto = new FormsAgregarProducto(this);
            tempAgregarProducto.Show();
        }

        public void refrescarProductosDataGridView()
        {
            var source = new BindingSource();
            source.DataSource = myBaseForm.materiales;

            //this.ProductosDataGridView = null;
            this.ProductosDataGridView.DataSource = source;
            this.ProductosDataGridView.Update();
            this.ProductosDataGridView.Refresh();
        }

        private void ProductosDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.refrescarProductosDataGridView();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormsInventario_Load(object sender, EventArgs e)
        {

        }

        private void ProductosDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {/*
            for (int i = 0; i < ProductosDataGridView.Rows[e.RowIndex].Cells.Count; i++)
            {
                ProductosDataGridView[i, e.RowIndex].Style.BackColor = Color.Yellow;
            }*/
        }

        private void ProductosDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            for (int i = 0; i < ProductosDataGridView.Rows[e.RowIndex].Cells.Count; i++)
            {
                ProductosDataGridView[i, e.RowIndex].Style.BackColor = Color.Empty;
            }
        }

        private void ProductosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cantidadMinima = 10;

            foreach(DataGridViewRow row in ProductosDataGridView.Rows){
                for (int i = 1; i < row.Cells.Count; i++) {
                    if (row.Cells[i].Value != null) {
                        if (Convert.ToDouble(row.Cells[4].Value) >= cantidadMinima){
                            row.Cells[4].Style.BackColor = Color.Green;
                        }
                        else if(Convert.ToDouble(row.Cells[4].Value) < cantidadMinima){
                            row.Cells[4].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
