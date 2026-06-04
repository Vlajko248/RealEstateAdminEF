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
            using (var ctx = new RealEstateDBDataContext())
            {
                return (from s in ctx.Strukture
                        orderby s.Naziv
                        select new StrukturaDTO
                        {
                            StrukturaID = s.StrukturaID,
                            KategorijaID = s.KategorijaID,
                            Naziv = s.Naziv ?? string.Empty,
                            Opis = s.Opis ?? string.Empty,
                            KategorijaNaziv = s.Kategorija != null ? s.Kategorija.Naziv : string.Empty
                        }).ToList();
            }
        }

        public void Insert(StrukturaDTO struktura)
        {
            if (struktura == null)
            {
                throw new ArgumentNullException(nameof(struktura));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Struktura_Insert(
                    struktura.KategorijaID,
                    struktura.Naziv ?? string.Empty,
                    struktura.Opis ?? string.Empty);
            }
        }

        public void Update(StrukturaDTO struktura)
        {
            if (struktura == null)
            {
                throw new ArgumentNullException(nameof(struktura));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Struktura_Update(
                    struktura.StrukturaID,
                    struktura.KategorijaID,
                    struktura.Naziv ?? string.Empty,
                    struktura.Opis ?? string.Empty);
            }
        }

        public void Delete(int strukturaId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Struktura_Delete(strukturaId);
            }
        }
    }
}
