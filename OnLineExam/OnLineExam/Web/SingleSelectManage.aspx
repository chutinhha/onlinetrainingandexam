﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="SingleSelectManage.aspx.cs" Inherits="Web_SingleSelectManage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" height="100%" width="100%">
        <tr>
            <td valign="top" align="left" width="960px">
                <h4 style="font-family: 楷体_GB2312">
                    &nbsp;</h4>
                <hr />
                <asp:UpdatePanel ID="up" runat="server">
                    <ContentTemplate>
                        <p align="left">
                            <asp:DropDownList ID="ddlCourse" runat="server" Width="130px" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged"
                                AutoPostBack="True">
                            </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                        </p>
                        <asp:GridView ID="GridView1" runat="server" Width="100%" OnRowDeleting="GridView1_RowDeleting"
                            Font-Size="13px" CellPadding="4" DataKeyNames="ID" OnRowDataBound="GridView1_RowDataBound"
                            PageSize="12" AllowPaging="True" AutoGenerateColumns="False" ForeColor="Black"
                            GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" 
                            BorderStyle="None" BorderWidth="1px">
                            <RowStyle BackColor="#F7F7DE"></RowStyle>
                            <Columns>
                                <asp:TemplateField HeaderText="序号" InsertVisible="False" SortExpression="ID">
                                    <EditItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text=''></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CourseID" HeaderText="题目代号" SortExpression="CourseID"
                                    Visible="False"></asp:BoundField>
                                <asp:BoundField DataField="Title" HeaderText="题目" SortExpression="Title"></asp:BoundField>
                                <asp:BoundField DataField="AnswerA" HeaderText="AnswerA" SortExpression="AnswerA"
                                    Visible="False"></asp:BoundField>
                                <asp:BoundField DataField="AnswerB" HeaderText="AnswerB" SortExpression="AnswerB"
                                    Visible="False"></asp:BoundField>
                                <asp:BoundField DataField="AnswerC" HeaderText="AnswerC" SortExpression="AnswerC"
                                    Visible="False"></asp:BoundField>
                                <asp:BoundField DataField="AnswerD" HeaderText="AnswerD" SortExpression="AnswerD"
                                    Visible="False"></asp:BoundField>
                                <asp:BoundField DataField="Answer" HeaderText="Answer" SortExpression="Answer" Visible="False">
                                </asp:BoundField>
                                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="SingleSelectUpdate.aspx?ID={0}"
                                    Text="详细" HeaderText="详细"></asp:HyperLinkField>
                                <asp:CommandField ShowDeleteButton="True" HeaderText="删除"></asp:CommandField>
                            </Columns>
                            <FooterStyle BackColor="#CCCC99"></FooterStyle>
                            <PagerStyle HorizontalAlign="Right" BackColor="#90BBC5" ForeColor="Black"></PagerStyle>
                            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                            <HeaderStyle BackColor="#90BBC5" Font-Bold="True" ForeColor="White"></HeaderStyle>
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT SingleProblem.* FROM SingleProblem" DeleteCommand="DELETE FROM SingleProblem WHERE ID = @ID">
                    <DeleteParameters>
                        <asp:Parameter Name="ID" />
                    </DeleteParameters>
                </asp:SqlDataSource>--%>
                <br />
                <a href="SingleSelectAdd.aspx" style="font-size: medium;"><font color="red" style="font-family: 楷体_GB2312">
                    <u>添加单选题</u></font></a>
            </td>
        </tr>
    </table>
</asp:Content>
