Imports System
Imports System.Data
Imports System.Data.SqlClient
Partial Class CustomerSampleReceiptCheckPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub


    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        ' Assuming you have a method to get the SampleReqizitionID, e.g., from another control or session

        ' Create an instance of CustomerSampleReceiptCheck with the SampleReqizitionID
        Dim receiptCheck As New CustomerSampleReceiptCheck(Request.QueryString("id"))

        ' Set properties
        receiptCheck.SRRefID = txtSRRefID.Text
        receiptCheck.MaterialReceivedInGoodCondition = rblMaterialReceivedInGoodCondition.SelectedValue
        receiptCheck.SupportingDocumentationReceived = rblSupportingDocumentationReceived.SelectedValue

        ' Parse ExpectedTestingDate from TextBox to Date?
        Dim expectedDate As DateTime
        If DateTime.TryParse(txtExpectedTestingDate.Text, expectedDate) Then
            receiptCheck.ExpectedTestingDate = expectedDate
        Else
            receiptCheck.ExpectedTestingDate = Nothing
        End If

        receiptCheck.OtherRemarks = txtOtherRemarks.Text

        ' Insert record
        Dim result As Boolean = receiptCheck.InsertCustomerSampleReceiptCheck()

        ' Show result
        If result Then
            ClearForm()
            Response.Write("<script>alert('Record inserted successfully.');</script>")
            Response.Redirect("ViewSampleRequisition.aspx")

        Else
            Response.Write("<script>alert('Failed to insert record.');</script>")
        End If
    End Sub

    Private Sub ClearForm()
        ' Clear text boxes
        txtSRRefID.Text = String.Empty
        txtExpectedTestingDate.Text = String.Empty
        txtOtherRemarks.Text = String.Empty

        ' Clear radio button lists
        rblMaterialReceivedInGoodCondition.ClearSelection()
        rblSupportingDocumentationReceived.ClearSelection()
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
