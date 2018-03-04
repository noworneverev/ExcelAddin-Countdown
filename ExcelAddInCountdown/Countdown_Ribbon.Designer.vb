Partial Class Countdown_Ribbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab2 = Me.Factory.CreateRibbonTab
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Tab2.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab2
        '
        Me.Tab2.Groups.Add(Me.Group2)
        Me.Tab2.Label = "Count Down"
        Me.Tab2.Name = "Tab2"
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.Button1)
        Me.Group2.Items.Add(Me.Button2)
        Me.Group2.Items.Add(Me.Button3)
        Me.Group2.Name = "Group2"
        '
        'Button2
        '
        Me.Button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button2.Label = "Log out 9"
        Me.Button2.Name = "Button2"
        Me.Button2.OfficeImageId = "GroupPictureTools"
        Me.Button2.ShowImage = True
        '
        'Button1
        '
        Me.Button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button1.Label = "Log out 7"
        Me.Button1.Name = "Button1"
        Me.Button1.OfficeImageId = "GroupPictureTools"
        Me.Button1.ShowImage = True
        '
        'Button3
        '
        Me.Button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button3.Label = "Log out Custom"
        Me.Button3.Name = "Button3"
        Me.Button3.OfficeImageId = "GroupPictureTools"
        Me.Button3.ShowImage = True
        '
        'Countdown_Ribbon
        '
        Me.Name = "Countdown_Ribbon"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab2)
        Me.Tab2.ResumeLayout(False)
        Me.Tab2.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab2 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Countdown_Ribbon() As Countdown_Ribbon
        Get
            Return Me.GetRibbon(Of Countdown_Ribbon)()
        End Get
    End Property
End Class
