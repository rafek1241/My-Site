using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Shared.Models;
using MySite.Shared.Models.Utils;

namespace MySite.Client.Service
{
    public class PersonalInformationService : BaseCrudService<PersonalInformation>, IPersonalInformationService
    {
        public PersonalInformationService()
        {
            ResourceBaseUrl = "api/personal-information";
        }

        public override Task<ResponseModel> Add(PersonalInformation item)
        {
            throw new NotImplementedException("This method is not accepted for specified resource.");
        }

        public override async Task<PersonalInformation[]> Get()
        {
            throw new NotImplementedException("This method is not accepted for specified resource.");
        }

        public override Task<ResponseModel> Remove(PersonalInformation item)
        {
            throw new NotImplementedException("This method is not accepted for specified resource.");
        }

        public override Task<ResponseModel> Update(long itemId, PersonalInformation item)
        {
            throw new NotImplementedException("This method is not accepted for specified resource.");
        }
    }
}
