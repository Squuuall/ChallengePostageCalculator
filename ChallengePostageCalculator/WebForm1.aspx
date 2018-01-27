<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengePostageCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="handle" AutoPostBack="True"></asp:TextBox>
        <br />
        Height:&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="handle" AutoPostBack="True"></asp:TextBox>
        <br />
        Length:&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="handle" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadio" runat="server" GroupName="shippingOption" OnCheckedChanged="handle" Text="Ground" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="airRadio" runat="server" GroupName="shippingOption" OnCheckedChanged="handle" Text="Air" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="nextDayRadio" runat="server" GroupName="shippingOption" OnCheckedChanged="handle" Text="Next Day" AutoPostBack="True" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
