<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="OgretmenGuncelle.aspx.cs" Inherits="Yaz_Okulu_Dersler.OgretmenGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">

            <div class="row g-3">
                <div class="col-md-12 ">
                    <asp:Label for="txtOgrtId" runat="server" Text="Öğretmen Id"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrtId" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-12 ">
                    <asp:Label for="txtOgrtAdSoyad" runat="server" Text="Öğretmen Adı Soyadı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrtAdSoyad" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-12">
                    <asp:Label for="DropDownDers" runat="server" Text="Öğretmen İçin Ders Seçimi"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="DropDownDers" runat="server"></asp:DropDownList>
                </div>

            </div>
            <div class="col-12">
                <asp:Button ID="btnOgretmenGuncelle" runat="server" Text="Öğretmen Güncelle" CssClass="btn btn-warning my-2" OnClick="btnOgretmenGuncelle_Click" />
            </div>


        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
