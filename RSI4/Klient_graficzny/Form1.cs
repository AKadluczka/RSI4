using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient_graficzny
{
    public partial class Form1 : Form
    {
        ServiceReference1.StrumienClient client2;
        public Form1()
        {
            client2 = new ServiceReference1.StrumienClient();
            InitializeComponent();
        }


    }
}
