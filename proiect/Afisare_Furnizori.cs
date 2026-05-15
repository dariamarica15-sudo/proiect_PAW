using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class Afisare_Furnizori : Form
    {
        public Afisare_Furnizori(List<Furnizor> listaFurnizori)
        {
            InitializeComponent();
            IncarcaFurnizori();
        }

        private void IncarcaFurnizori()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Items.Clear();

            foreach (var furn in Form1.furnizori)
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

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un furnizor din listă!");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DialogResult rezultat = MessageBox.Show(
                "Sigur doriți să ștergeți acest furnizor?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                Furnizor furnizorDeSters = Form1.furnizori
                    .FirstOrDefault(f => f.Id == id);

                if (furnizorDeSters != null)
                {
                    Form1.furnizori.Remove(furnizorDeSters);
                }

                // Ștergem și materialele asociate furnizorului, dacă există
                if (Form1.materialePeFurnizor.ContainsKey(id))
                {
                    Form1.materialePeFurnizor.Remove(id);
                }

                // Ștergem și contractele asociate furnizorului
                Form1.contracte.RemoveAll(c => c.IdFurnizor == id);

                IncarcaFurnizori();

                MessageBox.Show("Furnizorul a fost șters cu succes!");
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un furnizor din listă!");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            Furnizor furnizorDeEditat = Form1.furnizori
                .FirstOrDefault(f => f.Id == id);

            if (furnizorDeEditat == null)
            {
                MessageBox.Show("Furnizorul nu a fost găsit!");
                return;
            }

            EditareFurnizor editForm = new EditareFurnizor(furnizorDeEditat);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                IncarcaFurnizori();
            }
        }
    }
}