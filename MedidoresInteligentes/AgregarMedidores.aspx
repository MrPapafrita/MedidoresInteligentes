<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidores.aspx.cs" Inherits="MedidoresInteligentes.AgregarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class ="mensajes">

                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>

            </div>
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Agregar Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                       <label for="nombre">nombre: </label>
                        <asp:TextBox ID="Nombre" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       <label for="codigo">codigo: </label>
                        <asp:TextBox ID="Codigo" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                       
                        <asp:Button runat="server" ID="AgregarMedidorBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="AgregarMedidorBtn_Click" />

                    </div>
  
                   

                </div>
            </div>
        </div>
    </div>
</asp:Content>
