using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROPT.Model
{
        public class Bayar
        {
            public int Id { get; set; }
            public string IdLahan { get; set; }
            public string NamaLahan { get; set; }
            public string Lokasi { get; set; }
            public string KodePembayaran { get; set; }
            public string NamaPembeli { get; set; }
            public string AlamatPembeli { get; set; }
            public string Status { get; set; }

            public int UserId { get; set; }
            public User Pembeli { get; set; }
            public Lahan Lahan { get; set; }
    }
    
}
