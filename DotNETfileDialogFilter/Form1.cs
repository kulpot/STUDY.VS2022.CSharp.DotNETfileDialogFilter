using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNETfileDialogFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlgOpenFile = new OpenFileDialog())
            {
                //dlgOpenFile.Filter = "Supported File Types|*.txt*;.bat;*log|All Files|*.*";
                dlgOpenFile.Filter = "Bitmap|*.bmp";
                //dlgOpenFile.Filter = "Bitmap Format|*.bmp";
                //dlgOpenFile.Filter = "Bitmap File|*.bmp";

                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
