using HotelReservation.Enum;
using System;
using System.Collections.Generic;

namespace HotelReservation.Domain.Services.Interfaces
{
    public interface IReservaHotelService
    {
        Hotel BuscarHotelMaisBarato(CategoriaCliente categoriaCliente, List<DateTime> listaDatas);
    }
}
