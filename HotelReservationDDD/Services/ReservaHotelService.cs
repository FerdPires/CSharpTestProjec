using HotelReservationDDD.Domain.Repository;
using HotelReservationDDD.Domain.Services.Interfaces;
using HotelReservationDDD.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservationDDD.Domain.Services
{
    public class ReservaHotelService : IReservaHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public ReservaHotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public Hotel BuscarHotelMaisBarato(CategoriaCliente categoriaCliente, List<DateTime> listaDatas)
        {
            List<Hotel> listaHoteis = _hotelRepository.GetHotels();

            return listaHoteis
                .OrderBy(hotel => hotel.CalcularPrecoReservaHotel(categoriaCliente, listaDatas))
                .ThenByDescending(hotel => hotel.Classificacao)
                .FirstOrDefault();
        }
    }
}
