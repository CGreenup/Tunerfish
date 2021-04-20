using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tunerfish
{
    public partial class Form2 : Form
    {
        Form formFrom;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form form)
        {
            InitializeComponent();
            formFrom = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
