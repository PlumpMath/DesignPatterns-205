using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IVacationPartFactory
    {
        IVacationPart BookHotel(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate);

        IVacationPart BookFlight(string companyName, string source, string destination, DateTime date);

        IVacationPart BookFerry(string lineName, bool fromMainland, DateTime date);

        IVacationPart BookMassage(string salon, DateTime date);
    }
}