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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbxIn = New System.Windows.Forms.GroupBox()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.cmsInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToTheTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToTheBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsOutput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxOut = New System.Windows.Forms.GroupBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tpOutputList = New System.Windows.Forms.TabPage()
        Me.lbxOutput = New System.Windows.Forms.ListBox()
        Me.tpOutputText = New System.Windows.Forms.TabPage()
        Me.tbxOutput = New System.Windows.Forms.TextBox()
        Me.tpRichText = New System.Windows.Forms.TabPage()
        Me.rtbxFind = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstbFind01 = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtFind01 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFind01Up = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFind01Dwn = New System.Windows.Forms.ToolStripButton()
        Me.tslbFind01 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstbFind02 = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtFind02 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFind02Dwn = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFind02Up = New System.Windows.Forms.ToolStripButton()
        Me.tslbFind02 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstbFind03 = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtFind03 = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFind03Up = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFind03Dwn = New System.Windows.Forms.ToolStripButton()
        Me.tslbFind03 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslInputStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspbInput = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsslOutputStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspbOutput = New System.Windows.Forms.ToolStripProgressBar()
        Me.cmsFind = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiClear = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbxIn.SuspendLayout()
        Me.cmsInput.SuspendLayout()
        Me.cmsOutput.SuspendLayout()
        Me.gbxOut.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.tpOutputList.SuspendLayout()
        Me.tpOutputText.SuspendLayout()
        Me.tpRichText.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.cmsFind.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbxIn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.ContextMenuStrip = Me.cmsOutput
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbxOut)
        Me.SplitContainer1.Size = New System.Drawing.Size(1023, 594)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 1
        '
        'gbxIn
        '
        Me.gbxIn.Controls.Add(Me.tbxInput)
        Me.gbxIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxIn.Location = New System.Drawing.Point(0, 0)
        Me.gbxIn.Name = "gbxIn"
        Me.gbxIn.Size = New System.Drawing.Size(1023, 109)
        Me.gbxIn.TabIndex = 0
        Me.gbxIn.TabStop = False
        Me.gbxIn.Text = "Input"
        '
        'tbxInput
        '
        Me.tbxInput.AllowDrop = True
        Me.tbxInput.ContextMenuStrip = Me.cmsInput
        Me.tbxInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxInput.Location = New System.Drawing.Point(3, 16)
        Me.tbxInput.Multiline = True
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxInput.Size = New System.Drawing.Size(1017, 90)
        Me.tbxInput.TabIndex = 0
        '
        'cmsInput
        '
        Me.cmsInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ToTheTopToolStripMenuItem, Me.ToTheBottomToolStripMenuItem})
        Me.cmsInput.Name = "cmsInput"
        Me.cmsInput.Size = New System.Drawing.Size(150, 70)
        Me.cmsInput.Text = "Input"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToTheTopToolStripMenuItem
        '
        Me.ToTheTopToolStripMenuItem.Name = "ToTheTopToolStripMenuItem"
        Me.ToTheTopToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ToTheTopToolStripMenuItem.Text = "To the top"
        '
        'ToTheBottomToolStripMenuItem
        '
        Me.ToTheBottomToolStripMenuItem.Name = "ToTheBottomToolStripMenuItem"
        Me.ToTheBottomToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ToTheBottomToolStripMenuItem.Text = "To the bottom"
        '
        'cmsOutput
        '
        Me.cmsOutput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearOutputToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToTopToolStripMenuItem, Me.ToBottomToolStripMenuItem})
        Me.cmsOutput.Name = "cmsOutput"
        Me.cmsOutput.Size = New System.Drawing.Size(143, 92)
        '
        'ClearOutputToolStripMenuItem
        '
        Me.ClearOutputToolStripMenuItem.Name = "ClearOutputToolStripMenuItem"
        Me.ClearOutputToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClearOutputToolStripMenuItem.Text = "Clear Output"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToTopToolStripMenuItem
        '
        Me.ToTopToolStripMenuItem.Name = "ToTopToolStripMenuItem"
        Me.ToTopToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ToTopToolStripMenuItem.Text = "To Top"
        '
        'ToBottomToolStripMenuItem
        '
        Me.ToBottomToolStripMenuItem.Name = "ToBottomToolStripMenuItem"
        Me.ToBottomToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ToBottomToolStripMenuItem.Text = "To Bottom"
        '
        'gbxOut
        '
        Me.gbxOut.Controls.Add(Me.TabControl)
        Me.gbxOut.Controls.Add(Me.StatusStrip1)
        Me.gbxOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxOut.Location = New System.Drawing.Point(0, 0)
        Me.gbxOut.Name = "gbxOut"
        Me.gbxOut.Size = New System.Drawing.Size(1023, 479)
        Me.gbxOut.TabIndex = 0
        Me.gbxOut.TabStop = False
        Me.gbxOut.Text = "Output"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tpOutputList)
        Me.TabControl.Controls.Add(Me.tpOutputText)
        Me.TabControl.Controls.Add(Me.tpRichText)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(3, 16)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1017, 438)
        Me.TabControl.TabIndex = 4
        '
        'tpOutputList
        '
        Me.tpOutputList.Controls.Add(Me.lbxOutput)
        Me.tpOutputList.Location = New System.Drawing.Point(4, 22)
        Me.tpOutputList.Name = "tpOutputList"
        Me.tpOutputList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOutputList.Size = New System.Drawing.Size(1009, 412)
        Me.tpOutputList.TabIndex = 0
        Me.tpOutputList.Text = "List Output"
        Me.tpOutputList.UseVisualStyleBackColor = True
        '
        'lbxOutput
        '
        Me.lbxOutput.ContextMenuStrip = Me.cmsOutput
        Me.lbxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxOutput.FormattingEnabled = True
        Me.lbxOutput.Location = New System.Drawing.Point(3, 3)
        Me.lbxOutput.Name = "lbxOutput"
        Me.lbxOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbxOutput.ScrollAlwaysVisible = True
        Me.lbxOutput.Size = New System.Drawing.Size(1003, 406)
        Me.lbxOutput.TabIndex = 2
        '
        'tpOutputText
        '
        Me.tpOutputText.Controls.Add(Me.tbxOutput)
        Me.tpOutputText.Location = New System.Drawing.Point(4, 22)
        Me.tpOutputText.Name = "tpOutputText"
        Me.tpOutputText.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOutputText.Size = New System.Drawing.Size(1009, 412)
        Me.tpOutputText.TabIndex = 1
        Me.tpOutputText.Text = "Plain Text"
        Me.tpOutputText.UseVisualStyleBackColor = True
        '
        'tbxOutput
        '
        Me.tbxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxOutput.Location = New System.Drawing.Point(3, 3)
        Me.tbxOutput.Multiline = True
        Me.tbxOutput.Name = "tbxOutput"
        Me.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxOutput.Size = New System.Drawing.Size(1003, 406)
        Me.tbxOutput.TabIndex = 0
        '
        'tpRichText
        '
        Me.tpRichText.Controls.Add(Me.rtbxFind)
        Me.tpRichText.Controls.Add(Me.ToolStrip1)
        Me.tpRichText.Location = New System.Drawing.Point(4, 22)
        Me.tpRichText.Name = "tpRichText"
        Me.tpRichText.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRichText.Size = New System.Drawing.Size(1009, 412)
        Me.tpRichText.TabIndex = 2
        Me.tpRichText.Text = "Rich Text"
        Me.tpRichText.UseVisualStyleBackColor = True
        '
        'rtbxFind
        '
        Me.rtbxFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbxFind.Location = New System.Drawing.Point(3, 28)
        Me.rtbxFind.Name = "rtbxFind"
        Me.rtbxFind.Size = New System.Drawing.Size(1003, 381)
        Me.rtbxFind.TabIndex = 1
        Me.rtbxFind.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstbFind01, Me.tsbtFind01, Me.tsbtFind01Up, Me.tsbtFind01Dwn, Me.tslbFind01, Me.ToolStripSeparator1, Me.tstbFind02, Me.tsbtFind02, Me.tsbtFind02Dwn, Me.tsbtFind02Up, Me.tslbFind02, Me.ToolStripSeparator2, Me.tstbFind03, Me.tsbtFind03, Me.tsbtFind03Up, Me.tsbtFind03Dwn, Me.tslbFind03, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1003, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstbFind01
        '
        Me.tstbFind01.BackColor = System.Drawing.Color.LightSalmon
        Me.tstbFind01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstbFind01.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstbFind01.Name = "tstbFind01"
        Me.tstbFind01.Size = New System.Drawing.Size(150, 25)
        '
        'tsbtFind01
        '
        Me.tsbtFind01.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind01.Image = Global.JenkinsView.My.Resources.Resources._049
        Me.tsbtFind01.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind01.Name = "tsbtFind01"
        Me.tsbtFind01.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind01.Text = "ToolStripButton1"
        '
        'tsbtFind01Up
        '
        Me.tsbtFind01Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind01Up.Enabled = False
        Me.tsbtFind01Up.Image = Global.JenkinsView.My.Resources.Resources._107
        Me.tsbtFind01Up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind01Up.Name = "tsbtFind01Up"
        Me.tsbtFind01Up.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind01Up.Text = "ToolStripButton1"
        Me.tsbtFind01Up.ToolTipText = "Next"
        '
        'tsbtFind01Dwn
        '
        Me.tsbtFind01Dwn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind01Dwn.Enabled = False
        Me.tsbtFind01Dwn.Image = Global.JenkinsView.My.Resources.Resources._108
        Me.tsbtFind01Dwn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind01Dwn.Name = "tsbtFind01Dwn"
        Me.tsbtFind01Dwn.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind01Dwn.Text = "ToolStripButton1"
        Me.tsbtFind01Dwn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tslbFind01
        '
        Me.tslbFind01.Name = "tslbFind01"
        Me.tslbFind01.Size = New System.Drawing.Size(44, 22)
        Me.tslbFind01.Text = "-- of --"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tstbFind02
        '
        Me.tstbFind02.BackColor = System.Drawing.Color.Chartreuse
        Me.tstbFind02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstbFind02.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstbFind02.Name = "tstbFind02"
        Me.tstbFind02.Size = New System.Drawing.Size(150, 25)
        '
        'tsbtFind02
        '
        Me.tsbtFind02.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind02.Image = Global.JenkinsView.My.Resources.Resources._049
        Me.tsbtFind02.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind02.Name = "tsbtFind02"
        Me.tsbtFind02.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind02.Text = "ToolStripButton2"
        '
        'tsbtFind02Dwn
        '
        Me.tsbtFind02Dwn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind02Dwn.Enabled = False
        Me.tsbtFind02Dwn.Image = Global.JenkinsView.My.Resources.Resources._107
        Me.tsbtFind02Dwn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind02Dwn.Name = "tsbtFind02Dwn"
        Me.tsbtFind02Dwn.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind02Dwn.Text = "ToolStripButton5"
        '
        'tsbtFind02Up
        '
        Me.tsbtFind02Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind02Up.Enabled = False
        Me.tsbtFind02Up.Image = Global.JenkinsView.My.Resources.Resources._108
        Me.tsbtFind02Up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind02Up.Name = "tsbtFind02Up"
        Me.tsbtFind02Up.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind02Up.Text = "ToolStripButton3"
        '
        'tslbFind02
        '
        Me.tslbFind02.Name = "tslbFind02"
        Me.tslbFind02.Size = New System.Drawing.Size(44, 22)
        Me.tslbFind02.Text = "-- of --"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tstbFind03
        '
        Me.tstbFind03.BackColor = System.Drawing.Color.PowderBlue
        Me.tstbFind03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstbFind03.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstbFind03.Name = "tstbFind03"
        Me.tstbFind03.Size = New System.Drawing.Size(150, 25)
        '
        'tsbtFind03
        '
        Me.tsbtFind03.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind03.Image = Global.JenkinsView.My.Resources.Resources._049
        Me.tsbtFind03.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind03.Name = "tsbtFind03"
        Me.tsbtFind03.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind03.Text = "ToolStripButton3"
        '
        'tsbtFind03Up
        '
        Me.tsbtFind03Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind03Up.Enabled = False
        Me.tsbtFind03Up.Image = Global.JenkinsView.My.Resources.Resources._108
        Me.tsbtFind03Up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind03Up.Name = "tsbtFind03Up"
        Me.tsbtFind03Up.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind03Up.Text = "ToolStripButton4"
        '
        'tsbtFind03Dwn
        '
        Me.tsbtFind03Dwn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFind03Dwn.Enabled = False
        Me.tsbtFind03Dwn.Image = Global.JenkinsView.My.Resources.Resources._107
        Me.tsbtFind03Dwn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFind03Dwn.Name = "tsbtFind03Dwn"
        Me.tsbtFind03Dwn.Size = New System.Drawing.Size(23, 22)
        Me.tsbtFind03Dwn.Text = "ToolStripButton6"
        '
        'tslbFind03
        '
        Me.tslbFind03.Name = "tslbFind03"
        Me.tslbFind03.Size = New System.Drawing.Size(44, 22)
        Me.tslbFind03.Text = "-- of --"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslInputStatus, Me.tspbInput, Me.tsslOutputStatus, Me.tspbOutput})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1017, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslInputStatus
        '
        Me.tsslInputStatus.Name = "tsslInputStatus"
        Me.tsslInputStatus.Size = New System.Drawing.Size(38, 17)
        Me.tsslInputStatus.Text = "Input:"
        '
        'tspbInput
        '
        Me.tspbInput.Name = "tspbInput"
        Me.tspbInput.Size = New System.Drawing.Size(100, 16)
        Me.tspbInput.ToolTipText = "Input progress"
        '
        'tsslOutputStatus
        '
        Me.tsslOutputStatus.Name = "tsslOutputStatus"
        Me.tsslOutputStatus.Size = New System.Drawing.Size(44, 17)
        Me.tsslOutputStatus.Text = "Ouput:"
        '
        'tspbOutput
        '
        Me.tspbOutput.Name = "tspbOutput"
        Me.tspbOutput.Size = New System.Drawing.Size(100, 16)
        Me.tspbOutput.ToolTipText = "Output progress"
        '
        'cmsFind
        '
        Me.cmsFind.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiClear})
        Me.cmsFind.Name = "cmsFind"
        Me.cmsFind.Size = New System.Drawing.Size(102, 26)
        '
        'tsmiClear
        '
        Me.tsmiClear.Name = "tsmiClear"
        Me.tsmiClear.Size = New System.Drawing.Size(101, 22)
        Me.tsmiClear.Text = "Clear"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 594)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "JenkinsView"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbxIn.ResumeLayout(False)
        Me.gbxIn.PerformLayout()
        Me.cmsInput.ResumeLayout(False)
        Me.cmsOutput.ResumeLayout(False)
        Me.gbxOut.ResumeLayout(False)
        Me.gbxOut.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.tpOutputList.ResumeLayout(False)
        Me.tpOutputText.ResumeLayout(False)
        Me.tpOutputText.PerformLayout()
        Me.tpRichText.ResumeLayout(False)
        Me.tpRichText.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.cmsFind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents gbxIn As GroupBox
    Friend WithEvents gbxOut As GroupBox
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents cmsInput As ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsOutput As ContextMenuStrip
    Friend WithEvents ClearOutputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToTheTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToTheBottomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbxOutput As ListBox
    Friend WithEvents ToTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToBottomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslInputStatus As ToolStripStatusLabel
    Friend WithEvents tspbInput As ToolStripProgressBar
    Friend WithEvents tsslOutputStatus As ToolStripStatusLabel
    Friend WithEvents tspbOutput As ToolStripProgressBar
    Friend WithEvents TabControl As TabControl
    Friend WithEvents tpOutputList As TabPage
    Friend WithEvents tpOutputText As TabPage
    Friend WithEvents tbxOutput As TextBox
    Friend WithEvents tpRichText As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tstbFind01 As ToolStripTextBox
    Friend WithEvents tsbtFind01 As ToolStripButton
    Friend WithEvents tstbFind02 As ToolStripTextBox
    Friend WithEvents tsbtFind02 As ToolStripButton
    Friend WithEvents tstbFind03 As ToolStripTextBox
    Friend WithEvents tsbtFind03 As ToolStripButton
    Friend WithEvents rtbxFind As RichTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tslbFind01 As ToolStripLabel
    Friend WithEvents tslbFind02 As ToolStripLabel
    Friend WithEvents tslbFind03 As ToolStripLabel
    Friend WithEvents tsbtFind01Up As ToolStripButton
    Friend WithEvents tsbtFind01Dwn As ToolStripButton
    Friend WithEvents tsbtFind02Up As ToolStripButton
    Friend WithEvents tsbtFind03Up As ToolStripButton
    Friend WithEvents tsbtFind02Dwn As ToolStripButton
    Friend WithEvents tsbtFind03Dwn As ToolStripButton
    Friend WithEvents cmsFind As ContextMenuStrip
    Friend WithEvents tsmiClear As ToolStripMenuItem
End Class
