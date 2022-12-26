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
        public int Add(int firstNumber, int secondNumber)
        {
            int toplam = firstNumber + secondNumber;

            return toplam;
        }
    }
}
