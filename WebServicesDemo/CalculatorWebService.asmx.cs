using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : WebService
    {

        [WebMethod]
        public string Add(int firstNumber, int secondNumber)
        {
            var toplam = firstNumber + secondNumber;

            return "Toplam Sonuç: "+toplam;
        }
    }
}
