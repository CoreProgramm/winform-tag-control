using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Here we are going to add item dynamically when the page is load.

            List<string> mytags = new List<string>();
            mytags.AddRange(new string[] { "C#", "MVC", "Web API", ".NET Core MVC", "Youtube Videos", "CoreProgramm" });
            tagListControl1.Tags = mytags;
        }
    }
}
