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
        Try
            Dim sampleReq As New SampleReqiziationStock()

            ' Correctly parse the SampleReqizitionID
            Dim sampleReqId As Integer
            If Integer.TryParse(Request.QueryString("id"), sampleReqId) Then
                sampleReq.SampleReqizitionID = sampleReqId
            Else
                ' Handle invalid ID if necessary
                ' Display error message or log the issue
                Return
            End If

            ' Set values with default Nothing if empty
            If String.IsNullOrEmpty(txtSampleRequestID.Text) Then
                sampleReq.SR_Ref_ID = Nothing
            Else
                sampleReq.SR_Ref_ID = txtSampleRequestID.Text
            End If

            If String.IsNullOrEmpty(rblIsSampleAvailableInPlant.SelectedValue) Then
                sampleReq.IsSampleAvailableInPlant = Nothing
            Else
                sampleReq.IsSampleAvailableInPlant = rblIsSampleAvailableInPlant.SelectedValue
            End If

            If sampleReq.IsSampleAvailableInPlant = "Yes" Then
                Dim quantity As Integer
                If Integer.TryParse(txtTotalQuantity.Text, quantity) Then
                    sampleReq.TotalQuantity = quantity
                Else
                    sampleReq.TotalQuantity = Nothing
                End If

                If String.IsNullOrEmpty(txtBatchNo.Text) Then
                    sampleReq.BatchNo = Nothing
                Else
                    sampleReq.BatchNo = txtBatchNo.Text
                End If

                If String.IsNullOrEmpty(txtRemarkIfYes.Text) Then
                    sampleReq.RemarkIfYes = Nothing
                Else
                    sampleReq.RemarkIfYes = txtRemarkIfYes.Text
                End If
            ElseIf sampleReq.IsSampleAvailableInPlant = "No" Then
                If rblRequestForwarded.SelectedValue = "Yes" Then
                    sampleReq.RequestForwardedToRnD = True
                Else
                    sampleReq.RequestForwardedToRnD = False
                End If

                If ddlConcernedPerson.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(ddlConcernedPerson.SelectedItem.Text) Then
                    sampleReq.ConcernedPersonName = Nothing
                Else
                    sampleReq.ConcernedPersonName = ddlConcernedPerson.SelectedItem.Text
                End If

                If String.IsNullOrEmpty(txtRemarkIfNo.Text) Then
                    sampleReq.RemarkIfNo = Nothing
                Else
                    sampleReq.RemarkIfNo = txtRemarkIfNo.Text
                End If
            End If

            If SampleReqiziationStock.UpdateSampleReqiziationStock(sampleReq) Then
                Response.Redirect("ViewSampleRequisition.aspx")
            Else
                ' Handle update failure
                lblErrorMessage.Text = "Update failed. Please try again later."
                lblErrorMessage.Visible = True
            End If
        Catch ex As Exception
            ' Handle exceptions
            ' e.g., LogError(ex)
        End Try
    End Sub




    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Response.Redirect("ViewSampleRequisition.aspx")
    End Sub

    Protected Sub rblIsSampleAvailableInPlant_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim selectedValue As String = rblIsSampleAvailableInPlant.SelectedValue
        panelYes.Visible = (selectedValue = "Yes")
        panelNo.Visible = (selectedValue = "No")
    End Sub
End Class
