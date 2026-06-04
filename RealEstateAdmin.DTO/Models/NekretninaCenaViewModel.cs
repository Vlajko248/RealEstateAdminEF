using System;

namespace RealEstateAdmin.DTO
{
    public class NekretninaCenaViewModel
    {
        public string Sifra { get; set; }
        public string NekretninaNaziv { get; set; }
        public string ProjekatNaziv { get; set; }
        public decimal? Iznos { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public bool? CenaAktivna { get; set; }
    }
}
