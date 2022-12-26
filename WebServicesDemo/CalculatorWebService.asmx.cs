using System.Collections.Generic;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
   
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : WebService
    {

        [WebMethod(enableSession: true, Description ="Bu metot iki sayıyı toplar." ,CacheDuration =15)]
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;

            if (Session["CALCULATIONS"]==null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }

            int toplam = firstNumber + secondNumber;

            string strRecentCalculation = firstNumber.ToString() + "+" + secondNumber.ToString() + "=" + toplam.ToString();

            calculations.Add(strRecentCalculation);

            Session["CALCULATIONS"] = calculations;


            return toplam;
        }

        [WebMethod(enableSession: true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("Herhangi bir hesaplama yapmadınız!!");

                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }
        }

        [WebMethod(MessageName ="UcSayiToplar", Description = "3 Adet Sayıyı Toplar")]
        public int Add(int firstNumber, int secondNumber,int thirdNumber)
        {
           
            int toplam = firstNumber + secondNumber + thirdNumber;

            return toplam;
        }

        [WebMethod(MessageName ="DortSayiToplar",Description ="4 Adet Sayıyı Toplar")]
        public int Add(int firstNumber, int secondNumber,int thirdNumber ,int fourthNumber)
        {

            int toplam = firstNumber + secondNumber + thirdNumber + fourthNumber;

            return toplam;
        }
    }
}
