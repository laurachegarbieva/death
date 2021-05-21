using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Торговая_точка.Formy
{
    public partial class FormDobavleniye : Form
    {
        public FormDobavleniye()
        {
            InitializeComponent();
        }

        private void buttonSohranit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Entity.EntityContext())
                {
                    context.Tovar.Add(
                       new Entity.Tovar()
                       {
                           id =Convert.ToInt32(textBoxNomer.Text),
                           naimenovaniye = textBoxName.Text,
                           cena =Convert.ToDecimal( textBoxCena.Text),
                           colichestvo = textBoxColichestvo.Text,
                       });
                    context.SaveChanges();
                    
                }
                MessageBox.Show("Заказ успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка добавления информации в базу данных, проверьте вводимые данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
