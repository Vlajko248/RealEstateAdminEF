using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class StrukturaRepository
    {
        public List<StrukturaDTO> GetAll()
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Struktura
                    .OrderBy(s => s.Naziv)
                    .Select(s => new StrukturaDTO
                    {
                        StrukturaID = s.StrukturaID,
                        KategorijaID = s.KategorijaID,
                        Naziv = s.Naziv ?? string.Empty,
                        Opis = s.Opis ?? string.Empty,
                        KategorijaNaziv = s.Kategorija != null ? s.Kategorija.Naziv : string.Empty
                    })
                    .ToList();
            }
        }

        public void Insert(StrukturaDTO struktura)
        {
            if (struktura == null) throw new ArgumentNullException(nameof(struktura));

            using (var ctx = new RealEstateDBEntities())
            {
                ctx.Struktura.Add(new Struktura
                {
                    KategorijaID = struktura.KategorijaID,
                    Naziv = struktura.Naziv,
                    Opis = struktura.Opis
                });
                ctx.SaveChanges();
            }
        }

        public void Update(StrukturaDTO struktura)
        {
            if (struktura == null) throw new ArgumentNullException(nameof(struktura));

            using (var ctx = new RealEstateDBEntities())
            {
                var strukturaDb = ctx.Struktura.Find(struktura.StrukturaID);
                if (strukturaDb == null) throw new InvalidOperationException("Struktura nije pronađena.");
                strukturaDb.KategorijaID = struktura.KategorijaID;
                strukturaDb.Naziv = struktura.Naziv;
                strukturaDb.Opis = struktura.Opis;
                ctx.SaveChanges();
            }
        }

        public void Delete(int strukturaId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var struktura = ctx.Struktura.Find(strukturaId);
                if (struktura == null) throw new InvalidOperationException("Struktura nije pronađena.");
                ctx.Struktura.Remove(struktura);
                ctx.SaveChanges();
            }
        }
    }
}
