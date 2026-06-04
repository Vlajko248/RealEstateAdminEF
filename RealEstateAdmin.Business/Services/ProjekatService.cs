using System;
using System.Collections.Generic;
using RealEstateAdmin.Data;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Business
{
    public class ProjekatService
    {
        private readonly ProjekatRepository _projekatRepository = new ProjekatRepository();

        public List<ProjekatDTO> GetAll()
        {
            return _projekatRepository.GetAll();
        }

        public void Insert(ProjekatDTO projekat)
        {
            ValidateProjekat(projekat);
            _projekatRepository.Insert(projekat);
        }

        public void Update(ProjekatDTO projekat)
        {
            ValidateProjekat(projekat);
            _projekatRepository.Update(projekat);
        }

        public void Delete(int id)
        {
            _projekatRepository.Delete(id);
        }

        private void ValidateProjekat(ProjekatDTO projekat)
        {
            if (projekat == null)
            {
                throw new ArgumentNullException(nameof(projekat), "Projekat ne sme biti null.");
            }

            if (string.IsNullOrWhiteSpace(projekat.Naziv))
            {
                throw new ArgumentException("Naziv projekta je obavezan.", nameof(projekat.Naziv));
            }

            if (string.IsNullOrWhiteSpace(projekat.Adresa))
            {
                throw new ArgumentException("Adresa je obavezna.", nameof(projekat.Adresa));
            }

            if (string.IsNullOrWhiteSpace(projekat.Opis))
            {
                throw new ArgumentException("Opis je obavezan.", nameof(projekat.Opis));
            }

            if (projekat.GradID <= 0)
            {
                throw new ArgumentException("GradID mora biti veći od 0.", nameof(projekat.GradID));
            }
        }
    }
}
