Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class ReceivingofPOfromcustomer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _PONo As String
    Private _Product As String
    Private _QtyInKg As Decimal
    Private _POAmount As Decimal
    Private _ExpectedDeliveryDate As Date
    Private _Remarks As String

    ' Properties
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

    Public Property PONo() As String
        Get
            Return _PONo
        End Get
        Set(ByVal value As String)
            _PONo = value
        End Set
    End Property

    Public Property Product() As String
        Get
            Return _Product
        End Get
        Set(ByVal value As String)
            _Product = value
        End Set
    End Property

    Public Property QtyInKg() As Decimal
        Get
            Return _QtyInKg
        End Get
        Set(ByVal value As Decimal)
            _QtyInKg = value
        End Set
    End Property

    Public Property POAmount() As Decimal
        Get
            Return _POAmount
        End Get
        Set(ByVal value As Decimal)
            _POAmount = value
        End Set
    End Property

    Public Property ExpectedDeliveryDate() As Date
        Get
            Return _ExpectedDeliveryDate
        End Get
        Set(ByVal value As Date)
            _ExpectedDeliveryDate = value
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

    ' Method to Insert Record
    Public Shared Function InsertReceivingOfPOFromCustomer(ByVal paramReceivingDetails As ReceivingofPOfromcustomer) As Boolean
        With paramReceivingDetails
            Dim params(7) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SRRefID", .SRRefID)
            params(2) = New SqlParameter("@PONo", .PONo)
            params(3) = New SqlParameter("@Product", .Product)
            params(4) = New SqlParameter("@QtyInKg", .QtyInKg)
            params(5) = New SqlParameter("@POAmount", .POAmount)
            params(6) = New SqlParameter("@ExpectedDeliveryDate", .ExpectedDeliveryDate)
            params(7) = New SqlParameter("@Remarks", .Remarks)

            Dim storedProcName As String = "InsertReceivingOfPOfromCustomer"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function

End Class
