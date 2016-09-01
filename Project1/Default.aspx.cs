using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void NameButton_Click(object sender, EventArgs e)
    {
        NameOutput.Text = "Hello, " + TextBoxName.Text;
    }

    protected void CheckButton_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            CheckBoxOutput.Text = "The box has been checked";
        }
        else
        {
            CheckBoxOutput.Text = "The Checkbox has NOT been checked";
        }
    }


    protected void RadioButtonList_Click(object sender, EventArgs e)
    {
        RadioListOutput.Text = "You selected" + RadioButtonList1.SelectedItem.Text;
    }

    protected void TextBoxButton_Click(object sender, EventArgs e)
    {
        TextBoxOutput.Text = "You have typed " + TextBox1.Text.Length + " characters in this box.";
    }

    protected void EmailButton_Click(object sender, EventArgs e)
    {
             if (txtEmail.Text.Contains("@"))
        {
            EmailOutput.Text = "You entered a valid email address.";
        }
        else {
            EmailOutput.Text = "Invalid email address";
        }
    }

    protected void DropButton_Click(object sender, EventArgs e)
    {
        DropOutput.Text = "You selected " + DropDownList1.SelectedItem.Text;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        CalendarLabel.Text = "The date you selected is: " + Calendar1.SelectedDate;
    }

    protected void ListBoxButton_Click(object sender, EventArgs e)
    {
        CheckBoxList1.Text = "";
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if (item.Selected == true)
            {
                DrinkOutput.Text += "Your favourite drink from the list is: " + item.Value + " <br/>";
            }
        
        }

       

    }
}


      