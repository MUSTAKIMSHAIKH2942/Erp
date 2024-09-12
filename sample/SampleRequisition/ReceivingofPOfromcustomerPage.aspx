<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="ReceivingofPOfromcustomerPage.aspx.vb" Inherits="ReceivingofPOfromcustomerPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Receiving of PO from Customer</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" rel="stylesheet" />
    <script type="text/javascript">
        $(function () {
            $("#txtExpectedDeliveryDate").datepicker({ dateFormat: 'yy-mm-dd' });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td class="tableheader" colspan="3">
                    Receiving of PO from Customer
                </td>
            </tr>
            <tr>
                <td class="fieldheaders" colspan="2">
                    &nbsp;
                </td>
                <td class="tabledata" align="right">
                    <asp:Button ID="btnBack" CausesValidation="False" runat="server" Text="Back" 
                        CssClass="btn-cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    SR Reference ID <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtSRRefID" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvSRRefID" runat="server" ControlToValidate="txtSRRefID"
                        ErrorMessage="SR Reference ID is required." ForeColor="Red" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    PO Number <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtPONo" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvPONo" runat="server" ControlToValidate="txtPONo"
                        ErrorMessage="PO Number is required." ForeColor="Red" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Product <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtProduct" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvProduct" runat="server" ControlToValidate="txtProduct"
                        ErrorMessage="Product is required." ForeColor="Red" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Quantity (in Kg)  <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtQtyInKg" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvQtyInKg" runat="server" ControlToValidate="txtQtyInKg"
                        ErrorMessage="Quantity is required." ForeColor="Red" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    PO Amount  <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtPOAmount" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvPOAmount" runat="server" ControlToValidate="txtPOAmount"
                        ErrorMessage="PO Amount is required." ForeColor="Red" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Expected Delivery Date  <span style="color: red;">*</span>
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtExpectedDeliveryDate" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvExpectedDeliveryDate" runat="server" ControlToValidate="txtExpectedDeliveryDate"
                        ErrorMessage="Expected Delivery Date is required." ForeColor="Red" Display="Dynamic" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Remarks
                </td>
                <td class="tabledata" colspan="2">
                    <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    &nbsp;
                </td>
                <td class="tabledata" colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3" class="form-message">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>