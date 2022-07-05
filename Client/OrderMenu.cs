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
    public partial class OrderMenu : Form
    {
        public OrderMenu()
        {
            InitializeComponent();
            comboBox1.DataSource = GlobalData.cakes;
            comboBox2.DataSource = GlobalData.customers;
            dataGridView1.DataSource = GlobalData.basket;
            dataGridView2.DataSource = GlobalData.orders;
        }

        private void product_add_button_Click(object sender, EventArgs e)
        {
            Cake temp_cake = GlobalData.cakes[comboBox1.SelectedIndex];
            int temp_count = Int32.Parse(count_txt.Text);
            var temp_item = new Item();
            temp_item.name = temp_cake.ToString();
            temp_item.count = temp_count;
            temp_item.cake = temp_cake;
            GlobalData.basket.Add(temp_item);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new MainMenu()));
            t.Start();
            this.Close();
        }

        private void Add_Order_button_Click(object sender, EventArgs e)
        {
            var temp = new Order();
            foreach(var item in GlobalData.basket) temp.Products.Add(item);
            temp.Customer = GlobalData.customers[comboBox2.SelectedIndex];
            temp.IsNew = true;
            temp.Hour = Int32.Parse(Hour_txt.Text);
            GlobalData.basket.Clear();
            GlobalData.orders.Add(temp);
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                GlobalData.basket.RemoveAt(dataGridView1.SelectedRows[i].Index);
            }
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
            request.order = true;
            request.Apply = true;
            request.Select = false;
            request.Objects = new List<ISendAble>();
            foreach (var obj in GlobalData.orders)
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

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GlobalData.basket.Clear();
            for(int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                var row = dataGridView2.SelectedRows[i].Index;
                foreach(var t in GlobalData.orders[row].Products) GlobalData.basket.Add(t);
                break;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                var row = dataGridView2.SelectedRows[i].Index;
                GlobalData.orders[row].Products.Clear();
                foreach (var t in GlobalData.basket) GlobalData.orders[row].Products.Add(t);
                break;
            }
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
            request.order = true;
            request.SelectObject = new Order();
            try
            {
                ((Order)request.SelectObject).Customer = GlobalData.customers[comboBox2.SelectedIndex];
            }
            catch (Exception ex)
            {
                ((Order)request.SelectObject).Customer = null;
            }

            if (ordernumber_txt.Text == "") ordernumber_txt.Text = "0";

            ((Order)request.SelectObject).Id = Int64.Parse(ordernumber_txt.Text);
            ((Order)request.SelectObject).OrderCode = ordercode_txt.Text;
            if (Hour_txt.Text == "") Hour_txt.Text = "0";
            ((Order)request.SelectObject).Hour = Int32.Parse(Hour_txt.Text);

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
            GlobalData.orders.Clear();
            foreach (var x in item.Objects)
            {
                GlobalData.orders.Add((Order)x);
            }
        }
    }
}
