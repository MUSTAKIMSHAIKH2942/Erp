Imports System
Imports System.Web.UI
Imports System.Data.SqlClient

Partial Public Class QA_VerificationPage
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Create a new instance of QA_Verification
        Dim verification As New QA_Verification()

        ' Set properties from form fields
        verification.SRRefID = txtSRRefID.Text
        verification.LabelVerified = rblLabelVerified.SelectedValue
        verification.COAChecked = rblCOAChecked.SelectedValue
        verification.SampleRequestEntry = rblSampleRequestEntry.SelectedValue
        verification.CoveringLetterFilePath = txtCoveringLetterFilePath.Text
        verification.MSDSFilePath = txtMSDSFilePath.Text
        verification.COAFilePath = txtCOAFilePath.Text

        ' Set SampleReqizitionID to 1
        verification.SampleReqizitionID = Request.QueryString("id")

        ' Call the method to add the verification record
        Dim success As Boolean = QA_Verification.AddQA_Verification(verification)

        ' Notify the user of success or failure
        If success Then
            ' Display success message
            Response.Redirect("ViewSampleRequisition.aspx")

            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Record added successfully!');", True)

            ' Clear all inputs after successful insertion
            ClearInputs()
        Else
            ' Display error message
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Failed to add record.');", True)
        End If
    End Sub

    Private Sub ClearInputs()
        ' Clear textboxes
        txtSRRefID.Text = String.Empty
        txtCoveringLetterFilePath.Text = String.Empty
        txtMSDSFilePath.Text = String.Empty
        txtCOAFilePath.Text = String.Empty

        ' Reset radio button lists
        rblLabelVerified.ClearSelection()
        rblCOAChecked.ClearSelection()
        rblSampleRequestEntry.ClearSelection()
    End Sub


    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
