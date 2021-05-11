using HotelReservationDDD.Enum;
using System;
using System.Collections.Generic;

namespace HotelReservationDDD.Domain.Services.Interfaces
{
    public interface IReservaHotelService
    {
        Hotel BuscarHotelMaisBarato(CategoriaCliente categoriaCliente, List<DateTime> listaDatas);
    }
}
