Public Class Form1
    Const cdecHoursPrice As Decimal = 8.99
    Const cdecSongsPrice As Decimal = 2.99
    Dim intOptionChoice As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub cboOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOptions.SelectedIndexChanged

        intOptionChoice = cboOptions.SelectedIndex
        Select Case intOptionChoice
            Case 0
                lblSelectionNum.Text = "Hourly Rental of Karaoke Room:"
                lblSelectionNum.Visible = True
                txtNumber.Select()
                txtNumber.Visible = True
                btnClear.Visible = True
                btnTotalCost.Visible = True
            Case 1
                lblSelectionNum.Text = "Number of Songs:"
                lblSelectionNum.Visible = True
                txtNumber.Select()
                txtNumber.Visible = True
                btnClear.Visible = True
                btnTotalCost.Visible = True
        End Select
    End Sub

    Private Sub lblSelectionNum_Click(sender As Object, e As EventArgs) Handles lblSelectionNum.Click

    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim intNumberOption As Integer
        Dim decTotalCost As Decimal

        If Integer.TryParse(txtNumber.Text, vbNull) Then
            intNumberOption = Convert.ToInt32(txtNumber.Text)
            If intNumberOption > 0 Then
                If cboOptions.SelectedIndex = 0 Then
                    decTotalCost = cdecHoursPrice * intNumberOption
                    lblTotal.Visible = True
                    lblTotal.Text = "Total cost of Karaoke Night - " + decTotalCost.ToString("c")
                Else
                    decTotalCost = cdecSongsPrice * intNumberOption
                    lblTotal.Visible = True
                    lblTotal.Text = "Total cost of Karaoke Night - " + decTotalCost.ToString("c")
                End If
            Else
                MessageBox.Show("Please enter a number greater than zero", "Invalid Entry")
            End If
        Else
            MessageBox.Show("Please enter a number", "Invalid Entry")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber.Clear()
        lblSelectionNum.Visible = False
        lblTotal.Text = ""
        lblTotal.Visible = False
        btnTotalCost.Visible = False
        btnClear.Visible = False
        txtNumber.Visible = False
    End Sub
End Class
