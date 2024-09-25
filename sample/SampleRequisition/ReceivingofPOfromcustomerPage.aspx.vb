Imports System.Data
Imports System.Data.SqlClient

Partial Class ReceivingofPOfromcustomerPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        ' Create an instance of the ReceivingofPOfromcustomer class
        Dim receivingDetails As New ReceivingofPOfromcustomer()

        ' Assign values from form controls to the properties of the class
        receivingDetails.SRRefID = txtSRRefID.Text.Trim()
        receivingDetails.PONo = txtPONo.Text.Trim()
        receivingDetails.Product = txtProduct.Text.Trim()
        receivingDetails.QtyInKg = Convert.ToDecimal(txtQtyInKg.Text.Trim())
        receivingDetails.POAmount = Convert.ToDecimal(txtPOAmount.Text.Trim())
        receivingDetails.ExpectedDeliveryDate = Convert.ToDateTime(txtExpectedDeliveryDate.Text.Trim())
        receivingDetails.Remarks = txtRemarks.Text.Trim()
        receivingDetails.SampleReqizitionID = Request.QueryString("id")


        ' Call the method to insert the record into the database
        Dim success As Boolean = ReceivingofPOfromcustomer.InsertReceivingOfPOFromCustomer(receivingDetails)

        ' Display a message and redirect based on the success of the operation
        If success Then
            ClearForm()
            lblMessage.Text = "Record inserted successfully."
            lblMessage.ForeColor = System.Drawing.Color.Green
            Response.Redirect("ViewSampleRequisition.aspx")
        Else
            lblMessage.Text = "Error occurred while inserting the record."
            lblMessage.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    ' Method to clear the form fields
    Private Sub ClearForm()
        txtSRRefID.Text = String.Empty
        txtPONo.Text = String.Empty
        txtProduct.Text = String.Empty
        txtQtyInKg.Text = String.Empty
        txtPOAmount.Text = String.Empty
        txtExpectedDeliveryDate.Text = String.Empty
        txtRemarks.Text = String.Empty
    End Sub
    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
