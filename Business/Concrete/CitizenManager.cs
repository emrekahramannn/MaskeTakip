using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CitizenManager : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public List<Citizen> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public bool CheckPerson(Citizen citizen)
        {
            throw new NotImplementedException();
        }

    }
}
