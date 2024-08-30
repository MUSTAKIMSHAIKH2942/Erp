Imports System.Data
Imports System.Data.SqlClient

Partial Class CustomerSampleApprovalPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub


    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim approval As New CustomerSampleApproval()

        ' Set default SampleReqizitionID
        approval.SampleReqizitionID = Request.QueryString("id")

        ' Assign values from form controls
        approval.SRRefID = txtSRRefID.Text.Trim()
        approval.SampleApprovedByCustomer = rblSampleApprovedByCustomer.SelectedValue
        approval.CustomerReportFilePath = txtCustomerReportFilePath.Text.Trim()
        approval.OnTrackForSaleToCustomer = rblOnTrackForSaleToCustomer.SelectedValue

        ' Check if ReasonForNotOnTrack is provided
        If Not String.IsNullOrEmpty(txtReasonForNotOnTrack.Text.Trim()) Then
            approval.ReasonForNotOnTrack = txtReasonForNotOnTrack.Text.Trim()
        Else
            approval.ReasonForNotOnTrack = Nothing ' Set to Nothing to represent NULL
        End If

        ' Check if NextStepToTrackForSale is provided
        If Not String.IsNullOrEmpty(txtNextStepToTrackForSale.Text.Trim()) Then
            approval.NextStepToTrackForSale = txtNextStepToTrackForSale.Text.Trim()
        Else
            approval.NextStepToTrackForSale = Nothing ' Set to Nothing to represent NULL
        End If

        ' Convert ExpectedOrderDate to DateTime if provided
        Dim expectedOrderDate As Date
        If Date.TryParse(txtExpectedOrderDate.Text.Trim(), expectedOrderDate) Then
            approval.ExpectedOrderDate = expectedOrderDate
        Else
            approval.ExpectedOrderDate = Date.MinValue ' Set to Date.MinValue if the date is not provided
        End If

        ' Insert data
        Dim success As Boolean = CustomerSampleApproval.InsertCustomerSampleApproval(approval)

        ' Provide feedback
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


    Private Sub ClearForm()
        txtSRRefID.Text = String.Empty
        rblSampleApprovedByCustomer.SelectedIndex = -1
        txtCustomerReportFilePath.Text = String.Empty
        rblOnTrackForSaleToCustomer.SelectedIndex = -1
        txtReasonForNotOnTrack.Text = String.Empty
        txtNextStepToTrackForSale.Text = String.Empty
        txtExpectedOrderDate.Text = String.Empty
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
