<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="OgretmenSayfasi.aspx.cs" Inherits="Yaz_Okulu_Dersler.Ogretmen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">

            <div class="row g-3">
                <div class="col-md-6 ">
                    <asp:Label for="txtOgrtAdSoyad" runat="server" Text="Öğretmen Adı Soyadı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrtAdSoyad" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="DropDownDers" runat="server" Text="Öğretmen İçin Ders Seçimi Yapın"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="DropDownDers" runat="server"></asp:DropDownList>
                </div>

            </div>
            <div class="col-12">
                <asp:Button ID="btnOgretmenKayit" runat="server" Text="Öğretmen Kaydet" CssClass="btn btn-warning my-2" OnClick="btnOgretmenKayit_Click" />
            </div>


            <hr />


            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">Öğretmen Id</th>
                        <th scope="col">Öğretmen Adı Soyadı</th>
                        <th scope="col">Öğretmen Branşı</th>
                        <th scope="col">İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><%#Eval("OgrtId") %></th>
                                <td><%#Eval("OgrtAdSoyad") %></td>
                                <td><%#Eval("OgrtBrans") %></td>
                                <td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgretmenSil.aspx?OgrtId="+Eval("OgrtId") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgretmenGuncelle.aspx?OgrtId="+Eval("OgrtId") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
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
