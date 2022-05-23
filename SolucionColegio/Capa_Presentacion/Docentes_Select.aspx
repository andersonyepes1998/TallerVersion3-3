<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Docentes_Select.aspx.cs" Inherits="Capa_Presentacion.Docentes_Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Docentes</h1>

    <p>
        <a href="Docentes_Insert.aspx">Ingresar Nuevo Docente</a>
    </p>

    <table border="1">
        <thead>
            <tr>
                <th>Id Docente</th>
                <th>Nombre</th>
                <th>Direccion</th>
                <th>Telefono</th>
                <th colspan="2">Opciones</th>
            </tr>
        </thead>

        <tbody id="tabla_body" runat="server">
         
        </tbody>

    </table>


    <p>
        <a href="index.html">Volver al Inicio</a>
    </p>
</body>
</html>
