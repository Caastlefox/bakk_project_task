using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakk_project_task
{
    public partial class AddNewClient : Form
    {

        public AddNewClient()
        {
            InitializeComponent();
 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {  
            WindowFlags.NewClient = false;
            this.Close();
        }
    }
}
