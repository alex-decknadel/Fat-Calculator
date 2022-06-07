<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.gpbUserInfo = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.cboActivity = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.gpbAlcohol = New System.Windows.Forms.GroupBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtConsumed = New System.Windows.Forms.TextBox()
        Me.cboBeverage = New System.Windows.Forms.ComboBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblConsumed = New System.Windows.Forms.Label()
        Me.lblBeverage = New System.Windows.Forms.Label()
        Me.gpbResults = New System.Windows.Forms.GroupBox()
        Me.lblDCN = New System.Windows.Forms.Label()
        Me.lblDCNTitle = New System.Windows.Forms.Label()
        Me.lblBAC = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblBacTitle = New System.Windows.Forms.Label()
        Me.lblTargetTitle = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblBmiTitle = New System.Windows.Forms.Label()
        Me.lblBMR = New System.Windows.Forms.Label()
        Me.lblBmrTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsMetric = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpGlossary = New System.Windows.Forms.ToolStripMenuItem()
        Me.tolMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.gpbUserInfo.SuspendLayout()
        Me.gpbAlcohol.SuspendLayout()
        Me.gpbResults.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbUserInfo
        '
        Me.gpbUserInfo.Controls.Add(Me.radFemale)
        Me.gpbUserInfo.Controls.Add(Me.radMale)
        Me.gpbUserInfo.Controls.Add(Me.txtAge)
        Me.gpbUserInfo.Controls.Add(Me.txtHeight)
        Me.gpbUserInfo.Controls.Add(Me.txtWeight)
        Me.gpbUserInfo.Controls.Add(Me.lblActivity)
        Me.gpbUserInfo.Controls.Add(Me.cboActivity)
        Me.gpbUserInfo.Controls.Add(Me.lblGender)
        Me.gpbUserInfo.Controls.Add(Me.lblAge)
        Me.gpbUserInfo.Controls.Add(Me.lblHeight)
        Me.gpbUserInfo.Controls.Add(Me.lblWeight)
        Me.gpbUserInfo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbUserInfo.Location = New System.Drawing.Point(12, 50)
        Me.gpbUserInfo.Name = "gpbUserInfo"
        Me.gpbUserInfo.Size = New System.Drawing.Size(375, 197)
        Me.gpbUserInfo.TabIndex = 0
        Me.gpbUserInfo.TabStop = False
        Me.gpbUserInfo.Text = "User Information"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(271, 133)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(83, 21)
        Me.radFemale.TabIndex = 11
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.tolMain.SetToolTip(Me.radFemale, "This will not consider gender fluidity. Ever.")
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(171, 133)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(65, 21)
        Me.radMale.TabIndex = 10
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.tolMain.SetToolTip(Me.radMale, "This will not consider gender fluidity. Ever.")
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(171, 99)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(134, 24)
        Me.txtAge.TabIndex = 9
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tolMain.SetToolTip(Me.txtAge, "How old you are")
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(171, 66)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(134, 24)
        Me.txtHeight.TabIndex = 8
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tolMain.SetToolTip(Me.txtHeight, "Your height in inches or centimeters")
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(171, 33)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(134, 24)
        Me.txtWeight.TabIndex = 7
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tolMain.SetToolTip(Me.txtWeight, "Your weight in either pounds or kilograms")
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.Location = New System.Drawing.Point(13, 168)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(143, 17)
        Me.lblActivity.TabIndex = 5
        Me.lblActivity.Text = "Activity Level:"
        Me.tolMain.SetToolTip(Me.lblActivity, "More explaination on Activity Level in the About window")
        '
        'cboActivity
        '
        Me.cboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActivity.FormattingEnabled = True
        Me.cboActivity.Items.AddRange(New Object() {"Sedentary", "Lightly Active", "Moderately Active", "Very Active", "Extra Active"})
        Me.cboActivity.Location = New System.Drawing.Point(171, 165)
        Me.cboActivity.Name = "cboActivity"
        Me.cboActivity.Size = New System.Drawing.Size(183, 25)
        Me.cboActivity.TabIndex = 4
        Me.tolMain.SetToolTip(Me.cboActivity, "More explaination on Activity Level in the Glossary")
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(85, 135)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(71, 17)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblGender, "This will not consider gender fluidity. Ever.")
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(116, 102)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 17)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblAge, "How old you are")
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(40, 69)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(116, 17)
        Me.lblHeight.TabIndex = 1
        Me.lblHeight.Text = "Height (in):"
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblHeight, "Your height in inches or centimeters")
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(31, 36)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(125, 17)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Weight (lbs):"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblWeight, "Your weight in either pounds or kilograms")
        '
        'gpbAlcohol
        '
        Me.gpbAlcohol.Controls.Add(Me.txtHours)
        Me.gpbAlcohol.Controls.Add(Me.txtConsumed)
        Me.gpbAlcohol.Controls.Add(Me.cboBeverage)
        Me.gpbAlcohol.Controls.Add(Me.lblHours)
        Me.gpbAlcohol.Controls.Add(Me.lblConsumed)
        Me.gpbAlcohol.Controls.Add(Me.lblBeverage)
        Me.gpbAlcohol.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAlcohol.Location = New System.Drawing.Point(12, 275)
        Me.gpbAlcohol.Name = "gpbAlcohol"
        Me.gpbAlcohol.Size = New System.Drawing.Size(354, 144)
        Me.gpbAlcohol.TabIndex = 1
        Me.gpbAlcohol.TabStop = False
        Me.gpbAlcohol.Text = "Alcohol Level Information"
        Me.tolMain.SetToolTip(Me.gpbAlcohol, "Current Blood Alcohol Content")
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(159, 105)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(146, 24)
        Me.txtHours.TabIndex = 5
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tolMain.SetToolTip(Me.txtHours, "Hours elapsed since you started drinking")
        '
        'txtConsumed
        '
        Me.txtConsumed.Location = New System.Drawing.Point(159, 70)
        Me.txtConsumed.Name = "txtConsumed"
        Me.txtConsumed.Size = New System.Drawing.Size(146, 24)
        Me.txtConsumed.TabIndex = 4
        Me.txtConsumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tolMain.SetToolTip(Me.txtConsumed, "The number of drinks you've consumed")
        '
        'cboBeverage
        '
        Me.cboBeverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBeverage.FormattingEnabled = True
        Me.cboBeverage.Items.AddRange(New Object() {"Liquer (1.5oz; 40%)", "Beer (12 oz; 5%)", "Wine (5 oz; 12%)"})
        Me.cboBeverage.Location = New System.Drawing.Point(159, 35)
        Me.cboBeverage.Name = "cboBeverage"
        Me.cboBeverage.Size = New System.Drawing.Size(176, 25)
        Me.cboBeverage.TabIndex = 3
        Me.tolMain.SetToolTip(Me.cboBeverage, "Displays standard drink size and alcohol content")
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(28, 108)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(125, 17)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Time Elapsed:"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblHours, "Hours elapsed since you started drinking")
        '
        'lblConsumed
        '
        Me.lblConsumed.AutoSize = True
        Me.lblConsumed.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsumed.Location = New System.Drawing.Point(4, 73)
        Me.lblConsumed.Name = "lblConsumed"
        Me.lblConsumed.Size = New System.Drawing.Size(152, 17)
        Me.lblConsumed.TabIndex = 1
        Me.lblConsumed.Text = "Number Consumed:"
        Me.lblConsumed.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblConsumed, "The number of drinks you've consumed")
        '
        'lblBeverage
        '
        Me.lblBeverage.AutoSize = True
        Me.lblBeverage.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeverage.Location = New System.Drawing.Point(67, 38)
        Me.lblBeverage.Name = "lblBeverage"
        Me.lblBeverage.Size = New System.Drawing.Size(89, 17)
        Me.lblBeverage.TabIndex = 0
        Me.lblBeverage.Text = "Beverage:"
        Me.lblBeverage.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblBeverage, "Liquer is alcohol like Gin and Whiskey")
        '
        'gpbResults
        '
        Me.gpbResults.Controls.Add(Me.lblDCN)
        Me.gpbResults.Controls.Add(Me.lblDCNTitle)
        Me.gpbResults.Controls.Add(Me.lblBAC)
        Me.gpbResults.Controls.Add(Me.lblTarget)
        Me.gpbResults.Controls.Add(Me.lblBacTitle)
        Me.gpbResults.Controls.Add(Me.lblTargetTitle)
        Me.gpbResults.Controls.Add(Me.lblBMI)
        Me.gpbResults.Controls.Add(Me.lblBmiTitle)
        Me.gpbResults.Controls.Add(Me.lblBMR)
        Me.gpbResults.Controls.Add(Me.lblBmrTitle)
        Me.gpbResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbResults.Location = New System.Drawing.Point(397, 275)
        Me.gpbResults.Name = "gpbResults"
        Me.gpbResults.Size = New System.Drawing.Size(203, 213)
        Me.gpbResults.TabIndex = 2
        Me.gpbResults.TabStop = False
        Me.gpbResults.Text = "Calculation Results"
        '
        'lblDCN
        '
        Me.lblDCN.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblDCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDCN.Location = New System.Drawing.Point(63, 68)
        Me.lblDCN.Name = "lblDCN"
        Me.lblDCN.Size = New System.Drawing.Size(124, 23)
        Me.lblDCN.TabIndex = 11
        Me.lblDCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tolMain.SetToolTip(Me.lblDCN, "Daily Calorie Needs")
        '
        'lblDCNTitle
        '
        Me.lblDCNTitle.AutoSize = True
        Me.lblDCNTitle.Location = New System.Drawing.Point(15, 71)
        Me.lblDCNTitle.Name = "lblDCNTitle"
        Me.lblDCNTitle.Size = New System.Drawing.Size(44, 17)
        Me.lblDCNTitle.TabIndex = 10
        Me.lblDCNTitle.Text = "DCN:"
        Me.lblDCNTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblDCNTitle, "Daily Calorie Needs")
        '
        'lblBAC
        '
        Me.lblBAC.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblBAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBAC.Location = New System.Drawing.Point(63, 176)
        Me.lblBAC.Name = "lblBAC"
        Me.lblBAC.Size = New System.Drawing.Size(124, 23)
        Me.lblBAC.TabIndex = 7
        Me.lblBAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tolMain.SetToolTip(Me.lblBAC, "Blood Alcohol Content")
        '
        'lblTarget
        '
        Me.lblTarget.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTarget.Location = New System.Drawing.Point(63, 140)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(124, 23)
        Me.lblTarget.TabIndex = 6
        Me.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tolMain.SetToolTip(Me.lblTarget, "Target Heart Rate")
        '
        'lblBacTitle
        '
        Me.lblBacTitle.AutoSize = True
        Me.lblBacTitle.Location = New System.Drawing.Point(15, 179)
        Me.lblBacTitle.Name = "lblBacTitle"
        Me.lblBacTitle.Size = New System.Drawing.Size(44, 17)
        Me.lblBacTitle.TabIndex = 5
        Me.lblBacTitle.Text = "BAC:"
        Me.lblBacTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblBacTitle, "Blood Alcohol Content")
        '
        'lblTargetTitle
        '
        Me.lblTargetTitle.AutoSize = True
        Me.lblTargetTitle.Location = New System.Drawing.Point(15, 143)
        Me.lblTargetTitle.Name = "lblTargetTitle"
        Me.lblTargetTitle.Size = New System.Drawing.Size(44, 17)
        Me.lblTargetTitle.TabIndex = 4
        Me.lblTargetTitle.Text = "THR:"
        Me.tolMain.SetToolTip(Me.lblTargetTitle, "Target Heart Rate")
        '
        'lblBMI
        '
        Me.lblBMI.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBMI.Location = New System.Drawing.Point(63, 104)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(124, 23)
        Me.lblBMI.TabIndex = 3
        Me.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tolMain.SetToolTip(Me.lblBMI, "Body Mass Index")
        '
        'lblBmiTitle
        '
        Me.lblBmiTitle.AutoSize = True
        Me.lblBmiTitle.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBmiTitle.Location = New System.Drawing.Point(15, 107)
        Me.lblBmiTitle.Name = "lblBmiTitle"
        Me.lblBmiTitle.Size = New System.Drawing.Size(44, 17)
        Me.lblBmiTitle.TabIndex = 2
        Me.lblBmiTitle.Text = "BMI:"
        Me.lblBmiTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblBmiTitle, "Body Mass Index")
        '
        'lblBMR
        '
        Me.lblBMR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblBMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBMR.Location = New System.Drawing.Point(63, 32)
        Me.lblBMR.Name = "lblBMR"
        Me.lblBMR.Size = New System.Drawing.Size(124, 23)
        Me.lblBMR.TabIndex = 1
        Me.lblBMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tolMain.SetToolTip(Me.lblBMR, "Basal Metabolic Rate")
        '
        'lblBmrTitle
        '
        Me.lblBmrTitle.AutoSize = True
        Me.lblBmrTitle.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBmrTitle.Location = New System.Drawing.Point(15, 35)
        Me.lblBmrTitle.Name = "lblBmrTitle"
        Me.lblBmrTitle.Size = New System.Drawing.Size(44, 17)
        Me.lblBmrTitle.TabIndex = 0
        Me.lblBmrTitle.Text = "BMR:"
        Me.lblBmrTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tolMain.SetToolTip(Me.lblBmrTitle, "Basal Metabolic Rate")
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(432, 50)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(168, 39)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.tolMain.SetToolTip(Me.btnCalculate, "Click to calculate results")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(432, 108)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 39)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.tolMain.SetToolTip(Me.btnClear, "Click to clear the form")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(432, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.tolMain.SetToolTip(Me.btnExit, "Click to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOptions, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(612, 28)
        Me.mnuMain.TabIndex = 6
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(161, 26)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsEnglish, Me.mnuOptionsMetric})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(73, 24)
        Me.mnuOptions.Text = "Options"
        '
        'mnuOptionsEnglish
        '
        Me.mnuOptionsEnglish.Checked = True
        Me.mnuOptionsEnglish.CheckOnClick = True
        Me.mnuOptionsEnglish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuOptionsEnglish.Name = "mnuOptionsEnglish"
        Me.mnuOptionsEnglish.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuOptionsEnglish.Size = New System.Drawing.Size(155, 26)
        Me.mnuOptionsEnglish.Text = "&English"
        '
        'mnuOptionsMetric
        '
        Me.mnuOptionsMetric.CheckOnClick = True
        Me.mnuOptionsMetric.Name = "mnuOptionsMetric"
        Me.mnuOptionsMetric.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuOptionsMetric.Size = New System.Drawing.Size(155, 26)
        Me.mnuOptionsMetric.Text = "&Metric"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout, Me.mnuHelpGlossary})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpAbout.Size = New System.Drawing.Size(163, 26)
        Me.mnuHelpAbout.Text = "&About"
        '
        'mnuHelpGlossary
        '
        Me.mnuHelpGlossary.Name = "mnuHelpGlossary"
        Me.mnuHelpGlossary.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuHelpGlossary.Size = New System.Drawing.Size(163, 26)
        Me.mnuHelpGlossary.Text = "Glossary"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(612, 530)
        Me.Controls.Add(Me.gpbAlcohol)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gpbResults)
        Me.Controls.Add(Me.gpbUserInfo)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Fat Calculator"
        Me.gpbUserInfo.ResumeLayout(False)
        Me.gpbUserInfo.PerformLayout()
        Me.gpbAlcohol.ResumeLayout(False)
        Me.gpbAlcohol.PerformLayout()
        Me.gpbResults.ResumeLayout(False)
        Me.gpbResults.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbUserInfo As GroupBox
    Friend WithEvents gpbAlcohol As GroupBox
    Friend WithEvents gpbResults As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuOptionsEnglish As ToolStripMenuItem
    Friend WithEvents mnuOptionsMetric As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblActivity As Label
    Friend WithEvents cboActivity As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblConsumed As Label
    Friend WithEvents lblBeverage As Label
    Friend WithEvents txtConsumed As TextBox
    Friend WithEvents cboBeverage As ComboBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblBMI As Label
    Friend WithEvents tolMain As ToolTip
    Friend WithEvents lblBmiTitle As Label
    Friend WithEvents lblBMR As Label
    Friend WithEvents lblBmrTitle As Label
    Friend WithEvents lblTargetTitle As Label
    Friend WithEvents lblBacTitle As Label
    Friend WithEvents lblBAC As Label
    Friend WithEvents lblTarget As Label
    Friend WithEvents mnuHelpGlossary As ToolStripMenuItem
    Friend WithEvents lblDCN As Label
    Friend WithEvents lblDCNTitle As Label
End Class
