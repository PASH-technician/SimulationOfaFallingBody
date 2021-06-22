Public Class Form1
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles enter_S.TextChanged, enter_c.TextChanged, enter_m.TextChanged, enter_p.TextChanged, enter_step_time.TextChanged

        Dim m As Double
        Dim p As Double
        Dim c As Double
        Dim S As Double
        Dim stepTime As Double

        Dim mg As Double
        Dim k2 As Single

        If enter_m.Text <> "" Then
            m = Convert.ToDouble(enter_m.Text)
            mg = mgCalc(m)
            mg_text.Text = "mg = " + Math.Round(mg, 2).ToString
        Else
            mg_text.Text = "mg"
        End If

        If enter_p.Text <> "" And enter_c.Text <> "" And enter_S.Text <> "" Then
            p = Convert.ToDouble(enter_p.Text)
            c = Convert.ToDouble(enter_c.Text)
            S = Convert.ToDouble(enter_S.Text)
            k2 = k2Calc(p, c, S)
            k2_text.Text = "k2 = " + Math.Round(k2, 2).ToString
        Else
            k2_text.Text = "k2"
        End If

        If enter_m.Text <> "" And enter_p.Text <> "" And enter_c.Text <> "" And enter_S.Text <> "" And enter_step_time.Text <> "" Then
            stepTime = Convert.ToDouble(enter_step_time.Text)
            searchConstantSpeed(m, stepTime, mg, k2)
        Else
            tEnd_text.Text = "tEnd = ?"
            vEnd_text.Text = "vEnd = ?"
            hEnd_text.Text = "hEnd = ?"
        End If

    End Sub

    Private Function mgCalc(m As Single) As Double
        Return Math.Round(m * 9.8, 2)
    End Function

    Private Function k2Calc(p As Single, c As Single, S As Single) As Double
        Return Math.Round(0.5 * p * c * S, 2)
    End Function

    Private Function tNextCalc(t As Single, stepTime As Single) As Double
        Return Math.Round(t + stepTime, 1)
    End Function

    Private Function vNextCalc(v As Single, m As Single, mg As Single, k2 As Single, stepTime As Single) As Double
        Return Math.Round(v + (stepTime / 2) * ((mg - k2 * v ^ 2) / m + (mg - k2 * (v + stepTime * (mg - k2 * v ^ 2) / m) ^ 2) / m), 1)
    End Function

    Private Function hNextCalc(h As Single, v As Single, stepTime As Single) As Double
        Return Math.Round(v + h + stepTime, 1)
    End Function

    Private Function searchConstantSpeed(m As Single, stepTime As Single, mg As Single, k2 As Single)
        Dim t = 0.0
        Dim v = 0.0
        Dim h = 0.0

        Dim tOld As Double
        Dim vOld As Double
        Dim hOld As Double

        Do
            tOld = t
            vOld = v
            hOld = h

            t = tNextCalc(t, stepTime)
            v = vNextCalc(v, m, mg, k2, stepTime)
            h = hNextCalc(h, v, stepTime)
        Loop While v <> vOld

        tEnd_text.Text = "tEnd = " + Math.Round(t, 1).ToString
        vEnd_text.Text = "vEnd = " + Math.Round(vOld, 1).ToString
        hEnd_text.Text = "hEnd = " + Math.Round(hOld, 1).ToString

    End Function
End Class