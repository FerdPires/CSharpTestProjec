using HotelReservation.Domain;
using HotelReservation.Domain.Repository;
using HotelReservation.Enum;
using System.Collections.Generic;

namespace CSharpTestProject.FakeRepositories
{
    public class FakeHotelRepository : IHotelRepository
    {
        public List<Hotel> GetHotels()
        {
            return new List<Hotel>()
            {
                new Hotel(
                    "Parque das flores",
                    3,
                    new List<Preco>() {
                        new Preco(110, false, CategoriaCliente.Regular),
                        new Preco(80, false, CategoriaCliente.Fidelidade),
                        new Preco(90, true, CategoriaCliente.Regular),
                        new Preco(80, true, CategoriaCliente.Fidelidade)
                    }),

                new Hotel(
                    "Jardim Botânico",
                    4,
                    new List<Preco>() {
                        new Preco(160, false, CategoriaCliente.Regular),
                        new Preco(110, false, CategoriaCliente.Fidelidade),
                        new Preco(60, true, CategoriaCliente.Regular),
                        new Preco(50, true, CategoriaCliente.Fidelidade)
                    }),

                new Hotel(
                    "Mar Atlântico",
                    5,
                    new List<Preco>() {
                        new Preco(220, false, CategoriaCliente.Regular),
                        new Preco(100, false, CategoriaCliente.Fidelidade),
                        new Preco(150, true, CategoriaCliente.Regular),
                        new Preco(40, true, CategoriaCliente.Fidelidade)
                    })
            };
        }
    }
}
