﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DesktopSpace.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  重写当前线程的 CurrentUICulture 属性，对
        '''  使用此强类型资源类的所有资源查找执行重写。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property code() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("code", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property 云桌面() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("云桌面", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property 感叹号1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("感叹号1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property 手柄2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("手柄2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property 音乐_音符() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("音乐,音符", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
