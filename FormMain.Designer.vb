<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.txtAddrList = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblAddressList = New System.Windows.Forms.Label()
        Me.txtAmtMin = New System.Windows.Forms.TextBox()
        Me.txtAmtMax = New System.Windows.Forms.TextBox()
        Me.lblAmtMin = New System.Windows.Forms.Label()
        Me.lblAmtMax = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.chk6DecimalPlaces = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblConstantAmtNote = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReGen = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAddrList
        '
        Me.txtAddrList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAddrList.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddrList.Location = New System.Drawing.Point(0, 0)
        Me.txtAddrList.MaxLength = 0
        Me.txtAddrList.Multiline = True
        Me.txtAddrList.Name = "txtAddrList"
        Me.txtAddrList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddrList.Size = New System.Drawing.Size(687, 299)
        Me.txtAddrList.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutput.Location = New System.Drawing.Point(0, 0)
        Me.txtOutput.MaxLength = 0
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(687, 121)
        Me.txtOutput.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAddrList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtOutput)
        Me.SplitContainer1.Size = New System.Drawing.Size(687, 424)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 1
        '
        'lblAddressList
        '
        Me.lblAddressList.AutoSize = True
        Me.lblAddressList.Location = New System.Drawing.Point(12, 21)
        Me.lblAddressList.Name = "lblAddressList"
        Me.lblAddressList.Size = New System.Drawing.Size(67, 13)
        Me.lblAddressList.TabIndex = 6
        Me.lblAddressList.Text = "Address List:"
        '
        'txtAmtMin
        '
        Me.txtAmtMin.Location = New System.Drawing.Point(202, 2)
        Me.txtAmtMin.Name = "txtAmtMin"
        Me.txtAmtMin.Size = New System.Drawing.Size(69, 20)
        Me.txtAmtMin.TabIndex = 3
        Me.txtAmtMin.Text = "5"
        Me.txtAmtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmtMax
        '
        Me.txtAmtMax.Location = New System.Drawing.Point(324, 2)
        Me.txtAmtMax.Name = "txtAmtMax"
        Me.txtAmtMax.Size = New System.Drawing.Size(69, 20)
        Me.txtAmtMax.TabIndex = 5
        Me.txtAmtMax.Text = "50"
        Me.txtAmtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAmtMin
        '
        Me.lblAmtMin.AutoSize = True
        Me.lblAmtMin.Location = New System.Drawing.Point(97, 5)
        Me.lblAmtMin.Name = "lblAmtMin"
        Me.lblAmtMin.Size = New System.Drawing.Size(107, 13)
        Me.lblAmtMin.TabIndex = 2
        Me.lblAmtMin.Text = "Amount Range,  Min:"
        '
        'lblAmtMax
        '
        Me.lblAmtMax.AutoSize = True
        Me.lblAmtMax.Location = New System.Drawing.Point(280, 5)
        Me.lblAmtMax.Name = "lblAmtMax"
        Me.lblAmtMax.Size = New System.Drawing.Size(46, 13)
        Me.lblAmtMax.TabIndex = 4
        Me.lblAmtMax.Text = "To Max:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtTotalAmt)
        Me.Panel1.Controls.Add(Me.lblTotalAmt)
        Me.Panel1.Location = New System.Drawing.Point(28, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 24)
        Me.Panel1.TabIndex = 1
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Location = New System.Drawing.Point(76, 1)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Size = New System.Drawing.Size(115, 20)
        Me.txtTotalAmt.TabIndex = 1
        Me.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Location = New System.Drawing.Point(2, 4)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalAmt.TabIndex = 0
        Me.lblTotalAmt.Text = "Total Amount:"
        '
        'lblExample
        '
        Me.lblExample.AutoSize = True
        Me.lblExample.Location = New System.Drawing.Point(1, -1)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(414, 26)
        Me.lblExample.TabIndex = 0
        Me.lblExample.Text = "Note: CureCoin uses 6 decimal places" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Command Info: sendmany <fromaccount> {addre" &
    "ss:amount, ...} [minconf=1] [comment]"
        '
        'chk6DecimalPlaces
        '
        Me.chk6DecimalPlaces.AutoSize = True
        Me.chk6DecimalPlaces.Location = New System.Drawing.Point(438, 6)
        Me.chk6DecimalPlaces.Name = "chk6DecimalPlaces"
        Me.chk6DecimalPlaces.Size = New System.Drawing.Size(15, 14)
        Me.chk6DecimalPlaces.TabIndex = 7
        Me.chk6DecimalPlaces.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblConstantAmtNote)
        Me.Panel2.Location = New System.Drawing.Point(155, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 16)
        Me.Panel2.TabIndex = 8
        '
        'lblConstantAmtNote
        '
        Me.lblConstantAmtNote.AutoSize = True
        Me.lblConstantAmtNote.Location = New System.Drawing.Point(0, 0)
        Me.lblConstantAmtNote.Name = "lblConstantAmtNote"
        Me.lblConstantAmtNote.Size = New System.Drawing.Size(309, 13)
        Me.lblConstantAmtNote.TabIndex = 0
        Me.lblConstantAmtNote.Text = "Note: For a fixed constant amount: Set Min and Max to be equal"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblExample)
        Me.Panel3.Location = New System.Drawing.Point(246, 446)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(417, 28)
        Me.Panel3.TabIndex = 9
        '
        'btnReGen
        '
        Me.btnReGen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReGen.BackColor = System.Drawing.Color.Transparent
        Me.btnReGen.FlatAppearance.BorderSize = 0
        Me.btnReGen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReGen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReGen.Location = New System.Drawing.Point(397, 1)
        Me.btnReGen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReGen.Name = "btnReGen"
        Me.btnReGen.Size = New System.Drawing.Size(21, 20)
        Me.btnReGen.TabIndex = 10
        Me.btnReGen.Text = "R"
        Me.btnReGen.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 482)
        Me.Controls.Add(Me.btnReGen)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chk6DecimalPlaces)
        Me.Controls.Add(Me.txtAmtMin)
        Me.Controls.Add(Me.txtAmtMax)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAmtMax)
        Me.Controls.Add(Me.lblAmtMin)
        Me.Controls.Add(Me.lblAddressList)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormMain"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddrList As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblAddressList As Label
    Friend WithEvents txtAmtMin As TextBox
    Friend WithEvents txtAmtMax As TextBox
    Friend WithEvents lblAmtMin As Label
    Friend WithEvents lblAmtMax As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTotalAmt As TextBox
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents lblExample As Label
    Friend WithEvents chk6DecimalPlaces As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblConstantAmtNote As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnReGen As Button
End Class
