using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Packages
{
    public partial class QRCoder : Form
    {
        public QRCoder()
        {
            InitializeComponent();
        }

        private void QRCoder_Load(object sender, EventArgs e)
        {
            QRCodeGenerator monQRCodeGenerator = new QRCodeGenerator();
            QRCodeData monQRCodeData = monQRCodeGenerator.CreateQrCode("http://www.facebook.com", QRCodeGenerator.ECCLevel.Q);
            QRCode monQRCode = new QRCode(monQRCodeData);
            // picBoxQRCode.Image = monQRCode.GetGraphic(5, Color.Blue, Color.Red, true);
            picBoxQRCode.Image = monQRCode.GetGraphic(5);        
        }
    }
}
