using ExemploEntityFramework.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                dataGridView2.DataSource = db.Categorias.ToList();
            }
        }
    }
}
