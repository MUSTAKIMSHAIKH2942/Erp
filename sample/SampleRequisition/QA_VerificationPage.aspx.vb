Imports System
Imports System.Web.UI
Imports System.Data.SqlClient
Imports System.IO ' Add this import for handling file paths and file operations

Partial Public Class QA_VerificationPage
    Inherits System.Web.UI.Page

    ' Class-level variable for COA file path
    Dim COAFile As String

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
        Dim objCommon As New common()

        ' Handle COA file upload
        COAFile = objCommon.UploadFile("COA", FUCOA, "Sample_Requizition")
        If COAFile.StartsWith("Error") Then
            ' Display the error message if COA upload fails
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('" & COAFile & "');", True)
            Exit Sub
        End If

        ' Handle Covering Letter file upload
        Dim coveringLetterPath As String = objCommon.UploadFile("CoveringLetter", FUCoveringLetter, "Sample_Requizition")
        If coveringLetterPath.StartsWith("Error") Then
            ' Display the error message if Covering Letter upload fails
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('" & coveringLetterPath & "');", True)
            Exit Sub
        End If

        ' Handle MSDS file upload
        Dim msdsFilePath As String = objCommon.UploadFile("MSDS", FUMSDS, "Sample_Requizition")
        If msdsFilePath.StartsWith("Error") Then
            ' Display the error message if MSDS upload fails
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('" & msdsFilePath & "');", True)
            Exit Sub
        End If

        ' Set properties from form fields
        verification.SRRefID = txtSRRefID.Text
        verification.LabelVerified = rblLabelVerified.SelectedValue
        verification.COAChecked = rblCOAChecked.SelectedValue
        verification.SampleRequestEntry = rblSampleRequestEntry.SelectedValue
        verification.CoveringLetterFilePath = coveringLetterPath
        verification.MSDSFilePath = msdsFilePath
        verification.COAFilePath = COAFile

        ' Set SampleReqizitionID from QueryString (this could be converted to an integer if necessary)
        verification.SampleReqizitionID = Request.QueryString("id")

        ' Call the method to add the verification record
        Dim success As Boolean = QA_Verification.AddQA_Verification(verification)

        ' Notify the user of success or failure
        If success Then
            ' Display success message and redirect
            ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Record added successfully!');", True)
            Response.Redirect("ViewSampleRequisition.aspx")

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

        ' Clear the file upload controls
        FUCOA.Attributes.Clear()
        FUCoveringLetter.Attributes.Clear()
        FUMSDS.Attributes.Clear()

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
