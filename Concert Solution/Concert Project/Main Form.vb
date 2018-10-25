'Name:          Ticket Miser Calculate
'Purpose:       Calculate tickets/total based on seats and potential discount
'
'Programmer:    Kyle Hotchkiss on 07/09/2018

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Const dmlBOX As Decimal = 97.5D
    Const dmlPAVILION As Decimal = 55.5D
    Const dmlLAWN As Decimal = 21
    Const dmlDISCOUNT As Decimal = 0.1D

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNumBox As Integer
        Dim intNumPav As Integer
        Dim intNumLawn As Integer
        Dim dblSubTotal As Double
        Dim dblTotal As Double
        Dim intNumTicks As Integer

        Integer.TryParse(txtBox.Text, intNumBox)
        Integer.TryParse(txtLawn.Text, intNumLawn)
        Integer.TryParse(txtPav.Text, intNumPav)

        'calculate subtotal and number of tickets

        dblSubTotal = (intNumBox * dmlBOX) + (intNumLawn * dmlLAWN) + (intNumPav * dmlPAVILION)
        intNumTicks = intNumBox + intNumLawn + intNumPav

        'apply discount if necessary

        If chkDiscount.Checked Then
            dblTotal = dblSubTotal - (dblSubTotal * dmlDISCOUNT)
            lblTotalTicks.Text = intNumTicks.ToString("n0")
            lblTotalDue.Text = dblTotal.ToString("c2")
        Else
            dblTotal = dblSubTotal
            lblTotalTicks.Text = intNumTicks.ToString("n0")
            lblTotalDue.Text = dblTotal.ToString("c2")
        End If

    End Sub

    Private Sub ClearLabels(sender As Object, e As KeyPressEventArgs) Handles txtBox.KeyPress, txtLawn.KeyPress, txtPav.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If

    End Sub

    Private Sub chkBox_CheckStateChanged(sender As Object, e As EventArgs) Handles chkBox.CheckStateChanged

        If chkBox.Checked = True Then

            txtBox.Visible = True
        Else
            chkBox.Checked = False
            txtBox.Visible = False
            txtBox.Text = ""
        End If


    End Sub

    Private Sub chkLawn_CheckStateChanged(sender As Object, e As EventArgs) Handles chkLawn.CheckStateChanged

        If chkLawn.Checked = True Then
            txtLawn.Visible = True

        Else
            txtLawn.Visible = False
            chkLawn.Checked = False
            txtLawn.Text = ""
        End If

    End Sub

    Private Sub chkPav_CheckStateChanged(sender As Object, e As EventArgs) Handles chkPav.CheckStateChanged

        If chkPav.Checked = True Then
            txtPav.Visible = True

        Else
            chkPav.Checked = False
            txtPav.Visible = False
            txtPav.Text = ""
        End If

    End Sub

End Class
