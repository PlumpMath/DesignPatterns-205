using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IHotelService
    {
        IVacationPart Book(HotelInfo hotelName, DateTime checkin, DateTime checkout);
    }
}