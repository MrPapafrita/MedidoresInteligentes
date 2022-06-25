<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresInteligentes.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-borderer" 
                     OnRowCommand="grillaMedidores_RowCommand"
                     AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="CodigoMedidor"/>
                            <asp:BoundField DataField="Nombre" HeaderText="NombreMedidor"/>

                            
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
