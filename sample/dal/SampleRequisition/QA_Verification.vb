Imports System.Data
Imports System.Data.SqlClient

Public Class QA_Verification
    Private _QA_VerificationId As Integer
    Private _SampleReqizitionID As Integer
    Private _SRRefID As String
    Private _LabelVerified As String
    Private _COAChecked As String
    Private _SampleRequestEntry As String
    Private _CoveringLetterFilePath As String
    Private _MSDSFilePath As String
    Private _COAFilePath As String
    Private _InsertedDate As DateTime

    ' Properties
    Public Property QA_VerificationId() As Integer
        Get
            Return _QA_VerificationId
        End Get
        Set(ByVal value As Integer)
            _QA_VerificationId = value
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

    Public Property LabelVerified() As String
        Get
            Return _LabelVerified
        End Get
        Set(ByVal value As String)
            _LabelVerified = value
        End Set
    End Property

    Public Property COAChecked() As String
        Get
            Return _COAChecked
        End Get
        Set(ByVal value As String)
            _COAChecked = value
        End Set
    End Property

    Public Property SampleRequestEntry() As String
        Get
            Return _SampleRequestEntry
        End Get
        Set(ByVal value As String)
            _SampleRequestEntry = value
        End Set
    End Property

    Public Property CoveringLetterFilePath() As String
        Get
            Return _CoveringLetterFilePath
        End Get
        Set(ByVal value As String)
            _CoveringLetterFilePath = value
        End Set
    End Property

    Public Property MSDSFilePath() As String
        Get
            Return _MSDSFilePath
        End Get
        Set(ByVal value As String)
            _MSDSFilePath = value
        End Set
    End Property

    Public Property COAFilePath() As String
        Get
            Return _COAFilePath
        End Get
        Set(ByVal value As String)
            _COAFilePath = value
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

    ' Method to add a QA_Verification record
    Public Shared Function AddQA_Verification(ByVal paramQA_Verification As QA_Verification) As Boolean
        Dim params(8) As SqlParameter
        params(0) = New SqlParameter("@SampleReqizitionID", paramQA_Verification.SampleReqizitionID)
        params(1) = New SqlParameter("@SRRefID", paramQA_Verification.SRRefID)
        params(2) = New SqlParameter("@LabelVerified", paramQA_Verification.LabelVerified)
        params(3) = New SqlParameter("@COAChecked", paramQA_Verification.COAChecked)
        params(4) = New SqlParameter("@SampleRequestEntry", paramQA_Verification.SampleRequestEntry)
        params(5) = New SqlParameter("@CoveringLetterFilePath", paramQA_Verification.CoveringLetterFilePath)
        params(6) = New SqlParameter("@MSDSFilePath", paramQA_Verification.MSDSFilePath)
        params(7) = New SqlParameter("@COAFilePath", paramQA_Verification.COAFilePath)

        Dim storedProcName As String = "InsertQA_Verification"

        Return SqlHelper.ExecuteNonQuery(WebGlobalVariables.Connection2, CommandType.StoredProcedure, storedProcName, params)
    End Function
End Class
