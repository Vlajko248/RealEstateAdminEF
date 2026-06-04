using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class NekretninaRepository
    {
        public List<NekretninaDTO> GetAll()
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Nekretnina
                    .OrderBy(n => n.Naziv)
                    .Select(n => new NekretninaDTO
                    {
                        NekretninaID = n.NekretninaID,
                        ProjekatID = n.ProjekatID,
                        KategorijaID = n.KategorijaID,
                        StrukturaID = n.StrukturaID,
                        Sifra = n.Sifra ?? string.Empty,
                        Naziv = n.Naziv ?? string.Empty,
                        Sprat = n.Sprat,
                        Kvadratura = n.Kvadratura,
                        Opis = n.Opis ?? string.Empty,
                        Aktivna = n.Aktivna,
                        ProjekatNaziv = n.Projekat != null ? n.Projekat.Naziv : string.Empty,
                        KategorijaNaziv = n.Kategorija != null ? n.Kategorija.Naziv : string.Empty,
                        StrukturaNaziv = n.Struktura != null ? n.Struktura.Naziv : string.Empty
                    })
                    .ToList();
            }
        }

        public List<NekretninaCenaViewModel> GetNekretninaCenaStat()
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Nekretnina
                    .GroupJoin(
                        ctx.Cena,
                        n => n.NekretninaID,
                        c => c.NekretninaID,
                        (n, cene) => new NekretninaCenaViewModel
                        {
                            Sifra = n.Sifra,
                            NekretninaNaziv = n.Naziv,
                            ProjekatNaziv = n.Projekat.Naziv,
                            BrojCena = cene.Count(),
                            MinIznos = cene.Min(c => (decimal?)c.Iznos),
                            MaxIznos = cene.Max(c => (decimal?)c.Iznos),
                            UkupnoIznos = cene.Sum(c => (decimal?)c.Iznos)
                        })
                    .OrderByDescending(x => x.BrojCena)
                    .ToList();
            }
        }

        public void Insert(NekretninaDTO nekretnina)
        {
            if (nekretnina == null) throw new ArgumentNullException(nameof(nekretnina));

            using (var ctx = new RealEstateDBEntities())
            {
                ctx.Nekretnina.Add(new Nekretnina
                {
                    ProjekatID = nekretnina.ProjekatID,
                    KategorijaID = nekretnina.KategorijaID,
                    StrukturaID = nekretnina.StrukturaID,
                    Sifra = nekretnina.Sifra,
                    Naziv = nekretnina.Naziv,
                    Sprat = nekretnina.Sprat,
                    Kvadratura = nekretnina.Kvadratura,
                    Opis = nekretnina.Opis,
                    Aktivna = nekretnina.Aktivna
                });
                ctx.SaveChanges();
            }
        }

        public void Update(NekretninaDTO nekretnina)
        {
            if (nekretnina == null) throw new ArgumentNullException(nameof(nekretnina));

            using (var ctx = new RealEstateDBEntities())
            {
                var nekretninaDb = ctx.Nekretnina.Find(nekretnina.NekretninaID);
                if (nekretninaDb == null) throw new InvalidOperationException("Nekretnina nije pronađena.");
                nekretninaDb.ProjekatID = nekretnina.ProjekatID;
                nekretninaDb.KategorijaID = nekretnina.KategorijaID;
                nekretninaDb.StrukturaID = nekretnina.StrukturaID;
                nekretninaDb.Sifra = nekretnina.Sifra;
                nekretninaDb.Naziv = nekretnina.Naziv;
                nekretninaDb.Sprat = nekretnina.Sprat;
                nekretninaDb.Kvadratura = nekretnina.Kvadratura;
                nekretninaDb.Opis = nekretnina.Opis;
                nekretninaDb.Aktivna = nekretnina.Aktivna;
                ctx.SaveChanges();
            }
        }

        public void Delete(int nekretninaId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var nekretnina = ctx.Nekretnina.Find(nekretninaId);
                if (nekretnina == null) throw new InvalidOperationException("Nekretnina nije pronađena.");
                ctx.Nekretnina.Remove(nekretnina);
                ctx.SaveChanges();
            }
        }
    }
}
