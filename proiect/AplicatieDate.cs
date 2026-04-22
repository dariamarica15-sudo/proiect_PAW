using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class AplicatieDate
    {
        public List<Furnizor> furnizori { get; set; }
        public Dictionary<int, List<Material>> materialePeFurnizor { get; set; }
        public List<Contract> contracte { get; set; }
    }
}
