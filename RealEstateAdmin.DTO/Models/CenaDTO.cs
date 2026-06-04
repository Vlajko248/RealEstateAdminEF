using System;

namespace RealEstateAdmin.DTO
{
    public class CenaDTO
    {
        public int CenaID { get; set; }
        public int NekretninaID { get; set; }
        public decimal Iznos { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public bool Aktivna { get; set; }
        public string NekretninaNaziv { get; set; }
    }
}
