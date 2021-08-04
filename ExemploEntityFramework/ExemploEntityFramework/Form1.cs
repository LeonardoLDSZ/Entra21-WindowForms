using ExemploEntityFramework.Dominio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExemploEntityFramework
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                categoriaBindingSource.DataSource = db.Categorias.ToList();
                dataGridView2.DataSource = db.Categorias.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoria1 = new Categoria();
            if (sender == button1)
            {
                categoriaBindingSource.Add(categoria1);
                categoriaBindingSource.MoveLast();

            }

            //if (categoriaBindingSource.Current == null) return;
            //using (var form = new FormCategoria(categoriaBindingSource.Current as Categoria));
        }
    }
}
