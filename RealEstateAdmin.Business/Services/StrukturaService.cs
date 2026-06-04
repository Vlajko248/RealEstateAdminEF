using System;
using System.Collections.Generic;
using RealEstateAdmin.Data;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Business
{
    public class StrukturaService
    {
        private readonly StrukturaRepository _strukturaRepository = new StrukturaRepository();

        public List<StrukturaDTO> GetAll()
        {
            return _strukturaRepository.GetAll();
        }

        public void Insert(StrukturaDTO struktura)
        {
            ValidateStruktura(struktura);
            _strukturaRepository.Insert(struktura);
        }

        public void Update(StrukturaDTO struktura)
        {
            ValidateStruktura(struktura);
            _strukturaRepository.Update(struktura);
        }

        public void Delete(int id)
        {
            _strukturaRepository.Delete(id);
        }

        private void ValidateStruktura(StrukturaDTO struktura)
        {
            if (struktura == null)
            {
                throw new ArgumentNullException(nameof(struktura), "Struktura ne sme biti null.");
            }

            if (struktura.KategorijaID <= 0)
            {
                throw new ArgumentException("KategorijaID mora biti veći od 0.", nameof(struktura.KategorijaID));
            }

            if (string.IsNullOrWhiteSpace(struktura.Naziv))
            {
                throw new ArgumentException("Naziv strukture je obavezan.", nameof(struktura.Naziv));
            }

            if (string.IsNullOrWhiteSpace(struktura.Opis))
            {
                throw new ArgumentException("Opis je obavezan.", nameof(struktura.Opis));
            }
        }
    }
}
