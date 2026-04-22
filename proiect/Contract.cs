using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class Contract
    {
        public int IdContract { get; set; }
        public int IdFurnizor { get; set; }
        public string Observatii { get; set; }
        public DateTime DataContract { get; set; }

        public List<Material> Materiale { get; set; }

        // Proprietate calculată automat
        public decimal TotalContract
        {
            get
            {
                return Materiale.Sum(m => (decimal)m.Cantitate * m.PretUnitar);
            }
        }
        //public Furnizor Furnizor { get; set; }
        //public Material Material { get; set; }


        public Contract(int idContract, int idFurnizor, DateTime dataContract, List<Material> materiale, string observatii = "")
        {
            this.IdContract = idContract;
            this.IdFurnizor = idFurnizor;
            this.DataContract = dataContract;
            this.Materiale = materiale;
            this.Observatii = observatii;
        }

        public Contract() { }

        public override string ToString()
        {
            return $"Contract {IdContract} | Data: {DataContract.ToShortDateString()} | Total: {TotalContract} lei";
        }


    }
     
}
