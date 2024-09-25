<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="SamplePreparationPage.aspx.vb" Inherits="SamplePreparationPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Sample Preparation</title>
  <link href="../Styles.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
  <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td class="tableheader" align="center" colspan="2">
                    Prepare sample as per the requirement & sent  back to QC Department
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
                    Sample Reference ID <span style="color: red;">*</span>
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
                    Select Division <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:DropDownList ID="ddlDivision" runat="server" CssClass="form-control">
                        <asp:ListItem Value="">-- Select Division --</asp:ListItem>
                        <asp:ListItem Value="Polymer">Polymer</asp:ListItem>
                        <asp:ListItem Value="Bulk Drugs">Bulk Drugs</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvDivision" runat="server" ControlToValidate="ddlDivision" 
                        InitialValue="" ErrorMessage="Division is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Whether Prepared as per requirement ? <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="ddlPreparedAsPerRequirement" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Yes">Yes</asp:ListItem>
                        <asp:ListItem Value="No">No</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvPreparedAsPerRequirement" runat="server" ControlToValidate="ddlPreparedAsPerRequirement" 
                        InitialValue="" ErrorMessage="Selection is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Whether Sample Quality Checked ? <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="ddlSampleQualityChecked" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Yes">Yes</asp:ListItem>
                        <asp:ListItem Value="No">No</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvSampleQualityChecked" runat="server" ControlToValidate="ddlSampleQualityChecked" 
                        InitialValue="" ErrorMessage="Selection is required" CssClass="error-message" 
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Whether Packed Sample Sent to QC ? <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="ddlPackedSampleSentToQC" runat="server" CssClass="form-control" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Yes">Yes</asp:ListItem>
                        <asp:ListItem Value="No">No</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvPackedSampleSentToQC" runat="server" ControlToValidate="ddlPackedSampleSentToQC" 
                        InitialValue="" ErrorMessage="Selection is required" CssClass="error-message" 
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
