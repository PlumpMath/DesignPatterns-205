using System.Collections.Generic;

namespace AbstractFactory
{
    public class VacationSpecification
    {
        private List<IVacationPart> _parts;

        public VacationSpecification(List<IVacationPart> parts)
        {
            _parts = parts;
        }
    }
}