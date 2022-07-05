using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public partial class OutputMenu : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>();
        public OutputMenu()
        {
            InitializeComponent();
            dataGridView1.DataSource = customers;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new MainMenu()));
            t.Start();
            this.Close();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            long money;
            try
            {
                money = Convert.ToInt64(money_txt.Text);
            }
            catch
            {
                MessageBox.Show("Enter Intiger");
                return;
            }

            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
            request.cutomer = true;
            request.SelectObject = new Customer("**", "", "", "");
            ((Customer)request.SelectObject).Balance = money;

            MySocket mySocket = new MySocket();
            var indented = Formatting.Indented;
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string data = JsonConvert.SerializeObject(request, indented, settings);
            data = mySocket.Request(data);
            var settings2 = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            ServerToClient item = (ServerToClient)JsonConvert.DeserializeObject(data, settings2);
            customers.Clear();
            foreach (var x in item.Objects)
            {
                customers.Add((Customer)x);
            }
        }
    }
}
