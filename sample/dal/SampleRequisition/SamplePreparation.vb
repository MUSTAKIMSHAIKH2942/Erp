Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class SamplePreparation
    Private _SampleID As Integer
    Private _SampleReqizitionID As Integer
    Private _SR_Ref_ID As String
    Private _Division As String
    Private _PreparedAsPerRequirement As String
    Private _SampleQualityChecked As String
    Private _PackedSampleSentToQC As String
    Private _InsertedDate As DateTime

    ' Properties
    Public Property SampleID() As Integer
        Get
            Return _SampleID
        End Get
        Set(ByVal value As Integer)
            _SampleID = value
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

    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property

    Public Property PreparedAsPerRequirement() As String
        Get
            Return _PreparedAsPerRequirement
        End Get
        Set(ByVal value As String)
            _PreparedAsPerRequirement = value
        End Set
    End Property

    Public Property SampleQualityChecked() As String
        Get
            Return _SampleQualityChecked
        End Get
        Set(ByVal value As String)
            _SampleQualityChecked = value
        End Set
    End Property

    Public Property PackedSampleSentToQC() As String
        Get
            Return _PackedSampleSentToQC
        End Get
        Set(ByVal value As String)
            _PackedSampleSentToQC = value
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

    Public Shared Function AddSamplePreparation(ByVal paramSamplePreparation As SamplePreparation) As Boolean
        With paramSamplePreparation
            Dim params(6) As SqlParameter
            params(0) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(1) = New SqlParameter("@SR_Ref_ID", .SR_Ref_ID)
            params(2) = New SqlParameter("@Division", .Division)
            params(3) = New SqlParameter("@PreparedAsPerRequirement", .PreparedAsPerRequirement)
            params(4) = New SqlParameter("@SampleQualityChecked", .SampleQualityChecked)
            params(5) = New SqlParameter("@PackedSampleSentToQC", .PackedSampleSentToQC)
            ' No parameter for InsertedDate as it has a default value in the table

            Dim storedProcName As String = "InsertSamplePreparation"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function

    Public Shared Function UpdateSamplePreparation(ByVal paramSamplePreparation As SamplePreparation) As Boolean
        With paramSamplePreparation
            Dim params(6) As SqlParameter
            params(0) = New SqlParameter("@SampleID", .SampleID)
            params(1) = New SqlParameter("@SampleReqizitionID", .SampleReqizitionID)
            params(2) = New SqlParameter("@SR_Ref_ID", .SR_Ref_ID)
            params(3) = New SqlParameter("@Division", .Division)
            params(4) = New SqlParameter("@PreparedAsPerRequirement", .PreparedAsPerRequirement)
            params(5) = New SqlParameter("@SampleQualityChecked", .SampleQualityChecked)
            params(6) = New SqlParameter("@PackedSampleSentToQC", .PackedSampleSentToQC)
            ' Optionally include InsertedDate if necessary for the update

            Dim storedProcName As String = "UpdateSamplePreparation"

            Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
        End With
    End Function

End Class
