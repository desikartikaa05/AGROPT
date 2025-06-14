using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROPT.Model
{
    public class Lahan
    {
        public int Id { get; set; }
        public string Id_Lahan { get; set; }
        public string NamaLahan { get; set; }
        public string Lokasi { get; set; }
        public string Deskripsi { get; set; }
        public bool Status { get; set; }
        public DateTime TanggalUpload { get; set; }
        public string NoHp { get; set; }    

        public int UserId { get; set; }
        public User Petani { get; set; }

        public string StatusTeks => Status ? "Tersedia" : "Tidak Tersedia";

    }
}
