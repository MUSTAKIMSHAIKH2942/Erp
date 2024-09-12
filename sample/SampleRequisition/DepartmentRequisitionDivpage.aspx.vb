Imports System.Data
Imports System.Data.SqlClient

Partial Class DepartmentRequisitionDivpage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSrRefId.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Try
            ' Create a new instance of the DepartmentRequisitionDiv class
            Dim div As New DepartmentRequisitionDiv()
            div.SrRefId = txtSrRefId.Text
            div.Division = ddlDivision.SelectedValue
            div.SampleRequestSent = ddlSampleRequestSent.SelectedValue
            div.ConcernedPersonName = txtConcernedPersonName.Text
            div.MaterialReadyDays = txtMaterialReadyDays.Text
            div.Remarks = txtRemarks.Text

            ' Set SampleReqizitionID to Request.QueryString("id")
            div.SampleReqizitionID = Request.QueryString("id")

            ' Insert the record using the InsertDepartmentRequisitionDiv method
            If DepartmentRequisitionDiv.InsertDepartmentRequisitionDiv(div) Then
                ClearForm()
                Response.Redirect("ViewSampleRequisition.aspx")

            Else
                Response.Write("<script>alert('Failed to insert record.');</script>")
            End If
        Catch ex As Exception
            Response.Write("<script>alert('An error occurred: " & ex.Message & "');</script>")
        End Try
    End Sub

    Private Sub ClearForm()
        txtSrRefId.Text = ""
        ddlDivision.SelectedIndex = 0
        ddlSampleRequestSent.SelectedIndex = 0
        txtConcernedPersonName.Text = ""
        txtMaterialReadyDays.Text = ""
        txtRemarks.Text = ""
    End Sub
    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
