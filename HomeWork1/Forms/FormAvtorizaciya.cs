using HomeWork1.Entity;
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
                if ((string.IsNullOrEmpty(textBoxPassword.Text) || (string.IsNullOrWhiteSpace(textBoxPassword.Text)) || (string.IsNullOrEmpty(textBoxlogin.Text) || (string.IsNullOrWhiteSpace(textBoxlogin.Text)))))
                    throw new Exception("Неправельный пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание","Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var bd = new EntityContext())
                try
                {
                    var logpas = bd.managers.FirstOrDefault(u => u.Login == textBoxlogin.Text && u.Password == textBoxPassword.Text);
                    if (logpas != null)
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
                textBoxPassword.PasswordChar = '\0';
            else textBoxPassword.PasswordChar = '*';
        }
    }
}
