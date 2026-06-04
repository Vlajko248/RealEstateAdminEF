using System;
using System.Configuration;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace RealEstateAdmin.Data
{
    public class RealEstateDBDataContext : DataContext
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["tsql"] != null
                ? ConfigurationManager.ConnectionStrings["tsql"].ConnectionString
                : throw new ConfigurationErrorsException("Connection string 'tsql' was not found.");

        public RealEstateDBDataContext() : base(_connectionString) { }

        public Table<Grad> Gradovi => GetTable<Grad>();
        public Table<Projekat> Projekti => GetTable<Projekat>();
        public Table<Kategorija> Kategorije => GetTable<Kategorija>();
        public Table<Struktura> Strukture => GetTable<Struktura>();
        public Table<Nekretnina> Nekretnine => GetTable<Nekretnina>();
        public Table<Cena> Cene => GetTable<Cena>();

        [Function(Name = "sp_Grad_Insert")]
        public int sp_Grad_Insert(
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "PostanskiBroj")] string postanskiBroj)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), naziv, postanskiBroj);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Grad_Update")]
        public int sp_Grad_Update(
            [Parameter(Name = "GradID")] int gradId,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "PostanskiBroj")] string postanskiBroj)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), gradId, naziv, postanskiBroj);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Grad_Delete")]
        public int sp_Grad_Delete(
            [Parameter(Name = "GradID")] int gradId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), gradId);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Projekat_Insert")]
        public int sp_Projekat_Insert(
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Adresa")] string adresa,
            [Parameter(Name = "GradID")] int gradId,
            [Parameter(Name = "Opis")] string opis)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), naziv, adresa, gradId, opis);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Projekat_Update")]
        public int sp_Projekat_Update(
            [Parameter(Name = "ProjekatID")] int projekatId,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Adresa")] string adresa,
            [Parameter(Name = "GradID")] int gradId,
            [Parameter(Name = "Opis")] string opis)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), projekatId, naziv, adresa, gradId, opis);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Projekat_Delete")]
        public int sp_Projekat_Delete(
            [Parameter(Name = "ProjekatID")] int projekatId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), projekatId);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Kategorija_Insert")]
        public int sp_Kategorija_Insert(
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Opis")] string opis)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), naziv, opis);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Kategorija_Update")]
        public int sp_Kategorija_Update(
            [Parameter(Name = "KategorijaID")] int kategorijaId,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Opis")] string opis)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), kategorijaId, naziv, opis);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Kategorija_Delete")]
        public int sp_Kategorija_Delete(
            [Parameter(Name = "KategorijaID")] int kategorijaId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), kategorijaId);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Struktura_Insert")]
        public int sp_Struktura_Insert(
            [Parameter(Name = "KategorijaID")] int kategorijaId,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Opis")] string opis)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), kategorijaId, naziv, opis);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Struktura_Update")]
        public int sp_Struktura_Update(
            [Parameter(Name = "StrukturaID")] int strukturaId,
            [Parameter(Name = "KategorijaID")] int kategorijaId,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Opis")] string opis)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), strukturaId, kategorijaId, naziv, opis);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Struktura_Delete")]
        public int sp_Struktura_Delete(
            [Parameter(Name = "StrukturaID")] int strukturaId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), strukturaId);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Nekretnina_Insert")]
        public int sp_Nekretnina_Insert(
            [Parameter(Name = "ProjekatID")] int projekatId,
            [Parameter(Name = "KategorijaID")] int kategorijaId,
            [Parameter(Name = "StrukturaID")] int strukturaId,
            [Parameter(Name = "Sifra")] string sifra,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Sprat")] int sprat,
            [Parameter(Name = "Kvadratura")] decimal kvadratura,
            [Parameter(Name = "Opis")] string opis,
            [Parameter(Name = "Aktivna")] bool aktivna)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), projekatId, kategorijaId, strukturaId, sifra, naziv, sprat, kvadratura, opis, aktivna);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Nekretnina_Update")]
        public int sp_Nekretnina_Update(
            [Parameter(Name = "NekretninaID")] int nekretninaId,
            [Parameter(Name = "ProjekatID")] int projekatId,
            [Parameter(Name = "KategorijaID")] int kategorijaId,
            [Parameter(Name = "StrukturaID")] int strukturaId,
            [Parameter(Name = "Sifra")] string sifra,
            [Parameter(Name = "Naziv")] string naziv,
            [Parameter(Name = "Sprat")] int sprat,
            [Parameter(Name = "Kvadratura")] decimal kvadratura,
            [Parameter(Name = "Opis")] string opis,
            [Parameter(Name = "Aktivna")] bool aktivna)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nekretninaId, projekatId, kategorijaId, strukturaId, sifra, naziv, sprat, kvadratura, opis, aktivna);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Nekretnina_Delete")]
        public int sp_Nekretnina_Delete(
            [Parameter(Name = "NekretninaID")] int nekretninaId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nekretninaId);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Cena_Insert")]
        public int sp_Cena_Insert(
            [Parameter(Name = "NekretninaID")] int nekretninaId,
            [Parameter(Name = "Iznos")] decimal iznos,
            [Parameter(Name = "DatumOd")] DateTime datumOd,
            [Parameter(Name = "DatumDo")] DateTime datumDo,
            [Parameter(Name = "Aktivna")] bool aktivna)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), nekretninaId, iznos, datumOd, datumDo, aktivna);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Cena_Update")]
        public int sp_Cena_Update(
            [Parameter(Name = "CenaID")] int cenaId,
            [Parameter(Name = "NekretninaID")] int nekretninaId,
            [Parameter(Name = "Iznos")] decimal iznos,
            [Parameter(Name = "DatumOd")] DateTime datumOd,
            [Parameter(Name = "DatumDo")] DateTime datumDo,
            [Parameter(Name = "Aktivna")] bool aktivna)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cenaId, nekretninaId, iznos, datumOd, datumDo, aktivna);
            return Convert.ToInt32(result.ReturnValue);
        }

        [Function(Name = "sp_Cena_Delete")]
        public int sp_Cena_Delete(
            [Parameter(Name = "CenaID")] int cenaId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, (MethodInfo)MethodBase.GetCurrentMethod(), cenaId);
            return Convert.ToInt32(result.ReturnValue);
        }
    }
}
