<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="QCSampleApprovalFormPage.aspx.vb" Inherits="QCSampleApprovalFormPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Add QC Sample Approval</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td class="tableheader" align="center" colspan="3">
                    QC / R&D Approval on Sample Request
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
                    SR Ref ID <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtSRRefID" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator
                        ID="rfvSRRefID"
                        runat="server"
                        ControlToValidate="txtSRRefID"
                        ErrorMessage="SR Ref ID is required."
                        CssClass="error-message"
                        Display="Dynamic"
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Total Quantity Available/will be ready?  <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtAvailableQuantity" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator
                        ID="rfvAvailableQuantity"
                        runat="server"
                        ControlToValidate="txtAvailableQuantity"
                        ErrorMessage="Available Quantity is required."
                        CssClass="error-message"
                        Display="Dynamic"
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Batch No
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtBatchNumber" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Remark (if any)
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtRemark" runat="server" CssClass="form-control" TextMode="MultiLine" />
                </td>
            </tr>
           
            <tr>
                <td colspan="3" align="center">
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn-submit" OnClick="btnSave_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:Label ID="lblMessage" runat="server" CssClass="error-message" Visible="False" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
