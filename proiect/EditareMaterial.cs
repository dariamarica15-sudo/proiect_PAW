using System;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class EditareMaterial : Form
    {
        private Material material;
        private int idInitial;

        public EditareMaterial(Material materialSelectat)
        {
            InitializeComponent();

            material = materialSelectat;
            idInitial = materialSelectat.Id;

            cbMaterial.Items.Clear();

            foreach (Material m in Form1.materiale)
            {
                cbMaterial.Items.Add(m.Denumire);
            }

            tbIdMaterial.Text = material.Id.ToString();
            cbMaterial.Text = material.Denumire;
            tbCantitate.Text = material.Cantitate.ToString();
            tbPret.Text = material.PretUnitar.ToString();
        }

        private bool IdMaterialExista(int id)
        {
            foreach (var entry in Form1.materialePeFurnizor)
            {
                if (entry.Value.Any(m => m.Id == id && id != idInitial))
                    return true;
            }

            foreach (var contract in Form1.contracte)
            {
                if (contract.Materiale != null &&
                    contract.Materiale.Any(m => m.Id == id && id != idInitial))
                    return true;
            }

            return false;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(tbIdMaterial.Text, out int idNou))
            {
                errorProvider1.SetError(tbIdMaterial, "ID-ul trebuie să fie număr!");
                return;
            }

            if (idNou <= 0)
            {
                errorProvider1.SetError(tbIdMaterial, "ID-ul trebuie să fie mai mare decât 0!");
                return;
            }

            if (IdMaterialExista(idNou))
            {
                errorProvider1.SetError(tbIdMaterial, "Acest ID există deja!");
                return;
            }

            if (cbMaterial.SelectedItem == null && string.IsNullOrWhiteSpace(cbMaterial.Text))
            {
                errorProvider1.SetError(cbMaterial, "Selectați un material!");
                return;
            }

            if (!double.TryParse(tbCantitate.Text, out double cantitate) || cantitate <= 0)
            {
                errorProvider1.SetError(tbCantitate, "Cantitatea trebuie să fie mai mare decât 0!");
                return;
            }

            if (!decimal.TryParse(tbPret.Text, out decimal pret) || pret <= 0)
            {
                errorProvider1.SetError(tbPret, "Prețul trebuie să fie mai mare decât 0!");
                return;
            }

            material.Id = idNou;
            material.Denumire = cbMaterial.Text;
            material.Cantitate = cantitate;
            material.PretUnitar = pret;

            MaterialRepository repo = new MaterialRepository();
            repo.EditeazaMaterial(material, idInitial);

            MessageBox.Show("Materialul a fost modificat cu succes!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}