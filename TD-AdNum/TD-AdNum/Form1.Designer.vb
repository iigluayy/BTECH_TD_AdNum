<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbNum1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNum2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btSum = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNum1
        '
        Me.tbNum1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbNum1.Location = New System.Drawing.Point(12, 87)
        Me.tbNum1.Name = "tbNum1"
        Me.tbNum1.PlaceholderText = "กรอกตัวเลขที่ 1"
        Me.tbNum1.Size = New System.Drawing.Size(297, 47)
        Me.tbNum1.TabIndex = 1
        Me.tbNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมบวกเลข"
        '
        'tbNum2
        '
        Me.tbNum2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbNum2.Location = New System.Drawing.Point(12, 140)
        Me.tbNum2.Name = "tbNum2"
        Me.tbNum2.PlaceholderText = "กรอกตัวเลขที่ 2"
        Me.tbNum2.Size = New System.Drawing.Size(297, 47)
        Me.tbNum2.TabIndex = 1
        Me.tbNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 57)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ผลลัพธ์"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSum
        '
        Me.btSum.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btSum.Location = New System.Drawing.Point(12, 207)
        Me.btSum.Name = "btSum"
        Me.btSum.Size = New System.Drawing.Size(169, 63)
        Me.btSum.TabIndex = 2
        Me.btSum.Text = "คำนวณ"
        Me.btSum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btSum.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(187, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reset"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 374)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btSum)
        Me.Controls.Add(Me.tbNum1)
        Me.Controls.Add(Me.tbNum2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "โปรแกรมบวกเลข"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbNum2 As TextBox
    Friend WithEvents tbNum1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btSum As Button
    Friend WithEvents Button1 As Button
End Class
