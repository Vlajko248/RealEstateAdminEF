using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class KategorijaRepository
    {
        public List<KategorijaDTO> GetAll()
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Kategorija
                    .OrderBy(k => k.Naziv)
                    .Select(k => new KategorijaDTO
                    {
                        KategorijaID = k.KategorijaID,
                        Naziv = k.Naziv ?? string.Empty,
                        Opis = k.Opis ?? string.Empty
                    })
                    .ToList();
            }
        }

        public void Insert(KategorijaDTO kategorija)
        {
            if (kategorija == null) throw new ArgumentNullException(nameof(kategorija));

            using (var ctx = new RealEstateDBEntities())
            {
                ctx.Kategorija.Add(new Kategorija
                {
                    Naziv = kategorija.Naziv,
                    Opis = kategorija.Opis
                });
                ctx.SaveChanges();
            }
        }

        public void Update(KategorijaDTO kategorija)
        {
            if (kategorija == null) throw new ArgumentNullException(nameof(kategorija));

            using (var ctx = new RealEstateDBEntities())
            {
                var kategorijaDb = ctx.Kategorija.Find(kategorija.KategorijaID);
                if (kategorijaDb == null) throw new InvalidOperationException("Kategorija nije pronađena.");
                kategorijaDb.Naziv = kategorija.Naziv;
                kategorijaDb.Opis = kategorija.Opis;
                ctx.SaveChanges();
            }
        }

        public void Delete(int kategorijaId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var kategorija = ctx.Kategorija.Find(kategorijaId);
                if (kategorija == null) throw new InvalidOperationException("Kategorija nije pronađena.");
                ctx.Kategorija.Remove(kategorija);
                ctx.SaveChanges();
            }
        }
    }
}
