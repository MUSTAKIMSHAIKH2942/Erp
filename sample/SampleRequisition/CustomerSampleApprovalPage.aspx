<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="CustomerSampleApprovalPage.aspx.vb" Inherits="CustomerSampleApprovalPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Customer Sample Receipt Check</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet">
    <!-- Include jQuery UI CSS -->
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <!-- Include jQuery and jQuery UI JavaScript -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
        $(document).ready(function () {
            // Initialize datepicker for Expected Order Date field
            $("#<%= txtExpectedOrderDate.ClientID %>").datepicker({
                dateFormat: 'yy-mm-dd' // Format the date as YYYY-MM-DD
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td class="tableheader" align="center" colspan="2">
                    Tracking of Sample Test Report & Sales Progress
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
                    SR Reference ID <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSRRefID" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator
                        ID="rfvSRRefID"
                        runat="server"
                        ControlToValidate="txtSRRefID"
                        ErrorMessage="SR Reference ID is required."
                        CssClass="error-message"
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Is Supplied Sample Approved by Customer ? <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblSampleApprovedByCustomer" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Yes">Yes</asp:ListItem>
                        <asp:ListItem Value="No">No</asp:ListItem>
                    </asp:RadioButtonList>
                     <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2"
                        runat="server"
                        ControlToValidate="rblSampleApprovedByCustomer"
                        ErrorMessage="Is Supplied Sample Approved by Customer required."
                        CssClass="error-message"
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Upload Customer Report  
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCustomerReportFilePath" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Whether on track for sale to customer ? <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblOnTrackForSaleToCustomer" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Yes">Yes</asp:ListItem>
                        <asp:ListItem Value="No">No</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3"
                        runat="server"
                        ControlToValidate="rblOnTrackForSaleToCustomer"
                        ErrorMessage="please Check On Track for Sale to Customer required"
                        CssClass="error-message"
                        ForeColor="Red" />

                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    If No, Please Specify the Reason 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtReasonForNotOnTrack" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    If Yes, Next Step to Track for Sale 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtNextStepToTrackForSale" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    If Yes, Expected Order Date 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtExpectedOrderDate" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="linespace" colspan="2"></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
