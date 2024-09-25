Imports System.Data.SqlClient

Partial Class RMCPL_RmcplRequisitionHODApprove
    Inherits System.Web.UI.Page
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            LoadData(sender, e)
            lblMessage.Text = ""
        End If
    End Sub
    Public Sub LoadData(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ds As Data.DataSet = RmcplRequisition.GetRmcplRequisition()
        'Dim ds As Data.DataSet = SalesReport.GetSalesReport(dateinfo.GetMonthName(Date.Now.Month) & Date.Now.Year, "Paper")

        With dgRmcplRequisition
            .ShowFooter = True
            .DataSource = ds
            .DataBind()
        End With
    End Sub

    Protected Sub dgRmcplRequisition_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgRmcplRequisition.ItemCommand
        Select Case e.CommandName
            Case "Approve"
                Dim _RMCPL_TID As Integer = dgRmcplRequisition.DataKeys(e.Item.ItemIndex)
                Dim SampleID As String = CType(e.Item.FindControl("lblRMCPL_SR_NO"), Label).Text.Trim
                Dim oRmcplRequisition As RmcplRequisition = New RmcplRequisition
                With oRmcplRequisition


                    .RMCPL_TID = _RMCPL_TID

                    .IsHODApproved = 1
                    .UpdateRmcplRequisitionHOFApprove()

                End With
                LoadData(source, e)
                lblMessage.Text = "Sample '" & SampleID & "' Approved Successfully"

        End Select
    End Sub

    Protected Sub dgRmcplRequisition_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgRmcplRequisition.ItemCreated
        Try
            Dim btn As LinkButton = CType(e.Item.FindControl("lnkbtnApprove"), LinkButton)
            btn.Attributes.Add("onclick", "return confirm('Are you sure you want to approve this record?')")
            
        Catch
        End Try
    End Sub

End Class
