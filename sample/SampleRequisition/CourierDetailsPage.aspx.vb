Imports System
Imports System.IO
Imports System.Web.UI

Partial Class CourierDetailsPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtSRRefID.Text = Request.QueryString("No")
        End If
    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim courierDetails As New CourierDetails()

        Dim objCommon As common = New common()
        Dim _COA_COPY As String = objCommon.UploadFile("COA", FUUploadOfCOA, "Sample_Requizition")


        If _COA_COPY.StartsWith("Error") Then
            lblMessage.Text = _COA_COPY
            Exit Sub
        End If
        ' Directly assign values from form fields
        courierDetails.SampleReqizitionID = Request.QueryString("id")
        courierDetails.SRRefID = txtSRRefID.Text
        courierDetails.CourierServiceName = txtCourierServiceName.Text
        courierDetails.CourierTrackingNo = txtCourierTrackingNo.Text
        courierDetails.CourierDate = Convert.ToDateTime(txtCourierDate.Text)
        courierDetails.CourierCharges = Convert.ToDecimal(txtCourierCharges.Text)
        courierDetails.EstimatedDateOfDelivery = Convert.ToDateTime(txtEstimatedDateOfDelivery.Text)
        courierDetails.UploadOfCOA = _COA_COPY



        ' Insert data into the database
        CourierDetails.InsertCourierDetails(courierDetails)

        ' Redirect after successful operation
        ClearFormFields()
        Response.Redirect("ViewSampleRequisition.aspx")
    End Sub

    ' Clears all form fields
    Private Sub ClearFormFields()
        txtSRRefID.Text = String.Empty
        txtCourierServiceName.Text = String.Empty
        txtCourierTrackingNo.Text = String.Empty
        txtCourierDate.Text = String.Empty
        txtCourierCharges.Text = String.Empty
        txtEstimatedDateOfDelivery.Text = String.Empty
        FUUploadOfCOA.Attributes.Clear() ' Clear the file upload control
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        ' Redirect to another page on cancel action
        Response.Redirect("ViewSampleRequisition.aspx")
    End Sub
End Class
