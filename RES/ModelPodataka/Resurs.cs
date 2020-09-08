using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPodataka
{
    public class Resurs
    {
        public int Id { get; set; }
        public string Naziv  { get; set; }
        public string Opis  { get; set; }
        public TipResursa Tip  { get; set; }

        public Resurs(int id, string naziv, string opis, TipResursa tip)
        {
            Id = id;
            Naziv = naziv;
            Opis = opis;
            Tip = tip;
        }

        public Resurs() { }
    }
}
