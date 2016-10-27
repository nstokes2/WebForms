<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AnimalDetails.aspx.cs" Inherits="WebForms.AnimalDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="animalDetail" runat="server" ItemType="WebForms.Models.Animal" SelectMethod ="GetAnimal" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.AnimalName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.AnimalName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.TicketPrice) %></span>
                        <br />
                        <span><b>Animal ID:</b>&nbsp;<%#:Item.AnimalID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
