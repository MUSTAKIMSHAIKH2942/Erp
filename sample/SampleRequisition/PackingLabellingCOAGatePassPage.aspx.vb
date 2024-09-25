Imports System.Data
Imports System.Data.SqlClient

Public Class PackingLabellingCOAGatePassPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSRRefID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim packingLabellingCOAGatePass As New PackingLabellingCOAGatePass()

        ' Populate the PackingLabellingCOAGatePass object with data from the form
        packingLabellingCOAGatePass.SRRefID = txtSRRefID.Text
        packingLabellingCOAGatePass.ProperPackagingLabellingDone = ddlProperPackagingLabellingDone.SelectedValue
        packingLabellingCOAGatePass.PrepareCOA = ddlPrepareCOA.SelectedValue
        packingLabellingCOAGatePass.GatePassNo = txtGatePassNo.Text
        packingLabellingCOAGatePass.SampleReqizitionID = Request.QueryString("id")


        Dim gatePassDate As DateTime
        If DateTime.TryParse(txtGatePassDate.Text, gatePassDate) AndAlso gatePassDate >= New DateTime(1753, 1, 1) AndAlso gatePassDate <= New DateTime(9999, 12, 31) Then
            packingLabellingCOAGatePass.GatePassDate = gatePassDate
        Else
            packingLabellingCOAGatePass.GatePassDate = Nothing ' Or handle as needed
        End If
        packingLabellingCOAGatePass.SampleReqizitionID = Request.QueryString("id")
        ' Set a default value for InsertedDate if necessary
        packingLabellingCOAGatePass.InsertedDate = DateTime.Now

        ' Call the method to insert data into the database
        Try
            If PackingLabellingCOAGatePass.AddPackingLabellingCOAGatePass(packingLabellingCOAGatePass) Then
                ClearForm() ' Call method to clear the form fields
                Response.Redirect("ViewSampleRequisition.aspx")

            Else

            End If

        Catch ex As Exception
        End Try
    End Sub



    Private Sub ClearForm()
        ' Clear text boxes
        txtSRRefID.Text = String.Empty
        txtGatePassNo.Text = String.Empty
        txtGatePassDate.Text = String.Empty

        ' Reset dropdowns to default (first item or empty)
        ddlProperPackagingLabellingDone.SelectedIndex = 0
        ddlPrepareCOA.SelectedIndex = 0
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
