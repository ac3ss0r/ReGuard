<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NsTheme1 = New ReGuard_Desktop.NSTheme()
        Me.NsGroupBox2 = New ReGuard_Desktop.NSGroupBox()
        Me.NsTextBox1 = New ReGuard_Desktop.NSTextBox()
        Me.NsButton2 = New ReGuard_Desktop.NSButton()
        Me.NsControlButton1 = New ReGuard_Desktop.NSControlButton()
        Me.NsGroupBox1 = New ReGuard_Desktop.NSGroupBox()
        Me.NsTabControl1 = New ReGuard_Desktop.NSTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NsButton1 = New ReGuard_Desktop.NSButton()
        Me.NsOnOffBox1 = New ReGuard_Desktop.NSOnOffBox()
        Me.NsCheckBox1 = New ReGuard_Desktop.NSCheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NsTheme1.SuspendLayout()
        Me.NsGroupBox2.SuspendLayout()
        Me.NsGroupBox1.SuspendLayout()
        Me.NsTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New ReGuard_Desktop.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsGroupBox2)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Controls.Add(Me.NsGroupBox1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(301, 380)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "ReGuard"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsGroupBox2
        '
        Me.NsGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsGroupBox2.Controls.Add(Me.NsTextBox1)
        Me.NsGroupBox2.Controls.Add(Me.NsButton2)
        Me.NsGroupBox2.DrawSeperator = False
        Me.NsGroupBox2.Location = New System.Drawing.Point(12, 44)
        Me.NsGroupBox2.Name = "NsGroupBox2"
        Me.NsGroupBox2.Size = New System.Drawing.Size(277, 62)
        Me.NsGroupBox2.SubTitle = ""
        Me.NsGroupBox2.TabIndex = 4
        Me.NsGroupBox2.Title = "Load assembly"
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox1.Location = New System.Drawing.Point(3, 26)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = False
        Me.NsTextBox1.Size = New System.Drawing.Size(240, 23)
        Me.NsTextBox1.TabIndex = 3
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        '
        'NsButton2
        '
        Me.NsButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsButton2.Font = New System.Drawing.Font("Verdana", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NsButton2.Location = New System.Drawing.Point(244, 26)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(29, 23)
        Me.NsButton2.TabIndex = 0
        Me.NsButton2.Text = "• • •"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = ReGuard_Desktop.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(278, 5)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 2
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'NsGroupBox1
        '
        Me.NsGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsGroupBox1.Controls.Add(Me.NsTabControl1)
        Me.NsGroupBox1.DrawSeperator = False
        Me.NsGroupBox1.Location = New System.Drawing.Point(15, 112)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(274, 256)
        Me.NsGroupBox1.SubTitle = "Specify options to protect assembly"
        Me.NsGroupBox1.TabIndex = 1
        Me.NsGroupBox1.Title = "DRM Configuration"
        '
        'NsTabControl1
        '
        Me.NsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.NsTabControl1.Controls.Add(Me.TabPage1)
        Me.NsTabControl1.Controls.Add(Me.TabPage2)
        Me.NsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.NsTabControl1.ItemSize = New System.Drawing.Size(28, 115)
        Me.NsTabControl1.Location = New System.Drawing.Point(3, 43)
        Me.NsTabControl1.Multiline = True
        Me.NsTabControl1.Name = "NsTabControl1"
        Me.NsTabControl1.SelectedIndex = 0
        Me.NsTabControl1.Size = New System.Drawing.Size(267, 202)
        Me.NsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.NsTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.NsButton1)
        Me.TabPage1.Controls.Add(Me.NsOnOffBox1)
        Me.TabPage1.Controls.Add(Me.NsCheckBox1)
        Me.TabPage1.Location = New System.Drawing.Point(119, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(144, 194)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(6, 65)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(69, 23)
        Me.NsButton1.TabIndex = 2
        Me.NsButton1.Text = "NsButton1"
        '
        'NsOnOffBox1
        '
        Me.NsOnOffBox1.Checked = False
        Me.NsOnOffBox1.Location = New System.Drawing.Point(6, 35)
        Me.NsOnOffBox1.MaximumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.MinimumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.Name = "NsOnOffBox1"
        Me.NsOnOffBox1.Size = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.TabIndex = 1
        Me.NsOnOffBox1.Text = "NsOnOffBox1"
        '
        'NsCheckBox1
        '
        Me.NsCheckBox1.Checked = False
        Me.NsCheckBox1.Location = New System.Drawing.Point(6, 6)
        Me.NsCheckBox1.Name = "NsCheckBox1"
        Me.NsCheckBox1.Size = New System.Drawing.Size(112, 23)
        Me.NsCheckBox1.TabIndex = 0
        Me.NsCheckBox1.Text = "NsCheckBox1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(119, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(144, 194)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 380)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsGroupBox2.ResumeLayout(False)
        Me.NsGroupBox1.ResumeLayout(False)
        Me.NsTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents NsControlButton1 As NSControlButton
    Friend WithEvents NsGroupBox1 As NSGroupBox
    Friend WithEvents NsTextBox1 As NSTextBox
    Friend WithEvents NsGroupBox2 As NSGroupBox
    Friend WithEvents NsButton2 As NSButton
    Friend WithEvents NsTabControl1 As NSTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents NsOnOffBox1 As NSOnOffBox
    Friend WithEvents NsCheckBox1 As NSCheckBox
    Friend WithEvents TabPage2 As TabPage
End Class
