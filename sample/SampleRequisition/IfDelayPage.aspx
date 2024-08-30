<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="IfDelayPage.aspx.vb" Inherits="IfDelayPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>If Delay Entry</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet">
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#txtNextEstimateDateOfDispatch").datepicker({
                dateFormat: "yy-mm-dd" // Change format if needed
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td colspan="2" class="tableheader">
                    If Delay Entry Form
                </td>
            </tr>  <tr>
                <td class="fieldheaders">
                    &nbsp;</td>
                <td class="tabledata" align="right">
                    <asp:Button ID="btnBack" CausesValidation="False" runat="server" Text="Back" 
                        CssClass="btn-cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    SR REf ID <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSRID" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator
                        ID="rfvSRID"
                        runat="server"
                        ControlToValidate="txtSRID"
                        ErrorMessage="SRID is required."
                        ForeColor="Red"
                        Display="Dynamic"
                        ValidationGroup="vgIfDelay" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Reason for Delay <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtReasonForDelay" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator
                        ID="rfvReasonForDelay"
                        runat="server"
                        ControlToValidate="txtReasonForDelay"
                        ErrorMessage="Reason for Delay is required."
                        ForeColor="Red"
                        Display="Dynamic"
                        ValidationGroup="vgIfDelay" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Next Estimate Date of Dispatch <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtNextEstimateDateOfDispatch" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator
                        ID="rfvNextEstimateDateOfDispatch"
                        runat="server"
                        ControlToValidate="txtNextEstimateDateOfDispatch"
                        ErrorMessage="Next Estimate Date of Dispatch is required."
                        ForeColor="Red"
                        Display="Dynamic"
                        ValidationGroup="vgIfDelay" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Remarks if Any 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtRemarksIfAny" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Insert" OnClick="btnSubmit_Click" CssClass="btn-submit" />

                    <asp:Label ID="lblMessage" runat="server" ForeColor="green"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>