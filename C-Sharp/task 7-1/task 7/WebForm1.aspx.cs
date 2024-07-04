using System;


namespace task_7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string Name = name.Text;
            string Email = email.Text;
            string Id = id.Text;
            string Gender = female.Checked ? "Female" : male.Checked ? "Male" : string.Empty;
            string Course = courseCSharp.Checked ? "C#" : courseCpp.Checked ? "C++" : string.Empty;
            string Comment = comment.Text;



            resultLabel.Text = $"Name: {Name}<br/>Email: {Email}<br/>ID: {Id}<br/>Gender: {Gender}<br/>Course: {Course}<br/>Comments: {Comment}";
        }
    }
    }


