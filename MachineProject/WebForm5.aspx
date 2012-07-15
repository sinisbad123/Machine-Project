<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="MachineProject.WebForm5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Blue Form</title>
<link href="css/styles.css" rel="stylesheet" type="text/css" media="all" />
    <style type="text/css">
        .style1
        {
            width: 310px;
            text-align: center;
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
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
        <asp:Label ID="Label2" runat="server" Text="Invalid User Name / Password" ForeColor="White"></asp:Label>
                </td>
                <td align="center">
&nbsp;&nbsp;
                    &nbsp;&nbsp;
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Back to log-in page" Width="294px" />
    
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>

 </div>
    
</div>
    <div>
    
    </div>
    </form>
</body>
</html>
