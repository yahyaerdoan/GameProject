using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient
                (KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return  client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.IdentityNumber),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
