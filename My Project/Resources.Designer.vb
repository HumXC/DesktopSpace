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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ThemeEditor.Resources", GetType(Resources).Assembly)
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
        Friend ReadOnly Property _Default() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("_Default", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
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
        '''  查找类似 这是DesktopSpace的默认主题
        '''主题内容从&quot;Theme_Start&quot;开始,由&quot;Theme_End&quot;结束。从&quot;Theme_Start&quot;开始,前9行为:
        '''主窗口颜色
        '''Box的大小:两个数字表示，中间由逗号隔开。有多少个桌面就会生成多少个Box,但不会超过10个。
        '''Box和主窗体左边界的距离：用一个数字表示
        '''Box和主窗体上边界的距离：用一个数字表示
        '''Box之间的距离：用一个数字表示
        '''标题的字体名称：输入一个字体名称，例如&quot;微软雅黑&quot;，无需带引号。
        '''标题的字体字号：一个数字，可以是小数
        '''标题文字颜色：3位整数表示RGB颜色，用逗号隔开，例如&quot;255，255，255&quot;。
        '''文字底部标识线的高度：一个数字表示
        '''文字底部标识线被选中的颜色：3位整数表示
        '''文字底部标识线鼠标经过时的颜色：3位整数表示。从这一行开始，便是对单个Box的设置。
        '''标题名称：任意可以被用来创建文件夹的字符。
        '''图标路径：图片的完整路径
        '''图标位置：图标在Box上的偏移量
        '''图标大小：图标显示的大小。4行为一组，可以继续往下设置第二个Box（桌面）。
        '''标题名称2
        '''图标路径2
        '''图标位置2
        '''图标大小2
        '''标题名称3 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property Default_Theme() As String
            Get
                Return ResourceManager.GetString("Default_Theme", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Game() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Game", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Music() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Music", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property 笑脸() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("笑脸", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property 透明() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("透明", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
