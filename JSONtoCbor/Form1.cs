using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeterO.Cbor;

namespace JSONtoCbor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            string jsonData = rTB_json.Text;
            File.WriteAllText(@"obj1.json", jsonData);

            using (var stream = new FileStream("obj1.json", FileMode.Open))
            {
                // Read the JSON object from the stream
                // as a CBOR object
                var cbor = CBORObject.ReadJSON(stream);
                rTB_cbor.Text = cbor.ToString();
            }


        }
    }
}
