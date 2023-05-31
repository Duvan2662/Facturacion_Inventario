<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FerrelectricosRYF.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link rel="stylesheet" href="../../EstilosCss/dist/css/adminlte.min.css">

    <link rel="stylesheet" href="../../css/style.css">
	<link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet">
	<script src="https://kit.fontawesome.com/a81368914c.js"></script>
	<meta name="viewport" content="width=device-width, initial-scale=1">
  
</head>
<body>
    <form id="form1" runat="server">
       <img class="wave" src="../../img/image.png">
	<div class="container">
		<div class="img">
			<img src="img/contruccion.svg">
		</div>
		<div class="login-content">
            <div class="login-form">
                <h2>Ferrelectricos RYF</h2>

                <asp:Label ID="lblMensajeError" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNombreUsuario" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar sesión" OnClick="btnIniciarSesion_Click" />
            </div>
			
        </div>
    </div>
    </form>
</body>
</html>


