<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlueFormFillUp.aspx.cs" Inherits="MachineProject.BlueFormFillUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Blue Form</title>
<link href="css/styles.css" rel="stylesheet" type="text/css" media="all" />
</head>

<body>
    <form id="form1" runat="server">
<div id="head">
 <div id="head_cen">
  <div id="head_sup" class="head_height">
    
  <br />
  <br />
  <br />

    <img src=logo.png />
    
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label1" runat="server" Text="First Name:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label2" runat="server" Text="Last Name:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label3" runat="server" Text="Course:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label4" runat="server" Text="I.D. Number:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIDNumber" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label5" runat="server" Text="Event Name:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEventName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label6" runat="server" Text="Event Organizer:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEventOrganizer" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label7" runat="server" Text="Event Venue:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEventVenue" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label8" runat="server" Text="Absence Date:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAbsenceDate" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label9" runat="server" Text="Absence Time:" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAbsenceTime" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label10" runat="server" Text="Classes Affected:" 
                        ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClassesAffected" runat="server" Height="55px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label11" runat="server" Text="Excused Absences:" 
                        ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtExcusedAbsences" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label12" runat="server" Text="Unexcused Absences:" 
                        ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUnexcusedAbsences" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Submit Blue Form" Width="184px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <a href="contact.html"><asp:Button ID="Button2" runat="server" 
                        onclick="Button2_Click" Text="Cancel" Width="82px" />
                    </a></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
        </a>
    
  </div>
 </div>
</div>
    <div>
    
    </div>
    </form>
</body>
</html>
