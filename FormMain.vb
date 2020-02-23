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
    Private Const NUM6 As String = "0.000000"
    Private Const NUM8 As String = "0.00000000"

#Region "Form Events"
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.AirDrop_16_32_48_256
        Me.Text = Prog_Name & " v" & My.Application.Info.Version.Major
        Me.SplitContainer1.SplitterWidth = 2
        'Update the control's text
        Me.chk6DecimalPlaces.Checked = True
    End Sub

    Private Sub txtAddrList_TextChanged(sender As Object, e As EventArgs) Handles txtAddrList.TextChanged
        GenerateText()
    End Sub

    Private Sub txtAmtMin_TextChanged(sender As Object, e As EventArgs) Handles txtAmtMin.TextChanged
        GenerateText()
    End Sub

    Private Sub txtAmtMax_TextChanged(sender As Object, e As EventArgs) Handles txtAmtMax.TextChanged
        GenerateText()
    End Sub

    Private Sub chk6DecimalPlaces_CheckedChanged(sender As Object, e As EventArgs) Handles chk6DecimalPlaces.CheckedChanged
        Me.chk6DecimalPlaces.Text = If(Me.chk6DecimalPlaces.Checked = True, "6", "8") & " Decimal Places"
        GenerateText()
    End Sub
#End Region

#Region "Helper Functions"
    Private Function FixStr6(ByRef val As Double) As String
        Return val.ToString(NUM6, Globalization.CultureInfo.InvariantCulture)
    End Function
    Private Function FixStr8(ByRef val As Double) As String
        Return val.ToString(NUM8, Globalization.CultureInfo.InvariantCulture)
    End Function

    Private Function FixDbl6(val As Double) As Double
        Return Math.Round(val, 6, MidpointRounding.AwayFromZero)
    End Function
    Private Function FixDbl8(val As Double) As Double
        Return Math.Round(val, 8, MidpointRounding.AwayFromZero)
    End Function
#End Region

#Region "Generate Output Text"
    Private Sub GenerateText()
        'Reset for new output text
        m_sbMsg.Length = 0
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
                            If Me.chk6DecimalPlaces.Checked = True Then
                                '6 Decimal places
                                For i = 0 To m_iEnd
                                    m_dRndAmt = FixDbl6((m_rNum.NextDouble * (m_dMax - m_dMin)) + m_dMin)

                                    m_dTotalAmt += m_dRndAmt

                                    'Trim out any extra spaces or commas from the address list while building the text string. Add the trailing comma for all entries except the last
                                    m_sbMsg.Append("\""" & strAddr(i).Trim(","c, ";"c, " "c) & "\"":" & FixStr6(m_dRndAmt) & If(i = m_iEnd, "", ","))
                                Next
                            Else
                                '8 Decimal places
                                For i = 0 To m_iEnd
                                    m_dRndAmt = FixDbl8((m_rNum.NextDouble * (m_dMax - m_dMin)) + m_dMin)

                                    m_dTotalAmt += m_dRndAmt

                                    'Trim out any extra spaces or commas from the address list while building the text string. Add the trailing comma for all entries except the last
                                    m_sbMsg.Append("\""" & strAddr(i).Trim(","c, ";"c, " "c) & "\"":" & FixStr8(m_dRndAmt) & If(i = m_iEnd, "", ","))
                                Next
                            End If
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

        'Display the total Amount
        If Me.chk6DecimalPlaces.Checked = True Then
            Me.txtTotalAmt.Text = FixStr6(m_dTotalAmt)
        Else
            Me.txtTotalAmt.Text = FixStr8(m_dTotalAmt)
        End If
    End Sub
#End Region
End Class
