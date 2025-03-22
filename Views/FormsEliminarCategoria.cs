using aplicacionInventario4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionInventario4.Views
{
    public partial class FormsEliminarCategoria : Form
    {
        public Form1 myBaseForm;
        public FormsCategorias mySecondForm;

        public FormsEliminarCategoria(FormsCategorias mySecondForm)
        {
            InitializeComponent();
            this.myBaseForm = mySecondForm.myBaseForm;
            this.mySecondForm = mySecondForm;
            EliminarCategoriaIdComboBox.DataSource = mySecondForm.myBaseForm.categorias;
        }

        public void eliminarCategoria()
        {
            Categoria tmpCategoria = (Categoria)EliminarCategoriaIdComboBox.SelectedItem;
            
            this.myBaseForm.categorias.Remove(tmpCategoria);
        }

        private void ConfirmarEliminarCategoriaButton_Click(object sender, EventArgs e)
        {
            eliminarCategoria();

            FormsCategorias tempFormsCategorias = new FormsCategorias(this.myBaseForm);
            tempFormsCategorias.Show();
            this.Hide();
        }

        private void EliminarCategoriaIdComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
