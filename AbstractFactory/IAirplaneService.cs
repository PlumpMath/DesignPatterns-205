using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IAirplaneService
    {
        IVacationPart Book(string companyName, string origin, string destination, DateTime travelDate);
    }
}