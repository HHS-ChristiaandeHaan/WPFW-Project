using System.Security.Cryptography;

namespace Authenticatie;

class VerificatieToken 
{
    public string token {get;set;}
    public DateTime verloopDatum{get;set;}

    public VerificatieToken()
    {
        token = "1345ABC";
        verloopDatum = DateTime.Today.AddDays(3);
    }
}