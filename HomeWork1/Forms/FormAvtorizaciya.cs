using HomeWork1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork1
{
    public partial class FormAvtorizaciya : Form
    {
        public string login = "login1";
        

        public FormAvtorizaciya()
        {
            InitializeComponent();
           
        }

        private void buttonAvtor_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(textBoxDannye.Text) || (string.IsNullOrWhiteSpace(textBoxDannye.Text)) || (string.IsNullOrEmpty(textBoxPassword.Text) || (string.IsNullOrWhiteSpace(textBoxPassword.Text)))))
                    throw new Exception("Неправельный пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание","Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (textBoxDannye.Text == "tuptup" && textBoxPassword.Text == login)
                {
                    Form f_m = new FormMeneger(login);
                    f_m.Owner = this;
                    f_m.Show();

                }
                else throw new Exception("Такого пользователя не существует!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", "Неправильный логин или пороль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();


        }

        private void checkBoxPokazat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPokazat.Checked == true)
                textBoxDannye.PasswordChar = '\0';
            else textBoxDannye.PasswordChar = '*';
        }
    }
}
