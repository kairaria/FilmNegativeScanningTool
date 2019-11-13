#Region "Includes"
Imports NUnit.Framework
#End Region

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright 2018 (c) by No Namespace All Rights Reserved.
'  
' Project:      
' Module:       frmQATest.vb
' Description:  Tests for the frm Quality Assurance class in the Negative Scanning assembly.
'  
' Date:       Author:           Comments:
' 9/20/2018 11:53 AM  Kairaria     Module created.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
Namespace NoNamespaceTest

    ''' <summary>
    ''' Tests for the frm Quality Assurance Class
    ''' Documentation: 
    ''' </summary>
    ''' <remarks></remarks>
    <TestFixture, Description("Tests for frm Quality Assurance")>
    Public Class frmQATest
#Region "Class Variables"
        'Class Variables
        Private _frmQa As frmQA = Nothing
#End Region

#Region "Setup/Cleanup"
        ''' <summary>
        ''' Code that is run before each test
        ''' </summary>
        ''' <remarks></remarks>
        <SetUp()>
        Public Sub Initialize()
            'New instance of frm Quality Assurance
            _frmQa = New frmQA()
        End Sub

        ''' <summary>
        ''' Code that is run after each test
        ''' </summary>
        ''' <remarks></remarks>
        <TearDown()>
        Public Sub Cleanup()
            'TODO: Put dispose in here for _frmQa or delete this line
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
        ''' Form 2 Load Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Form2_Load(sender As System.Object, e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Form2_LoadTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("Form2_Load",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.Form2_Load Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' loadcbo Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub loadcbo()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub loadcboTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("loadcbo",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.loadcbo Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' load img Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub load_img()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub load_imgTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("load_img",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.load_img Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' search Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub search()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub searchTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("search",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.search Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Date Time Picker 1 Value Changed Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DateTimePicker1_ValueChangedTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("DateTimePicker1_ValueChanged",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.DateTimePicker1_ValueChanged Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Date Time Picker 2 Value Changed Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DateTimePicker2_ValueChangedTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("DateTimePicker2_ValueChanged",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.DateTimePicker2_ValueChanged Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Button 1 Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Button1_Click(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Button1_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("Button1_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.Button1_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Button 2 Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Button2_Click(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Button2_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("Button2_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.Button2_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Button 3 Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Button3_Click(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Button3_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("Button3_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.Button3_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Button 4 Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Button4_Click(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Button4_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("Button4_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.Button4_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Button 5 Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub Button5_Click(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub Button5_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("Button5_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.Button5_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Data Grid View 1 Cell Content Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DataGridView1_CellContentClick(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DataGridView1_CellContentClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("DataGridView1_CellContentClick",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.DataGridView1_CellContentClick Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Data Grid View 1 Selection Changed Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub DataGridView1_SelectionChangedTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("DataGridView1_SelectionChanged",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.DataGridView1_SelectionChanged Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Rotate Img Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub RotateImg()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub RotateImgTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("RotateImg",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.RotateImg Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Invert Img Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub InvertImg()
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub InvertImgTest()
            Dim methodStartTime As Date = Now


            'Parameters

            Dim method As Reflection.MethodInfo =
                GetType(frmQA).GetMethod("InvertImg",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmQa As frmQA = New frmQA()
            method.Invoke(frmQa, Nothing)

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmQA.InvertImg Time Elapsed: {0}", methodDuration))
        End Sub

#End Region 'End of GeneratedMethods
#End Region

    End Class
End Namespace
