<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.InstallButton = New System.Windows.Forms.Button()
        Me.ForgeInstall = New System.Windows.Forms.CheckBox()
        Me.EDMInstall = New System.Windows.Forms.CheckBox()
        Me.VersionSelector = New System.Windows.Forms.ComboBox()
        Me.Directory = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'InstallButton
        '
        Me.InstallButton.Location = New System.Drawing.Point(20, 110)
        Me.InstallButton.Name = "InstallButton"
        Me.InstallButton.Size = New System.Drawing.Size(75, 20)
        Me.InstallButton.TabIndex = 0
        Me.InstallButton.Text = "Install"
        Me.InstallButton.UseVisualStyleBackColor = True
        '
        'ForgeInstall
        '
        Me.ForgeInstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgeInstall.Location = New System.Drawing.Point(20, 85)
        Me.ForgeInstall.Name = "ForgeInstall"
        Me.ForgeInstall.Size = New System.Drawing.Size(75, 20)
        Me.ForgeInstall.TabIndex = 1
        Me.ForgeInstall.Text = "Forge"
        Me.ForgeInstall.UseVisualStyleBackColor = True
        '
        'EDMInstall
        '
        Me.EDMInstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EDMInstall.Location = New System.Drawing.Point(20, 60)
        Me.EDMInstall.Name = "EDMInstall"
        Me.EDMInstall.Size = New System.Drawing.Size(130, 20)
        Me.EDMInstall.TabIndex = 2
        Me.EDMInstall.Text = "Extra Diamonds Mod"
        Me.EDMInstall.UseVisualStyleBackColor = True
        '
        'VersionSelector
        '
        Me.VersionSelector.FormattingEnabled = True
        Me.VersionSelector.Items.AddRange(New Object() {"1.8", "1.7.10", "1.7.2"})
        Me.VersionSelector.Location = New System.Drawing.Point(20, 35)
        Me.VersionSelector.Name = "VersionSelector"
        Me.VersionSelector.Size = New System.Drawing.Size(130, 21)
        Me.VersionSelector.TabIndex = 3
        '
        'Directory
        '
        Me.Directory.Location = New System.Drawing.Point(20, 10)
        Me.Directory.Name = "Directory"
        Me.Directory.Size = New System.Drawing.Size(210, 20)
        Me.Directory.TabIndex = 4
        '
        'FindButton
        '
        Me.FindButton.Location = New System.Drawing.Point(235, 10)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(25, 20)
        Me.FindButton.TabIndex = 5
        Me.FindButton.Text = "..."
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'FolderBrowser
        '
        Me.FolderBrowser.RootFolder = System.Environment.SpecialFolder.ApplicationData
        Me.FolderBrowser.ShowNewFolderButton = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 141)
        Me.Controls.Add(Me.FindButton)
        Me.Controls.Add(Me.Directory)
        Me.Controls.Add(Me.VersionSelector)
        Me.Controls.Add(Me.EDMInstall)
        Me.Controls.Add(Me.ForgeInstall)
        Me.Controls.Add(Me.InstallButton)
        Me.Name = "MainWindow"
        Me.Text = "Mod Installer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InstallButton As Button
    Friend WithEvents ForgeInstall As CheckBox
    Friend WithEvents EDMInstall As CheckBox
    Friend WithEvents VersionSelector As ComboBox
    Friend WithEvents Directory As TextBox
    Friend WithEvents FindButton As Button
    Friend WithEvents FolderBrowser As FolderBrowserDialog
End Class
