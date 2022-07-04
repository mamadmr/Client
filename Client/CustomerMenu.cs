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
    public partial class CustomerMenu : Form
    {
        System.Random random;
        public CustomerMenu()
        {
            InitializeComponent();
            random = new System.Random();
            dataGridView1.DataSource = GlobalData.customers;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new MainMenu()));
            t.Start();
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            var temp = new Customer(Name_txt.Text, phoneNumber_txt.Text
                , Address_txt.Text, code_generator());
            temp.Balance = Int64.Parse(Money_txt.Text);
            temp.IsNew = true;
            GlobalData.customers.Add(temp);
            Name_txt.Text="";
            phoneNumber_txt.Text="";
            Address_txt.Text="";
            Money_txt.Text="";
        }

        private string code_generator()
        {
            return random.Next(1000, 99999).ToString();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
            request.cutomer = true;
            request.Apply = true;
            request.Select = false;
            request.Objects = new List<ISendAble>();
            foreach (var obj in GlobalData.customers)
            {
                request.Objects.Add(obj);
            }

            MySocket mySocket = new MySocket();
            var indented = Formatting.Indented;
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string data = JsonConvert.SerializeObject(request, indented, settings);

            data = mySocket.Request(data);
            MessageBox.Show(data);
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
            request.cutomer = true;
            request.SelectObject = new Customer(Name_txt.Text, phoneNumber_txt.Text, Address_txt.Text
                , SubscribeCode_txt.Text);
            if (Money_txt.Text == "") Money_txt.Text = "0";
            ((Customer)request.SelectObject).Balance = Int64.Parse(Money_txt.Text);
            request.Select = true;
            request.Apply = false;

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
            GlobalData.customers.Clear();
            foreach (var x in item.Objects)
            {
                GlobalData.customers.Add((Customer)x);
            }
        }
    }

}
