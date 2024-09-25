Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class QCSampleApproval
    Private _QCSampleApprovalID As Integer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _AvailableQuantity As Integer
    Private _BatchNumber As String
    Private _Remark As String
    Private _InsertedDate As DateTime

    ' Properties
    Public Property QCSampleApprovalID() As Integer
        Get
            Return _QCSampleApprovalID
        End Get
        Set(ByVal value As Integer)
            _QCSampleApprovalID = value
        End Set
    End Property

    Public Property SampleReqizitionID() As Integer
        Get
            Return _SampleReqizitionID
        End Get
        Set(ByVal value As Integer)
            _SampleReqizitionID = value
        End Set
    End Property

    Public Property SRRefID() As String
        Get
            Return _SRRefID
        End Get
        Set(ByVal value As String)
            _SRRefID = value
        End Set
    End Property

    Public Property AvailableQuantity() As Integer
        Get
            Return _AvailableQuantity
        End Get
        Set(ByVal value As Integer)
            _AvailableQuantity = value
        End Set
    End Property

    Public Property BatchNumber() As String
        Get
            Return _BatchNumber
        End Get
        Set(ByVal value As String)
            _BatchNumber = value
        End Set
    End Property

    Public Property Remark() As String
        Get
            Return _Remark
        End Get
        Set(ByVal value As String)
            _Remark = value
        End Set
    End Property

    Public ReadOnly Property InsertedDate() As DateTime
        Get
            Return _InsertedDate
        End Get
    End Property

    ' Method to add a record
    Public Shared Function AddQCSampleApproval(ByVal paramQCSampleApproval As QCSampleApproval) As Boolean
        With paramQCSampleApproval
            Dim params(4) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SRRefID", .SRRefID)
            params(2) = New SqlParameter("@AvailableQuantity", .AvailableQuantity)
            params(3) = New SqlParameter("@BatchNumber", .BatchNumber)
            params(4) = New SqlParameter("@Remark", .Remark)

            Dim storedProcName As String = "InsertQCSampleApproval"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function
End Class
