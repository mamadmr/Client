using Newtonsoft.Json;

namespace Client
{
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = UserName_txt.Text;
            string password = Password_txt.Text;
            var request = new ClientToServer(username, password, false, false);
            MySocket mySocket = new MySocket();
            var indented = Formatting.Indented;
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
            };
            string data = JsonConvert.SerializeObject(request, indented, settings);

            data =  mySocket.Request(data);
            if(data == "True")
            {

                var t = new Thread(() => Application.Run(new MainMenu()));
                GlobalData.Username = username;
                GlobalData.Password = password;
                t.Start();
                this.Close();
            } 
            else MessageBox.Show("Username or password is wrong");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}