using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using System.Xml;

namespace proiect
{
    public partial class Form1 : Form
    {

        public static List<Furnizor> furnizori = new List<Furnizor>();
        public static List<Material> materiale = new List<Material>();

        public static Dictionary<int, List<Material>> materialePeFurnizor
            = new Dictionary<int, List<Material>>();

        public static List<Contract> contracte = new List<Contract>();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // materiale default, ca să nu fie ComboBox-ul gol
            materiale.Add(new Material(1, "Ciment"));
            materiale.Add(new Material(2, "Fier beton"));
            materiale.Add(new Material(3, "Cărămidă"));
            materiale.Add(new Material(4, "Nisip"));
            materiale.Add(new Material(5, "Grindă"));
        }

        private void btnAdaugaFurnizor_Click(object sender, EventArgs e)
        {
            var f = new AdaugaFurnizor();
            f.Show();
        }

        private void btnSelecteazaMateriale_Click(object sender, EventArgs e)
        {
            var sm = new SelecteazaMaterial();
            sm.Show();
        }

        private void furnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var af = new Afisare_Furnizori(furnizori);
            af.Show();
        }

        private void materialeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afisare_Materiale am = new Afisare_Materiale();
            am.Show();
        }


        private void btnAdaugaContract_Click(object sender, EventArgs e)
        {
            AdaugaContract ac = new AdaugaContract();
            ac.Show();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afisare_Contracte ac = new Afisare_Contracte();
            ac.Show();
        }

        private void materialeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Afisare_Materiale am = new Afisare_Materiale();
            am.Show();
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicatieDate date = new AplicatieDate
            {
                furnizori = furnizori,
                materialePeFurnizor = materialePeFurnizor,
                contracte = contracte
            };

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fișier JSON|*.json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(date, Formatting.Indented);
                File.WriteAllText(sfd.FileName, json);
                MessageBox.Show("Datele au fost salvate cu succes.");
            }
        }

        private void deschideFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fișier JSON|*.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(ofd.FileName);
                AplicatieDate date = JsonConvert.DeserializeObject<AplicatieDate>(json);

                // încărcăm datele în aplicație
                furnizori = date.furnizori ?? new List<Furnizor>();
                materialePeFurnizor = date.materialePeFurnizor ?? new Dictionary<int, List<Material>>();
                contracte = date.contracte ?? new List<Contract>();

                MessageBox.Show("Datele au fost încărcate cu succes.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}
