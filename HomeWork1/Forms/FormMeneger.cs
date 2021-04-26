using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork1.Forms
{
    public partial class FormMeneger : Form
    {
        public FormMeneger(string login)
        {
            InitializeComponent();
        }

        private void buttonOform_Click(object sender, EventArgs e)
        {
            FormZakazy newFormMeneger = new FormZakazy();
            newFormMeneger.Show();
        }
    }
}
