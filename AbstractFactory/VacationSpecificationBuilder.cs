using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class VacationSpecificationBuilder
    {
        private List<IVacationPart> _parts = new List<IVacationPart>();
        private DateTime _arrivalDate;
        private int _totalNights;
        private string _destinationTown;
        private string _livingTown;
        private IVacationPartFactory _vacationFactory;

        public VacationSpecificationBuilder(DateTime arrivalDate, int totalNights, string livingTown, string destinationTown, IVacationPartFactory vacationFactory)
        {
            _arrivalDate = arrivalDate;
            _totalNights = totalNights;
            _livingTown = livingTown;
            _destinationTown = destinationTown;
            _vacationFactory = vacationFactory;
        }

        public void BookHotel(string hotelName)
        {
            var part = _vacationFactory.BookHotel(_destinationTown, hotelName, _arrivalDate, _arrivalDate.AddDays(_totalNights));
            _parts.Add(part);
        }

        public void BookFlight(string companyName)
        {
            var part = _vacationFactory.BookFlight(companyName, _destinationTown, _livingTown, _arrivalDate.AddDays(_totalNights));
            _parts.Add(part);
        }

        public VacationSpecification BuildVacation()
        {
            _parts.ForEach(p => p.Purchase());

            return new VacationSpecification(_parts);
        }
    }
}