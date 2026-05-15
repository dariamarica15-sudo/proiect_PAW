using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace proiect
{
    public partial class SelecteazaMaterial : Form
    {
        public SelecteazaMaterial()
        {
            InitializeComponent();

            // Populează furnizorii în ComboBox
            foreach (Furnizor f in Form1.furnizori)
            {
                cbIdFurnizor.Items.Add(f.Id);
            }

            if (cbIdFurnizor.Items.Count > 0)
                cbIdFurnizor.SelectedIndex = 0;

            // Populează materialele în ComboBox
            foreach (Material m in Form1.materiale)
            {
                cbMaterial.Items.Add(m.Denumire);
            }

            if (cbMaterial.Items.Count > 0)
                cbMaterial.SelectedIndex = 0;

            // IP LOCAL
            cbIpLocal.Items.Add(GetLocalIP());
            cbIpLocal.SelectedIndex = 0;

            // IP FURNIZOR – valori default
            cbIpFurnizor.Items.Add("8.8.8.8");
            cbIpFurnizor.Items.Add("1.1.1.1");
            cbIpFurnizor.SelectedIndex = 0;
        }

        private string GetLocalIP()
        {
            return Dns.GetHostEntry(Dns.GetHostName())
                      .AddressList
                      .First(a => a.AddressFamily ==
                          System.Net.Sockets.AddressFamily.InterNetwork)
                      .ToString();
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NU completăm ID-ul automat, îl scrii tu manual
        }

        private void btnTesteazaConexiunea_Click(object sender, EventArgs e)
        {
            string ip = cbIpFurnizor.Text;

            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip);

                if (reply.Status == IPStatus.Success)
                    Log.Items.Add($"[{DateTime.Now:HH:mm}] Ping către {ip}: OK");
                else
                    Log.Items.Add($"[{DateTime.Now:HH:mm}] Ping către {ip}: Eșuat");
            }
            catch
            {
                Log.Items.Add($"[{DateTime.Now:HH:mm}] Ping către {ip}: Eroare");
            }
        }

        private void tbIdMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbIdMaterial.Text, out int idMat))
            {
                errorProvider1.SetError(tbIdMaterial, "ID material trebuie să fie un număr!");
                e.Cancel = true;
                return;
            }

            if (idMat <= 1)
            {
                errorProvider1.SetError(tbIdMaterial, "ID material trebuie să fie mai mare decât 1!");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(tbIdMaterial, "");
        }


        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            // Validare ID material
            if (!int.TryParse(tbIdMaterial.Text, out int idMat))
            {
                errorProvider1.SetError(tbIdMaterial, "ID material trebuie să fie un număr!");
                return;
            }

            if (idMat <= 1)
            {
                errorProvider1.SetError(tbIdMaterial, "ID material trebuie să fie mai mare decât 1!");
                return;
            }

            errorProvider1.SetError(tbIdMaterial, "");

            // Validare cantitate
            if (!double.TryParse(tbCantitate.Text, out double cantitate) || cantitate <= 0)
            {
                errorProvider1.SetError(tbCantitate, "Cantitatea trebuie să fie mai mare decât 0!");
                return;
            }

            errorProvider1.SetError(tbCantitate, "");

            // Validare preț
            if (!decimal.TryParse(tbPret.Text, out decimal pret) || pret <= 0)
            {
                errorProvider1.SetError(tbPret, "Prețul trebuie să fie mai mare decât 0!");
                return;
            }

            errorProvider1.SetError(tbPret, "");

            if (cbIdFurnizor.SelectedItem == null)
            {
                MessageBox.Show("Selectați un furnizor!");
                return;
            }

            if (cbMaterial.SelectedItem == null)
            {
                MessageBox.Show("Selectați un material!");
                return;
            }

            int idFurnizor = (int)cbIdFurnizor.SelectedItem;
            string material = cbMaterial.SelectedItem.ToString();
            string data = dateTimePicker1.Value.ToShortDateString();

            // linie doar pentru afișare în listbox
            string linie = $"{idMat} | {material} | Cant: {cantitate} kg | Preț: {pret} lei | Furnizor ID: {idFurnizor} | {data}";
            MaterialeSelectate.Items.Add(linie);

            // salvăm materialul în dicționarul furnizorului
            if (!Form1.materialePeFurnizor.ContainsKey(idFurnizor))
            {
                Form1.materialePeFurnizor[idFurnizor] = new List<Material>();
            }

            Material mat = new Material();
            mat.Id = idMat;
            mat.Denumire = material;
            mat.Cantitate = cantitate;
            mat.PretUnitar = pret;

            Form1.materialePeFurnizor[idFurnizor].Add(mat);

            MaterialRepository repo = new MaterialRepository();
            repo.AdaugaMaterial(mat, idFurnizor);

            Log.Items.Add($"[{DateTime.Now:HH:mm}] Material salvat pentru furnizorul {idFurnizor}: {material}");

            tbIdMaterial.Clear();
            tbCantitate.Clear();
            tbPret.Clear();
        }



        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite doar cifre, backspace și virgulă
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
                e.Handled = true;
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite doar cifre, backspace și virgulă
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
                e.Handled = true;
        }

        

        private void tbCantitate_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbCantitate.Text, out double cant))
            {
                errorProvider1.SetError(tbCantitate, "Introduceți o cantitate validă!");
                e.Cancel = true;
                return;
            }

            if (cant <= 0)
            {
                errorProvider1.SetError(tbCantitate, "Cantitatea trebuie să fie mai mare decât 0!");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(tbCantitate, "");
        }

        private void tbPret_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(tbPret.Text, out decimal pret))
            {
                errorProvider1.SetError(tbPret, "Introduceți un preț valid!");
                e.Cancel = true;
                return;
            }

            if (pret <= 0)
            {
                errorProvider1.SetError(tbPret, "Prețul trebuie să fie mai mare decât 0!");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(tbPret, "");
        }


        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelecteazaMaterial_Load(object sender, EventArgs e)
        {

        }

        private void cbIdFurnizor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
