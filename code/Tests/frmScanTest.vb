#Region "Includes"
Imports NUnit.Framework
#End Region

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright 2018 (c) by No Namespace All Rights Reserved.
'  
' Project:      
' Module:       frmScanTest.vb
' Description:  Tests for the frm Scan class in the Negative Scanning assembly.
'  
' Date:       Author:           Comments:
' 9/20/2018 11:53 AM  Kairaria     Module created.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
Namespace NoNamespaceTest

    ''' <summary>
    ''' Tests for the frm Scan Class
    ''' Documentation: 
    ''' </summary>
    ''' <remarks></remarks>
    <TestFixture, Description("Tests for frm Scan")>
    Public Class frmScanTest
#Region "Class Variables"
        'Class Variables
        Private _frmScan As frmScan = Nothing
#End Region

#Region "Setup/Cleanup"
        ''' <summary>
        ''' Code that is run before each test
        ''' </summary>
        ''' <remarks></remarks>
        <SetUp()>
        Public Sub Initialize()
            'New instance of frm Scan
            _frmScan = New frmScan()
        End Sub

        ''' <summary>
        ''' Code that is run after each test
        ''' </summary>
        ''' <remarks></remarks>
        <TearDown()>
        Public Sub Cleanup()
            'TODO: Put dispose in here for _frmScan or delete this line
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
        ''' Select Source Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Select_Source()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Select_SourceTest()
            Dim methodStartTime As Date = Now


            'Parameters

            _frmScan.Select_Source()

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmScan.Select_Source Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Acquire Save Image Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub AcquireSave_Image()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub AcquireSave_ImageTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmScan).GetMethod("AcquireSave_Image",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmScan As frmScan = New frmScan()
            method.Invoke(frmScan, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmScan.AcquireSave_Image Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Save Image Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Save_Image()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Save_ImageTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmScan).GetMethod("Save_Image",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmScan As frmScan = New frmScan()
            method.Invoke(frmScan, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmScan.Save_Image Time Elapsed: {0}", methodDuration))
        End Sub

#End Region 'End of GeneratedMethods
#End Region

    End Class
End Namespace
