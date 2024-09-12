Imports System.Data
Imports System.Data.SqlClient

Partial Class TrackDispatchUntideliveryPage
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ' Create an instance of the class
            Dim details As New TrackDispatchUntidelivery()

            ' Set properties from form inputs
            details.SRRefID = txtSRRefID.Text.Trim()
            details.SampleReqizitionID = Request.QueryString("id")
            ' Use DateTime.TryParse for safer date parsing
            Dim deliveryDate As DateTime
            If DateTime.TryParse(txtMaterialDeliveryDate.Text.Trim(), deliveryDate) Then
                details.MaterialDeliveryDate = deliveryDate
            Else
                lblMessage.Text = "Invalid date format."
                lblMessage.ForeColor = System.Drawing.Color.Red
                Return
            End If

            details.MaterialHandoverTo = txtMaterialHandoverTo.Text.Trim()
            details.UploadPODCopy = txtUploadPODCopy.Text.Trim()

            ' Call the method to insert data
            Dim success As Boolean = TrackDispatchUntidelivery.InsertTrackDispatchUntidelivery(details)

            ' Display success or error message
            If success Then
                lblMessage.Text = "Record inserted successfully."
                lblMessage.ForeColor = System.Drawing.Color.Green

                ' Clear form fields after successful insertion
                ClearFormFields()
                Response.Redirect("ViewSampleRequisition.aspx")

            Else
                lblMessage.Text = "Failed to insert record."
                lblMessage.ForeColor = System.Drawing.Color.Red
            End If
        Catch ex As Exception
            lblMessage.Text = "An error occurred: " & ex.Message
            lblMessage.ForeColor = System.Drawing.Color.Red
        End Try
    End Sub

    Private Sub ClearFormFields()
        ' Clear textboxes
        txtSRRefID.Text = String.Empty
        txtMaterialDeliveryDate.Text = String.Empty
        txtMaterialHandoverTo.Text = String.Empty
        txtUploadPODCopy.Text = String.Empty

        ' Optionally, you can clear the message label
    End Sub
    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx")
    End Sub
End Class