using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class ProjekatRepository
    {
        public List<ProjekatDTO> GetAll()
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Projekat
                    .OrderBy(p => p.Naziv)
                    .Select(p => new ProjekatDTO
                    {
                        ProjekatID = p.ProjekatID,
                        Naziv = p.Naziv ?? string.Empty,
                        Adresa = p.Adresa ?? string.Empty,
                        GradID = p.GradID,
                        Opis = p.Opis ?? string.Empty,
                        GradNaziv = p.Grad != null ? p.Grad.Naziv : string.Empty
                    })
                    .ToList();
            }
        }

        public void Insert(ProjekatDTO projekat)
        {
            if (projekat == null) throw new ArgumentNullException(nameof(projekat));

            using (var ctx = new RealEstateDBEntities())
            {
                ctx.Projekat.Add(new Projekat
                {
                    Naziv = projekat.Naziv,
                    Adresa = projekat.Adresa,
                    GradID = projekat.GradID,
                    Opis = projekat.Opis
                });
                ctx.SaveChanges();
            }
        }

        public void Update(ProjekatDTO projekat)
        {
            if (projekat == null) throw new ArgumentNullException(nameof(projekat));

            using (var ctx = new RealEstateDBEntities())
            {
                var projekatDb = ctx.Projekat.Find(projekat.ProjekatID);
                if (projekatDb == null) throw new InvalidOperationException("Projekat nije pronađen.");
                projekatDb.Naziv = projekat.Naziv;
                projekatDb.Adresa = projekat.Adresa;
                projekatDb.GradID = projekat.GradID;
                projekatDb.Opis = projekat.Opis;
                ctx.SaveChanges();
            }
        }

        public void Delete(int projekatId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var projekat = ctx.Projekat.Find(projekatId);
                if (projekat == null) throw new InvalidOperationException("Projekat nije pronađen.");
                ctx.Projekat.Remove(projekat);
                ctx.SaveChanges();
            }
        }
    }
}
