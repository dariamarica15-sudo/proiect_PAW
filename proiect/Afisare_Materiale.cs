using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace proiect
{
    public partial class Afisare_Materiale : Form
    {
        public Afisare_Materiale()
        {
            InitializeComponent();
        }

        private void Afisare_Materiale_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Clear();
            listView1.Columns.Add("ID Material", 100);
            listView1.Columns.Add("Denumire", 150);
            listView1.Columns.Add("Cantitate", 100);
            listView1.Columns.Add("Preț", 100);
            listView1.Columns.Add("Furnizor ID", 100);
            listView1.Columns.Add("Data contract", 120);

            listView1.Items.Clear();

            foreach (var c in Form1.contracte)
            {
                int idFurnizor = c.IdFurnizor;
                DateTime data = c.DataContract;

                if (c.Materiale == null) continue;

                foreach (var m in c.Materiale)
                {
                    ListViewItem item = new ListViewItem(m.Id.ToString());
                    item.SubItems.Add(m.Denumire);
                    item.SubItems.Add(m.Cantitate.ToString());
                    item.SubItems.Add(m.PretUnitar.ToString());
                    item.SubItems.Add(idFurnizor.ToString());
                    item.SubItems.Add(data.ToShortDateString());

                    listView1.Items.Add(item);
                }
            }
        }


        private void btnPrinteaza_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentMateriale_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocumentMateriale_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float yPos = 50;

            e.Graphics.DrawString("Lista Materiale", new Font("Arial", 16, FontStyle.Bold), brush, 100, yPos);
            yPos += 40;

            foreach (var entry in Form1.materialePeFurnizor)
            {
                int idFurnizor = entry.Key;
                var listaMateriale = entry.Value;

                foreach (var m in listaMateriale)
                {
                    string linie =
                        $"ID {m.Id} | {m.Denumire} | Cant: {m.Cantitate} | Pret: {m.PretUnitar} lei | Furnizor: {idFurnizor}";

                    e.Graphics.DrawString(linie, font, brush, 50, yPos);
                    yPos += 25;
                }
            }
        }
    }
}
