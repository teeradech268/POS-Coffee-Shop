<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUI
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
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lblorderbook = New System.Windows.Forms.Label()
        Me.lblorderNo = New System.Windows.Forms.Label()
        Me.cbcoffee = New System.Windows.Forms.ComboBox()
        Me.cbtopping = New System.Windows.Forms.ComboBox()
        Me.checkhot = New System.Windows.Forms.CheckBox()
        Me.checkcold = New System.Windows.Forms.CheckBox()
        Me.lblCoffee = New System.Windows.Forms.Label()
        Me.lbltopping = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lbluserlogin = New System.Windows.Forms.Label()
        Me.lblCofresult = New System.Windows.Forms.Label()
        Me.lblcoforder = New System.Windows.Forms.Label()
        Me.lbltopresult = New System.Windows.Forms.Label()
        Me.lbltoporder = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblpriceshow = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblbaht = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(323, 38)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 1
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'lblorderbook
        '
        Me.lblorderbook.AutoSize = True
        Me.lblorderbook.Location = New System.Drawing.Point(1, 13)
        Me.lblorderbook.Name = "lblorderbook"
        Me.lblorderbook.Size = New System.Drawing.Size(44, 13)
        Me.lblorderbook.TabIndex = 2
        Me.lblorderbook.Text = "Orders :"
        '
        'lblorderNo
        '
        Me.lblorderNo.AutoSize = True
        Me.lblorderNo.Location = New System.Drawing.Point(72, 13)
        Me.lblorderNo.Name = "lblorderNo"
        Me.lblorderNo.Size = New System.Drawing.Size(0, 13)
        Me.lblorderNo.TabIndex = 3
        '
        'cbcoffee
        '
        Me.cbcoffee.FormattingEnabled = True
        Me.cbcoffee.Items.AddRange(New Object() {"Americano", "Cappuccino", "Espresso", "Latte", "Mocha"})
        Me.cbcoffee.Location = New System.Drawing.Point(122, 79)
        Me.cbcoffee.Name = "cbcoffee"
        Me.cbcoffee.Size = New System.Drawing.Size(121, 21)
        Me.cbcoffee.TabIndex = 4
        '
        'cbtopping
        '
        Me.cbtopping.FormattingEnabled = True
        Me.cbtopping.Items.AddRange(New Object() {"None", "Whip-Cream", "Jelly Coffee", "Milk Froth"})
        Me.cbtopping.Location = New System.Drawing.Point(122, 131)
        Me.cbtopping.Name = "cbtopping"
        Me.cbtopping.Size = New System.Drawing.Size(121, 21)
        Me.cbtopping.TabIndex = 5
        '
        'checkhot
        '
        Me.checkhot.AutoSize = True
        Me.checkhot.Location = New System.Drawing.Point(273, 81)
        Me.checkhot.Name = "checkhot"
        Me.checkhot.Size = New System.Drawing.Size(46, 17)
        Me.checkhot.TabIndex = 6
        Me.checkhot.Text = "ร้อน"
        Me.checkhot.UseVisualStyleBackColor = True
        '
        'checkcold
        '
        Me.checkcold.AutoSize = True
        Me.checkcold.Location = New System.Drawing.Point(340, 81)
        Me.checkcold.Name = "checkcold"
        Me.checkcold.Size = New System.Drawing.Size(46, 17)
        Me.checkcold.TabIndex = 7
        Me.checkcold.Text = "เย็น"
        Me.checkcold.UseVisualStyleBackColor = True
        '
        'lblCoffee
        '
        Me.lblCoffee.AutoSize = True
        Me.lblCoffee.Location = New System.Drawing.Point(72, 82)
        Me.lblCoffee.Name = "lblCoffee"
        Me.lblCoffee.Size = New System.Drawing.Size(44, 13)
        Me.lblCoffee.TabIndex = 8
        Me.lblCoffee.Text = "Coffee :"
        '
        'lbltopping
        '
        Me.lbltopping.AutoSize = True
        Me.lbltopping.Location = New System.Drawing.Point(64, 134)
        Me.lbltopping.Name = "lbltopping"
        Me.lbltopping.Size = New System.Drawing.Size(52, 13)
        Me.lbltopping.TabIndex = 9
        Me.lbltopping.Text = "Topping :"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(296, 13)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(35, 13)
        Me.lbluser.TabIndex = 10
        Me.lbluser.Text = "User :"
        '
        'lbluserlogin
        '
        Me.lbluserlogin.AutoSize = True
        Me.lbluserlogin.Location = New System.Drawing.Point(337, 13)
        Me.lbluserlogin.Name = "lbluserlogin"
        Me.lbluserlogin.Size = New System.Drawing.Size(0, 13)
        Me.lbluserlogin.TabIndex = 11
        '
        'lblCofresult
        '
        Me.lblCofresult.AutoSize = True
        Me.lblCofresult.Location = New System.Drawing.Point(93, 223)
        Me.lblCofresult.Name = "lblCofresult"
        Me.lblCofresult.Size = New System.Drawing.Size(44, 13)
        Me.lblCofresult.TabIndex = 12
        Me.lblCofresult.Text = "Coffee :"
        '
        'lblcoforder
        '
        Me.lblcoforder.AutoSize = True
        Me.lblcoforder.Location = New System.Drawing.Point(143, 223)
        Me.lblcoforder.Name = "lblcoforder"
        Me.lblcoforder.Size = New System.Drawing.Size(0, 13)
        Me.lblcoforder.TabIndex = 13
        '
        'lbltopresult
        '
        Me.lbltopresult.AutoSize = True
        Me.lbltopresult.Location = New System.Drawing.Point(85, 252)
        Me.lbltopresult.Name = "lbltopresult"
        Me.lbltopresult.Size = New System.Drawing.Size(52, 13)
        Me.lbltopresult.TabIndex = 14
        Me.lbltopresult.Text = "Topping :"
        '
        'lbltoporder
        '
        Me.lbltoporder.AutoSize = True
        Me.lbltoporder.Location = New System.Drawing.Point(144, 252)
        Me.lbltoporder.Name = "lbltoporder"
        Me.lbltoporder.Size = New System.Drawing.Size(0, 13)
        Me.lbltoporder.TabIndex = 15
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(100, 279)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(37, 13)
        Me.lblprice.TabIndex = 16
        Me.lblprice.Text = "Price :"
        '
        'lblpriceshow
        '
        Me.lblpriceshow.AutoSize = True
        Me.lblpriceshow.Location = New System.Drawing.Point(144, 279)
        Me.lblpriceshow.Name = "lblpriceshow"
        Me.lblpriceshow.Size = New System.Drawing.Size(0, 13)
        Me.lblpriceshow.TabIndex = 17
        '
        'btnorder
        '
        Me.btnorder.Location = New System.Drawing.Point(273, 206)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(81, 59)
        Me.btnorder.TabIndex = 18
        Me.btnorder.Text = "Order"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(273, 279)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(81, 59)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblbaht
        '
        Me.lblbaht.AutoSize = True
        Me.lblbaht.Location = New System.Drawing.Point(217, 279)
        Me.lblbaht.Name = "lblbaht"
        Me.lblbaht.Size = New System.Drawing.Size(32, 13)
        Me.lblbaht.TabIndex = 20
        Me.lblbaht.Text = "Baht."
        '
        'MainUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 358)
        Me.Controls.Add(Me.lblbaht)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.lblpriceshow)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lbltoporder)
        Me.Controls.Add(Me.lbltopresult)
        Me.Controls.Add(Me.lblcoforder)
        Me.Controls.Add(Me.lblCofresult)
        Me.Controls.Add(Me.lbluserlogin)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lbltopping)
        Me.Controls.Add(Me.lblCoffee)
        Me.Controls.Add(Me.checkcold)
        Me.Controls.Add(Me.checkhot)
        Me.Controls.Add(Me.cbtopping)
        Me.Controls.Add(Me.cbcoffee)
        Me.Controls.Add(Me.lblorderNo)
        Me.Controls.Add(Me.lblorderbook)
        Me.Controls.Add(Me.btnlogout)
        Me.Name = "MainUI"
        Me.Text = "OrderCoffee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogout As Button
    Friend WithEvents lblorderbook As Label
    Friend WithEvents lblorderNo As Label
    Friend WithEvents cbcoffee As ComboBox
    Friend WithEvents cbtopping As ComboBox
    Friend WithEvents checkhot As CheckBox
    Friend WithEvents checkcold As CheckBox
    Friend WithEvents lblCoffee As Label
    Friend WithEvents lbltopping As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lbluserlogin As Label
    Friend WithEvents lblCofresult As Label
    Friend WithEvents lblcoforder As Label
    Friend WithEvents lbltopresult As Label
    Friend WithEvents lbltoporder As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents lblpriceshow As Label
    Friend WithEvents btnorder As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents lblbaht As Label
End Class
