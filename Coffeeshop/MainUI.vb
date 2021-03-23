Public Class MainUI

    Public usernameInMain As String
    Dim price, pricetop As Integer
    Dim count = 1


    Dim cof As New Coffee()

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        usernameInMain = login.username
        lbluserlogin.Text = usernameInMain
        cbcoffee.SelectedIndex = 0
        cbtopping.SelectedIndex = 0
        checkhot.Checked = True
        lblorderNo.Text = count


    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click

        login.Show()
        Me.Close()


    End Sub

    Private Sub cbcoffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcoffee.SelectedIndexChanged

        If cbcoffee.SelectedIndex = 0 Then
            cof.coffeeMenu = cbcoffee.Text
            lblcoforder.Text = cof.coffeeMenu
            lblpriceshow.Text = price + pricetop
        ElseIf cbcoffee.SelectedIndex = 1 Then
            cof.coffeeMenu = cbcoffee.Text
            lblcoforder.Text = cof.coffeeMenu
            lblpriceshow.Text = price + pricetop
        ElseIf cbcoffee.SelectedIndex = 2 Then
            cof.coffeeMenu = cbcoffee.Text
            lblcoforder.Text = cof.coffeeMenu
            lblpriceshow.Text = price + pricetop
        ElseIf cbcoffee.SelectedIndex = 3 Then
            cof.coffeeMenu = cbcoffee.Text
            lblcoforder.Text = cof.coffeeMenu
            lblpriceshow.Text = price + pricetop
        ElseIf cbcoffee.SelectedIndex = 4 Then
            cof.coffeeMenu = cbcoffee.Text
            lblcoforder.Text = cof.coffeeMenu
            lblpriceshow.Text = price + pricetop
        End If

    End Sub

    Private Sub checkhot_CheckedChanged(sender As Object, e As EventArgs) Handles checkhot.CheckedChanged

        If checkhot.Checked = True Then
            If cbcoffee.SelectedIndex = 0 Then
                price = 35
                lblpriceshow.Text = price + pricetop
                checkcold.Checked = False
            ElseIf cbcoffee.SelectedIndex = 1 Then
                price = 45
                lblpriceshow.Text = price + pricetop
                checkcold.Checked = False
            ElseIf cbcoffee.SelectedIndex = 2 Then
                price = 30
                lblpriceshow.Text = price + pricetop
                checkcold.Checked = False
            ElseIf cbcoffee.SelectedIndex = 3 Then
                price = 50
                lblpriceshow.Text = price + pricetop
                checkcold.Checked = False
            ElseIf cbcoffee.SelectedIndex = 4 Then
                price = 50
                lblpriceshow.Text = price + pricetop
                checkcold.Checked = False
            End If
        End If


    End Sub

    Private Sub cbtopping_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtopping.SelectedIndexChanged

        If cbtopping.SelectedIndex = 0 Then
            cof.toppingMenu = cbtopping.Text
            lbltoporder.Text = cof.toppingMenu
            pricetop = 0
            lblpriceshow.Text = price + pricetop
        ElseIf cbtopping.SelectedIndex = 1 Then
            cof.toppingMenu = cbtopping.Text
            lbltoporder.Text = cof.toppingMenu
            pricetop = 10
            lblpriceshow.Text = price + pricetop
        ElseIf cbtopping.SelectedIndex = 2 Then
            cof.toppingMenu = cbtopping.Text
            lbltoporder.Text = cof.toppingMenu
            pricetop = 15
            lblpriceshow.Text = price + pricetop
        ElseIf cbtopping.SelectedIndex = 3 Then
            cof.toppingMenu = cbtopping.Text
            lbltoporder.Text = cof.toppingMenu
            pricetop = 15
            lblpriceshow.Text = price + pricetop
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        cbcoffee.SelectedIndex = 0
        cbtopping.SelectedIndex = 0
        checkhot.Checked = True
        lblorderNo.Text = count
        lbltoporder.Text = cbtopping.Text
        price = 35
        pricetop = 0
        lblcoforder.Text = cbcoffee.Text
        lblpriceshow.Text = price + pricetop


    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click

        Dim result As DialogResult = MessageBox.Show("Coffee : " & cof.coffeeMenu & vbNewLine &
                        "Topping : " & cof.toppingMenu & vbNewLine &
                        "Price : " & price + pricetop, "Confirm Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            MessageBox.Show("Order Confirm!!", "Confirm")
            count += 1
            cbcoffee.SelectedIndex = 0
            cbtopping.SelectedIndex = 0
            checkhot.Checked = True
            lblorderNo.Text = count
            lbltoporder.Text = cbtopping.Text
            price = 35
            pricetop = 0
            lblcoforder.Text = cbcoffee.Text
            lblpriceshow.Text = price + pricetop
        End If

    End Sub

    Private Sub checkcold_CheckedChanged(sender As Object, e As EventArgs) Handles checkcold.CheckedChanged

        If checkcold.Checked = True Then
            If cbcoffee.SelectedIndex = 0 Then
                price = 55
                lblpriceshow.Text = price + pricetop
                checkhot.Checked = False
            ElseIf cbcoffee.SelectedIndex = 1 Then
                price = 60
                lblpriceshow.Text = price + pricetop
                checkhot.Checked = False
            ElseIf cbcoffee.SelectedIndex = 2 Then
                price = 55
                lblpriceshow.Text = price + pricetop
                checkhot.Checked = False
            ElseIf cbcoffee.SelectedIndex = 3 Then
                price = 65
                lblpriceshow.Text = price + pricetop
                checkhot.Checked = False
            ElseIf cbcoffee.SelectedIndex = 4 Then
                price = 65
                lblpriceshow.Text = price + pricetop
                checkhot.Checked = False
            End If
        End If

    End Sub
End Class