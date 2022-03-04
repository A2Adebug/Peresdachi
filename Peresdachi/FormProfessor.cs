using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peresdachi
{
    public partial class FormProfessor : Form
    {
        string idUser = "";
        public FormProfessor(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void FormProfessor_Shown(object sender, EventArgs e)
        {

        }
    }
}
