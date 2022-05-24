<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Especialidads_Update.aspx.cs" Inherits="Capa_Presentacion.Especialidads_Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Modificar Usuario Existente</h1>
    <form id="form1" runat="server">
         <table border="1">
            <tr>
                <td>Id Especialidad: </td>
                <td><asp:TextBox ID="Id_Especialidad" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nombre: </td>
                <td><asp:TextBox ID="Nom_Especialidad" runat="server"></asp:TextBox></td>
            </tr>

        </table>

        <asp:Button ID="Button1" runat="server" Text="Guardar Cambios" OnClick="Button1_Click" />
    </form>
</body>
</html>
