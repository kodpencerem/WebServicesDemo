using System;
using CalculatorWebApplication.CalculatorService;

namespace CalculatorWebApplication
{
    public partial class CalculatorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();

            int result = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));

            lblResult.Text = result.ToString();

            gvCalculations.DataSource=client.GetCalculations();
            gvCalculations.DataBind();

            gvCalculations.HeaderRow.Cells[0].Text = "Yapılan Son Hesaplamalar";

        }
    }
}