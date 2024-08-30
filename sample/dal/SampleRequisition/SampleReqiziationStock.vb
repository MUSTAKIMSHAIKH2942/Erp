Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class SampleReqiziationStock
    ' Private fields
    Private _SampleReqiziationStockID As Integer
    Private _SampleReqizitionID As Integer
    Private _SR_Ref_ID As String
    Private _IsAvailableInStores As String
    Private _IsSampleAvailableInPlant As String
    Private _InsertedDate As DateTime

    ' Properties
    Public Property SampleReqiziationStockID() As Integer
        Get
            Return _SampleReqiziationStockID
        End Get
        Set(ByVal value As Integer)
            _SampleReqiziationStockID = value
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

    Public Property SR_Ref_ID() As String
        Get
            Return _SR_Ref_ID
        End Get
        Set(ByVal value As String)
            _SR_Ref_ID = value
        End Set
    End Property

    Public Property IsAvailableInStores() As String
        Get
            Return _IsAvailableInStores
        End Get
        Set(ByVal value As String)
            _IsAvailableInStores = value
        End Set
    End Property

    Public Property IsSampleAvailableInPlant() As String
        Get
            Return _IsSampleAvailableInPlant
        End Get
        Set(ByVal value As String)
            _IsSampleAvailableInPlant = value
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

    ' Method to add a new record
    Public Shared Function AddSampleReqiziationStock(ByVal paramSampleReqiziationStock As SampleReqiziationStock) As Boolean
        With paramSampleReqiziationStock
            Dim params(4) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SR_Ref_ID", .SR_Ref_ID)
            params(2) = New SqlParameter("@IsAvailableInStores", .IsAvailableInStores)
            params(3) = New SqlParameter("@IsSampleAvailableInPlant", DBNull.Value)
            ' No parameter needed for InsertedDate

            Dim storedProcName As String = "InsertSampleReqiziationStock"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function

    ' Method to update an existing record
    Public Shared Function UpdateSampleReqiziationStock(ByVal paramSampleReqiziationStock As SampleReqiziationStock) As Boolean
        With paramSampleReqiziationStock
            Dim params(4) As SqlParameter
            params(0) = New SqlParameter("@SampleReqiziationStockID", ._SampleReqiziationStockID) ' Primary key
            params(1) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(2) = New SqlParameter("@SR_Ref_ID", .SR_Ref_ID)
            params(3) = New SqlParameter("@IsSampleAvailableInPlant", .IsSampleAvailableInPlant)

            ' No parameter needed for InsertedDate since it is not being updated

            Dim storedProcName As String = "UpdateSampleReqiziationStock"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function
End Class
