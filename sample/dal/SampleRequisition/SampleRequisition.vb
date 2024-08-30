Imports Microsoft.VisualBasic

Imports System.Data
Imports System.Data.SqlClient
Public Class SampleRequisition
    Private _RMCPL_TID As Integer
    Private _RMCPL_SR_NO As String
    Private _RMCPL_DATE As Date
    Private _RMCPL_PACK_SIZE As String
    Private _RMCPL_PACK_SIZEApr As String
    Private _RMCPL_QTY_REQUIRED As Integer
    Private _RMCPL_QTY_APPROVED As Integer
    Private _RMCPL_QTY_PENDING As Integer
    Private _RMCPL_EMP_CD As Integer
    Private _RMCPL_SAMPLE_CD As Integer
    Private _RMCPL_SAMPLE_CDApr As Integer
    Private _Rmcpl_Approved_date As Date
    Private _RMCPL_EXPECTED_DT As Date
    Private _ApprovedBy As Integer
    Private _Inserteddate As Date
    Private _remarks As String
    Private _AprRemarks As String
    Private _RMCPL_USER_TYPE As String
    Private _DisplayByUserCD As String
    Private _OrganisationName As String
    Private _CustomerType As String
    Private _CustomerEmail As String
    Private _CustomerContactNo As String
    Private _Department As String
    Private _SalesManager As String
    Private _CustomerAddress As String
    Private _IsHODApproved As Integer
    Private _HODApprovalDate As Date

    Public Property RMCPL_TID() As Integer
        Get
            Return _RMCPL_TID
        End Get
        Set(ByVal value As Integer)
            _RMCPL_TID = value
        End Set
    End Property
    Public Property RMCPL_SR_NO() As String
        Get
            Return _RMCPL_SR_NO
        End Get
        Set(ByVal value As String)
            _RMCPL_SR_NO = value
        End Set
    End Property
    Public Property RMCPL_DATE() As Date
        Get
            Return _RMCPL_DATE
        End Get
        Set(ByVal value As Date)
            _RMCPL_DATE = value
        End Set
    End Property
    Public Property RMCPL_PACK_SIZE() As String
        Get
            Return _RMCPL_PACK_SIZE
        End Get
        Set(ByVal value As String)
            _RMCPL_PACK_SIZE = value
        End Set
    End Property
    Public Property RMCPL_PACK_SIZEApr() As String
        Get
            Return _RMCPL_PACK_SIZEApr
        End Get
        Set(ByVal value As String)
            _RMCPL_PACK_SIZEApr = value
        End Set
    End Property
    Public Property RMCPL_QTY_REQUIRED() As Integer
        Get
            Return _RMCPL_QTY_REQUIRED
        End Get
        Set(ByVal value As Integer)
            _RMCPL_QTY_REQUIRED = value
        End Set
    End Property
    Public Property RMCPL_QTY_APPROVED() As Integer
        Get
            Return _RMCPL_QTY_APPROVED
        End Get
        Set(ByVal value As Integer)
            _RMCPL_QTY_APPROVED = value
        End Set
    End Property
    Public Property RMCPL_QTY_PENDING() As Integer
        Get
            Return _RMCPL_QTY_PENDING
        End Get
        Set(ByVal value As Integer)
            _RMCPL_QTY_PENDING = value
        End Set
    End Property
    Public Property RMCPL_EMP_CD() As Integer
        Get
            Return _RMCPL_EMP_CD
        End Get
        Set(ByVal value As Integer)
            _RMCPL_EMP_CD = value
        End Set
    End Property
    Public Property RMCPL_SAMPLE_CD() As Integer
        Get
            Return _RMCPL_SAMPLE_CD
        End Get
        Set(ByVal value As Integer)
            _RMCPL_SAMPLE_CD = value
        End Set
    End Property
    Public Property RMCPL_SAMPLE_CDApr() As Integer
        Get
            Return _RMCPL_SAMPLE_CDApr
        End Get
        Set(ByVal value As Integer)
            _RMCPL_SAMPLE_CDApr = value
        End Set
    End Property
    Public Property Rmcpl_Approved_date() As Date
        Get
            Return _Rmcpl_Approved_date
        End Get
        Set(ByVal value As Date)
            _Rmcpl_Approved_date = value
        End Set
    End Property
    Public Property RMCPL_EXPECTED_DT() As Date
        Get
            Return _RMCPL_EXPECTED_DT
        End Get
        Set(ByVal value As Date)
            _RMCPL_EXPECTED_DT = value
        End Set
    End Property
    Public Property ApprovedBy() As Integer
        Get
            Return _ApprovedBy
        End Get
        Set(ByVal value As Integer)
            _ApprovedBy = value
        End Set
    End Property
    Public Property Inserteddate() As Date
        Get
            Return _Inserteddate
        End Get
        Set(ByVal value As Date)
            _Inserteddate = value
        End Set
    End Property
    Public Property remarks() As String
        Get
            Return _remarks
        End Get
        Set(ByVal value As String)
            _remarks = value
        End Set
    End Property
    Public Property AprRemarks() As String
        Get
            Return _AprRemarks
        End Get
        Set(ByVal value As String)
            _AprRemarks = value
        End Set
    End Property
    Public Property RMCPL_USER_TYPE() As String
        Get
            Return _RMCPL_USER_TYPE
        End Get
        Set(ByVal value As String)
            _RMCPL_USER_TYPE = value
        End Set
    End Property
    Public Property DisplayByUserCD() As String
        Get
            Return _DisplayByUserCD
        End Get
        Set(ByVal value As String)
            _DisplayByUserCD = value
        End Set
    End Property
    Public Property OrganisationName() As String
        Get
            Return _OrganisationName
        End Get
        Set(ByVal value As String)
            _OrganisationName = value
        End Set
    End Property
    Public Property CustomerType() As String
        Get
            Return _CustomerType
        End Get
        Set(ByVal value As String)
            _CustomerType = value
        End Set
    End Property
    Public Property CustomerEmail() As String
        Get
            Return _CustomerEmail
        End Get
        Set(ByVal value As String)
            _CustomerEmail = value
        End Set
    End Property
    Public Property CustomerContactNo() As String
        Get
            Return _CustomerContactNo
        End Get
        Set(ByVal value As String)
            _CustomerContactNo = value
        End Set
    End Property
    Public Property Department() As String
        Get
            Return _Department
        End Get
        Set(ByVal value As String)
            _Department = value
        End Set
    End Property
    Public Property SalesManager() As String
        Get
            Return _SalesManager
        End Get
        Set(ByVal value As String)
            _SalesManager = value
        End Set
    End Property
    Public Property CustomerAddress() As String
        Get
            Return _CustomerAddress
        End Get
        Set(ByVal value As String)
            _CustomerAddress = value
        End Set
    End Property
    Public Property IsHODApproved() As Integer
        Get
            Return _IsHODApproved
        End Get
        Set(ByVal value As Integer)
            _IsHODApproved = value
        End Set
    End Property
    Public Property HODApprovalDate() As Date
        Get
            Return _HODApprovalDate
        End Get
        Set(ByVal value As Date)
            _HODApprovalDate = value
        End Set
    End Property
    Public Shared Function GetRmcplRequisition(ByVal searchstring As String) As DataSet
        Dim SQL As String
        SQL = SQL & "select * from V_SampleRequisition " & "where RMCPL_SR_NO Like '%" + searchstring + "%' " & " order by inserteddate desc"
        Return SqlHelper.ExecuteDataset(WebGlobalVariables.Connection2, CommandType.Text, SQL)
    End Function
     
End Class
