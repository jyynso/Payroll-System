﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEmp
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
        Btnback = New Button()
        btnadd = New Button()
        btndel = New Button()
        lbdisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Btnback
        ' 
        Btnback.BackColor = Color.FromArgb(CByte(158), CByte(188), CByte(159))
        Btnback.FlatStyle = FlatStyle.Popup
        Btnback.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnback.Location = New Point(430, 23)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(83, 48)
        Btnback.TabIndex = 20
        Btnback.Text = "Back"
        Btnback.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(115), CByte(146), CByte(240))
        btnadd.FlatStyle = FlatStyle.Popup
        btnadd.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnadd.Location = New Point(87, 344)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(138, 48)
        btnadd.TabIndex = 22
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btndel
        ' 
        btndel.BackColor = Color.FromArgb(CByte(207), CByte(105), CByte(119))
        btndel.FlatStyle = FlatStyle.Popup
        btndel.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndel.Location = New Point(294, 344)
        btndel.Name = "btndel"
        btndel.Size = New Size(138, 48)
        btndel.TabIndex = 24
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = False
        ' 
        ' lbdisplay
        ' 
        lbdisplay.FormattingEnabled = True
        lbdisplay.ItemHeight = 25
        lbdisplay.Location = New Point(58, 92)
        lbdisplay.Name = "lbdisplay"
        lbdisplay.Size = New Size(397, 229)
        lbdisplay.TabIndex = 25
        ' 
        ' ManageEmp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(203), CByte(217))
        ClientSize = New Size(536, 435)
        Controls.Add(lbdisplay)
        Controls.Add(btndel)
        Controls.Add(btnadd)
        Controls.Add(Btnback)
        FormBorderStyle = FormBorderStyle.None
        Name = "ManageEmp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageEmp"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btnback As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndel As Button
    Friend WithEvents lbdisplay As ListBox
End Class
