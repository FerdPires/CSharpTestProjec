using HotelReservationDDD.Domain;
using HotelReservationDDD.Domain.Repository;
using HotelReservationDDD.Enum;
using System.Collections.Generic;

namespace CSharpTestProject.Mocks
{
    public class FakeHotelRepository : IHotelRepository
    {
        public List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel(
                    "Parque das Flores",
                    3,
                    new List<Preco>(){
                        new Preco(110, false, CategoriaCliente.Regular),
                        new Preco(80, false, CategoriaCliente.Fidelidade),
                        new Preco(90, true, CategoriaCliente.Regular),
                        new Preco(80, false, CategoriaCliente.Regular),
                    }),

                new Hotel(
                    "Jardim Botânico",
                    4,
                    new List<Preco>(){
                        new Preco(160, false, CategoriaCliente.Regular),
                        new Preco(110, false, CategoriaCliente.Fidelidade),
                        new Preco(60, true, CategoriaCliente.Regular),
                        new Preco(50, false, CategoriaCliente.Regular),
                    }),

                new Hotel(
                    "Mar Atlântico",
                    5,
                    new List<Preco>(){
                        new Preco(220, false, CategoriaCliente.Regular),
                        new Preco(110, false, CategoriaCliente.Fidelidade),
                        new Preco(150, true, CategoriaCliente.Regular),
                        new Preco(40, false, CategoriaCliente.Regular),
                    })
            };

        }
    }
}
