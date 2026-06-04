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
            using (var ctx = new RealEstateDBEntities())
            {
                return ctx.Grad
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
            if (grad == null) throw new ArgumentNullException(nameof(grad));

            using (var ctx = new RealEstateDBEntities())
            {
                ctx.Grad.Add(new Grad
                {
                    Naziv = grad.Naziv,
                    PostanskiBroj = grad.PostanskiBroj
                });
                ctx.SaveChanges();
            }
        }

        public void Update(GradDTO grad)
        {
            if (grad == null) throw new ArgumentNullException(nameof(grad));

            using (var ctx = new RealEstateDBEntities())
            {
                var entity = ctx.Grad.Find(grad.GradID);
                if (entity == null) throw new InvalidOperationException("Grad nije pronađen.");
                entity.Naziv = grad.Naziv;
                entity.PostanskiBroj = grad.PostanskiBroj;
                ctx.SaveChanges();
            }
        }

        public void Delete(int gradId)
        {
            using (var ctx = new RealEstateDBEntities())
            {
                var entity = ctx.Grad.Find(gradId);
                if (entity == null) throw new InvalidOperationException("Grad nije pronađen.");
                ctx.Grad.Remove(entity);
                ctx.SaveChanges();
            }
        }
    }
}
