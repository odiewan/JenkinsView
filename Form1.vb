Public Class Form1

  Dim frmInputSize As Integer
  Dim frmOutputSize As Integer


  Dim occurList01 As New List(Of Integer)()
  Dim occurList02 As New List(Of Integer)()
  Dim occurList03 As New List(Of Integer)()
  Dim occurance01 As Integer
  Dim occurance02 As Integer
  Dim occurance03 As Integer
  Dim find01Color As Color = Color.Orange
  Dim find02Color As Color = Color.Green
  Dim find03Color As Color = Color.Red


  '============================================================================
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    frmInputSize = 0
    frmOutputSize = 0
    occurance01 = 0
    occurance02 = 0
    occurance03 = 0
    updateGUI()
  End Sub

  '============================================================================
  Private Sub updateGUI()
    If lbxOutput.Items.Count = 0 Then
      cmsOutput.Enabled = False
      lbxOutput.Enabled = False
    Else
      cmsOutput.Enabled = True
      lbxOutput.Enabled = True
    End If

    If tbxInput.Lines.Length = 0 Then
      cmsOutput.Enabled = False
      'tbxInput.Enabled = False
    Else
      cmsOutput.Enabled = True
      'tbxInput.Enabled = True
    End If


    If tbxInput.Lines.Length = 0 Then
      cmsInput.Enabled = False
      'tbxInput.Enabled = False
    Else
      cmsInput.Enabled = True
      'tbxInput.Enabled = True
    End If

    tsslInputStatus.Text = "Input size:" + frmInputSize.ToString
    tsslOutputStatus.Text = "Output size:" + frmOutputSize.ToString


  End Sub

  '============================================================================
  Private Sub tbxInput_DragEnter(sender As Object, e As DragEventArgs) Handles tbxInput.DragEnter
    Debug.WriteLine("tbxInput_DragEnter")

    If e.Data.GetDataPresent(DataFormats.Text) Then
      e.Effect = DragDropEffects.Move
      tbxInput.Clear()
      tbxInput.BackColor = Color.Orange
    ElseIf e.Data.GetDataPresent(DataFormats.FileDrop) Then
      e.Effect = DragDropEffects.Copy
    Else
      e.Effect = DragDropEffects.None
    End If
    updateGUI()
  End Sub


  '============================================================================
  Private Sub tbxInput_DragDrop(sender As Object, e As DragEventArgs) Handles tbxInput.DragDrop
    Dim tmpStr As String = e.Data.GetData(DataFormats.Text)
    Debug.WriteLine("tbxSearchTerm_DragDrop")
    Debug.WriteLine("AllowedEffect:" & e.AllowedEffect)

    tbxInput.Clear()
    tbxInput.Text = tmpStr
    tbxInput.BackColor = SystemColors.Window

    lbxOutput.Items.Clear()
    lbxOutput.BackColor = SystemColors.Window

    tbxOutput.Clear()
    rtbxFind.Clear()

    tbxOutput.BackColor = SystemColors.Window
    rtbxFind.BackColor = SystemColors.Window


    frmInputSize = tmpStr.Length()
    parseInputTbx(tmpStr)

    updateGUI()
  End Sub

  '============================================================================
  Private Sub parseInputTbx(ByRef nInputStr As String)
    Dim tmpStr As String() = Split(tbxInput.Text, "\n")


    lbxOutput.Items.Clear()
    lbxOutput.BackColor = Color.Orange

    tbxOutput.Clear()
    tbxOutput.BackColor = Color.Orange
    rtbxFind.Clear()
    rtbxFind.BackColor = Color.Orange

    tspbOutput.Visible = True
    tspbOutput.Value = 0
    tspbOutput.Maximum = tmpStr.Length()
    frmOutputSize = tmpStr.Length()

    For Each line As String In tmpStr
      tbxOutput.AppendText(line + vbNewLine)
      lbxOutput.Items.Add(line)
      rtbxFind.AppendText(line + vbNewLine)
      If tspbOutput.Value < tspbOutput.Maximum Then
        tspbOutput.Value += 1
      End If
    Next
    lbxOutput.BackColor = SystemColors.Window
    tbxOutput.BackColor = SystemColors.Window
    rtbxFind.BackColor = SystemColors.Window
    updateGUI()
    tspbOutput.Visible = False
  End Sub

  '============================================================================
  Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
    tbxInput.Clear()
    updateGUI()
  End Sub

  '============================================================================
  Private Sub ClearOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearOutputToolStripMenuItem.Click
    lbxOutput.Items.Clear()
    updateGUI()
  End Sub

  '============================================================================
  Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
    parseInputTbx(tbxInput.Text)

  End Sub


  '============================================================================
  Private Sub ToTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToTopToolStripMenuItem.Click
    lbxOutput.SelectedIndex = lbxOutput.TopIndex
  End Sub

  '============================================================================
  Private Sub ToBottomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToBottomToolStripMenuItem.Click
    lbxOutput.SelectedIndex = lbxOutput.Items.Count - 1
  End Sub

  '============================================================================
  Private Sub tsbtFind_Click(sender As Object, e As EventArgs) Handles tsbtFind01.Click, tsbtFind02.Click, tsbtFind03.Click
    find(sender)
  End Sub

  Private Sub tstbFind_KeyDown(sender As Object, e As KeyEventArgs) Handles tstbFind01.KeyDown, tstbFind02.KeyDown, tstbFind03.KeyDown
    If e.KeyCode = Keys.Enter Then
      find(sender)
    End If
  End Sub

  Private Sub find(sender As Object)

    Dim searchstring As String
    Dim occurList As New List(Of Integer)()
    Dim tempLabel As ToolStripLabel
    Dim tempColor As Color
    Dim tempUpBtn As ToolStripButton
    Dim tempDwnBtn As ToolStripButton



    Select Case sender.Name
      Case "tstbFind01", "tsbtFind01"
        searchstring = tstbFind01.Text
        tempLabel = tslbFind01
        tempColor = find01Color
        occurList = occurList01
        tempUpBtn = tsbtFind01Up
        tempDwnBtn = tsbtFind01Dwn

      Case "tstbFind02", "tsbtFind02"
        searchstring = tstbFind02.Text
        tempLabel = tslbFind02
        tempColor = find02Color
        occurList = occurList02
        tempUpBtn = tsbtFind02Up
        tempDwnBtn = tsbtFind02Dwn

      Case "tstbFind03", "tsbtFind03"
        searchstring = tstbFind03.Text
        tempLabel = tslbFind03
        tempColor = find03Color
        occurList = occurList03
        tempUpBtn = tsbtFind03Up
        tempDwnBtn = tsbtFind03Dwn
      Case Else
        Return

    End Select


    If searchstring <> "" And rtbxFind.Text <> "" Then
      searchstring.Trim()
      ' The word you're looking for
      Dim indexList As New List(Of Integer)()
      Dim idxShadow As Integer = 0
      Dim idx As Integer

      For i As Integer = 0 To rtbxFind.Text.Length - 1
        idx = rtbxFind.Text.IndexOf(searchstring, i)
        If idx <> -1 Then
          'If the word is found
          'Add the index to the list
          indexList.Add(idx)
          If idx <> idxShadow Then
            occurList.Add(idx)
          End If
        End If
        idxShadow = idx
      Next
      Try
        For i As Integer = 0 To indexList.Count - 1

          rtbxFind.[Select](indexList(i), searchstring.Length)
          'rtbxFind.SelectionFont = New Font(rtbxFind.Font, FontStyle.Bold)
          rtbxFind.SelectionBackColor = tempColor
          indexList.RemoveAt(i)
        Next
      Catch
      End Try
      rtbxFind.[Select](rtbxFind.Text.Length, 0)
      rtbxFind.SelectionFont = New Font(rtbxFind.Font, FontStyle.Regular)
      rtbxFind.SelectionBackColor = SystemColors.Window

    End If

    If occurList.Count > 0 Then
      tempLabel.Text = "? of " + occurList.Count.ToString
      tempUpBtn.Enabled = True
      tempDwnBtn.Enabled = True
    Else
      tempLabel.Text = "? -- 0"
      tempUpBtn.Enabled = False
      tempDwnBtn.Enabled = False

    End If

  End Sub

  Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub tstbFind_KeyDown(sender As Object, e As EventArgs)

  End Sub

  Private Sub tstbFind02_Click(sender As Object, e As EventArgs) Handles tstbFind02.Click

  End Sub

  Private Sub tstbFind01_TextChanged(sender As Object, e As EventArgs) Handles tstbFind01.TextChanged
    Dim tempLabel As ToolStripLabel

    Dim tempUpBtn As ToolStripButton
    Dim tempDwnBtn As ToolStripButton



    Select Case sender.Name
      Case "tstbFind01", "tsbtFind01"
        tempLabel = tslbFind01
        tempUpBtn = tsbtFind01Up
        tempDwnBtn = tsbtFind01Dwn

      Case "tstbFind02", "tsbtFind02"
        tempLabel = tslbFind02
        tempUpBtn = tsbtFind02Up
        tempDwnBtn = tsbtFind02Dwn

      Case "tstbFind03", "tsbtFind03"
        tempLabel = tslbFind03
        tempUpBtn = tsbtFind03Up
        tempDwnBtn = tsbtFind03Dwn
      Case Else
        Return

    End Select


    tempLabel.Text = "-- of --"
    tempUpBtn.Enabled = False
    tempDwnBtn.Enabled = False
  End Sub

  Private Sub cycleThroughOccurances(sender As Object, e As EventArgs) Handles tsbtFind01Up.Click, tsbtFind01Dwn.Click, tsbtFind02Dwn.Click, tsbtFind02Up.Click, tsbtFind03Up.Click, tsbtFind03Dwn.Click
    Dim tempLabel As ToolStripLabel
    Dim tempOccur As Integer
    Dim tempOCount As Integer
    Dim dir As Integer
    Dim occurList As List(Of Integer)

    Select Case sender.Name
      Case "tsbtFind01Up", "tsbtFind01Dwn"
        occurList = occurList01

        tempLabel = tslbFind01
        tempOccur = occurance01


      Case "tsbtFind02Up", "tsbtFind02Dwn"
        occurList = occurList02
        tempLabel = tslbFind02
        tempOccur = occurance02

      Case "tsbtFind03Up", "tsbtFind03Dwn"
        occurList = occurList03
        tempLabel = tslbFind03
        tempOccur = occurance03

      Case Else
        Return
    End Select

    Select Case sender.Name
      Case "tsbtFind01Dwn", "tsbtFind02Dwn", "tsbtFind03Dwn"
        dir = -1

      Case "tsbtFind01Up", "tsbtFind02Up", "tsbtFind03Up"
        dir = 1

    End Select


    tempOCount = occurList.Count
    tempOccur += (1 * dir)

    If tempOccur < 0 Then
      tempOccur = tempOCount
    ElseIf tempOccur > tempOCount Then
      tempOccur = 0
    End If

    tempLabel.Text = tempOccur.ToString + " of " + tempOCount.ToString

    Select Case sender.Name
      Case "tsbtFind01Up", "tsbtFind01Dwn"
        occurance01 = tempOccur

      Case "tsbtFind02Up", "tsbtFind02Dwn"
        occurance02 = tempOccur

      Case "tsbtFind03Up", "tsbtFind03Dwn"
        occurance03 = tempOccur

    End Select


  End Sub

  Private Sub tstbFind01_MouseDown(sender As Object, e As MouseEventArgs) Handles tstbFind01.MouseDown

  End Sub
End Class
