<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Verteilung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.von = New System.Windows.Forms.DateTimePicker()
        Me.ziel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bis = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.datum = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.cStunde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cZiel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cKum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vonSA = New System.Windows.Forms.DateTimePicker()
        Me.bisSA = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(847, 418)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.TabStop = False
        Me.OK_Button.Text = "OK"
        Me.OK_Button.Visible = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.TabStop = False
        Me.Cancel_Button.Text = "Beenden"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(402, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(581, 336)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.TabStop = False
        '
        'von
        '
        Me.von.CustomFormat = "HH:mm"
        Me.von.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.von.Location = New System.Drawing.Point(534, 9)
        Me.von.Name = "von"
        Me.von.ShowUpDown = True
        Me.von.Size = New System.Drawing.Size(83, 20)
        Me.von.TabIndex = 1
        Me.von.TabStop = False
        Me.von.Value = New Date(2021, 5, 5, 9, 30, 0, 0)
        '
        'ziel
        '
        Me.ziel.Location = New System.Drawing.Point(45, 38)
        Me.ziel.Name = "ziel"
        Me.ziel.Size = New System.Drawing.Size(100, 20)
        Me.ziel.TabIndex = 4
        Me.ziel.Text = "2559"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ziel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mo - Fr   Von"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(625, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bis"
        '
        'bis
        '
        Me.bis.CustomFormat = "HH:mm"
        Me.bis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bis.Location = New System.Drawing.Point(652, 9)
        Me.bis.Name = "bis"
        Me.bis.ShowUpDown = True
        Me.bis.Size = New System.Drawing.Size(83, 20)
        Me.bis.TabIndex = 2
        Me.bis.TabStop = False
        Me.bis.Value = New Date(2021, 5, 5, 19, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(225, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 336)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TabStop = False
        '
        'datum
        '
        Me.datum.CustomFormat = "dddd"
        Me.datum.Location = New System.Drawing.Point(45, 12)
        Me.datum.Name = "datum"
        Me.datum.Size = New System.Drawing.Size(191, 20)
        Me.datum.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tag"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.TabStop = False
        Me.Button1.Text = "Berechnen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cStunde, Me.cZiel, Me.cKum})
        Me.DataGridView2.Location = New System.Drawing.Point(16, 72)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(203, 364)
        Me.DataGridView2.TabIndex = 6
        Me.DataGridView2.TabStop = False
        '
        'cStunde
        '
        Me.cStunde.HeaderText = "Stunde"
        Me.cStunde.Name = "cStunde"
        Me.cStunde.Width = 50
        '
        'cZiel
        '
        Me.cZiel.HeaderText = "Ziel"
        Me.cZiel.Name = "cZiel"
        Me.cZiel.Width = 70
        '
        'cKum
        '
        Me.cKum.HeaderText = "Kumuliert"
        Me.cKum.Name = "cKum"
        Me.cKum.Width = 70
        '
        'vonSA
        '
        Me.vonSA.CustomFormat = "HH:mm"
        Me.vonSA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.vonSA.Location = New System.Drawing.Point(534, 35)
        Me.vonSA.Name = "vonSA"
        Me.vonSA.ShowUpDown = True
        Me.vonSA.Size = New System.Drawing.Size(83, 20)
        Me.vonSA.TabIndex = 1
        Me.vonSA.TabStop = False
        Me.vonSA.Value = New Date(2021, 5, 5, 9, 30, 0, 0)
        '
        'bisSA
        '
        Me.bisSA.CustomFormat = "HH:mm"
        Me.bisSA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bisSA.Location = New System.Drawing.Point(652, 35)
        Me.bisSA.Name = "bisSA"
        Me.bisSA.ShowUpDown = True
        Me.bisSA.Size = New System.Drawing.Size(83, 20)
        Me.bisSA.TabIndex = 2
        Me.bisSA.TabStop = False
        Me.bisSA.Value = New Date(2021, 5, 5, 18, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(480, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sa   Von"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(625, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Bis"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(908, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Verteilung
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 454)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.datum)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ziel)
        Me.Controls.Add(Me.bisSA)
        Me.Controls.Add(Me.vonSA)
        Me.Controls.Add(Me.bis)
        Me.Controls.Add(Me.von)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Verteilung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Verteilung"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents von As DateTimePicker
    Friend WithEvents ziel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bis As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents datum As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cStunde As DataGridViewTextBoxColumn
    Friend WithEvents cZiel As DataGridViewTextBoxColumn
    Friend WithEvents cKum As DataGridViewTextBoxColumn
    Friend WithEvents vonSA As DateTimePicker
    Friend WithEvents bisSA As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
