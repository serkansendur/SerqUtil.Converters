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
    public partial class frmBase64Converter : Form
    {
        public frmBase64Converter()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtPlainText.Text))
            {
             txtEncodedText.Text = Base64Converter.ConvertToBase64(txtPlainText.Text, Encoding.GetEncodings().First(en=>en.Name==cmbEncodings.SelectedItem.ToString()));
            }
            else if(!string.IsNullOrWhiteSpace(txtEncodedText.Text))
            {
              txtPlainText.Text =  Base64Converter.ConvertFromBase64(txtEncodedText.Text, Encoding.GetEncodings().First(en => en.Name == cmbEncodings.SelectedItem.ToString()));
            }
        }

        private void frmBase64Converter_Load(object sender, EventArgs e)
        {
            cmbEncodings.Items.AddRange(Encoding.GetEncodings().Select(en => en.Name).ToArray());
            cmbEncodings.SelectedItem = "utf-8";
        }
    }
}
