using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace proiect
{
    public partial class AdaugaFurnizor : Form
    {
        private bool renunt = false; // permite închiderea fără validare

        public AdaugaFurnizor()
        {
            InitializeComponent();

            // Sugestii
            Sugestii.Items.Add("SC Exemplu SRL");
            Sugestii.Items.Add("12345678");
            Sugestii.Items.Add("Str. Mihai Eminescu nr. 10");
            Sugestii.Items.Add("0722123456");
            Sugestii.Items.Add("contact@firma.ro");

            // Activare drag & drop
            tbNume.AllowDrop = true;
            tbCUI.AllowDrop = true;
            tbAdresa.AllowDrop = true;
            tbTelefon.AllowDrop = true;
            tbEmail.AllowDrop = true;

            tbNume.DragEnter += TxtBox_DragEnter;
            tbCUI.DragEnter += TxtBox_DragEnter;
            tbAdresa.DragEnter += TxtBox_DragEnter;
            tbTelefon.DragEnter += TxtBox_DragEnter;
            tbEmail.DragEnter += TxtBox_DragEnter;

            tbNume.DragDrop += TxtBox_DragDrop;
            tbCUI.DragDrop += TxtBox_DragDrop;
            tbAdresa.DragDrop += TxtBox_DragDrop;
            tbTelefon.DragDrop += TxtBox_DragDrop;
            tbEmail.DragDrop += TxtBox_DragDrop;

            Sugestii.MouseDown += Sugestii_MouseDown;

            // Legăm butonul din UserControl
            userControl11.Btnsalveaza.Click += BtnSalveaza_Click;

            // Validări
            userControl11.TbId.Validating += tbId_Validating;
            userControl11.TbId.Validated += tbId_Validated;

            tbTelefon.Validating += tbTelefon_Validating;
            tbTelefon.Validated += tbTelefon_Validated;

            // IMPORTANT: permite închiderea fără validare
            this.AutoValidate = AutoValidate.Disable;
        }

        // SALVARE FURNIZOR

        private void BtnSalveaza_Click(object sender, EventArgs e)
        {
            // Validare ID
            if (!int.TryParse(userControl11.TbId.Text, out int id))
            {
                MessageBox.Show("ID-ul trebuie să fie un număr întreg!", "Eroare ID");
                return;
            }

            // ID unic
            if (Form1.furnizori.Any(furn => furn.Id == id))
            {
                MessageBox.Show("ID-ul există deja! Trebuie să fie unic.", "ID duplicat");
                return;
            }

            // Telefon valid
            if (tbTelefon.Text.Length < 10)
            {
                MessageBox.Show("Numărul de telefon este incorect!", "Eroare Telefon");
                return;
            }

            // Creare furnizor
            var furnizorNou = new Furnizor(
                id,
                tbNume.Text,
                tbCUI.Text,
                tbAdresa.Text,
                tbTelefon.Text,
                tbEmail.Text
            );

            // Adăugare în lista globală
            FurnizorRepository repo = new FurnizorRepository();
            repo.AdaugaFurnizor(furnizorNou);

            Form1.furnizori.Add(furnizorNou);

            // Afișare în ListBox-ul local
            Furnizori.Items.Add(furnizorNou.ToString());

            // Curățare câmpuri
            userControl11.TbId.Clear();
            tbNume.Clear();
            tbCUI.Clear();
            tbAdresa.Clear();
            tbTelefon.Clear();
            tbEmail.Clear();
        }

        // VALIDARE ID (doar la salvare)
        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (renunt) return; // dacă renunți, nu validăm nimic

            if (!int.TryParse(userControl11.TbId.Text, out _))
            {
                errorProvider1.SetError(userControl11.TbId, "ID-ul trebuie să fie un număr întreg!");
                e.Cancel = true;
            }
        }

        private void tbId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(userControl11.TbId, "");
        }

        // VALIDARE TELEFON
        
        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (renunt) return;

            if (tbTelefon.Text.Length < 10)
            {
                errorProvider2.SetError(tbTelefon, "Număr de telefon incorect!");
                e.Cancel = true;
            }
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(tbTelefon, "");
        }

        // DRAG & DROP
        private void Sugestii_MouseDown(object sender, MouseEventArgs e)
        {
            if (Sugestii.SelectedItem != null)
                Sugestii.DoDragDrop(Sugestii.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void TxtBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void TxtBox_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        // RENUNȚARE (fără validare)

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            renunt = true; // dezactivăm validările
            this.Close();
        }

        private void AdaugaFurnizor_Load(object sender, EventArgs e)
        {
        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
