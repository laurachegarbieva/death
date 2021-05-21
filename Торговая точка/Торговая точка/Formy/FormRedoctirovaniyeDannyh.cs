using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Торговая_точка
{
    public partial class FormRedactirovaniyeDannyh : Form
    {

        private struct Tovar
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal cena { get; set; }
            public string colichestvo { get; set; }
        }


        public FormRedactirovaniyeDannyh()
        {
            InitializeComponent();
            InitializeDataGridBd();
        }
        private void InitializeDataGridBd()
        {
            List<Tovar> tovars = new List<Tovar>();
            BindDataGrid();
            LoadData(tovars);
            SetDataSource(tovars);
        }
        private void BindDataGrid()
        {
            ColumnId.DataPropertyName = nameof(Tovar.id);
            ColumnName.DataPropertyName = nameof(Tovar.name);
            ColumnCena.DataPropertyName = nameof(Tovar.cena);
            ColumnColichestvo.DataPropertyName = nameof(Tovar.colichestvo);
        }

        private void LoadData(List<Tovar> list)
        {
            using (Entity.EntityContext context = new Entity.EntityContext())
            {
                foreach (var item in context.Tovar)
                {
                    try
                    {
                        list.Add(new Tovar()
                        {
                            id = item.id,
                            name = item.naimenovaniye,
                            cena = item.cena,
                            colichestvo = item.colichestvo,
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR" + ex.ToString());
                    }
                }
            }
        }
        private void SetDataSource(List<Tovar> list)
        {
            dataGridViewBd.DataSource = list;
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            Form f_CO = new Formy.FormDobavleniye();
            f_CO.ShowDialog();
        }

        private void FormRedactirovaniyeDannyh_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUdalit_Click(object sender, EventArgs e)
        {
            using (Entity.EntityContext context = new Entity.EntityContext())
            {
                if (dataGridViewBd.SelectedRows.Count != 1)
                    return;
                int selectedItemIndex = dataGridViewBd.SelectedRows[0].Index;
                int tovarid = Convert.ToInt32(dataGridViewBd[0, selectedItemIndex].Value);

                var tovar = context.Tovar.FirstOrDefault(_tovar => (_tovar.id == tovarid));

                context.Tovar.Remove(tovar);
                context.SaveChanges();
                InitializeDataGridBd();
            }
        }
    }
}
