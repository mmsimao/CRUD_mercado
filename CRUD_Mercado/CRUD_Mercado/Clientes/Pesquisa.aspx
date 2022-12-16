<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="CRUD_Mercado.Clientes.Pesquisa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-2"></div>
            <div class="col-sm-10">
                <h1>PESQUISA DE CLIENTE</h1>
            </div>
            <div class="col-sm-2"></div>
        </div>
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <div class="row">
                    <asp:TextBox runat="server" ID="cliente">Insira um nome</asp:TextBox>
                </div>
                <div class="row" style="margin-top: 5px">
                    <asp:Button runat="server" ID="pesquisar" Text="pesquisar" OnClick="pesquisar_Click" />
                </div>
            </div>
            <div class="col-sm-4"></div>
        </div>
        <div class="row">
            <asp:GridView runat="server" ID="grdClientes" Width="100%" AutoGenerateColumns="false"
                CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                OnRowCommand="grdClientes_RowCommand" AllowPaging="true" PageSize="10" OnPageIndexChanging="grdClientes_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="nome" HeaderText="NOME" />
                    <asp:BoundField DataField="Compras" HeaderText="COMPRAS" />
                    <asp:ButtonField ButtonType="Link" CommandName="editar" Text="Editar" />
                    <asp:ButtonField ButtonType="Link" CommandName="excluir" Text="Excluir" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
