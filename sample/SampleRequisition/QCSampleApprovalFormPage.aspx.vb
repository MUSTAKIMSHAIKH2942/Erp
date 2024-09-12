Imports System.Data
Imports System.Data.SqlClient

Public Class QCSampleApprovalFormpage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' Hide the message label before processing
        lblMessage.Visible = False

        Try
            ' Retrieve form values
            Dim sampleApproval As New QCSampleApproval()
            sampleApproval.SampleReqizitionID = Request.QueryString("id")
            sampleApproval.SRRefID = txtSRRefID.Text.Trim()
            sampleApproval.AvailableQuantity = Convert.ToInt32(txtAvailableQuantity.Text.Trim())
            sampleApproval.BatchNumber = txtBatchNumber.Text.Trim()
            sampleApproval.Remark = txtRemark.Text.Trim()

            ' Insert data using the AddQCSampleApproval method
            If QCSampleApproval.AddQCSampleApproval(sampleApproval) Then
                lblMessage.Text = "Record added successfully!"
                lblMessage.ForeColor = System.Drawing.Color.Green
                lblMessage.Visible = True
                ClearForm()
                Response.Redirect("ViewSampleRequisition.aspx")

            Else
                lblMessage.ForeColor = System.Drawing.Color.Red
                lblMessage.Visible = True
            End If
        Catch ex As Exception
            lblMessage.ForeColor = System.Drawing.Color.Red
            lblMessage.Visible = True
        End Try
    End Sub

    Private Sub ClearForm()
        txtSRRefID.Text = String.Empty
        txtAvailableQuantity.Text = String.Empty
        txtBatchNumber.Text = String.Empty
        txtRemark.Text = String.Empty
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
