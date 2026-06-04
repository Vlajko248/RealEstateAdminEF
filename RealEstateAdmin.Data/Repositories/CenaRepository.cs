using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class CenaRepository
    {
        public List<CenaDTO> GetAll()
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Cena
                    .OrderByDescending(c => c.DatumOd)
                    .Select(c => new CenaDTO
                    {
                        CenaID = c.CenaID,
                        NekretninaID = c.NekretninaID,
                        Iznos = c.Iznos,
                        DatumOd = c.DatumOd,
                        DatumDo = c.DatumDo,
                        Aktivna = c.Aktivna,
                        NekretninaNaziv = c.Nekretnina != null ? c.Nekretnina.Naziv : string.Empty
                    })
                    .ToList();
            }
        }

        public List<CenaDTO> GetByNekretninaId(int nekretninaId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Cena
                    .Where(c => c.NekretninaID == nekretninaId)
                    .OrderByDescending(c => c.DatumOd)
                    .Select(c => new CenaDTO
                    {
                        CenaID = c.CenaID,
                        NekretninaID = c.NekretninaID,
                        Iznos = c.Iznos,
                        DatumOd = c.DatumOd,
                        DatumDo = c.DatumDo,
                        Aktivna = c.Aktivna,
                        NekretninaNaziv = c.Nekretnina != null ? c.Nekretnina.Naziv : string.Empty
                    })
                    .ToList();
            }
        }

        public void Insert(CenaDTO cena)
        {
            if (cena == null) throw new ArgumentNullException(nameof(cena));

            using (var ctx = new RealEstateDBEntities())
            {
                ctx.Cena.Add(new Cena
                {
                    NekretninaID = cena.NekretninaID,
                    Iznos = cena.Iznos,
                    DatumOd = cena.DatumOd,
                    DatumDo = cena.DatumDo,
                    Aktivna = cena.Aktivna
                });
                ctx.SaveChanges();
            }
        }

        public void Update(CenaDTO cena)
        {
            if (cena == null) throw new ArgumentNullException(nameof(cena));

            using (var ctx = new RealEstateDBEntities())
            {
                var cenaDb = ctx.Cena.Find(cena.CenaID);
                if (cenaDb == null) throw new InvalidOperationException("Cena nije pronađena.");
                cenaDb.NekretninaID = cena.NekretninaID;
                cenaDb.Iznos = cena.Iznos;
                cenaDb.DatumOd = cena.DatumOd;
                cenaDb.DatumDo = cena.DatumDo;
                cenaDb.Aktivna = cena.Aktivna;
                ctx.SaveChanges();
            }
        }

        public void Delete(int cenaId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var cena = ctx.Cena.Find(cenaId);
                if (cena == null) throw new InvalidOperationException("Cena nije pronađena.");
                ctx.Cena.Remove(cena);
                ctx.SaveChanges();
            }
        }
    }
}
