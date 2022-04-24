<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="OgrenciSayfasi.aspx.cs" Inherits="Yaz_Okulu_Dersler.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">

        <div class="toast-container">
                    <div id="toast" class="toast" role="alert" aria-live="assertive" aria-atomic="true">
                        <div class="toast-header">
                            <img src="..." class="rounded me-2" alt="...">
                            <strong class="me-auto">Bootstrap</strong>
                            <small class="text-muted">just now</small>
                            <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
                        </div>
                        <div class="toast-body">
                            See? Just like this.
                        </div>
                    </div>
                </div>

        <form id="form1" runat="server">

            <div class="row g-3">
                <div class="col-md-6 ">
                    <asp:Label for="txtOgrAdi" runat="server" Text="Öğrenci Adı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrAdi" runat="server"></asp:TextBox>
                </div>


                <div class="col-md-6">
                    <asp:Label for="txtOgrSoyadi" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrSoyadi" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="txtOgrNumara" runat="server" Text="Öğrenci Numarsı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrNumara" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="txtOgrSifre" runat="server" Text="Öğrenci Sifresi"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrSifre" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="txtOgrFoto" runat="server" Text="Öğrenci Fotografı"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrFoto" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-6">
                    <asp:Label for="txtOgrBakiye" runat="server" Text="Öğrenci Bakiyesi"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtOgrBakiye" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="col-12">
                <asp:Button CssClass="btn btn-primary my-2" ID="Button1" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
            </div>
        </form>

        <hr />

        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col">Ögrenci Id</th>
                    <th scope="col">Öğrenci Adı</th>
                    <th scope="col">Öğrenci Soyadı</th>
                    <th scope="col">Öğrenci Numarası</th>
                    <th scope="col">Öğrenci Şifresi</th>
                    <th scope="col">Öğrenci Fotografı</th>
                    <th scope="col">Öğrenci Bakiye</th>
                    <th scope="col">İşlemler</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th scope="row"><%#Eval("OgrId") %></th>
                            <td><%#Eval("OgrAd") %></td>
                            <td><%#Eval("OgrSoyad") %></td>
                            <td><%#Eval("OgrNumara") %></td>
                            <td><%#Eval("OgrSifre") %></td>
                            <td><%#Eval("OgrFotograf") %></td>
                            <td><%#Eval("OgrBakiye") %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgrenciSil.aspx?OgrId="+Eval("OgrId") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OgrId="+Eval("OgrId") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <%--<script>
        $(document).ready(function () {
            var toast = new bootstrap.Toast($("#toast"))

            toast.show()
        });
    </script>--%>
</asp:Content>
