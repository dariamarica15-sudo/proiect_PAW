using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class EditareContract : Form
    {
        private Contract contract;

        public EditareContract(Contract contractSelectat)
        {
            InitializeComponent();

            contract = contractSelectat;
            richTextBox1.Text = contract.Observatii;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            contract.Observatii = richTextBox1.Text;

            ContractRepository repo = new ContractRepository();
            repo.EditeazaContract(contract);

            MessageBox.Show("Observațiile contractului au fost modificate cu succes!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}