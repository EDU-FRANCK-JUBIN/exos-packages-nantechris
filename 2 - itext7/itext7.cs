using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2___itext7;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace _2___itext7
{
    public partial class itext7 : Form
    {
        public itext7()
        {
            InitializeComponent();
        }


        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            string monTexte = richTxtBox.Text;
            var writer = new PdfWriter("C:\\Users\\Nante\\Desktop\\test.pdf");
            var pdf = new PdfDocument(writer);
            var doc = new Document(pdf);
            doc.Add(new Paragraph(monTexte));
            doc.Close();
            MessageBox.Show("PDF généré !!!");
            this.Close();
        }
    }
}
