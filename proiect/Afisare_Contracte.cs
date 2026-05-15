using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class Afisare_Contracte : Form
    {
        public Afisare_Contracte()
        {
            InitializeComponent();
            this.Load += Afisare_Contracte_Load;
        }

        private void Afisare_Contracte_Load(object sender, EventArgs e)
        {
            IncarcaContracte();
        }

        private void IncarcaContracte()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();
            
            listView1.Items.Clear();

            listView1.Columns.Add("ID Contract", 100);
            listView1.Columns.Add("ID Furnizor", 100);
            listView1.Columns.Add("Data", 120);
            listView1.Columns.Add("Total", 100);
            listView1.Columns.Add("Observații", 200);

            foreach (var c in Form1.contracte)
            {
                ListViewItem item = new ListViewItem(c.IdContract.ToString());
                item.SubItems.Add(c.IdFurnizor.ToString());
                item.SubItems.Add(c.DataContract.ToShortDateString());
                item.SubItems.Add(c.TotalContract + " lei");
                item.SubItems.Add(c.Observatii);

                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentContracte_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocumentContracte_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float yPos = 50;

            e.Graphics.DrawString("Lista Contracte", new Font("Arial", 16, FontStyle.Bold), brush, 100, yPos);
            yPos += 40;

            foreach (var c in Form1.contracte)
            {
                string info =
                    $"Contract {c.IdContract} | Furnizor: {c.IdFurnizor} | Data: {c.DataContract.ToShortDateString()} | Total: {c.TotalContract} lei | Obs: {c.Observatii}";

                e.Graphics.DrawString(info, font, brush, 50, yPos);
                yPos += 25;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un contract din listă!");
                return;
            }

            int idContract = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DialogResult rezultat = MessageBox.Show(
                "Sigur doriți să ștergeți acest contract?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                Contract contractDeSters = Form1.contracte
                    .FirstOrDefault(c => c.IdContract == idContract);

                if (contractDeSters != null)
                {
                    Form1.contracte.Remove(contractDeSters);
                }

                IncarcaContracte();

                MessageBox.Show("Contractul a fost șters cu succes!");
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un contract din listă!");
                return;
            }

            int idContract = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            Contract contractDeEditat = Form1.contracte
                .FirstOrDefault(c => c.IdContract == idContract);

            if (contractDeEditat == null)
            {
                MessageBox.Show("Contractul nu a fost găsit!");
                return;
            }

            EditareContract editForm = new EditareContract(contractDeEditat);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                IncarcaContracte();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Afisare_Contracte_Load_1(object sender, EventArgs e)
        {

        }
    }
}