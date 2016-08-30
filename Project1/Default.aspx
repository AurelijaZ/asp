<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> My First Ever ASP.NET Web Forms Page</h1>
        <asp:Label ID="Label1" runat="server" Text="Please Type in your Name:"></asp:Label>
         <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:Button ID="NameButton" runat="server" Text="Click Me" OnClick="NameButton_Click" />
        <br />
        <asp:Label ID="NameOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Please Check or uncheck the box:"></asp:Label>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <br />
        <asp:Button ID="CheckButton" runat="server" Text="Check Box Button" OnClick="CheckButton_Click" />
        <br />
        <asp:Label ID="CheckBoxOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelRadio" runat="server" Text="Please Click the radio Button:"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <br />
        <asp:Button ID="RadioCheck" runat="server" Text="Radio Button"/>
        <br />
        <asp:Label ID="RadioOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="RadioList" runat="server" Text="Please click one of the radio buttons on the list:"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Radio 1</asp:ListItem>
            <asp:ListItem>Radio 2</asp:ListItem>
            <asp:ListItem>Radio 3</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
              <asp:Button ID="RadioButtonList" runat="server" Text="Radio Button List" OnClick="RadioButtonList_Click" />
        <br />
        <asp:Label ID="RadioListOutput" runat="server" Text=""></asp:Label>
        <br />
        <h2 > Crib Sheet Examples </h2>
           <asp:HyperLink id="hyperlink1" 
                  NavigateUrl="https://www.pottermore.com/"
                  Text="LinkButton, which is just a link really "
                  runat="server"/> 
               <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Click the Image to follow to the link"></asp:Label>
        <br />
       
  <asp:HyperLink id="hyperlink2" 
                  ImageUrl="http://img13.deviantart.net/d313/i/2014/201/1/4/harry_potter__hi_res_logo_design__by_brodyblue-d7rgv5m.png"
                  NavigateUrl="http://www.pottermore.com"
                  Text="Harry Potter Page"
                  Target="_new"
                  runat="server"/>  
        <br />
        <br />
        <asp:Label ID="TextLabelBox" runat="server" Text="This is a multiline text box - please type something and click the button below:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="61px" TextMode="MultiLine" Width="157px"></asp:TextBox>
        
        <asp:Button ID="TextBoxButton" runat="server" Text="Click me" OnClick="TextBoxButton_Click" />
        <br />
        <asp:Label ID="TextBoxOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
      <asp:Label  
        id="lblEmail"
        Text="Email Address:"
        AssociatedControlID="txtEmail"
        Runat="server" />
    <asp:TextBox
        id="txtEmail"
        Runat="server" />

    <br /><br />

        <asp:Button ID="EmailButton" runat="server" Text="Click" OnClick="EmailButton_Click" />
        <br />
         <asp:Label ID="EmailOutput" runat="server" Text=""></asp:Label>
         
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Here is a calendar control."></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Label ID="CalendarLabel" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <p>List Control</p> 
        <asp:Label ID="Label5" runat="server" Text="Favourite CC Child:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Scorpius</asp:ListItem>
            <asp:ListItem>Albus</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="DropButton" runat="server" Text="Click" OnClick="DropButton_Click" />
        <br />
        <asp:Label ID="DropOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="What Drinks do you like from the list, you can select more than one:"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Tea</asp:ListItem>
            <asp:ListItem>Coffee</asp:ListItem>
            <asp:ListItem>Syrup</asp:ListItem>
            <asp:ListItem>Fizzy Drink</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="ListBoxButton" runat="server" Text="Click" OnClick="ListBoxButton_Click" />
        <br />
        <asp:Label ID="DrinkOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />


    </div>
    </form>
</body>
</html>
