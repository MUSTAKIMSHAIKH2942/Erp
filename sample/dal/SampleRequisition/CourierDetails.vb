Imports System.Data
Imports System.Data.SqlClient

Public Class CourierDetails
    Private _Id As Integer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _CourierServiceName As String
    Private _CourierTrackingNo As String
    Private _CourierDate As DateTime
    Private _CourierCharges As Decimal
    Private _EstimatedDateOfDelivery As DateTime
    Private _UploadOfCOA As String
    Private _InsertedDate As DateTime

    ' Properties
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
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

    Public Property CourierServiceName() As String
        Get
            Return _CourierServiceName
        End Get
        Set(ByVal value As String)
            _CourierServiceName = value
        End Set
    End Property

    Public Property CourierTrackingNo() As String
        Get
            Return _CourierTrackingNo
        End Get
        Set(ByVal value As String)
            _CourierTrackingNo = value
        End Set
    End Property

    Public Property CourierDate() As DateTime
        Get
            Return _CourierDate
        End Get
        Set(ByVal value As DateTime)
            _CourierDate = value
        End Set
    End Property

    Public Property CourierCharges() As Decimal
        Get
            Return _CourierCharges
        End Get
        Set(ByVal value As Decimal)
            _CourierCharges = value
        End Set
    End Property

    Public Property EstimatedDateOfDelivery() As DateTime
        Get
            Return _EstimatedDateOfDelivery
        End Get
        Set(ByVal value As DateTime)
            _EstimatedDateOfDelivery = value
        End Set
    End Property

    Public Property UploadOfCOA() As String
        Get
            Return _UploadOfCOA
        End Get
        Set(ByVal value As String)
            _UploadOfCOA = value
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

    ' Method to insert data into CourierDetails
    Public Shared Function InsertCourierDetails(ByVal paramCourierDetails As CourierDetails) As Boolean
        With paramCourierDetails
            Dim params(7) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SRRefID", .SRRefID)
            params(2) = New SqlParameter("@CourierServiceName", .CourierServiceName)
            params(3) = New SqlParameter("@CourierTrackingNo", .CourierTrackingNo)
            params(4) = New SqlParameter("@CourierDate", .CourierDate)
            params(5) = New SqlParameter("@CourierCharges", .CourierCharges)
            params(6) = New SqlParameter("@EstimatedDateOfDelivery", .EstimatedDateOfDelivery)
            params(7) = New SqlParameter("@UploadOfCOA", .UploadOfCOA)

            Dim storedProcName As String = "InsertIntoCourierDetails"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function

End Class
