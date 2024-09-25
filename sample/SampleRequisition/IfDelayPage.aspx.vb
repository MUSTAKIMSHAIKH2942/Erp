Imports System.Data
Imports System.Data.SqlClient

Public Class IfDelayPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim delayEntry As New IfDelay()
        Dim nextEstimateDateOfDispatch As DateTime

        ' Retrieve values from form fields
        delayEntry.SRID = txtSRID.Text
        delayEntry.ReasonForDelay = txtReasonForDelay.Text

        ' Attempt to parse the date
        If DateTime.TryParse(txtNextEstimateDateOfDispatch.Text, nextEstimateDateOfDispatch) Then
            delayEntry.NextEstimateDateOfDispatch = nextEstimateDateOfDispatch
        Else

            Return
        End If

        delayEntry.RemarksIfAny = txtRemarksIfAny.Text

        ' Set SampleReqizitionID to a default value or retrieve it as needed
        delayEntry.SampleReqizitionID = Request.QueryString("id") ' Set default value or retrieve dynamically

        ' Call method to insert data into database
        Dim result As Boolean = IfDelay.AddIfDelay(delayEntry)

        ' Provide feedback to the user
        If result Then
            ' Clear the form fields after successful insertion
            ClearFormFields()
            lblMessage.Text = "Data inserted successfully."
            Response.Redirect("ViewSampleRequisition.aspx")

        Else
            lblMessage.Text = "An error occurred while inserting data."
        End If
    End Sub

    Private Sub ClearFormFields()
        txtSRID.Text = String.Empty
        txtReasonForDelay.Text = String.Empty
        txtNextEstimateDateOfDispatch.Text = String.Empty
        txtRemarksIfAny.Text = String.Empty
    End Sub

Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
