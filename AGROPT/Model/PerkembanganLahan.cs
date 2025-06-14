using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROPT.Model
{
    public class PerkembanganLahan
    {
            public int Id { get; set; }
            public string IdLahan { get; set; }  // FK ke Lahan
            public string NamaLahan { get; set; }
            public string Keterangan { get; set; }
            public string ProgressPanen { get; set; }

            public int UserId { get; set; }  // FK ke petani
            public User Petani { get; set; }

            public Lahan Lahan { get; set; }
        

    }
}
