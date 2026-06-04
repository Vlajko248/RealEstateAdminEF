using System;
using System.Collections.Generic;
using System.Linq;
using RealEstateAdmin.DTO;

namespace RealEstateAdmin.Data
{
    public class NekretninaRepository
    {
        public List<NekretninaDTO> GetAll()
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                return (from n in ctx.Nekretnine
                        orderby n.Naziv
                        select new NekretninaDTO
                        {
                            NekretninaID = n.NekretninaID,
                            ProjekatID = n.ProjekatID,
                            KategorijaID = n.KategorijaID,
                            StrukturaID = n.StrukturaID,
                            Sifra = n.Sifra ?? string.Empty,
                            Naziv = n.Naziv ?? string.Empty,
                            Sprat = n.Sprat,
                            Kvadratura = n.Kvadratura,
                            Opis = n.Opis ?? string.Empty,
                            Aktivna = n.Aktivna,
                            ProjekatNaziv = n.Projekat != null ? n.Projekat.Naziv : string.Empty,
                            KategorijaNaziv = n.Kategorija != null ? n.Kategorija.Naziv : string.Empty,
                            StrukturaNaziv = n.Struktura != null ? n.Struktura.Naziv : string.Empty
                        }).ToList();
            }
        }

        public List<NekretninaCenaViewModel> GetNekretnineCenaLeftJoin()
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                var query = from n in ctx.Nekretnine
                            join p in ctx.Projekti on n.ProjekatID equals p.ProjekatID
                            join c in ctx.Cene on n.NekretninaID equals c.NekretninaID into ceneGroup
                            from c in ceneGroup.DefaultIfEmpty()
                            orderby n.Naziv
                            select new NekretninaCenaViewModel
                            {
                                Sifra = n.Sifra,
                                NekretninaNaziv = n.Naziv,
                                ProjekatNaziv = p.Naziv,
                                Iznos = (decimal?)c.Iznos,
                                DatumOd = (DateTime?)c.DatumOd,
                                DatumDo = (DateTime?)c.DatumDo,
                                CenaAktivna = (bool?)c.Aktivna
                            };

                return query.ToList();
            }
        }

        public void Insert(NekretninaDTO nekretnina)
        {
            if (nekretnina == null)
            {
                throw new ArgumentNullException(nameof(nekretnina));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Nekretnina_Insert(
                    nekretnina.ProjekatID,
                    nekretnina.KategorijaID,
                    nekretnina.StrukturaID,
                    nekretnina.Sifra ?? string.Empty,
                    nekretnina.Naziv ?? string.Empty,
                    nekretnina.Sprat,
                    nekretnina.Kvadratura,
                    nekretnina.Opis ?? string.Empty,
                    nekretnina.Aktivna);
            }
        }

        public void Update(NekretninaDTO nekretnina)
        {
            if (nekretnina == null)
            {
                throw new ArgumentNullException(nameof(nekretnina));
            }

            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Nekretnina_Update(
                    nekretnina.NekretninaID,
                    nekretnina.ProjekatID,
                    nekretnina.KategorijaID,
                    nekretnina.StrukturaID,
                    nekretnina.Sifra ?? string.Empty,
                    nekretnina.Naziv ?? string.Empty,
                    nekretnina.Sprat,
                    nekretnina.Kvadratura,
                    nekretnina.Opis ?? string.Empty,
                    nekretnina.Aktivna);
            }
        }

        public void Delete(int nekretninaId)
        {
            using (var ctx = new RealEstateDBDataContext())
            {
                ctx.sp_Nekretnina_Delete(nekretninaId);
            }
        }
    }
}
