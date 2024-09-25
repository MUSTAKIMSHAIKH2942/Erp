Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class PackingLabellingCOAGatePass

    Private _PackagingID As Integer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _ProperPackagingLabellingDone As String
    Private _PrepareCOA As String
    Private _GatePassNo As String
    Private _GatePassDate As DateTime
    Private _InsertedDate As DateTime

    ' Properties
    Public Property PackagingID() As Integer
        Get
            Return _PackagingID
        End Get
        Set(ByVal value As Integer)
            _PackagingID = value
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

    Public Property ProperPackagingLabellingDone() As String
        Get
            Return _ProperPackagingLabellingDone
        End Get
        Set(ByVal value As String)
            _ProperPackagingLabellingDone = value
        End Set
    End Property

    Public Property PrepareCOA() As String
        Get
            Return _PrepareCOA
        End Get
        Set(ByVal value As String)
            _PrepareCOA = value
        End Set
    End Property

    Public Property GatePassNo() As String
        Get
            Return _GatePassNo
        End Get
        Set(ByVal value As String)
            _GatePassNo = value
        End Set
    End Property

    Public Property GatePassDate() As DateTime
        Get
            Return _GatePassDate
        End Get
        Set(ByVal value As DateTime)
            _GatePassDate = value
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

    Public Shared Function AddPackingLabellingCOAGatePass(ByVal paramPackingLabellingCOAGatePass As PackingLabellingCOAGatePass) As Boolean
        With paramPackingLabellingCOAGatePass
            Dim params(6) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SRRefID", .SRRefID)
            params(2) = New SqlParameter("@ProperPackagingLabellingDone", .ProperPackagingLabellingDone)
            params(3) = New SqlParameter("@PrepareCOA", .PrepareCOA)
            params(4) = New SqlParameter("@GatePassNo", .GatePassNo)
            params(5) = New SqlParameter("@GatePassDate", .GatePassDate)
            ' No parameter for InsertedDate as it has a default value in the table

            Dim storedProcName As String = "InsertPackingLabellingCOAGatePass"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function

End Class
