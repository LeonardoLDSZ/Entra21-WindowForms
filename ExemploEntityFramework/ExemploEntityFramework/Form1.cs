using ExemploEntityFramework.Dominio;
using System;
using System.Data.Entity;
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

            if (categoriaBindingSource.Current == null) return;

            using (var form =
                new FormCategoria(
                    categoriaBindingSource.Current as Categoria))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    var categoria = categoriaBindingSource.Current as Categoria;

                    using (var db = new AppDBContext())
                    {
                        if (db.Entry(categoria).State == EntityState.Detached)
                        {
                            db.Set<Categoria>().Attach(categoria);
                        }
                        if (categoria.Id == 0)
                        {
                            db.Entry(categoria).State = EntityState.Added;
                        }
                        else
                        {
                            db.Entry(categoria).State = EntityState.Modified;
                        }

                        if (db.SaveChanges() > 0)
                        {
                            dataGridView2.Refresh();
                        }
                    }


                }
            }

            //if (categoriaBindingSource.Current == null) return;
            //using (var form = new FormCategoria(categoriaBindingSource.Current as Categoria));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var categoria = categoriaBindingSource.Current as Categoria;
            if (categoria == null) return;
            using (var db = new AppDBContext())
            {
                if (db.Entry(categoria).State == EntityState.Detached)
                {
                    db.Set<Categoria>().Attach(categoria);
                }

                db.Entry(categoria).State = EntityState.Deleted;
                if (db.SaveChanges() > 0)
                {
                    categoriaBindingSource.Remove(categoria);
                    dataGridView2.Refresh();
                }
            }
        }
    }
}
