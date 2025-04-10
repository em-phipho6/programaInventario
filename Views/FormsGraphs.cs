﻿using aplicacionInventario4.Models;
using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Material = aplicacionInventario4.Models.Material;

namespace aplicacionInventario4.Views
{
    public partial class FormsGraphs : Form
    {
        public Form1 myBaseForm;
        public FormsInventario mySecondForm;

        public FormsGraphs(Form1 myBaseForm, FormsInventario mySecondForm)
        {
            InitializeComponent();
            this.myBaseForm = myBaseForm;
            this.mySecondForm = mySecondForm;
        }

        private void FormsGraphs_Load(object sender, EventArgs e)
        {
            foreach (Material material  in myBaseForm.materiales)
            {
                GraficaCantidadProducto.Series["Cantidad"].Points.AddXY(material.DescripcionMaterial, material.Cantidad);
                GraficaCantidadProducto.Series["Cantidad"].AxisLabel = material.DescripcionMaterial;
                GraficaCantidadProducto.Series["Cantidad"].Label = Convert.ToString(material.Cantidad);

                if (material.Cantidad < mySecondForm.cantidadMinima)
                {
                    GraficaCantidadProducto.Series["Cantidad"].Color = Color.Red;
                }
                else if (material.Cantidad >= mySecondForm.cantidadMinima)
                {
                    GraficaCantidadProducto.Series["Cantidad"].Color = Color.Green;                
                }
            }
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
