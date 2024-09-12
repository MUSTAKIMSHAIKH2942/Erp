<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="QA_VerificationPage.aspx.vb" Inherits="QA_VerificationPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Verifying label & checking COA by QA</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td colspan="2" class="tableheader">
                   Verifying label & checking COA by QA
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    &nbsp;</td>
                <td class="tabledata" align="right">
                    <asp:Button ID="btnBack" CausesValidation="False" runat="server" Text="Back" 
                        CssClass="btn-cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    SR Ref ID   <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSRRefID" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                     Is Label Verified 
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblLabelVerified" runat="server" CssClass="form-radio">
                        <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    COA Checked
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblCOAChecked" runat="server" CssClass="form-radio">
                        <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Sample Request Entry 
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblSampleRequestEntry" runat="server" CssClass="form-radio">
                        <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Covering Letter File Path 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCoveringLetterFilePath" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    MSDS File Path
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtMSDSFilePath" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    COA File Path 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCOAFilePath" runat="server" CssClass="form-control" />
                </td>
            </tr>
                  <tr>
                <td class="linespace" colspan="2"></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Insert" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                </td>
        </table>
    </form>
</body>
</html>
