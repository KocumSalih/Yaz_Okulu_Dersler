<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="BasvuruGuncelle.aspx.cs" Inherits="Yaz_Okulu_Dersler.BasvuruGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="container">
        <form runat="server">

            <div class="row g-3">

                <div class="col-md-12 ">
                    <asp:Label for="txtBasvuruId" runat="server" Text="Başvuru Id"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtBasvuruId" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="DropDownDers" runat="server" Text="Öğretmen Seçimi Yapınız"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="DropDownOgrt" runat="server"></asp:DropDownList>
                </div>

                <div class="col-md-6">
                    <asp:Label for="DropDownDers" runat="server" Text="Öğrenci Seçimi Yapınız"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="DropDownOgr" runat="server"></asp:DropDownList>
                </div>

                <div class="col-md-12">
                    <asp:Label for="DropDownDers" runat="server" Text="Ders Seçimi Yapınız"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="DropDownDers" runat="server"></asp:DropDownList>
                </div>

            </div>

            <div class="col-12">
                <asp:Button CssClass="btn btn-primary my-2" ID="btnBaşvuruKaydet" runat="server" Text="Başvuru Güncelle" OnClick="btnBaşvuruKaydet_Click"  />
            </div>


        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
