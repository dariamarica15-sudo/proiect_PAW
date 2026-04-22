using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class Furnizor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string CUI { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }


        public Furnizor(int id, string nume, string cui, string adresa, string telefon, string email)
        {
            this.Id = id;
            this.Nume = nume;
            this.CUI = cui;
            this.Adresa = adresa;
            this.Telefon = telefon;
            this.Email = email;
        }

        public Furnizor() { }


        public override string ToString()
        {
            return $"{Id} - {Nume} - {CUI} - {Adresa} - {Telefon} - {Email}";
        }

    }
}

 

