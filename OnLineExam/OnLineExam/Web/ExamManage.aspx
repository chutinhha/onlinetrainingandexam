<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ExamManage.aspx.cs" Inherits="Web_CourseManage1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" height="100%" width="100%">
        <tr>
            <td style="width: 4px; background: url(../Images/line.gif) repeat-y;">
            </td>
            <td valign="top" align="left">
                <h4 style="font-family: ����_GB2312">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblMessger" runat="server" ForeColor="Red"></asp:Label>
                </h4>
                <hr />
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                    onrowdatabound="GridView1_RowDataBound1" onrowdeleting="GridView1_RowDeleting1" 
                    Width="100%" RowStyle-HorizontalAlign="Center" BackColor="White" 
                    BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                    <RowStyle BackColor="#F7F7DE" />
                    <Columns>
                        <asp:BoundField DataField="ExamId" HeaderText="���" Visible="False" />
                        <asp:TemplateField HeaderText="���">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="CourseName" HeaderText="��Ŀ" />
                        <asp:BoundField DataField="PaperName" HeaderText="�Ծ�" />
                        <asp:BoundField DataField="StartTime" HeaderText="��ʼʱ��" />
                        <asp:BoundField DataField="EndTime" HeaderText="����ʱ��" />
                        <asp:CommandField HeaderText="ɾ��" ShowDeleteButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <PagerStyle BackColor="#90BBC5" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#90BBC5" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <br />
                <a href="ExamAdd.aspx" style="font-size: medium;"><font color="red" style="font-family: ����_GB2312">
                    <u>��ӿ���</u></font></a>
            </td>
        </tr>
    </table>
</asp:Content>
