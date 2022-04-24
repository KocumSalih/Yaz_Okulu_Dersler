<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="BasvuruFormu.aspx.cs" Inherits="Yaz_Okulu_Dersler.BasvuruFormu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="container">
        <form runat="server">

            <div class="row g-3">

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
                <asp:Button CssClass="btn btn-primary my-2" ID="btnBaşvuruKaydet" runat="server" Text="Başvuru Kaydet" OnClick="btnBaşvuruKaydet_Click"  />
            </div>

            <hr />

            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">Başvuru Id</th>
                        <th scope="col">Öğretmen Adı Soyadı</th>
                        <th scope="col">Öğrenci Adı Soyadı</th>
                        <th scope="col">Ders Adı</th>
                        <th scope="col">İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><%#Eval("BasvuruId") %></th>
                                <td><%#Eval("OgrtAdSoyad") %></td>
                                <td><%#Eval("ogrAdSoyad") %></td>
                                <td><%#Eval("DersAdi") %></td>
                                <td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/BasvuruSil.aspx?BasvuruId="+Eval("BasvuruId") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/BasvuruGuncelle.aspx?BasvuruId="+Eval("BasvuruId") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>


        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
