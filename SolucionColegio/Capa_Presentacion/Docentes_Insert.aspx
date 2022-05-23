<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Docentes_Insert.aspx.cs" Inherits="Capa_Presentacion.Docentes_Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <h1>Ingresar Nuevo Docente</h1>
    <form id="form1" runat="server">
        <table border="1">
            <tr>
                <td>Id Docente: </td>
                <td><asp:TextBox ID="Id_Docente" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nombre: </td>
                <td><asp:TextBox ID="Nom_Docente" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Dirección: </td>
                <td><asp:TextBox ID="Dir_Docente" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Telefono: </td>
                <td><asp:TextBox ID="Tel_Docente" runat="server"></asp:TextBox></td>
            </tr>
        </table>

        <asp:Button ID="Button1" runat="server" Text="Guardar Nuevo" OnClick="Button1_Click" />

    </form>
</body>
</html>
