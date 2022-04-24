<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="DersSayfasi.aspx.cs" Inherits="Yaz_Okulu_Dersler.Ders_Sayfalari.DersSayfasi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <form runat="server">

            <div class="row g-3">
                <div class="col-md-12 ">
                    <asp:Label for="txtDersAdi" runat="server" Text="Ders Adı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtDersAdi" runat="server"></asp:TextBox>
                </div>


                <div class="col-md-6">
                    <asp:Label for="txtMinKont" runat="server" Text="Dersin Açılabilmesi İçin Gerekli Olan Başvuru Sayisi"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtMinKont" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="txtMaxKont" runat="server" Text="Dersin İçin Max. Başvuru Sayisi"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtMaxKont" runat="server"></asp:TextBox>
                </div>

            </div>

            <div class="col-12">
                <asp:Button CssClass="btn btn-primary my-2" ID="btnDersKaydet" runat="server" Text="Ders Kaydet" OnClick="btnDersKaydet_Click" />
            </div>

            <hr />

            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">Ders Id</th>
                        <th scope="col">Ders Adı</th>
                        <th scope="col">Dersin Açılması için Gereken Sayı</th>
                        <th scope="col">Ders İçin Max. Kontenjan</th>
                        <th scope="col">İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><%#Eval("DersId") %></th>
                                <td><%#Eval("DersAdi") %></td>
                                <td><%#Eval("DersMinKont") %></td>
                                <td><%#Eval("DersMaxKont") %></td>
                                <td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/DersSil.aspx?DersId="+Eval("DersId") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/DersGuncelle.aspx?DersId="+Eval("DersId") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
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
