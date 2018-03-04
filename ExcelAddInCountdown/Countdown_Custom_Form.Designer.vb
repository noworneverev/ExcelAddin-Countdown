<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Countdown_Custom_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelText
        '
        Me.LabelText.AutoSize = True
        Me.LabelText.Font = New System.Drawing.Font("Microsoft JhengHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelText.Location = New System.Drawing.Point(23, 18)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(316, 47)
        Me.LabelText.TabIndex = 2
        Me.LabelText.Text = "距離登出時間還有"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 61)
        Me.Label1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Countdown_Custom_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 225)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelText)
        Me.Name = "Countdown_Custom_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Countdown_Custom_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelText As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
