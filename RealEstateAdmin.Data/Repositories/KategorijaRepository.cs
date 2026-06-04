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
            using (var ctx = new RealEstateDBDataContext())
            {
                return ctx.Kategorije
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
            if (kategorija == null)
            {
                throw new ArgumentNullException(nameof(kategorija));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Kategorija_Insert(kategorija.Naziv ?? string.Empty, kategorija.Opis ?? string.Empty);
            }
        }

        public void Update(KategorijaDTO kategorija)
        {
            if (kategorija == null)
            {
                throw new ArgumentNullException(nameof(kategorija));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Kategorija_Update(kategorija.KategorijaID, kategorija.Naziv ?? string.Empty, kategorija.Opis ?? string.Empty);
            }
        }

        public void Delete(int kategorijaId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Kategorija_Delete(kategorijaId);
            }
        }
    }
}
