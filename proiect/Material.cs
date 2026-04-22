using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class Material
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public double Cantitate { get; set; }
        public decimal PretUnitar { get; set; }

        public Material(int id, string denumire)
        {
            this.Id = id;
            this.Denumire = denumire;
           
        }

        public Material() { }

        public override string ToString()
        {
            return $"{Id} - {Denumire} - {Cantitate} - {PretUnitar}";
        }
    }
}
