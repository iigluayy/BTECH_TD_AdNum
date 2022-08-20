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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.tbDayweek = New System.Windows.Forms.TextBox()
        Me.btOK = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 110)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ตรวจสอบวันในสัปดาห์"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 69)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ตัวเลข"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 69)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ผลลัพธ์"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbOutput
        '
        Me.lbOutput.BackColor = System.Drawing.Color.Salmon
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbOutput.Enabled = False
        Me.lbOutput.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbOutput.Location = New System.Drawing.Point(244, 240)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(254, 69)
        Me.lbOutput.TabIndex = 1
        Me.lbOutput.Text = "."
        Me.lbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbDayweek
        '
        Me.tbDayweek.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tbDayweek.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbDayweek.ForeColor = System.Drawing.Color.Black
        Me.tbDayweek.Location = New System.Drawing.Point(244, 144)
        Me.tbDayweek.Multiline = True
        Me.tbDayweek.Name = "tbDayweek"
        Me.tbDayweek.PlaceholderText = "ใส่ข้อมูลตัวเลข"
        Me.tbDayweek.Size = New System.Drawing.Size(254, 69)
        Me.tbDayweek.TabIndex = 2
        Me.tbDayweek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btOK.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btOK.ForeColor = System.Drawing.Color.White
        Me.btOK.Location = New System.Drawing.Point(12, 323)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(175, 60)
        Me.btOK.TabIndex = 3
        Me.btOK.Text = "คำนวณ"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'btClear
        '
        Me.btClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClear.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btClear.ForeColor = System.Drawing.Color.White
        Me.btClear.Location = New System.Drawing.Point(193, 323)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(175, 60)
        Me.btClear.TabIndex = 3
        Me.btClear.Text = "เคลียร์"
        Me.btClear.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btExit.ForeColor = System.Drawing.Color.White
        Me.btExit.Location = New System.Drawing.Point(374, 323)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(124, 60)
        Me.btExit.TabIndex = 3
        Me.btExit.Text = "ปิดโปรแกรม"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.tbDayweek)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Dayweek"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbOutput As Label
    Friend WithEvents tbDayweek As TextBox
    Friend WithEvents btOK As Button
    Friend WithEvents btClear As Button
    Friend WithEvents btExit As Button
End Class
