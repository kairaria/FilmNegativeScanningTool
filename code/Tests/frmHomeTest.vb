#Region "Includes"
Imports NUnit.Framework

#End Region

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright 2018 (c) by No Namespace All Rights Reserved.
'  
' Project:      
' Module:       frmHomeTest.vb
' Description:  Tests for the frm Home class in the Negative Scanning assembly.
'  
' Date:       Author:           Comments:
' 9/20/2018 11:53 AM  Kairaria     Module created.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
Namespace NoNamespaceTest

    ''' <summary>
    ''' Tests for the frm Home Class
    ''' Documentation: 
    ''' </summary>
    ''' <remarks></remarks>
    <TestFixture, Description("Tests for frm Home")>
    Public Class frmHomeTest
#Region "Class Variables"
        'Class Variables
        Private _frmHome As frmHome = Nothing
#End Region

#Region "Setup/Cleanup"
        <SetUp()>
        Public Sub Initialize()
            'New instance of frm Home
            _frmHome = New frmHome()
        End Sub

        ''' <summary>
        ''' Code that is run after each test
        ''' </summary>
        ''' <remarks></remarks>
        <TearDown()>
        Public Sub Cleanup()
            'TODO: Put dispose in here for _frmHome or delete this line
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
        ''' Show New Form Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub ShowNewFormTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("ShowNewForm",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.ShowNewForm Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Open File Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub OpenFileTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("OpenFile",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.OpenFile Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Save As Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub SaveAsToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("SaveAsToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.SaveAsToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Exit Tools Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub ExitToolsStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("ExitToolsStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.ExitToolsStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Cut Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub CutToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("CutToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.CutToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Copy Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub CopyToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("CopyToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.CopyToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Paste Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub PasteToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("PasteToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.PasteToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Tool Bar Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub ToolBarToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("ToolBarToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.ToolBarToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Status Bar Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub StatusBarToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("StatusBarToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.StatusBarToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Cascade Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub CascadeToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("CascadeToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.CascadeToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Tile Vertical Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub TileVerticalToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("TileVerticalToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.TileVerticalToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Tile Horizontal Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub TileHorizontalToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("TileHorizontalToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.TileHorizontalToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Arrange Icons Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub ArrangeIconsToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("ArrangeIconsToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.ArrangeIconsToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Close All Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub CloseAllToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As Object = New Object()
            Dim e As EventArgs = New EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("CloseAllToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.CloseAllToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' MDisability Insurance Parent 1 Load Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub MDIParent1_Load(sender As System.Object, e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub MDIParent1_LoadTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("MDIParent1_Load",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.MDIParent1_Load Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Quality Assurance Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub QAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub QAToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("QAToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.QAToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Reports Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub ReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub ReportsToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("ReportsToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.ReportsToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Small Negatives Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub SmallNegativesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub SmallNegativesToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("SmallNegativesToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.SmallNegativesToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

        ''' <summary>
        ''' Large Negatives Tool Strip Menu Item Click Method Test
        ''' Documentation   :  
        ''' Method Signature:  Sub LargeNegativesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''' </summary>
        <Test()>
        <Ignore("Please implement")>
        Public Sub LargeNegativesToolStripMenuItem_ClickTest()
            Dim methodStartTime As Date = Now


            'Parameters
            Dim sender As System.Object = New System.Object()
            Dim e As System.EventArgs = New System.EventArgs()

            Dim method As Reflection.MethodInfo =
                GetType(frmHome).GetMethod("LargeNegativesToolStripMenuItem_Click",
                    Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
            Dim frmHome As frmHome = New frmHome()
            method.Invoke(frmHome, New Object() {sender, e})

            Dim methodDuration As TimeSpan = DateTime.Now.Subtract(methodStartTime)
            Console.WriteLine(String.Format("NoNamespace.frmHome.LargeNegativesToolStripMenuItem_Click Time Elapsed: {0}", methodDuration))
        End Sub

#End Region 'End of GeneratedMethods
#End Region

    End Class
End Namespace
