using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proiect
{
    public partial class AdaugaContract : Form
    {
        public AdaugaContract()
        {
            InitializeComponent();
        }

        private void AdaugaContract_Load(object sender, EventArgs e)
        {
            cbIdFurnizor.Items.Clear();

            foreach (var f in Form1.furnizori)
            {
                cbIdFurnizor.Items.Add(f.Id);
            }

            if (cbIdFurnizor.Items.Count > 0)
                cbIdFurnizor.SelectedIndex = 0;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            // Validare ID contract
            if (!int.TryParse(tbIdContract.Text, out int idContract))
            {
                MessageBox.Show("ID contract invalid!");
                return;
            }

            // Validare furnizor
            if (cbIdFurnizor.SelectedItem == null)
            {
                MessageBox.Show("Selectați un furnizor!");
                return;
            }

            int idFurnizor = (int)cbIdFurnizor.SelectedItem;

            // Verificăm dacă furnizorul are materiale
            if (!Form1.materialePeFurnizor.ContainsKey(idFurnizor) ||
                Form1.materialePeFurnizor[idFurnizor].Count == 0)
            {
                MessageBox.Show("Acest furnizor nu are materiale selectate!");
                return;
            }

            // Luăm materialele furnizorului
            List<Material> materialeFurnizor = Form1.materialePeFurnizor[idFurnizor];

            // Creăm contractul
            Contract c = new Contract(
                idContract,
                idFurnizor,
                dateTimePicker1.Value,
                new List<Material>(materialeFurnizor),
                tbObservatii.Text
            );

            // Salvăm contractul
            Form1.contracte.Add(c);

            // Afișăm în listbox
            Contracte.Items.Add(
                $"Contract {c.IdContract} | Furnizor: {c.IdFurnizor} | Data: {c.DataContract.ToShortDateString()} | Total: {c.TotalContract} lei | Obs: {c.Observatii}"
            );

            // Golim materialele DOAR pentru acest furnizor
            Form1.materialePeFurnizor[idFurnizor].Clear();

            // Curățăm câmpurile
            tbIdContract.Clear();
            tbObservatii.Clear();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
