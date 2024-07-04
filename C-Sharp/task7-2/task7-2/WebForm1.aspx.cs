using System;

namespace task7_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(Numer1.Text);
            int num2 = Convert.ToInt32(Numer2.Text);
            double result = num1 + num2;

            resultLabel.Text = $"SUM: {result}";

        }

        protected void ButtonSubtract_Click(object sender, EventArgs e)
        {




              int  num1 = Convert.ToInt32(Numer1.Text);
               int num2 = Convert.ToInt32(Numer2.Text);
                double result = num1 - num2;
                resultLabel.Text = $"SUB: {result}";
            
           
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numer1.Text);
            int num2 = Convert.ToInt32(Numer2.Text);
            double result = num1 * num2;
            resultLabel.Text = $"MUL: {result}";


        }
    }
}
