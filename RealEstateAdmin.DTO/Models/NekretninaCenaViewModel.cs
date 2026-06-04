namespace RealEstateAdmin.DTO
{
    public class NekretninaCenaViewModel
    {
        public string Sifra { get; set; }
        public string NekretninaNaziv { get; set; }
        public string ProjekatNaziv { get; set; }
        public int BrojCena { get; set; }
        public decimal? MinIznos { get; set; }
        public decimal? MaxIznos { get; set; }
        public decimal? UkupnoIznos { get; set; }
    }
}
