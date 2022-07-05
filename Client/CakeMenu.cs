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
    public partial class CakeMenu_Form : Form
    {
        public CakeMenu_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = GlobalData.cakes;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new MainMenu()));
            t.Start();
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = new Cake(Int64.Parse(Price_txt.Text), Name_txt.Text,
                                       Describe_txt.Text);

                temp.IsNew = true;
                GlobalData.cakes.Add(temp);
                Price_txt.Text = "";
                Name_txt.Text = "";
                Describe_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a iniger as price");
            }

        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
            request.product = true;
            request.Apply = true;
            request.Select = false;
            request.Objects = new List<ISendAble>();
            foreach (var obj in GlobalData.cakes)
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
            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, true, false);
            request.Select = true;
            request.Apply = false;
            request.product = true;
            if (Price_txt.Text == "") Price_txt.Text = "0";
            request.SelectObject = new Cake(Int64.Parse(Price_txt.Text),
                                           Name_txt.Text, Describe_txt.Text);



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
            GlobalData.cakes.Clear();
            foreach (var x in item.Objects)
            {
                GlobalData.cakes.Add((Cake)x);
            }

        }
    }
}
