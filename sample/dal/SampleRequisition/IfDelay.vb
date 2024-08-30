Imports System.Data
Imports System.Data.SqlClient

Public Class IfDelay
    Private _Id As Integer
    Private _SRID As String
    Private _ReasonForDelay As String
    Private _NextEstimateDateOfDispatch As DateTime
    Private _RemarksIfAny As String
    Private _InsertedDate As DateTime
    Private _SampleReqizitionID As Integer

    ' Properties
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property SRID() As String
        Get
            Return _SRID
        End Get
        Set(ByVal value As String)
            _SRID = value
        End Set
    End Property

    Public Property ReasonForDelay() As String
        Get
            Return _ReasonForDelay
        End Get
        Set(ByVal value As String)
            _ReasonForDelay = value
        End Set
    End Property

    Public Property NextEstimateDateOfDispatch() As DateTime
        Get
            Return _NextEstimateDateOfDispatch
        End Get
        Set(ByVal value As DateTime)
            _NextEstimateDateOfDispatch = value
        End Set
    End Property

    Public Property RemarksIfAny() As String
        Get
            Return _RemarksIfAny
        End Get
        Set(ByVal value As String)
            _RemarksIfAny = value
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

    ' Method to insert data into IfDelay table
    Public Shared Function AddIfDelay(ByVal paramIfDelay As IfDelay) As Boolean
        With paramIfDelay
            Dim params(5) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SRID", .SRID)
            params(2) = New SqlParameter("@ReasonForDelay", .ReasonForDelay)
            params(3) = New SqlParameter("@NextEstimateDateOfDispatch", .NextEstimateDateOfDispatch)
            params(4) = New SqlParameter("@RemarksIfAny", .RemarksIfAny)
            ' No parameter for InsertedDate as it has a default value in the table

            Dim storedProcName As String = "InsertIntoIfDelay"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function
End Class
