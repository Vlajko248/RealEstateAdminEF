using System;
using System.Collections.Generic;
using RealEstateAdmin.Data;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Business
{
    public class GradService
    {
        private readonly GradRepository _gradRepository = new GradRepository();

        public List<GradDTO> GetAll()
        {
            return _gradRepository.GetAll();
        }

        public void Insert(GradDTO grad)
        {
            ValidateGrad(grad);
            _gradRepository.Insert(grad);
        }

        public void Update(GradDTO grad)
        {
            ValidateGrad(grad);
            _gradRepository.Update(grad);
        }

        public void Delete(int id)
        {
            _gradRepository.Delete(id);
        }

        private void ValidateGrad(GradDTO grad)
        {
            if (grad == null)
            {
                throw new ArgumentNullException(nameof(grad), "Grad ne sme biti null.");
            }

            if (string.IsNullOrWhiteSpace(grad.Naziv))
            {
                throw new ArgumentException("Naziv grada je obavezan.", nameof(grad.Naziv));
            }

            if (string.IsNullOrWhiteSpace(grad.PostanskiBroj))
            {
                throw new ArgumentException("Poštanski broj je obavezan.", nameof(grad.PostanskiBroj));
            }
        }
    }
}
