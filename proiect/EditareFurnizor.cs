using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class EditareFurnizor : Form
    {
        private Furnizor furnizor;

        public EditareFurnizor(Furnizor furnizorSelectat)
        {
            InitializeComponent();

            furnizor = furnizorSelectat;

            tbNume.Text = furnizor.Nume;
            tbCUI.Text = furnizor.CUI;
            tbAdresa.Text = furnizor.Adresa;
            tbTelefon.Text = furnizor.Telefon;
            tbEmail.Text = furnizor.Email;
        }

        private void btnSalveaza_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                MessageBox.Show("Numele furnizorului este obligatoriu!");
                return;
            }

            if (tbTelefon.Text.Length < 10)
            {
                MessageBox.Show("Numărul de telefon este incorect!");
                return;
            }

            furnizor.Nume = tbNume.Text;
            furnizor.CUI = tbCUI.Text;
            furnizor.Adresa = tbAdresa.Text;
            furnizor.Telefon = tbTelefon.Text;
            furnizor.Email = tbEmail.Text;

            FurnizorRepository repo = new FurnizorRepository();
            repo.EditeazaFurnizor(furnizor);

            MessageBox.Show("Furnizorul a fost modificat cu succes!");

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnRenunta_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}