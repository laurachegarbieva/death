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
    public partial class FormAvtorizaciya : Form
    {
        public FormAvtorizaciya()
        {
            InitializeComponent();
        }

        private void buttonAvtor_Click(object sender, EventArgs e)
        {

            try
            {
                if ((string.IsNullOrEmpty(textBoxParol.Text) || (string.IsNullOrWhiteSpace(textBoxParol.Text)) || (string.IsNullOrEmpty(textBoxLogin.Text) || (string.IsNullOrWhiteSpace(textBoxLogin.Text)))))
                    throw new Exception("Неправельный пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
                try
                {
                   
                    if (textBoxLogin.Text == "user" && textBoxParol.Text == "12345")
                    {
                        Form f_m = new FormRedactirovaniyeDannyh();
                        f_m.Owner = this;
                        f_m.Show();

                    }
                    else throw new Exception("Такого пользователя не существует!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неправильный логин или пороль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            this.Hide();

        }

        private void checkBoxProsmotr_CheckedChanged(object sender, EventArgs e)
        {
         
            textBoxParol.UseSystemPasswordChar = !checkBoxProsmotr.Checked;
        }

        private void FormAvtorizaciya_Load(object sender, EventArgs e)
        {

        }
    }
}







