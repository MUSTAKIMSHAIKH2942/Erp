Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class DepartmentRequisitionDiv

    Private _SrRefId As String
    Private _SampleReqizitionID As Integer
    Private _Division As String
    Private _SampleRequestSent As String
    Private _ConcernedPersonName As String
    Private _MaterialReadyDays As Nullable(Of Integer)
    Private _Remarks As String
    Private _InsertedDate As DateTime

    ' Properties
    Public Property SrRefId() As String
        Get
            Return _SrRefId
        End Get
        Set(ByVal value As String)
            _SrRefId = value
        End Set
    End Property

    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property

    Public Property SampleRequestSent() As String
        Get
            Return _SampleRequestSent
        End Get
        Set(ByVal value As String)
            _SampleRequestSent = value
        End Set
    End Property

    Public Property ConcernedPersonName() As String
        Get
            Return _ConcernedPersonName
        End Get
        Set(ByVal value As String)
            _ConcernedPersonName = value
        End Set
    End Property

    Public Property MaterialReadyDays() As Nullable(Of Integer)
        Get
            Return _MaterialReadyDays
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _MaterialReadyDays = value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return _Remarks
        End Get
        Set(ByVal value As String)
            _Remarks = value
        End Set
    End Property

    Public Property InsertedDate() As DateTime
        Get
            Return _InsertedDate
        End Get
        Set(ByVal value As DateTime)
            _InsertedDate = value
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

    Public Shared Function InsertDepartmentRequisitionDiv(ByVal div As DepartmentRequisitionDiv) As Boolean
        Dim params(6) As SqlParameter
        params(0) = New SqlParameter("@SampleReqizitionID", div.SampleReqizitionID)
        params(1) = New SqlParameter("@SrRefId", div.SrRefId)
        params(2) = New SqlParameter("@Division", div.Division)
        params(3) = New SqlParameter("@SampleRequestSent", div.SampleRequestSent)
        params(4) = New SqlParameter("@ConcernedPersonName", div.ConcernedPersonName)
        params(5) = New SqlParameter("@MaterialReadyDays", div.MaterialReadyDays)
        params(6) = New SqlParameter("@Remarks", div.Remarks)

        Dim storedProcName As String = "InsertDepartmentRequisitionDiv"

        Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
    End Function
End Class
