using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicatService)
        {
            _applicantService = applicatService;
        }
        public void GiveMask(Citizen citizen)
        {
            if(_applicantService.CheckPerson(Citizen citizen)
            {
                Console.WriteLine(citizen.FirstName + " " + citizen.LastName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(citizen.FirstName + " " + citizen.LastName + " için maske VERİLMEDİ");
            }
        }
    }
}
