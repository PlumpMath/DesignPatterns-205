using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        private static IUnityContainer InitIoC()
        {
            return new UnityContainer().RegisterType<Application, Application>()
                .RegisterType<IVacationPartFactory, VacationPartFactory>()
                .RegisterType<IHotelSelector, HotelSelector>()
                .RegisterType<IHotelService, HotelService>()
                .RegisterType<IAirplaneService, AirplaneService>();
        }

        public static void Main(string[] args)
        {
            InitIoC().Resolve<Application>().Run();
            Console.ReadKey();
        }
    }
}