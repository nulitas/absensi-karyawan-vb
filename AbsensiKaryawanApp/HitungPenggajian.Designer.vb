﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HitungPenggajian
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBIdPegawai = New System.Windows.Forms.ComboBox()
        Me.BtnHitungGaji = New System.Windows.Forms.Button()
        Me.CBBulan = New System.Windows.Forms.ComboBox()
        Me.LblNamaPegawai = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBIdPegawai)
        Me.Panel1.Controls.Add(Me.BtnHitungGaji)
        Me.Panel1.Controls.Add(Me.CBBulan)
        Me.Panel1.Controls.Add(Me.LblNamaPegawai)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(53, 86)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 474)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 247)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bulan Ke"
        '
        'CBIdPegawai
        '
        Me.CBIdPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBIdPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIdPegawai.FormattingEnabled = True
        Me.CBIdPegawai.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBIdPegawai.Location = New System.Drawing.Point(102, 108)
        Me.CBIdPegawai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBIdPegawai.Name = "CBIdPegawai"
        Me.CBIdPegawai.Size = New System.Drawing.Size(305, 33)
        Me.CBIdPegawai.TabIndex = 8
        '
        'BtnHitungGaji
        '
        Me.BtnHitungGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHitungGaji.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHitungGaji.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHitungGaji.Location = New System.Drawing.Point(100, 388)
        Me.BtnHitungGaji.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnHitungGaji.Name = "BtnHitungGaji"
        Me.BtnHitungGaji.Size = New System.Drawing.Size(307, 57)
        Me.BtnHitungGaji.TabIndex = 7
        Me.BtnHitungGaji.Text = "Hitung"
        Me.BtnHitungGaji.UseVisualStyleBackColor = False
        '
        'CBBulan
        '
        Me.CBBulan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBulan.FormattingEnabled = True
        Me.CBBulan.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBBulan.Location = New System.Drawing.Point(102, 289)
        Me.CBBulan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBBulan.Name = "CBBulan"
        Me.CBBulan.Size = New System.Drawing.Size(305, 33)
        Me.CBBulan.TabIndex = 6
        '
        'LblNamaPegawai
        '
        Me.LblNamaPegawai.AutoSize = True
        Me.LblNamaPegawai.Location = New System.Drawing.Point(187, 188)
        Me.LblNamaPegawai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaPegawai.Name = "LblNamaPegawai"
        Me.LblNamaPegawai.Size = New System.Drawing.Size(145, 25)
        Me.LblNamaPegawai.TabIndex = 5
        Me.LblNamaPegawai.Text = "NAMA PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Pegawai"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(169, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 41)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(52, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(523, 50)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# Form Hitung Gaji"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HitungPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 578)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HitungPenggajian"
        Me.Text = "HitungPenggajian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnHitungGaji As Button
    Friend WithEvents CBBulan As ComboBox
    Friend WithEvents LblNamaPegawai As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBIdPegawai As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
End Class
