using HotelReservation.Domain.Repository;
using HotelReservation.Domain.Services.Interfaces;
using HotelReservation.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservation.Domain.Services
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
            return _hotelRepository.GetHotels()
                .OrderBy(hotel => hotel.CalcularPrecoReservaHotel(categoriaCliente, listaDatas))
                .ThenByDescending(hotel => hotel.Classificacao)
                .FirstOrDefault();
        }
    }
}
