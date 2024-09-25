<%@ Page Language="VB" Theme="BlueChip" AutoEventWireup="false" CodeFile="CourierDetailsPage.aspx.vb" Inherits="CourierDetailsPage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Sample Dispatch</title>
      <link href="../Styles.css" type="text/css" rel="stylesheet">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" rel="stylesheet" />
    <script type="text/javascript">
        $(function () {
            $("#txtCourierDate").datepicker({ dateFormat: 'yy-mm-dd' });
            $("#txtEstimatedDateOfDelivery").datepicker({ dateFormat: 'yy-mm-dd' });
        });
    </script>
    <style type="text/css">
        .btn-secondary
        {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <table id="Table1" align="center" class="mainTable7">
            <tr>
                <td colspan="2" align="center" class="tableheader">
                    Sample Dispatch
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
            <tr >
                <td class="fieldheaders">
                    SR Reference ID <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtSRRefID" runat="server" CssClass="form-control" />
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Courier Service Name <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCourierServiceName" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvCourierServiceName" runat="server" ControlToValidate="txtCourierServiceName" 
                        ErrorMessage="Courier Service Name is required." CssClass="error-message" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Courier Tracking No <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCourierTrackingNo" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvCourierTrackingNo" runat="server" ControlToValidate="txtCourierTrackingNo" 
                        ErrorMessage="Courier Tracking No. is required." CssClass="error-message" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Courier Date <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCourierDate" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredCourierDate" runat="server" ControlToValidate="txtCourierDate" 
                        ErrorMessage="Courier Date is required." CssClass="error-message" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Courier Charges <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtCourierCharges" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredtxtCourierCharges" runat="server" ControlToValidate="txtCourierServiceName" 
                        ErrorMessage="Courier Charges in Rs." CssClass="error-message" ></asp:RequiredFieldValidator>
                </td>
               
            </tr>
            <tr>
                <td class="fieldheaders">
                    Estimated Date of Delivery <span style="color: red;">*</span>
                </td>
                <td class="tabledata">
                    <asp:TextBox ID="txtEstimatedDateOfDelivery" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvEstimatedDateOfDelivery" runat="server" ControlToValidate="txtEstimatedDateOfDelivery" 
                        ErrorMessage="Estimated Date Of Delivery Required*" CssClass="error-message" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="fieldheaders">
                    Upload COA 
                </td>
                <td class="tabledata">
                    <asp:FileUpload ID="FUUploadOfCOA" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="rfvUploadCOA" runat="server" ControlToValidate="FUUploadOfCOA" 
                        ErrorMessage="Please upload a COA file." CssClass="error-message"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <td class="fieldheaders">
                    <asp:Label CssClass="MessageBox" ID="lblMessage" runat="server"></asp:Label>
                </td>
            <tr>
                <td class="fieldheaders">
                    &nbsp;</td>
                <td class="tabledata">
                    <asp:Button ID="btnSubmit" runat="server" Text="Insert" OnClick="btnSubmit_Click" CssClass="btn-submit" />
                    
               
                </td>
            </tr>
            <tr>
                <td colspan="2" class="button-group">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
