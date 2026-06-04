using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.Data;
using RealEstateAdmin.DTO;


namespace RealEstateAdmin.Business
{
    public class NekretninaService
    {
        private readonly NekretninaRepository _nekretninaRepository = new NekretninaRepository();
        private readonly StrukturaRepository _strukturaRepository = new StrukturaRepository();

        public List<NekretninaDTO> GetAll()
        {
            return _nekretninaRepository.GetAll();
        }

        public List<NekretninaCenaViewModel> GetNekretninaCenaStat()
        {
            return _nekretninaRepository.GetNekretninaCenaStat();
        }

        public void Insert(NekretninaDTO nekretnina)
        {
            ValidateNekretnina(nekretnina);
            _nekretninaRepository.Insert(nekretnina);
        }

        public void Update(NekretninaDTO nekretnina)
        {
            ValidateNekretnina(nekretnina);
            _nekretninaRepository.Update(nekretnina);
        }

        public void Delete(int id)
        {
            _nekretninaRepository.Delete(id);
        }

        private void ValidateNekretnina(NekretninaDTO nekretnina)
        {
            if (nekretnina == null)
            {
                throw new ArgumentNullException(nameof(nekretnina), "Nekretnina ne sme biti null.");
            }

            if (nekretnina.ProjekatID <= 0)
            {
                throw new ArgumentException("ProjekatID mora biti veći od 0.", nameof(nekretnina.ProjekatID));
            }

            if (nekretnina.KategorijaID <= 0)
            {
                throw new ArgumentException("KategorijaID mora biti veći od 0.", nameof(nekretnina.KategorijaID));
            }

            if (nekretnina.StrukturaID <= 0)
            {
                throw new ArgumentException("StrukturaID mora biti veći od 0.", nameof(nekretnina.StrukturaID));
            }

            var struktura = _strukturaRepository.GetAll().FirstOrDefault(x => x.StrukturaID == nekretnina.StrukturaID);

            if (struktura == null)
            {
                throw new ArgumentException("Izabrana struktura ne postoji.", nameof(nekretnina.StrukturaID));
            }

            if (struktura.KategorijaID != nekretnina.KategorijaID)
            {
                throw new ArgumentException("Izabrana struktura ne pripada izabranoj kategoriji.");
            }

            if (string.IsNullOrWhiteSpace(nekretnina.Sifra))
            {
                throw new ArgumentException("Šifra je obavezna.", nameof(nekretnina.Sifra));
            }

            if (string.IsNullOrWhiteSpace(nekretnina.Naziv))
            {
                throw new ArgumentException("Naziv nekretnine je obavezan.", nameof(nekretnina.Naziv));
            }

            if (string.IsNullOrWhiteSpace(nekretnina.Opis))
            {
                throw new ArgumentException("Opis je obavezan.", nameof(nekretnina.Opis));
            }

            if (nekretnina.Kvadratura <= 0)
            {
                throw new ArgumentException("Kvadratura mora biti veća od 0.", nameof(nekretnina.Kvadratura));
            }
        }
    }
}
