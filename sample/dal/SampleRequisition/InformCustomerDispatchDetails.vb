Imports System.Data
Imports System.Data.SqlClient

Public Class InformCustomerDispatchDetails
    Private _ID As Integer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _InformedByPhoneEmailWhatsapp As String
    Private _Remarks As String
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

    Public Property InformedByPhoneEmailWhatsapp() As String
        Get
            Return _InformedByPhoneEmailWhatsapp
        End Get
        Set(ByVal value As String)
            _InformedByPhoneEmailWhatsapp = value
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

    ' Method to insert data into InformCustomerDispatchDetails
    Public Shared Function InsertInformCustomerDispatchDetails(ByVal paramDetails As InformCustomerDispatchDetails) As Boolean
        Try
            With paramDetails
                Dim params(4) As SqlParameter
                params(0) = New SqlParameter("@SampleReqizitionID", SqlDbType.Int)
                params(0).Value = .SampleReqizitionID

                params(1) = New SqlParameter("@SRRefID", SqlDbType.VarChar, 50)
                params(1).Value = .SRRefID

                params(2) = New SqlParameter("@InformedByPhoneEmailWhatsapp", SqlDbType.VarChar, 255)
                params(2).Value = .InformedByPhoneEmailWhatsapp

                params(3) = New SqlParameter("@Remarks", SqlDbType.VarChar, 255)
                params(3).Value = .Remarks

                ' InsertedDate is set to default value in the database; no need to pass it explicitly
                ' You could include it if needed for other purposes

                Dim storedProcName As String = "InsertIntoInformCustomerDispatchDetails"

                Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
            End With
        Catch ex As Exception
            ' Log the exception (implement logging as per your application needs)
            Console.WriteLine("Error occurred: " & ex.Message)
            Return False
        End Try
    End Function
End Class
