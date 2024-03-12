<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(102, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(140, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(248, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 0
        Label2.Text = "Middle Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(336, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(140, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(482, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 0
        Label3.Text = "Last Name:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(552, 74)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 23)
        TextBox3.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(482, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 0
        Label4.Text = "Birthday:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(552, 122)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 0
        Label5.Text = "Username:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(102, 125)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(140, 23)
        TextBox4.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(248, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 0
        Label6.Text = "Password:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(336, 125)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(140, 23)
        TextBox5.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(336, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 31)
        Button1.TabIndex = 3
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(285, 218)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(203, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already have an account? Login Here"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(299, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(209, 37)
        Label7.TabIndex = 0
        Label7.Text = "REGISTER HERE!"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 242)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
End Class
