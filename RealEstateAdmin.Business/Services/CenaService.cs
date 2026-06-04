using System;
using System.Collections.Generic;
using RealEstateAdmin.Data;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Business
{
    public class CenaService
    {
        private readonly CenaRepository _cenaRepository = new CenaRepository();

        public List<CenaDTO> GetAll()
        {
            return _cenaRepository.GetAll();
        }

        public List<CenaDTO> GetByNekretninaId(int nekretninaId)
        {
            return _cenaRepository.GetByNekretninaId(nekretninaId);
        }

        public void Insert(CenaDTO cena)
        {
            ValidateCena(cena);
            _cenaRepository.Insert(cena);
        }

        public void Update(CenaDTO cena)
        {
            ValidateCena(cena);
            _cenaRepository.Update(cena);
        }

        public void Delete(int id)
        {
            _cenaRepository.Delete(id);
        }

        private void ValidateCena(CenaDTO cena)
        {
            if (cena == null)
            {
                throw new ArgumentNullException(nameof(cena), "Cena ne sme biti null.");
            }

            if (cena.NekretninaID <= 0)
            {
                throw new ArgumentException("NekretninaID mora biti veći od 0.", nameof(cena.NekretninaID));
            }

            if (cena.Iznos <= 0)
            {
                throw new ArgumentException("Iznos mora biti veći od 0.", nameof(cena.Iznos));
            }

            if (cena.DatumOd > cena.DatumDo)
            {
                throw new ArgumentException("DatumOd ne sme biti veći od DatumDo.");
            }
        }
    }
}
