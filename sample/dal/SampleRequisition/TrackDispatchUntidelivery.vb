Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class TrackDispatchUntidelivery
    ' Private fields
    Private _ID As Integer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _MaterialDeliveryDate As DateTime
    Private _MaterialHandoverTo As String
    Private _UploadPODCopy As String
    Private _InsertedDate As DateTime

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

    Public Property MaterialDeliveryDate() As DateTime
        Get
            Return _MaterialDeliveryDate
        End Get
        Set(ByVal value As DateTime)
            _MaterialDeliveryDate = value
        End Set
    End Property

    Public Property MaterialHandoverTo() As String
        Get
            Return _MaterialHandoverTo
        End Get
        Set(ByVal value As String)
            _MaterialHandoverTo = value
        End Set
    End Property

    Public Property UploadPODCopy() As String
        Get
            Return _UploadPODCopy
        End Get
        Set(ByVal value As String)
            _UploadPODCopy = value
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

    ' Method to insert data into TrackDispatchUntidelivery
    Public Shared Function InsertTrackDispatchUntidelivery(ByVal paramDetails As TrackDispatchUntidelivery) As Boolean
        Try
            Dim params(5) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", paramDetails.SampleReqizitionID)
            params(1) = New SqlParameter("@SRRefID", paramDetails.SRRefID)
            params(2) = New SqlParameter("@MaterialDeliveryDate", paramDetails.MaterialDeliveryDate)
            params(3) = New SqlParameter("@MaterialHandoverTo", paramDetails.MaterialHandoverTo)
            params(4) = New SqlParameter("@UploadPODCopy", paramDetails.UploadPODCopy)
            ' Defaulting InsertedDate to SQL server's GETDATE() in the stored procedure, no need to pass it here
            'params(5) = New SqlParameter("@InsertedDate", If(paramDetails.InsertedDate = DateTime.MinValue, DBNull.Value, paramDetails.InsertedDate))

            Dim storedProcName As String = "InsertTrackDispatchUntildelivery"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        Catch ex As Exception
            ' Log the exception (implement logging as per your application needs)
            Console.WriteLine("Error occurred: " & ex.Message)
            Return False
        End Try
    End Function
End Class
