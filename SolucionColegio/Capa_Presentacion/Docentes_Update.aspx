<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Docentes_Update.aspx.cs" Inherits="Capa_Presentacion.Docentes_Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<h1>Modificar Docente Existente</h1>
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
                <td><asp:TextBox ID="Dire_Docente" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Telefono: </td>
                <td><asp:TextBox ID="Tel_Docente" runat="server"></asp:TextBox></td>
            </tr>
        </table>

        <asp:Button ID="Button1" runat="server" Text="Guardar Cambios" OnClick="Button1_Click" />

    </form>
</body>
</html>
