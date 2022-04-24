<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="Yaz_Okulu_Dersler.OgrenciGuncelle" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="form1" runat="server">
        <div class="container">

             <div class="form-group">
                <asp:Label for="txtOgrID" runat="server" Text="Öğrenci Id"></asp:Label>
                <asp:TextBox  CssClass="form-control" ID="txtOgrID" runat="server"></asp:TextBox>

            </div>

            <div class="form-group">
                <asp:Label for="txtOgrAdi" runat="server" Text="Öğrenci Adı"></asp:Label>
                <asp:TextBox  CssClass="form-control" ID="txtOgrAdi" runat="server"></asp:TextBox>

            </div>

           <div class="form-group">
                    <asp:Label for="txtOgrSoyadi" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrSoyadi" runat="server"></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label for="txtOgrNumara" runat="server" Text="Öğrenci Numarsı"></asp:Label>
                <asp:TextBox  CssClass="form-control" ID="txtOgrNumara" runat="server"></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label for="txtOgrSifre" runat="server" Text="Öğrenci Sifresi"></asp:Label>
                <asp:TextBox  CssClass="form-control" ID="txtOgrSifre" runat="server"></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label for="txtOgrFoto" runat="server" Text="Öğrenci Fotografı"></asp:Label>
                <asp:TextBox  CssClass="form-control" ID="txtOgrFoto" runat="server"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <asp:Label for="txtOgrBakiye" runat="server" Text="Öğrenci Bakiyesi"></asp:Label>
                <asp:TextBox  CssClass="form-control" ID="txtOgrBakiye" runat="server"></asp:TextBox>
            </div>

             <div class="form-group ">
                <asp:Button CssClass="btn btn-warning btn-lg col-md-4 my-2" ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" />
            </div>
        </div>
    </form>

</asp:Content>
