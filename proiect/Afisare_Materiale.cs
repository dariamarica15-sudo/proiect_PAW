using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class Afisare_Materiale : Form
    {
        public Afisare_Materiale()
        {
            InitializeComponent();
        }

        private void IncarcaMateriale()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("ID Comandă", 100);
            listView1.Columns.Add("Denumire", 150);
            listView1.Columns.Add("Cantitate", 100);
            listView1.Columns.Add("Preț", 100);
            listView1.Columns.Add("Furnizor ID", 100);

            foreach (var entry in Form1.materialePeFurnizor)
            {
                int idFurnizor = entry.Key;

                foreach (var m in entry.Value)
                {
                    ListViewItem item = new ListViewItem(m.Id.ToString());
                    item.SubItems.Add(m.Denumire);
                    item.SubItems.Add(m.Cantitate.ToString());
                    item.SubItems.Add(m.PretUnitar.ToString());
                    item.SubItems.Add(idFurnizor.ToString());

                    listView1.Items.Add(item);
                }
            }
        }

        private Material CautaMaterialDupaId(int idMaterial)
        {
            foreach (var contract in Form1.contracte)
            {
                if (contract.Materiale == null)
                    continue;

                Material material = contract.Materiale.FirstOrDefault(m => m.Id == idMaterial);

                if (material != null)
                    return material;
            }

            foreach (var entry in Form1.materialePeFurnizor)
            {
                Material material = entry.Value.FirstOrDefault(m => m.Id == idMaterial);

                if (material != null)
                    return material;
            }

            return null;
        }

        private void Afisare_Materiale_Load(object sender, EventArgs e)
        {
            IncarcaMateriale();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un material!");
                return;
            }

            int idMaterial = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DialogResult rezultat = MessageBox.Show(
                "Sigur doriți să ștergeți acest material?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                foreach (var contract in Form1.contracte)
                {
                    if (contract.Materiale != null)
                    {
                        Material material = contract.Materiale.FirstOrDefault(m => m.Id == idMaterial);

                        if (material != null)
                        {
                            contract.Materiale.Remove(material);
                            break;
                        }
                    }
                }

                foreach (var entry in Form1.materialePeFurnizor)
                {
                    Material material = entry.Value.FirstOrDefault(m => m.Id == idMaterial);

                    if (material != null)
                    {
                        entry.Value.Remove(material);
                        break;
                    }
                }

                IncarcaMateriale();

                MessageBox.Show("Materialul a fost șters cu succes!");
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați un material!");
                return;
            }

            int idMaterial = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            Material materialDeEditat = CautaMaterialDupaId(idMaterial);

            if (materialDeEditat == null)
            {
                MessageBox.Show("Materialul nu a fost găsit!");
                return;
            }

            EditareMaterial form = new EditareMaterial(materialDeEditat);

            if (form.ShowDialog() == DialogResult.OK)
            {
                IncarcaMateriale();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}