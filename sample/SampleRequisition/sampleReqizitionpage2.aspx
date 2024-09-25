<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="sampleReqizitionpage2.aspx.vb" Inherits="sampleReqizitionpage2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Update Sample Request Status</title>
    <link href="../Styles.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" align="center" class="mainTable7" >
            <tr>
                <td class="tableheader" align="center" colspan="2">
                    Check whether material is available in Plant
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
                    Sample Request ID <span style="color: red;">*</span>&nbsp; &nbsp; &nbsp; 
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSampleRequestID" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Is Sample Available In Plant? <span style="color: red;">*</span> &#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160 
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblIsSampleAvailableInPlant" runat="server" RepeatDirection="Horizontal" 
                        AutoPostBack="true" OnSelectedIndexChanged="rblIsSampleAvailableInPlant_SelectedIndexChanged">
                        <asp:ListItem Text="Yes" Value="Yes" />
                        <asp:ListItem Text="No" Value="No" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvIsSampleAvailableInPlant" runat="server" 
                        ControlToValidate="rblIsSampleAvailableInPlant" 
                        InitialValue="" 
                        ErrorMessage="Selection is required." 
                        CssClass="error-message" 
                        Display="Dynamic" />
                </td>
            </tr>
        </table>

        <!-- Panel for "Yes" option -->
        <table id="panelYes" runat="server" visible="false" class="mainTable7"  align="center" >
            <tr>
                <td class="fieldheaders">
                    Total Quantity available / will be ready? <span style="color: red;">*</span>&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160&#160
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtTotalQuantity" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Batch no. <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtBatchNo" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Remark (if any)
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtRemarkIfYes" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
        </table>

        <!-- Panel for "No" option -->
        <table id="panelNo" runat="server" visible="false" class="mainTable7"  align="center">
            <tr>
                <td class="fieldheaders">
                    If not available in Plant, request forwarded to R&D Department <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:RadioButtonList ID="rblRequestForwarded" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Yes" Value="Yes" />
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Requisition sent to? (Concerned person name)
                </td>
                <td class="tabledata">
                    <asp:DropDownList ID="ddlConcernedPerson" runat="server" CssClass="form-control">
                        <asp:ListItem Value="">-- Select Division --</asp:ListItem>
                        <asp:ListItem Value="Test1">Test1</asp:ListItem>
                        <asp:ListItem Value="Test2">Test2</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Remarks (If any)
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtRemarkIfNo" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
        </table>

        <table align="center" class="mainTable7">
            <tr>
                <td align="center">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn-submit" OnClick="btnUpdate_Click" />
                </td>
            </tr>
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>

        </table>
    </form>
</body>
</html>
