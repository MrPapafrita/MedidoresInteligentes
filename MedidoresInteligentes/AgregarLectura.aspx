<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="MedidoresInteligentes.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">

                    <div class="form-group">
                       <label for="medidorDal">medidor: </label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-control"></asp:DropDownList>
                    </div>

                     <div class="form-group">
                       <label for="fecha">fecha: </label>
                        <asp:TextBox ID="Fecha" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       <label for="hora">hora: </label>
                        <asp:TextBox ID="Hora" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                     <div class="form-group">
                       <label for="codigo">minuto: </label>
                        <asp:TextBox ID="Minuto" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <div class="form-group">
                       <label for="codigo">cantidad: </label>
                        <asp:TextBox ID="Cantidad" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>




                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="AgregarLecturaBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="AgregarLecturaBtn_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>