using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class GradRepository
    {
        public List<GradDTO> GetAll()
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                return ctx.Gradovi
                    .OrderBy(g => g.Naziv)
                    .Select(g => new GradDTO
                    {
                        GradID = g.GradID,
                        Naziv = g.Naziv ?? string.Empty,
                        PostanskiBroj = g.PostanskiBroj ?? string.Empty
                    })
                    .ToList();
            }
        }

        public void Insert(GradDTO grad)
        {
            if (grad == null)
            {
                throw new ArgumentNullException(nameof(grad));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Grad_Insert(grad.Naziv ?? string.Empty, grad.PostanskiBroj ?? string.Empty);
            }
        }

        public void Update(GradDTO grad)
        {
            if (grad == null)
            {
                throw new ArgumentNullException(nameof(grad));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Grad_Update(grad.GradID, grad.Naziv ?? string.Empty, grad.PostanskiBroj ?? string.Empty);
            }
        }

        public void Delete(int gradId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Grad_Delete(gradId);
            }
        }
    }
}
