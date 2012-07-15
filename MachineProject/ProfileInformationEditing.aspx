<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileInformationEditing.aspx.cs" Inherits="MachineProject.ProfileInformationEditing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Blue Form</title>
<link href="css/styles.css" rel="stylesheet" type="text/css" media="all" />
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            text-align: left;
        }
    </style>
</head>

<body>
    <form id="form2" runat="server">
<div id="head">
 <div id="head_cen">
  <div id="head_sup" class="head_height">
  
  <br />
  <br />
  <br />

    <img src=logo.png />
  <table style="width:100%;">
            <tr>
                <td class="style1">
    
        <table style="width:100%;">
            <tr>
                <td align="right">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label1" runat="server" Text="First Name:" ForeColor="White"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtFirstName" runat="server" Height="23px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label2" runat="server" Text="Last Name:" ForeColor="White"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label3" runat="server" Text="Year Level:" ForeColor="White"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtYearLevel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label4" runat="server" Text="Course:" ForeColor="White"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Update Profile Information" Width="247px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Back" 
                        Width="97px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;
                </td>
            </tr>
        </table>
    
&nbsp;&nbsp;
                    &nbsp;&nbsp;
                    </td>
            </tr>
            </table>

 </div>
    
</div>
    </form>
</body>
</html>
