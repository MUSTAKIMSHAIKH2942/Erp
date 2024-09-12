<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="sampleReqizitionpage1.aspx.vb" Inherits="sampleReqizitionpage1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Sample Requisition Page</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td class="tableheader" align="center" colspan="2">
                    Check whether material is available in stores
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">&nbsp;</td>
                <td class="tabledata" align="right">
                    <asp:Button ID="btnBack" CausesValidation="False" runat="server" Text="Back" 
                        CssClass="btn-cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Sample Request ID <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSampleRequestID" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Is Available In Stores? <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblIsAvailableInStores" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="rblIsAvailableInStores_SelectedIndexChanged">
                        <asp:ListItem Text="Yes" Value="Yes" />
                        <asp:ListItem Text="No" Value="No" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvIsAvailableInStores" runat="server"
                        ControlToValidate="rblIsAvailableInStores"
                        InitialValue=""
                        ErrorMessage="Selection is required."
                        CssClass="error-message"
                        Display="Dynamic" />
                </td>
            </tr>
            <!-- Availability Section: Shown only when 'Yes' is selected -->
            <asp:Panel ID="availabilitySection" runat="server" Visible="false">
                <tr>
                    <td class="fieldheaders">
                        Batch Number <span style="color: red;">*</span>
                    </td>
                    <td class="tabledata">
                        <asp:TextBox ID="txtBatchNo" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvBatchNo" runat="server"
                            ControlToValidate="txtBatchNo"
                            ErrorMessage="Batch number is required."
                            CssClass="error-message"
                            Display="Dynamic" />
                    </td>
                </tr>
                <tr>
                    <td class="fieldheaders">
                        Available in <span style="color: red;">*</span>
                    </td>
                    <td class="tabledata">
                        <asp:RadioButtonList ID="rblAvailableIn" runat="server" RepeatDirection="Vertical">
                            <asp:ListItem Text="RMCPL Godown" Value="RMCPL Godown" />
                            <asp:ListItem Text="SCPL Godown" Value="SCPL Godown" />
                            <asp:ListItem Text="Sankeshwar Godown" Value="Sankeshwar Godown" />
                            <asp:ListItem Text="Polymer Plant" Value="Polymer Plant" />
                            <asp:ListItem Text="Windsor Plant" Value="Windsor Plant" />
                            <asp:ListItem Text="Other Godown" Value="Other Godown" />
                            <asp:ListItem Text="Other" Value="Other" />
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="rfvAvailableIn" runat="server"
                            ControlToValidate="rblAvailableIn"
                            InitialValue=""
                            ErrorMessage="Selection is required."
                            CssClass="error-message"
                            Display="Dynamic" />
                    </td>
                </tr>
            </asp:Panel>
            <tr>
                <td class="fieldheaders">&nbsp;</td>
                <td class="tabledata">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td class="linespace" colspan="2"></td>
            </tr>
            <tr>
                <td colspan="2" align="center">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
