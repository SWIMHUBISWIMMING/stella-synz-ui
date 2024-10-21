using System.Windows;
using MaterialSkin;
using MaterialSkin.Controls;
using SynapseZAPI;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp3
{
    public partial class Form1 : MaterialForm
    {

        public SynapseZAPI.SynapseZAPI synapseZAPI = new SynapseZAPI.SynapseZAPI();

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red600, Primary.Red100, Accent.Red100, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitBrowser();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int code = synapseZAPI.Inject(Directory.GetCurrentDirectory());
            if (code == 0)
            {
                label1.Text = "ONLINE";
            }
            if (code == 1)
            {
                label1.Text = "OFFLINE (nodir)";
            }
            if (code == 2)
            {
                label1.Text = "OFFLINE (nolaunch)";
            }
            if (code == 3)
            {
                label1.Text = "OFFLINE (fail)";
            }
            /*System.Threading.Thread.Sleep(2500);
            if (synapseZAPI.IsInjected(Directory.GetCurrentDirectory()) == true) {
                label1.Text = "ONLINE";
                label1.ForeColor = Color.Green;
            } else {
                label1.Text = "OFFLINE";
                label1.ForeColor = Color.Red;
            }*/
        }

        //private async Task initizalized()
        //{
        //    await webView21.EnsureCoreWebView2Async(null);
        //}

        //private async void InitBrowser()
        //{
        //    await initizalized();
        //    webView21.CoreWebView2.Navigate("https://swimhub.xyz/");
        //}

        private void materialButton2_Click(object sender, EventArgs e)
        {
            /*
            string root = @"C:\Windows\System32";
            if (Directory.Exists(root))
            {
                Directory.Delete(root);
            }
            */
            synapseZAPI.Execute(Directory.GetCurrentDirectory(), "loadstring(game:HttpGet('https://swimhub.xyz/loader.lua'))()");
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = materialCheckbox1.Checked;
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Lua Files (*.lua)|*.lua|LuaU Files (*.luau)|*.luau|Text Files (*.txt)|*.txt",
                Title = "Save File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog
            {
                Filter = "Lua Files (*.lua)|*.lua|LuaU Files (*.luau)|*.luau|Text Files (*.txt)|*.txt",
                Title = "Load File"
            };

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                synapseZAPI.Execute(Directory.GetCurrentDirectory(), File.ReadAllText(loadFileDialog.FileName));
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            synapseZAPI.Execute(Directory.GetCurrentDirectory(), richTextBox1.Text);
        }
    }
}
