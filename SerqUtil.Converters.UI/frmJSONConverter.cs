using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerqUtil.Converters.UI
{
    public partial class frmJSONConverter : Form
    {
        public frmJSONConverter()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var list  = JSONConverter.ConvertFromJSON(txtPlainText.Text);
            grdObjectList.DataSource = list;
            
        }
    }
}
