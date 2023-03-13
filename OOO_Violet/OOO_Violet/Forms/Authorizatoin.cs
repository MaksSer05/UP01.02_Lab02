using OOO_Violet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Violet
{
    public partial class FAutores : Form
    {
        private OOO_VioletEntities3 local;
        public FAutores()
        {
            InitializeComponent();
            local = new OOO_VioletEntities3();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вошли как Гость");
            Katalog guest = new Katalog();
            this.Hide();
            guest.ShowDialog();
            this.Show();
        }

        private void bAutores_Click(object sender, EventArgs e)
        {
            string login = tblogin.Text;
            string password = tbpassword.Text;

            User flower = local.User.Where(num => num.UserLogin == login & num.UserPassword == password).FirstOrDefault();

            if (login != "" && password != "")
            {
                if (flower != null)
                {
                    MessageBox.Show("Вы вошли как " + flower.UserSurname + " " + flower.UserName + " " + flower.UserPatronymic + " " + flower.Role.RoleName);
                    Helper.UserRole = flower.Role.RoleName;
                    Katalog katalog = new Katalog();
                    this.Hide();
                    katalog.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Не правильный логин или пароль!");

                }

            }
            else
            {
                MessageBox.Show("Введите логин и пароль!");
            }
        }
    }
}
