Imports System
Imports System.Web.UI

Public Class sampleReqizitionpage2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSampleRequestID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        ' Create an instance of SampleReqiziationStock
        Dim sampleReq As New SampleReqiziationStock()

        ' Set the properties from form inputs
        sampleReq.SR_Ref_ID = txtSampleRequestID.Text
        sampleReq.IsSampleAvailableInPlant = rblIsSampleAvailableInPlant.SelectedValue
        sampleReq.SampleReqizitionID = Request.QueryString("id")
        ' Call the method to update the record
        If SampleReqiziationStock.UpdateSampleReqiziationStock(sampleReq) Then
            ' Notify user of success
            Response.Redirect("ViewSampleRequisition.aspx")
        Else
            ' Notify user of failure
            ' Optionally, you could show a message to the user about the failure
        End If
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx")
    End Sub
End Class
