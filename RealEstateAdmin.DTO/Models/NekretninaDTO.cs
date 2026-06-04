namespace RealEstateAdmin.DTO
{
    public class NekretninaDTO
    {
        public int NekretninaID { get; set; }
        public int ProjekatID { get; set; }
        public int KategorijaID { get; set; }
        public int StrukturaID { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public int Sprat { get; set; }
        public decimal Kvadratura { get; set; }
        public string Opis { get; set; }
        public bool Aktivna { get; set; }
        public string ProjekatNaziv { get; set; }
        public string KategorijaNaziv { get; set; }
        public string StrukturaNaziv { get; set; }
    }
}
