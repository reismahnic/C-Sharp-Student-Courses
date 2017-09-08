<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="StudentCourses.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Assignment1btn" runat="server" OnClick="Assignment1btn_Click" Text="Assignment 1" />
            <br />
            <br />
            <asp:Button ID="Assignment2btn" runat="server" OnClick="Assignment2btn_Click" Text="Assignment 2" />
            <br />
            <br />
            <asp:Button ID="Assignment3btn" runat="server" OnClick="Assignment3btn_Click" Text="Assignment 3" />
            <br />
            <br />
            <asp:Label ID="resultlbl" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
