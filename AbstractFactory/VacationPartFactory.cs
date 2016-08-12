using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class VacationPartFactory : IVacationPartFactory
    {
        private IAirplaneService _airplaneService;
        private IHotelSelector _hotelSelector;
        private IHotelService _hotelService;

        public VacationPartFactory(IAirplaneService airplaneService, IHotelSelector hotelSelector, IHotelService hotelService)
        {
            _hotelSelector = hotelSelector;
            _hotelService = hotelService;
            _airplaneService = airplaneService;
        }

        public IVacationPart BookFerry(string lineName, bool fromMainland, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart BookFlight(string companyName, string source, string destination, DateTime date)
        {
            return _airplaneService.Book(companyName, source, destination, date);
        }

        public IVacationPart BookHotel(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate)
        {
            var hotel = _hotelSelector.SelectHotel(town, hotelName);
            return _hotelService.Book(hotel, arrivalDate, leaveDate);
        }

        public IVacationPart BookMassage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}