using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Afisare_Furnizori : Form
    {
        public Afisare_Furnizori(List<Furnizor> listaFurnizori)
        {
            InitializeComponent();

            foreach (var furn in listaFurnizori)
            {
                ListViewItem item = new ListViewItem(furn.Id.ToString());
                item.SubItems.Add(furn.Nume);
                item.SubItems.Add(furn.CUI);
                item.SubItems.Add(furn.Adresa);
                item.SubItems.Add(furn.Telefon);
                item.SubItems.Add(furn.Email);

                listView1.Items.Add(item);
            }
        }



        private void btnPrinteaza_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentFurnizori_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }


        private void PrintDocumentFurnizori_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float yPos = 50;

            e.Graphics.DrawString("Lista Furnizori", new Font("Arial", 16, FontStyle.Bold), brush, 100, yPos);
            yPos += 40;

            foreach (var furn in Form1.furnizori)
            {
                string info = $"{furn.Id} | {furn.Nume} | {furn.CUI} | {furn.Adresa} | {furn.Telefon} | {furn.Email}";
                e.Graphics.DrawString(info, font, brush, 50, yPos);
                yPos += 25;
            }
        }

        private void Afisare_Furnizori_Load(object sender, EventArgs e)
        {

        }
    }

}



