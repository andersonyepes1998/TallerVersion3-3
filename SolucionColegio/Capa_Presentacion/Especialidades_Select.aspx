<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Especialidades_Select.aspx.cs" Inherits="Capa_Presentacion.Especialidades_Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Especialidades</h1>

    <p>
        <a href="Especialidades_Insert.aspx">Ingresar Nuevo Especialidades</a>
    </p>

    <table border="1">
        <thead>
            <tr>
                <th>Id Especialidades</th>
                <th>Nombre</th>
                <th colspan="2">Opciones</th>
            </tr>
        </thead>

        <tbody id="tabla_body" runat="server">
         
        </tbody>

    </table>


    <p>
        <a href="index.html">Volver al Inicio</a>
    </p>
    </form>
</body>
</html>
