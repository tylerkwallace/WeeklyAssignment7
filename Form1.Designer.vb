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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cboOptions = New System.Windows.Forms.ComboBox()
        Me.lblSelectionNum = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(444, 29)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(259, 29)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Karaoke Music Night"
        '
        'cboOptions
        '
        Me.cboOptions.BackColor = System.Drawing.Color.White
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cboOptions.FormattingEnabled = True
        Me.cboOptions.Items.AddRange(New Object() {"Hours in Private Karaoke Booth ($8.99 per hour)", "Songs in Private Karaoke Booth ($2.99 per song)"})
        Me.cboOptions.Location = New System.Drawing.Point(407, 77)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(333, 24)
        Me.cboOptions.TabIndex = 2
        '
        'lblSelectionNum
        '
        Me.lblSelectionNum.AutoSize = True
        Me.lblSelectionNum.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectionNum.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectionNum.Location = New System.Drawing.Point(406, 191)
        Me.lblSelectionNum.Name = "lblSelectionNum"
        Me.lblSelectionNum.Size = New System.Drawing.Size(63, 19)
        Me.lblSelectionNum.TabIndex = 3
        Me.lblSelectionNum.Text = "Label2"
        Me.lblSelectionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSelectionNum.Visible = False
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(547, 222)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(53, 27)
        Me.txtNumber.TabIndex = 4
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumber.Visible = False
        '
        'btnTotalCost
        '
        Me.btnTotalCost.BackColor = System.Drawing.Color.White
        Me.btnTotalCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(410, 282)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(137, 43)
        Me.btnTotalCost.TabIndex = 5
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = False
        Me.btnTotalCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(603, 282)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 43)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(445, 390)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 19)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Label3"
        Me.lblTotal.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WeeklyAssignment7.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(814, 497)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblSelectionNum)
        Me.Controls.Add(Me.cboOptions)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Karaoke Music Night"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents cboOptions As ComboBox
    Friend WithEvents lblSelectionNum As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
End Class
