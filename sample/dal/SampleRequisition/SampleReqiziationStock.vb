Imports System.Data
Imports System.Data.SqlClient

Public Class SampleReqiziationStock
    ' Private fields
    Private _SampleReqiziationStockID As Integer
    Private _SampleReqizitionID As Integer
    Private _SR_Ref_ID As String
    Private _IsSampleAvailableInPlant As String
    Private _IsAvailableInStores As String
    Private _TotalQuantity As Integer
    Private _BatchNo As String
    Private _RemarkIfYes As String
    Private _RequestForwardedToRnD As Boolean
    Private _ConcernedPersonName As String
    Private _RemarkIfNo As String
    Private _InsertedDate As DateTime
    Private _Available_In As String

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

    Public Property IsSampleAvailableInPlant() As String
        Get
            Return _IsSampleAvailableInPlant
        End Get
        Set(ByVal value As String)
            _IsSampleAvailableInPlant = value
        End Set
    End Property

    Public Property Available_In() As String
        Get
            Return _Available_In
        End Get
        Set(ByVal value As String)
            _Available_In = value
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

    Public Property TotalQuantity() As Integer
        Get
            Return _TotalQuantity
        End Get
        Set(ByVal value As Integer)
            _TotalQuantity = value
        End Set
    End Property

    Public Property BatchNo() As String
        Get
            Return _BatchNo
        End Get
        Set(ByVal value As String)
            _BatchNo = value
        End Set
    End Property

    Public Property RemarkIfYes() As String
        Get
            Return _RemarkIfYes
        End Get
        Set(ByVal value As String)
            _RemarkIfYes = value
        End Set
    End Property

    Public Property RequestForwardedToRnD() As Boolean
        Get
            Return _RequestForwardedToRnD
        End Get
        Set(ByVal value As Boolean)
            _RequestForwardedToRnD = value
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

    Public Property RemarkIfNo() As String
        Get
            Return _RemarkIfNo
        End Get
        Set(ByVal value As String)
            _RemarkIfNo = value
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
        Dim params(10) As SqlParameter
        params(0) = New SqlParameter("@SampleReqizitionID", paramSampleReqiziationStock.SampleReqizitionID)
        params(1) = New SqlParameter("@SR_Ref_ID", paramSampleReqiziationStock.SR_Ref_ID)
        params(2) = New SqlParameter("@IsAvailableInStores", paramSampleReqiziationStock.IsAvailableInStores)
        params(3) = New SqlParameter("@Available_In", paramSampleReqiziationStock.Available_In)
        params(4) = New SqlParameter("@IsSampleAvailableInPlant", DBNull.Value)
        params(5) = New SqlParameter("@TotalQuantity", DBNull.Value)
        params(6) = New SqlParameter("@BatchNo", paramSampleReqiziationStock.BatchNo)
        params(7) = New SqlParameter("@RemarkIfYes", DBNull.Value)
        params(8) = New SqlParameter("@RequestForwardedToRnD", DBNull.Value)
        params(9) = New SqlParameter("@ConcernedPersonName", DBNull.Value)
        params(10) = New SqlParameter("@RemarkIfNo", DBNull.Value)

        ' InsertedDate is set to GETDATE() in the stored procedure

        Dim storedProcName As String = "InsertSampleReqiziationStock"

        Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
    End Function

    ' Method to update an existing record
    Public Shared Function UpdateSampleReqiziationStock(ByVal paramSampleReqiziationStock As SampleReqiziationStock) As Boolean

        Try
            Dim params(9) As SqlParameter
            params(0) = New SqlParameter("@SampleReqiziationStockID", paramSampleReqiziationStock.SampleReqiziationStockID)
            params(1) = New SqlParameter("@SampleReqizitionID", paramSampleReqiziationStock.SampleReqizitionID)
            params(2) = New SqlParameter("@SR_Ref_ID", paramSampleReqiziationStock.SR_Ref_ID)
            params(3) = New SqlParameter("@IsSampleAvailableInPlant", paramSampleReqiziationStock.IsSampleAvailableInPlant)
            params(4) = New SqlParameter("@TotalQuantity", paramSampleReqiziationStock.TotalQuantity)
            params(5) = New SqlParameter("@BatchNo", paramSampleReqiziationStock.BatchNo)
            params(6) = New SqlParameter("@RemarkIfYes", paramSampleReqiziationStock.RemarkIfYes)
            params(7) = New SqlParameter("@RequestForwardedToRnD", paramSampleReqiziationStock.RequestForwardedToRnD)
            params(8) = New SqlParameter("@ConcernedPersonName", paramSampleReqiziationStock.ConcernedPersonName)
            params(9) = New SqlParameter("@RemarkIfNo", paramSampleReqiziationStock.RemarkIfNo)

            Dim storedProcName As String = "UpdateSampleReqiziationStock"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        Catch ex As Exception
            ' Log exception details
            ' e.g., LogError(ex)
            Return False
        End Try
    End Function
End Class
