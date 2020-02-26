Public Class FormMain
    Private Const Prog_Name As String = "Generate SendMany Text With Random Amounts"
    Private m_sbMsg As New System.Text.StringBuilder()
    Private m_rNum As New Random()

    Private i As Integer = 0
    Private m_iEnd As Integer = 0
    Private m_dRndAmt As Double = 0.0
    Private m_dTotalAmt As Double = 0.0
    Private m_dMin As Double = 0.0
    Private m_dMax As Double = 0.0

#Region "Form Events"
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.AirDrop_16_32_48_256
        Me.Text = Prog_Name & " v" & My.Application.Info.Version.Major

        Me.btnReGen.Text = ""
        Me.btnReGen.Image = My.Resources.Reload_16.ToBitmap

        Me.SplitContainer1.SplitterWidth = 2
    End Sub
#End Region

#Region "Control Events"
    Private Sub txtAddrList_TextChanged(sender As Object, e As EventArgs) Handles txtAddrList.TextChanged
        GenerateText()
    End Sub

    Private Sub txtAmtMin_TextChanged(sender As Object, e As EventArgs) Handles txtAmtMin.TextChanged
        GenerateText()
    End Sub

    Private Sub txtAmtMax_TextChanged(sender As Object, e As EventArgs) Handles txtAmtMax.TextChanged
        GenerateText()
    End Sub

    Private Sub btnReGen_Click(sender As Object, e As EventArgs) Handles btnReGen.Click
        GenerateText()
    End Sub

    Private Sub cboDecimalPlaces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDecimalPlaces.SelectedIndexChanged
        GenerateText()
    End Sub

    Private Sub cboDecimalPlaces_TextChanged(sender As Object, e As EventArgs) Handles cboDecimalPlaces.TextChanged
        Select Case Me.cboDecimalPlaces.Text
            Case "0", "1", "2", "4", "6", "8"
                'Good
            Case Else
                'Correct any other text
                Me.cboDecimalPlaces.Text = "6"
        End Select
    End Sub
#End Region

#Region "Keystroke Events"
    Private Sub txtAddrList_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddrList.KeyDown
        If e.Modifiers = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.A
                    'CTRL+A select all text
                    Me.txtAddrList.SelectAll()
                    e.SuppressKeyPress = True
            End Select
        End If
    End Sub

    Private Sub txtOutput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOutput.KeyDown
        If e.Modifiers = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.A
                    'CTRL+A select all text
                    Me.txtOutput.SelectAll()
                    e.SuppressKeyPress = True
            End Select
        End If
    End Sub
#End Region

#Region "Helper Functions"
    Private Function FixStr(ByRef val As Double) As String
        Select Case Me.cboDecimalPlaces.Text
            Case "0"
                Return val.ToString("0", Globalization.CultureInfo.InvariantCulture)
            Case "1"
                Return val.ToString("0.0", Globalization.CultureInfo.InvariantCulture)
            Case "2"
                Return val.ToString("0.00", Globalization.CultureInfo.InvariantCulture)
            Case "4"
                Return val.ToString("0.0000", Globalization.CultureInfo.InvariantCulture)
            Case "6"
                Return val.ToString("0.000000", Globalization.CultureInfo.InvariantCulture)
            Case "8"
                Return val.ToString("0.00000000", Globalization.CultureInfo.InvariantCulture)
            Case Else
                Return val.ToString("0.000000", Globalization.CultureInfo.InvariantCulture)
        End Select
    End Function

    Private Function FixDbl(val As Double) As Double
        Return Math.Round(val, CInt(Me.cboDecimalPlaces.Text), MidpointRounding.AwayFromZero)
    End Function
#End Region

#Region "Generate Output Text"
    Private Sub GenerateText()
        'Reset for new output text
        m_sbMsg.Length = 0
        m_iEnd = 0
        m_dRndAmt = 0.0
        m_dTotalAmt = 0.0
        m_dMin = 0.0
        m_dMax = 0.0
        Try
            If Me.txtAddrList.Text.Length > 0 Then
                If IsNumeric(Me.txtAmtMin.Text) = True AndAlso IsNumeric(Me.txtAmtMax.Text) = True Then
                    'Get the Min/Max range
                    m_dMin = CDbl(Me.txtAmtMin.Text)
                    m_dMax = CDbl(Me.txtAmtMax.Text)

                    If m_dMin <= m_dMax Then
                        If m_dMin >= 0.1 AndAlso m_dMax >= 0.1 Then
                            Me.txtOutput.BackColor = Color.FromKnownColor(KnownColor.Window)
                            Dim strAddr As String() = Me.txtAddrList.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                            m_iEnd = strAddr.Length - 1

                            'Build the output text
                            m_sbMsg.Append("sendmany """" ""{")
                            For i = 0 To m_iEnd
                                m_dRndAmt = FixDbl((m_rNum.NextDouble * (m_dMax - m_dMin)) + m_dMin)
                                'Add the new amount to the total
                                m_dTotalAmt += m_dRndAmt

                                'Trim out any extra spaces or commas from the address list while building the text string. Add the trailing comma for all entries except the last
                                m_sbMsg.Append("\""" & strAddr(i).Trim(","c, ";"c, " "c) & "\"":" & FixStr(m_dRndAmt) & If(i = m_iEnd, "", ","))
                            Next
                            m_sbMsg.Append("}""")

                            'Display the output text
                            Me.txtOutput.Text = m_sbMsg.ToString
                        Else
                            Me.txtOutput.BackColor = Color.Tomato
                            Me.txtOutput.Text = "Please enter Min / Max values greater than 0.1"
                        End If
                    Else
                        Me.txtOutput.BackColor = Color.Tomato
                        Me.txtOutput.Text = "Please enter a Min value less than or equal to the Max value"
                    End If
                Else
                    Me.txtOutput.BackColor = Color.Tomato
                    Me.txtOutput.Text = "Please enter valid Min / Max values above"
                End If
            Else
                Me.txtOutput.BackColor = Color.Tomato
                Me.txtOutput.Text = "Please add a list of addresses above"
            End If

        Catch ex As Exception
            Me.txtOutput.BackColor = Color.Tomato
            Me.txtOutput.Text = ex.ToString
        End Try

        'Display the Total Amount
        Me.txtTotalAmt.Text = FixStr(m_dTotalAmt)
        'Display the address count 
        Me.lblAddressList.Text = "Address List" & If(m_iEnd = 0, "", " (" & (m_iEnd + 1).ToString & ")") & ":"
    End Sub
#End Region
End Class
