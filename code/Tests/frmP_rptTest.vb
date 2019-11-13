#Region "Includes"
Imports NUnit.Framework
#End Region

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright 2018 (c) by No Namespace All Rights Reserved.
'  
' Project:      
' Module:       frmP_rptTest.vb
' Description:  Tests for the frm P rpt class in the Negative Scanning assembly.
'  
' Date:       Author:           Comments:
' 9/20/2018 11:53 AM  Kairaria     Module created.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
Namespace NoNamespaceTest

    ''' <summary>
    ''' Tests for the frm P rpt Class
    ''' Documentation: 
    ''' </summary>
    ''' <remarks></remarks>
    <TestFixture, Description("Tests for frm P rpt")>
    Public Class frmP_rptTest
#Region "Class Variables"
        'Class Variables
        Private _frmPRpt As frmP_rpt = Nothing
#End Region

#Region "Setup/Cleanup"
        ''' <summary>
        ''' Code that is run before each test
        ''' </summary>
        ''' <remarks></remarks>
        <SetUp()>
        Public Sub Initialize()
            'New instance of frm P rpt
            _frmPRpt = New frmP_rpt()
        End Sub

        ''' <summary>
        ''' Code that is run after each test
        ''' </summary>
        ''' <remarks></remarks>
        <TearDown()>
        Public Sub Cleanup()
            'TODO: Put dispose in here for _frmPRpt or delete this line
        End Sub
#End Region

#Region "Property Tests"
#Region "GeneratedProperties"

        ' No public properties were found. No tests are generated for non-public scoped properties.

#End Region 'End of GeneratedProperties
#End Region

#Region "Method Tests"

#Region "GeneratedMethods"

        ''' <summary>
        ''' frm NameG Prpt Load Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub frmNMGPrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub frmNMGPrpt_LoadTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("frmNMGPrpt_Load",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.frmNMGPrpt_Load Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Radio Button 3 Checked Changed Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub RadioButton3_CheckedChangedTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("RadioButton3_CheckedChanged",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.RadioButton3_CheckedChanged Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Select Rows Method Test
        ''' Documentation   :  
        ''' Method Signature:  Function SelectRows(ByVal dataSet As DataSet, ByVal connection As String, ByVal query As String) As DataSet
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub SelectRowsTest()
            Dim methodStartTime As Date = Now
            Dim expected As DataSet = New DataSet()


            'Parameters
            Dim dataSet As DataSet = New DataSet()
            Dim connection As String = "test"
            Dim query As String = "test"

            Dim results As DataSet = _frmPRpt.SelectRows(dataSet, connection, query)
            Assert.AreEqual(expected, results, "NoNamespace.frmP_rpt.SelectRows method test failed")

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.SelectRows Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Form Form Closing Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Form_FormClosingTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As System.Windows.Forms.FormClosingEventArgs = New System.Windows.Forms.FormClosingEventArgs(CloseReason.FormOwnerClosing, 0)

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("Form_FormClosing",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.Form_FormClosing Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Display Status Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DisplayStatus(ByVal Text As String)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DisplayStatusTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim Text As String = "test"

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("DisplayStatus",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {Text})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.DisplayStatus Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Display Results Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DisplayResults(ByVal Text As String)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DisplayResultsTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim Text As String = "test"

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("DisplayResults",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {Text})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.DisplayResults Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Display Info Delegate Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DisplayInfoDelegate(ByVal Text As String)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DisplayInfoDelegateTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim Text As String = "test"

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("DisplayInfoDelegate",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {Text})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.DisplayInfoDelegate Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Button 2 Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Button2_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmP_rpt).GetMethod("Button2_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmPRpt As frmP_rpt = New frmP_rpt()
            method.Invoke(frmPRpt, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmP_rpt.Button2_Click Time Elapsed: {0}", methodDuration))
        End Sub

#End Region 'End of GeneratedMethods
#End Region

    End Class
End Namespace
