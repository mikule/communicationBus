using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPodataka
{
    public class Veza
    {
        public int IdVeze { get; set; }
        public int IdPrvogResursa { get; set; }
        public int IdDrugogResursa { get; set; }
        public TipVeze Tip  { get; set; }

        public Veza(int idVeze, int idPrvogResursa, int idDrugogResursa, TipVeze tip)
        {
            IdVeze = idVeze;
            IdPrvogResursa = idPrvogResursa;
            IdDrugogResursa = idDrugogResursa;
            Tip = tip;
        }

        public Veza() { }
    }
}
