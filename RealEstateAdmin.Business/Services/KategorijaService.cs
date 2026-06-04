using System;
using System.Collections.Generic;
using RealEstateAdmin.Data;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Business
{
    public class KategorijaService
    {
        private readonly KategorijaRepository _kategorijaRepository = new KategorijaRepository();

        public List<KategorijaDTO> GetAll()
        {
            return _kategorijaRepository.GetAll();
        }

        public void Insert(KategorijaDTO kategorija)
        {
            ValidateKategorija(kategorija);
            _kategorijaRepository.Insert(kategorija);
        }

        public void Update(KategorijaDTO kategorija)
        {
            ValidateKategorija(kategorija);
            _kategorijaRepository.Update(kategorija);
        }

        public void Delete(int id)
        {
            _kategorijaRepository.Delete(id);
        }

        private void ValidateKategorija(KategorijaDTO kategorija)
        {
            if (kategorija == null)
            {
                throw new ArgumentNullException(nameof(kategorija), "Kategorija ne sme biti null.");
            }

            if (string.IsNullOrWhiteSpace(kategorija.Naziv))
            {
                throw new ArgumentException("Naziv kategorije je obavezan.", nameof(kategorija.Naziv));
            }

            if (string.IsNullOrWhiteSpace(kategorija.Opis))
            {
                throw new ArgumentException("Opis je obavezan.", nameof(kategorija.Opis));
            }
        }
    }
}
