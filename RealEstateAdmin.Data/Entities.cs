using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace RealEstateAdmin.Data
{
    [Table(Name = "Grad")]
    public class Grad
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int GradID { get; set; }

        [Column]
        public string Naziv { get; set; }

        [Column]
        public string PostanskiBroj { get; set; }

        private EntitySet<Projekat> _projekti = new EntitySet<Projekat>();

        [Association(Name = "FK_Projekat_Grad", Storage = "_projekti", OtherKey = "GradID")]
        public EntitySet<Projekat> Projekti
        {
            get { return _projekti; }
            set { _projekti.Assign(value); }
        }
    }

    [Table(Name = "Projekat")]
    public class Projekat
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ProjekatID { get; set; }

        [Column]
        public string Naziv { get; set; }

        [Column]
        public string Adresa { get; set; }

        [Column]
        public int GradID { get; set; }

        [Column]
        public string Opis { get; set; }

        private EntityRef<Grad> _grad;

        [Association(Name = "FK_Projekat_Grad", Storage = "_grad", ThisKey = "GradID", IsForeignKey = true)]
        public Grad Grad
        {
            get { return _grad.Entity; }
            set { _grad.Entity = value; }
        }

        private EntitySet<Nekretnina> _nekretnine = new EntitySet<Nekretnina>();

        [Association(Name = "FK_Nekretnina_Projekat", Storage = "_nekretnine", OtherKey = "ProjekatID")]
        public EntitySet<Nekretnina> Nekretnine
        {
            get { return _nekretnine; }
            set { _nekretnine.Assign(value); }
        }
    }

    [Table(Name = "Kategorija")]
    public class Kategorija
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int KategorijaID { get; set; }

        [Column]
        public string Naziv { get; set; }

        [Column]
        public string Opis { get; set; }

        private EntitySet<Struktura> _strukture = new EntitySet<Struktura>();

        [Association(Name = "FK_Struktura_Kategorija", Storage = "_strukture", OtherKey = "KategorijaID")]
        public EntitySet<Struktura> Strukture
        {
            get { return _strukture; }
            set { _strukture.Assign(value); }
        }

        private EntitySet<Nekretnina> _nekretnine = new EntitySet<Nekretnina>();

        [Association(Name = "FK_Nekretnina_Kategorija", Storage = "_nekretnine", OtherKey = "KategorijaID")]
        public EntitySet<Nekretnina> Nekretnine
        {
            get { return _nekretnine; }
            set { _nekretnine.Assign(value); }
        }
    }

    [Table(Name = "Struktura")]
    public class Struktura
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int StrukturaID { get; set; }

        [Column]
        public int KategorijaID { get; set; }

        [Column]
        public string Naziv { get; set; }

        [Column]
        public string Opis { get; set; }

        private EntityRef<Kategorija> _kategorija;

        [Association(Name = "FK_Struktura_Kategorija", Storage = "_kategorija", ThisKey = "KategorijaID", IsForeignKey = true)]
        public Kategorija Kategorija
        {
            get { return _kategorija.Entity; }
            set { _kategorija.Entity = value; }
        }

        private EntitySet<Nekretnina> _nekretnine = new EntitySet<Nekretnina>();

        [Association(Name = "FK_Nekretnina_Struktura", Storage = "_nekretnine", OtherKey = "StrukturaID")]
        public EntitySet<Nekretnina> Nekretnine
        {
            get { return _nekretnine; }
            set { _nekretnine.Assign(value); }
        }
    }

    [Table(Name = "Nekretnina")]
    public class Nekretnina
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int NekretninaID { get; set; }

        [Column]
        public int ProjekatID { get; set; }

        [Column]
        public int KategorijaID { get; set; }

        [Column]
        public int StrukturaID { get; set; }

        [Column]
        public string Sifra { get; set; }

        [Column]
        public string Naziv { get; set; }

        [Column]
        public int Sprat { get; set; }

        [Column]
        public decimal Kvadratura { get; set; }

        [Column]
        public string Opis { get; set; }

        [Column]
        public bool Aktivna { get; set; }

        private EntityRef<Projekat> _projekat;

        [Association(Name = "FK_Nekretnina_Projekat", Storage = "_projekat", ThisKey = "ProjekatID", IsForeignKey = true)]
        public Projekat Projekat
        {
            get { return _projekat.Entity; }
            set { _projekat.Entity = value; }
        }

        private EntityRef<Kategorija> _kategorija;

        [Association(Name = "FK_Nekretnina_Kategorija", Storage = "_kategorija", ThisKey = "KategorijaID", IsForeignKey = true)]
        public Kategorija Kategorija
        {
            get { return _kategorija.Entity; }
            set { _kategorija.Entity = value; }
        }

        private EntityRef<Struktura> _struktura;

        [Association(Name = "FK_Nekretnina_Struktura", Storage = "_struktura", ThisKey = "StrukturaID", IsForeignKey = true)]
        public Struktura Struktura
        {
            get { return _struktura.Entity; }
            set { _struktura.Entity = value; }
        }

        private EntitySet<Cena> _cene = new EntitySet<Cena>();

        [Association(Name = "FK_Cena_Nekretnina", Storage = "_cene", OtherKey = "NekretninaID")]
        public EntitySet<Cena> Cene
        {
            get { return _cene; }
            set { _cene.Assign(value); }
        }
    }

    [Table(Name = "Cena")]
    public class Cena
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int CenaID { get; set; }

        [Column]
        public int NekretninaID { get; set; }

        [Column]
        public decimal Iznos { get; set; }

        [Column]
        public DateTime DatumOd { get; set; }

        [Column]
        public DateTime DatumDo { get; set; }

        [Column]
        public bool Aktivna { get; set; }

        private EntityRef<Nekretnina> _nekretnina;

        [Association(Name = "FK_Cena_Nekretnina", Storage = "_nekretnina", ThisKey = "NekretninaID", IsForeignKey = true)]
        public Nekretnina Nekretnina
        {
            get { return _nekretnina.Entity; }
            set { _nekretnina.Entity = value; }
        }
    }
}
