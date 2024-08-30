Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class sampleReqizitionpage1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            ' Initialize the SampleRequestID textbox with query string value if available
            If Not String.IsNullOrEmpty(Request.QueryString("No")) Then
                txtSampleRequestID.Text = Request.QueryString("No")
            End If
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        ' Create an instance of SampleReqiziationStock
        Dim sampleReq As New SampleReqiziationStock()

        ' Set the properties from form inputs
        sampleReq.SampleReqizitionID = Request.QueryString("id")
        sampleReq.SR_Ref_ID = txtSampleRequestID.Text ' Replace with actual reference ID if needed
        sampleReq.IsAvailableInStores = rblIsAvailableInStores.SelectedValue

        ' Set IsSampleAvailableInPlant to DBNull.Value for NULL
        sampleReq.IsSampleAvailableInPlant = Nothing

        ' Call the method to add or update the record

        If SampleReqiziationStock.AddSampleReqiziationStock(sampleReq) Then
            ' Notify user of success
            Response.Redirect("ViewSampleRequisition.aspx")
        Else
            ' Notify user of failure
            ' Optionally display an error message
        End If
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click, btnBack.Click
        ' Handle cancel action here, such as clearing fields or redirecting to another page
        Response.Redirect("ViewSampleRequisition.aspx") ' Redirect to a different page (e.g., home page)
    End Sub
End Class
