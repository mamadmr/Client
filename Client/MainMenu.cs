using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            GlobalData.clerks.Clear();
            var t = new Thread(() => Application.Run(new LogIn_Form()));
            t.Start();
            this.Close();
        }

        private void Clerk_But_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new MyClerkMenu()));
            t.Start();
            this.Close();
        }

        private void Cake_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new CakeMenu_Form()));
            t.Start();
            this.Close();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new CustomerMenu()));
            t.Start();
            this.Close();
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            try
            {
                var t = new Thread(() => Application.Run(new OrderMenu()));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void output_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new OutputMenu()));
            t.Start();
            this.Close();
        }
    }
}
