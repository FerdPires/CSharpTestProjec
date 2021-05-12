using System.Collections.Generic;

namespace HotelReservation.Domain.Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotels();
    }
}
