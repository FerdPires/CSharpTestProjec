using System.Collections.Generic;

namespace HotelReservationDDD.Domain.Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotels();
    }
}
