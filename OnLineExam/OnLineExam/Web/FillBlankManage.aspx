﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="FillBlankManage.aspx.cs" Inherits="Web_FillBlankManage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" height="100%" width="100%">
        <tr>
            <td valign="top" align="left" width="960px">
                <h4 style="font-family: 楷体_GB2312">
                    &nbsp;</h4>
                <hr />
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <p align="left">
                            <asp:DropDownList ID="ddlCourse" runat="server" Width="130px" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged"
                                AutoPostBack="True">
                            </asp:DropDownList>
                        </p>
                        <asp:GridView ID="GridView1" runat="server" Width="100%" 
                            Font-Size="13px" CellPadding="4" DataKeyNames="ID" PageSize="12" AllowPaging="True"
                            AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" ForeColor="Black"
                            GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" 
                            BorderStyle="None" BorderWidth="1px">
                            <RowStyle BackColor="#F7F7DE"></RowStyle>
                            <Columns>
                                <asp:TemplateField HeaderText="序号" InsertVisible="False" SortExpression="ID">
                                    <EditItemTemplate>
                                        <asp:Label runat="server" Text='<%# Eval("ID") %>' ID="Label1"></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label runat="server" Text='' ID="Label1"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CourseID" HeaderText="CourseID" SortExpression="CourseID"
                                    Visible="False"></asp:BoundField>
                                <asp:BoundField DataField="FrontTitle" HeaderText="题目前半部分" SortExpression="FrontTitle">
                                </asp:BoundField>
                                <asp:BoundField DataField="BackTitle" HeaderText="题目后半部分" SortExpression="BackTitle">
                                </asp:BoundField>
                                <asp:BoundField DataField="Answer" HeaderText="Answer" SortExpression="Answer" Visible="False">
                                </asp:BoundField>
                                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FillBlankUpdate.aspx?ID={0}"
                                    Text="详细" HeaderText="详细"></asp:HyperLinkField>
                                <asp:CommandField DeleteText="&lt;div onclick=&quot;return confirm('确定要删除吗？')&quot;&gt;删除&lt;/div&gt;"
                                    ShowDeleteButton="True" HeaderText="删除"></asp:CommandField>
                            </Columns>
                            <FooterStyle BackColor="#CCCC99"></FooterStyle>
                            <PagerStyle HorizontalAlign="Right" BackColor="#90BBC5" ForeColor="Black"></PagerStyle>
                            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                            <HeaderStyle BackColor="#90BBC5" Font-Bold="True" ForeColor="White"></HeaderStyle>
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
                &nbsp; &nbsp;&nbsp;
                <br />
                <a href="FillBlankAdd.aspx" style="font-size: medium;"><font color="red" style="font-family: 楷体_GB2312">
                    <u>添加填空题</u></font></a>
            </td>
        </tr>
    </table>
</asp:Content>
