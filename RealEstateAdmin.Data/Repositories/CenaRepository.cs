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
            using (var ctx = new RealEstateDBDataContext())
            {
                return (from c in ctx.Cene
                        orderby c.DatumOd descending
                        select new CenaDTO
                        {
                            CenaID = c.CenaID,
                            NekretninaID = c.NekretninaID,
                            Iznos = c.Iznos,
                            DatumOd = c.DatumOd,
                            DatumDo = c.DatumDo,
                            Aktivna = c.Aktivna,
                            NekretninaNaziv = c.Nekretnina != null ? c.Nekretnina.Naziv : string.Empty
                        }).ToList();
            }
        }

        public List<CenaDTO> GetByNekretninaId(int nekretninaId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                return ctx.Cene
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
            if (cena == null)
            {
                throw new ArgumentNullException(nameof(cena));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Cena_Insert(cena.NekretninaID, cena.Iznos, cena.DatumOd, cena.DatumDo, cena.Aktivna);
            }
        }

        public void Update(CenaDTO cena)
        {
            if (cena == null)
            {
                throw new ArgumentNullException(nameof(cena));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Cena_Update(cena.CenaID, cena.NekretninaID, cena.Iznos, cena.DatumOd, cena.DatumDo, cena.Aktivna);
            }
        }

        public void Delete(int cenaId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Cena_Delete(cenaId);
            }
        }
    }
}
