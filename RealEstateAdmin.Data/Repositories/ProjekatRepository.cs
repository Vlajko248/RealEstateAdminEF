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
            using (var ctx = new RealEstateDBDataContext())
            {
                return (from p in ctx.Projekti
                        orderby p.Naziv
                        select new ProjekatDTO
                        {
                            ProjekatID = p.ProjekatID,
                            Naziv = p.Naziv ?? string.Empty,
                            Adresa = p.Adresa ?? string.Empty,
                            GradID = p.GradID,
                            Opis = p.Opis ?? string.Empty,
                            GradNaziv = p.Grad != null ? p.Grad.Naziv : string.Empty
                        }).ToList();
            }
        }

        public void Insert(ProjekatDTO projekat)
        {
            if (projekat == null)
            {
                throw new ArgumentNullException(nameof(projekat));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Projekat_Insert(
                    projekat.Naziv ?? string.Empty,
                    projekat.Adresa ?? string.Empty,
                    projekat.GradID,
                    projekat.Opis ?? string.Empty);
            }
        }

        public void Update(ProjekatDTO projekat)
        {
            if (projekat == null)
            {
                throw new ArgumentNullException(nameof(projekat));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Projekat_Update(
                    projekat.ProjekatID,
                    projekat.Naziv ?? string.Empty,
                    projekat.Adresa ?? string.Empty,
                    projekat.GradID,
                    projekat.Opis ?? string.Empty);
            }
        }

        public void Delete(int projekatId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Projekat_Delete(projekatId);
            }
        }
    }
}
