﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Resources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.ReportWizard.Resources", GetType(Resources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The table already has columns in it.
    '''</summary>
    Friend Shared ReadOnly Property ArgumentExceptionMessage() As String
        Get
            Return ResourceManager.GetString("ArgumentExceptionMessage", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property Bg_Blue() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("Bg_Blue", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property CmdNewReport() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("CmdNewReport", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property CmdOpen() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("CmdOpen", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property CmdSave() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("CmdSave", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property CmdSaveAs() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("CmdSaveAs", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to &amp;Finish &gt;.
    '''</summary>
    Friend Shared ReadOnly Property FinishText() As String
        Get
            Return ResourceManager.GetString("FinishText", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property GroupEditorHide() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("GroupEditorHide", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property GroupEditorShow() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("GroupEditorShow", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Hide Group Editor.
    '''</summary>
    Friend Shared ReadOnly Property HideGroupPanelToolTip() As String
        Get
            Return ResourceManager.GetString("HideGroupPanelToolTip", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property Info_02() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("Info_02", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to &amp;Next &gt;.
    '''</summary>
    Friend Shared ReadOnly Property NextText() As String
        Get
            Return ResourceManager.GetString("NextText", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Show Group Editor.
    '''</summary>
    Friend Shared ReadOnly Property ShowGroupPanelToolTip() As String
        Get
            Return ResourceManager.GetString("ShowGroupPanelToolTip", resourceCulture)
        End Get
    End Property
End Class
