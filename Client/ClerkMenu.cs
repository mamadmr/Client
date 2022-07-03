﻿using System;
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
    public partial class MyClerkMenu : Form
    {
        public MyClerkMenu()
        {
            InitializeComponent();
            dataGridView2.DataSource = GlobalData.clerks;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new MainMenu()));
            t.Start();
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            var temp = new Clerk(Name_txt.Text,
                                 Phone_txt.Text,
                                 Address_txt.Text,
                                 UserName_txt.Text,
                                 Password_txt.Text, IsAdmin_check.Checked);
            temp.IsNew = true;
            GlobalData.clerks.Add(temp);
            Name_txt.Text = "";
            Phone_txt.Text = "";
            Address_txt.Text = "";
            UserName_txt.Text = "";
            Password_txt.Text = "";
        }

        private void Select_button_Click(object sender, EventArgs e)
        {

        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalData.clerks.Count; i++)
            {
                var request = new ClientToServer(GlobalData.Username, GlobalData.Password, false, true);
                request.clerk = true;
                request.SelectObject = GlobalData.clerks[i];

                MySocket mySocket = new MySocket();
                var indented = Formatting.Indented;
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                string data = JsonConvert.SerializeObject(request, indented, settings);
                data = mySocket.Request(data);
                if(data == "Not Admin")
                {
                    MessageBox.Show("You Are not Admin");
                    break;
                }
            }
        }
    }
    public static class GlobalData
    {
        public static BindingList<Clerk> clerks = new BindingList<Clerk>();
        public static string Username = "";
        public static string Password = "";
    }
}
