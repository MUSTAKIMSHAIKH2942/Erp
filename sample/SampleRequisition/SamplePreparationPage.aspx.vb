Imports System.Data
Imports System.Data.SqlClient

Public Class SamplePreparationPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim samplePreparation As New SamplePreparation()

        ' Populate the SamplePreparation object with data from the form
        samplePreparation.SampleReqizitionID = Request.QueryString("id")
        samplePreparation.SR_Ref_ID = txtSRRefID.Text
        samplePreparation.Division = ddlDivision.SelectedValue
        samplePreparation.PreparedAsPerRequirement = ddlPreparedAsPerRequirement.SelectedValue
        samplePreparation.SampleQualityChecked = ddlSampleQualityChecked.SelectedValue
        samplePreparation.PackedSampleSentToQC = ddlPackedSampleSentToQC.SelectedValue

        ' Call the method to insert data into the database
        If samplePreparation.AddSamplePreparation(samplePreparation) Then
            ClearForm()
            Response.Redirect("ViewSampleRequisition.aspx")

        Else

        End If
    End Sub
    Private Sub ClearForm()
        ' Clear text boxes
        txtSRRefID.Text = String.Empty

        ' Reset dropdowns to default (first item or empty)
        ddlDivision.SelectedIndex = 0
        ddlPreparedAsPerRequirement.SelectedIndex = 0
        ddlSampleQualityChecked.SelectedIndex = 0
        ddlPackedSampleSentToQC.SelectedIndex = 0
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx")
    End Sub
End Class
