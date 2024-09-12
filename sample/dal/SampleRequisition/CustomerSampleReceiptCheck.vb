Imports System.Data
Imports System.Data.SqlClient

Public Class CustomerSampleReceiptCheck
    Private _ID As Integer
    Private _SampleReqizitionID As Integer ' Variable for SampleReqizitionID
    Private _SRRefID As String
    Private _MaterialReceivedInGoodCondition As String
    Private _SupportingDocumentationReceived As String
    Private _ExpectedTestingDate As Date
    Private _OtherRemarks As String
    Private _InsertedDate As DateTime

    ' Constructor
    Public Sub New(ByVal sampleReqizitionID As Integer)
        _SampleReqizitionID = sampleReqizitionID
    End Sub

    ' Properties
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
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

    Public Property MaterialReceivedInGoodCondition() As String
        Get
            Return _MaterialReceivedInGoodCondition
        End Get
        Set(ByVal value As String)
            _MaterialReceivedInGoodCondition = value
        End Set
    End Property

    Public Property SupportingDocumentationReceived() As String
        Get
            Return _SupportingDocumentationReceived
        End Get
        Set(ByVal value As String)
            _SupportingDocumentationReceived = value
        End Set
    End Property

    Public Property ExpectedTestingDate() As Date
        Get
            Return _ExpectedTestingDate
        End Get
        Set(ByVal value As Date)
            _ExpectedTestingDate = value
        End Set
    End Property

    Public Property OtherRemarks() As String
        Get
            Return _OtherRemarks
        End Get
        Set(ByVal value As String)
            _OtherRemarks = value
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

    ' Method to insert data into CustomerSampleReceiptCheck
    Public Function InsertCustomerSampleReceiptCheck() As Boolean
        Try
            Dim params(5) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", _SampleReqizitionID)
            params(1) = New SqlParameter("@SRRefID", _SRRefID)
            params(2) = New SqlParameter("@MaterialReceivedInGoodCondition", _MaterialReceivedInGoodCondition)
            params(3) = New SqlParameter("@SupportingDocumentationReceived", _SupportingDocumentationReceived)
            params(4) = New SqlParameter("@ExpectedTestingDate", _ExpectedTestingDate)
            params(5) = New SqlParameter("@OtherRemarks", _OtherRemarks)

            Dim storedProcName As String = "InsertCustomerSampleReceiptCheck"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        Catch ex As Exception
            ' Log the exception (implement logging as per your application needs)
            Console.WriteLine("Error occurred: " & ex.Message)
            Return False
        End Try
    End Function
End Class
