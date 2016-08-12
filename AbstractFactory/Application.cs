using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Application
    {
        private IVacationPartFactory _partFactory;

        public Application(IVacationPartFactory partFactory)
        {
            _partFactory = partFactory;
        }

        public void Run()
        {
            var builder = new VacationSpecificationBuilder(new DateTime(2016, 7, 11), 14, "rehovot", "seoul", _partFactory);

            builder.BookHotel("TurtlePlaza");
            builder.BookFlight("FlyingHippos, Inc");

            var spec = builder.BuildVacation();
        }
    }
}