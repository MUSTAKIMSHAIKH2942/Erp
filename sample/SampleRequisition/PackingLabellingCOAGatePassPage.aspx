<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="PackingLabellingCOAGatePassPage.aspx.vb" Inherits="PackingLabellingCOAGatePassPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Packing Labelling COA Gate Pass</title>
<link href="../Styles.css" type="text/css" rel="stylesheet">
    <link href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#txtGatePassDate").datepicker({
                dateFormat: "yy-mm-dd"
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td class="tableheader" align="center" colspan="2">
                    Packing, Labelling & COA Gate Pass
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
                    Sample Reference ID  <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSRRefID" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvSRRefID" runat="server" ControlToValidate="txtSRRefID" 
                        ErrorMessage="Sample Reference ID is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Proper Packaging and Labelling Done  <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="ddlProperPackagingLabellingDone" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Yes" Value="Yes" />
                        <asp:ListItem Text="No" Value="No" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvProperPackagingLabellingDone" runat="server" ControlToValidate="ddlProperPackagingLabellingDone" 
                        InitialValue="" ErrorMessage="Selection is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    COA Prepared  <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="ddlPrepareCOA" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Yes" Value="Yes" />
                        <asp:ListItem Text="No" Value="No" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvPrepareCOA" runat="server" ControlToValidate="ddlPrepareCOA" 
                        InitialValue="" ErrorMessage="Selection is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Gate Pass Number  <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtGatePassNo" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvGatePassNo" runat="server" ControlToValidate="txtGatePassNo" 
                        ErrorMessage="Gate Pass Number is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Gate Pass Date  <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtGatePassDate" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvGatePassDate" runat="server" ControlToValidate="txtGatePassDate" 
                        ErrorMessage="Gate Pass Date is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="linespace" colspan="2"></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Insert" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
