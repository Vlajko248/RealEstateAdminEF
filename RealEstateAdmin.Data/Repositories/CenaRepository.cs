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
                var entity = ctx.Cena.Find(cena.CenaID);
                if (entity == null) throw new InvalidOperationException("Cena nije pronađena.");
                entity.NekretninaID = cena.NekretninaID;
                entity.Iznos = cena.Iznos;
                entity.DatumOd = cena.DatumOd;
                entity.DatumDo = cena.DatumDo;
                entity.Aktivna = cena.Aktivna;
                ctx.SaveChanges();
            }
        }

        public void Delete(int cenaId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var entity = ctx.Cena.Find(cenaId);
                if (entity == null) throw new InvalidOperationException("Cena nije pronađena.");
                ctx.Cena.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
