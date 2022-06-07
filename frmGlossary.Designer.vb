<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGlossary
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
        Me.lblBMR = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblTHR = New System.Windows.Forms.Label()
        Me.lblBAC = New System.Windows.Forms.Label()
        Me.gpbAbbreviations = New System.Windows.Forms.GroupBox()
        Me.lblGrams = New System.Windows.Forms.Label()
        Me.lblMeters = New System.Windows.Forms.Label()
        Me.lblDCN = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblCentimeters = New System.Windows.Forms.Label()
        Me.lblKilograms = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.gpbActivity = New System.Windows.Forms.GroupBox()
        Me.lblExtra = New System.Windows.Forms.Label()
        Me.lblVery = New System.Windows.Forms.Label()
        Me.lblModerate = New System.Windows.Forms.Label()
        Me.lblLight = New System.Windows.Forms.Label()
        Me.lblSedentary = New System.Windows.Forms.Label()
        Me.gpbBMR = New System.Windows.Forms.GroupBox()
        Me.lblMenMetricBMR = New System.Windows.Forms.Label()
        Me.lblMenEngBMR = New System.Windows.Forms.Label()
        Me.lblWomenMetricBMR = New System.Windows.Forms.Label()
        Me.lblWomenEngBMR = New System.Windows.Forms.Label()
        Me.gpbDCN = New System.Windows.Forms.GroupBox()
        Me.lblExtraFormula = New System.Windows.Forms.Label()
        Me.lblVeryFormula = New System.Windows.Forms.Label()
        Me.lblModerateFormula = New System.Windows.Forms.Label()
        Me.lblLightFormula = New System.Windows.Forms.Label()
        Me.lblSedentaryFormula = New System.Windows.Forms.Label()
        Me.gpbBMI = New System.Windows.Forms.GroupBox()
        Me.lblBMIMetric = New System.Windows.Forms.Label()
        Me.lblBMIEnglish = New System.Windows.Forms.Label()
        Me.gpbTHR = New System.Windows.Forms.GroupBox()
        Me.lblTargetFormula = New System.Windows.Forms.Label()
        Me.gpbBAC = New System.Windows.Forms.GroupBox()
        Me.lblMaleBAC = New System.Windows.Forms.Label()
        Me.lblFemaleBAC = New System.Windows.Forms.Label()
        Me.gpbAlcohol = New System.Windows.Forms.GroupBox()
        Me.lblAlcoholContent = New System.Windows.Forms.Label()
        Me.lblEnglishWeightGrams = New System.Windows.Forms.Label()
        Me.lblMetricWeightGrams = New System.Windows.Forms.Label()
        Me.gpbAbbreviations.SuspendLayout()
        Me.gpbActivity.SuspendLayout()
        Me.gpbBMR.SuspendLayout()
        Me.gpbDCN.SuspendLayout()
        Me.gpbBMI.SuspendLayout()
        Me.gpbTHR.SuspendLayout()
        Me.gpbBAC.SuspendLayout()
        Me.gpbAlcohol.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBMR
        '
        Me.lblBMR.AutoSize = True
        Me.lblBMR.Location = New System.Drawing.Point(6, 29)
        Me.lblBMR.Name = "lblBMR"
        Me.lblBMR.Size = New System.Drawing.Size(187, 17)
        Me.lblBMR.TabIndex = 2
        Me.lblBMR.Text = "Basal Metabolic Rate = BMR"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(6, 57)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(153, 17)
        Me.lblBMI.TabIndex = 3
        Me.lblBMI.Text = "Body Index Mass = BMI"
        '
        'lblTHR
        '
        Me.lblTHR.AutoSize = True
        Me.lblTHR.Location = New System.Drawing.Point(6, 85)
        Me.lblTHR.Name = "lblTHR"
        Me.lblTHR.Size = New System.Drawing.Size(168, 17)
        Me.lblTHR.TabIndex = 4
        Me.lblTHR.Text = "Target Heart Rate = THR"
        '
        'lblBAC
        '
        Me.lblBAC.AutoSize = True
        Me.lblBAC.Location = New System.Drawing.Point(6, 113)
        Me.lblBAC.Name = "lblBAC"
        Me.lblBAC.Size = New System.Drawing.Size(190, 17)
        Me.lblBAC.TabIndex = 5
        Me.lblBAC.Text = "Blood Alcohol Content = BAC"
        '
        'gpbAbbreviations
        '
        Me.gpbAbbreviations.BackColor = System.Drawing.SystemColors.Control
        Me.gpbAbbreviations.Controls.Add(Me.lblGrams)
        Me.gpbAbbreviations.Controls.Add(Me.lblMeters)
        Me.gpbAbbreviations.Controls.Add(Me.lblDCN)
        Me.gpbAbbreviations.Controls.Add(Me.lblInches)
        Me.gpbAbbreviations.Controls.Add(Me.lblBMR)
        Me.gpbAbbreviations.Controls.Add(Me.lblBAC)
        Me.gpbAbbreviations.Controls.Add(Me.lblCentimeters)
        Me.gpbAbbreviations.Controls.Add(Me.lblBMI)
        Me.gpbAbbreviations.Controls.Add(Me.lblTHR)
        Me.gpbAbbreviations.Controls.Add(Me.lblKilograms)
        Me.gpbAbbreviations.Controls.Add(Me.lblPounds)
        Me.gpbAbbreviations.Location = New System.Drawing.Point(33, 4)
        Me.gpbAbbreviations.Name = "gpbAbbreviations"
        Me.gpbAbbreviations.Size = New System.Drawing.Size(418, 166)
        Me.gpbAbbreviations.TabIndex = 6
        Me.gpbAbbreviations.TabStop = False
        Me.gpbAbbreviations.Text = "Abbreviations"
        '
        'lblGrams
        '
        Me.lblGrams.AutoSize = True
        Me.lblGrams.Location = New System.Drawing.Point(339, 29)
        Me.lblGrams.Name = "lblGrams"
        Me.lblGrams.Size = New System.Drawing.Size(74, 17)
        Me.lblGrams.TabIndex = 12
        Me.lblGrams.Text = "Grams = g"
        '
        'lblMeters
        '
        Me.lblMeters.AutoSize = True
        Me.lblMeters.Location = New System.Drawing.Point(216, 140)
        Me.lblMeters.Name = "lblMeters"
        Me.lblMeters.Size = New System.Drawing.Size(78, 17)
        Me.lblMeters.TabIndex = 11
        Me.lblMeters.Text = "Meters = m"
        '
        'lblDCN
        '
        Me.lblDCN.AutoSize = True
        Me.lblDCN.Location = New System.Drawing.Point(6, 140)
        Me.lblDCN.Name = "lblDCN"
        Me.lblDCN.Size = New System.Drawing.Size(170, 17)
        Me.lblDCN.TabIndex = 10
        Me.lblDCN.Text = "Daily Calorie Need = DCN"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(216, 85)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(76, 17)
        Me.lblInches.TabIndex = 9
        Me.lblInches.Text = "Inches = in"
        '
        'lblCentimeters
        '
        Me.lblCentimeters.AutoSize = True
        Me.lblCentimeters.Location = New System.Drawing.Point(216, 113)
        Me.lblCentimeters.Name = "lblCentimeters"
        Me.lblCentimeters.Size = New System.Drawing.Size(117, 17)
        Me.lblCentimeters.TabIndex = 8
        Me.lblCentimeters.Text = "Centimeters = cm"
        '
        'lblKilograms
        '
        Me.lblKilograms.AutoSize = True
        Me.lblKilograms.Location = New System.Drawing.Point(216, 57)
        Me.lblKilograms.Name = "lblKilograms"
        Me.lblKilograms.Size = New System.Drawing.Size(101, 17)
        Me.lblKilograms.TabIndex = 7
        Me.lblKilograms.Text = "Kilograms = kg"
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(216, 29)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(90, 17)
        Me.lblPounds.TabIndex = 6
        Me.lblPounds.Text = "Pounds = lbs"
        '
        'gpbActivity
        '
        Me.gpbActivity.BackColor = System.Drawing.SystemColors.Control
        Me.gpbActivity.Controls.Add(Me.lblExtra)
        Me.gpbActivity.Controls.Add(Me.lblVery)
        Me.gpbActivity.Controls.Add(Me.lblModerate)
        Me.gpbActivity.Controls.Add(Me.lblLight)
        Me.gpbActivity.Controls.Add(Me.lblSedentary)
        Me.gpbActivity.Location = New System.Drawing.Point(18, 180)
        Me.gpbActivity.Name = "gpbActivity"
        Me.gpbActivity.Size = New System.Drawing.Size(449, 176)
        Me.gpbActivity.TabIndex = 7
        Me.gpbActivity.TabStop = False
        Me.gpbActivity.Text = "Activity Levels"
        '
        'lblExtra
        '
        Me.lblExtra.AutoSize = True
        Me.lblExtra.Location = New System.Drawing.Point(7, 146)
        Me.lblExtra.Name = "lblExtra"
        Me.lblExtra.Size = New System.Drawing.Size(436, 17)
        Me.lblExtra.TabIndex = 4
        Me.lblExtra.Text = "Extra Active = Very hard exercise/sports && physical job or 2x training"
        '
        'lblVery
        '
        Me.lblVery.AutoSize = True
        Me.lblVery.Location = New System.Drawing.Point(6, 117)
        Me.lblVery.Name = "lblVery"
        Me.lblVery.Size = New System.Drawing.Size(320, 17)
        Me.lblVery.TabIndex = 3
        Me.lblVery.Text = "Very Active = Hard exercise/sports 6-7 days/week"
        '
        'lblModerate
        '
        Me.lblModerate.AutoSize = True
        Me.lblModerate.Location = New System.Drawing.Point(6, 88)
        Me.lblModerate.Name = "lblModerate"
        Me.lblModerate.Size = New System.Drawing.Size(390, 17)
        Me.lblModerate.TabIndex = 2
        Me.lblModerate.Text = "Moderately Active = Moderate exercise/sports 3-5 days/week"
        '
        'lblLight
        '
        Me.lblLight.AutoSize = True
        Me.lblLight.Location = New System.Drawing.Point(6, 59)
        Me.lblLight.Name = "lblLight"
        Me.lblLight.Size = New System.Drawing.Size(325, 17)
        Me.lblLight.TabIndex = 1
        Me.lblLight.Text = "Lightly Active = Light exerice/sports 1-3 days/week"
        '
        'lblSedentary
        '
        Me.lblSedentary.AutoSize = True
        Me.lblSedentary.Location = New System.Drawing.Point(6, 30)
        Me.lblSedentary.Name = "lblSedentary"
        Me.lblSedentary.Size = New System.Drawing.Size(203, 17)
        Me.lblSedentary.TabIndex = 0
        Me.lblSedentary.Text = "Sedentary: Little to no exercise"
        '
        'gpbBMR
        '
        Me.gpbBMR.BackColor = System.Drawing.SystemColors.Control
        Me.gpbBMR.Controls.Add(Me.lblMenMetricBMR)
        Me.gpbBMR.Controls.Add(Me.lblMenEngBMR)
        Me.gpbBMR.Controls.Add(Me.lblWomenMetricBMR)
        Me.gpbBMR.Controls.Add(Me.lblWomenEngBMR)
        Me.gpbBMR.Location = New System.Drawing.Point(39, 366)
        Me.gpbBMR.Name = "gpbBMR"
        Me.gpbBMR.Size = New System.Drawing.Size(407, 162)
        Me.gpbBMR.TabIndex = 8
        Me.gpbBMR.TabStop = False
        Me.gpbBMR.Text = "BMR Formulas"
        '
        'lblMenMetricBMR
        '
        Me.lblMenMetricBMR.AutoSize = True
        Me.lblMenMetricBMR.Location = New System.Drawing.Point(9, 128)
        Me.lblMenMetricBMR.Name = "lblMenMetricBMR"
        Me.lblMenMetricBMR.Size = New System.Drawing.Size(341, 17)
        Me.lblMenMetricBMR.TabIndex = 3
        Me.lblMenMetricBMR.Text = "Men (Metric): 66 + (13.7 x kg) + (5 x cm) - (6.8 x age)"
        '
        'lblMenEngBMR
        '
        Me.lblMenEngBMR.AutoSize = True
        Me.lblMenEngBMR.Location = New System.Drawing.Point(9, 95)
        Me.lblMenEngBMR.Name = "lblMenEngBMR"
        Me.lblMenEngBMR.Size = New System.Drawing.Size(369, 17)
        Me.lblMenEngBMR.TabIndex = 2
        Me.lblMenEngBMR.Text = "Men (English): 66 + (6.23 x lbs) + (12.7 x in) - (6.8 x age) "
        '
        'lblWomenMetricBMR
        '
        Me.lblWomenMetricBMR.AutoSize = True
        Me.lblWomenMetricBMR.Location = New System.Drawing.Point(9, 62)
        Me.lblWomenMetricBMR.Name = "lblWomenMetricBMR"
        Me.lblWomenMetricBMR.Size = New System.Drawing.Size(374, 17)
        Me.lblWomenMetricBMR.TabIndex = 1
        Me.lblWomenMetricBMR.Text = "Women (Metric): 655 + (9.6 x kg) + (1.8 x cm) - (4.7 x age)"
        '
        'lblWomenEngBMR
        '
        Me.lblWomenEngBMR.AutoSize = True
        Me.lblWomenEngBMR.Location = New System.Drawing.Point(9, 29)
        Me.lblWomenEngBMR.Name = "lblWomenEngBMR"
        Me.lblWomenEngBMR.Size = New System.Drawing.Size(386, 17)
        Me.lblWomenEngBMR.TabIndex = 0
        Me.lblWomenEngBMR.Text = "Women (English): 655 + (4.35 x lbs) + (4.7 x in) - (4.7 x age)"
        '
        'gpbDCN
        '
        Me.gpbDCN.BackColor = System.Drawing.SystemColors.Control
        Me.gpbDCN.Controls.Add(Me.lblExtraFormula)
        Me.gpbDCN.Controls.Add(Me.lblVeryFormula)
        Me.gpbDCN.Controls.Add(Me.lblModerateFormula)
        Me.gpbDCN.Controls.Add(Me.lblLightFormula)
        Me.gpbDCN.Controls.Add(Me.lblSedentaryFormula)
        Me.gpbDCN.Location = New System.Drawing.Point(67, 538)
        Me.gpbDCN.Name = "gpbDCN"
        Me.gpbDCN.Size = New System.Drawing.Size(350, 176)
        Me.gpbDCN.TabIndex = 9
        Me.gpbDCN.TabStop = False
        Me.gpbDCN.Text = "DCN Formulas (Harris Benedict Formula)"
        '
        'lblExtraFormula
        '
        Me.lblExtraFormula.AutoSize = True
        Me.lblExtraFormula.Location = New System.Drawing.Point(12, 146)
        Me.lblExtraFormula.Name = "lblExtraFormula"
        Me.lblExtraFormula.Size = New System.Drawing.Size(287, 17)
        Me.lblExtraFormula.TabIndex = 4
        Me.lblExtraFormula.Text = "Extra Active: Calorie Calculation = BMR x 1.9"
        '
        'lblVeryFormula
        '
        Me.lblVeryFormula.AutoSize = True
        Me.lblVeryFormula.Location = New System.Drawing.Point(12, 115)
        Me.lblVeryFormula.Name = "lblVeryFormula"
        Me.lblVeryFormula.Size = New System.Drawing.Size(300, 17)
        Me.lblVeryFormula.TabIndex = 3
        Me.lblVeryFormula.Text = "Very Active: Calorie Calculation = BMR x 1.725"
        '
        'lblModerateFormula
        '
        Me.lblModerateFormula.AutoSize = True
        Me.lblModerateFormula.Location = New System.Drawing.Point(12, 87)
        Me.lblModerateFormula.Name = "lblModerateFormula"
        Me.lblModerateFormula.Size = New System.Drawing.Size(333, 17)
        Me.lblModerateFormula.TabIndex = 2
        Me.lblModerateFormula.Text = "Moderately Active: Calorie Calculation = BMR x 1.55"
        '
        'lblLightFormula
        '
        Me.lblLightFormula.AutoSize = True
        Me.lblLightFormula.Location = New System.Drawing.Point(12, 58)
        Me.lblLightFormula.Name = "lblLightFormula"
        Me.lblLightFormula.Size = New System.Drawing.Size(312, 17)
        Me.lblLightFormula.TabIndex = 1
        Me.lblLightFormula.Text = "Lightly Active: Calorie Calculation = BMR x 1.375"
        '
        'lblSedentaryFormula
        '
        Me.lblSedentaryFormula.AutoSize = True
        Me.lblSedentaryFormula.Location = New System.Drawing.Point(12, 30)
        Me.lblSedentaryFormula.Name = "lblSedentaryFormula"
        Me.lblSedentaryFormula.Size = New System.Drawing.Size(278, 17)
        Me.lblSedentaryFormula.TabIndex = 0
        Me.lblSedentaryFormula.Text = "Sedentary: Calorie Calculation = BMR x 1.2"
        '
        'gpbBMI
        '
        Me.gpbBMI.BackColor = System.Drawing.SystemColors.Control
        Me.gpbBMI.Controls.Add(Me.lblBMIMetric)
        Me.gpbBMI.Controls.Add(Me.lblBMIEnglish)
        Me.gpbBMI.Location = New System.Drawing.Point(39, 724)
        Me.gpbBMI.Name = "gpbBMI"
        Me.gpbBMI.Size = New System.Drawing.Size(209, 94)
        Me.gpbBMI.TabIndex = 10
        Me.gpbBMI.TabStop = False
        Me.gpbBMI.Text = "BMI Formulas"
        '
        'lblBMIMetric
        '
        Me.lblBMIMetric.AutoSize = True
        Me.lblBMIMetric.Location = New System.Drawing.Point(10, 61)
        Me.lblBMIMetric.Name = "lblBMIMetric"
        Me.lblBMIMetric.Size = New System.Drawing.Size(127, 17)
        Me.lblBMIMetric.TabIndex = 1
        Me.lblBMIMetric.Text = "Metric: kg / (m x m)"
        '
        'lblBMIEnglish
        '
        Me.lblBMIEnglish.AutoSize = True
        Me.lblBMIEnglish.Location = New System.Drawing.Point(10, 29)
        Me.lblBMIEnglish.Name = "lblBMIEnglish"
        Me.lblBMIEnglish.Size = New System.Drawing.Size(186, 17)
        Me.lblBMIEnglish.TabIndex = 0
        Me.lblBMIEnglish.Text = "English: (lbs x 703) / (in x in)"
        '
        'gpbTHR
        '
        Me.gpbTHR.BackColor = System.Drawing.SystemColors.Control
        Me.gpbTHR.Controls.Add(Me.lblTargetFormula)
        Me.gpbTHR.Location = New System.Drawing.Point(276, 734)
        Me.gpbTHR.Name = "gpbTHR"
        Me.gpbTHR.Size = New System.Drawing.Size(170, 59)
        Me.gpbTHR.TabIndex = 11
        Me.gpbTHR.TabStop = False
        Me.gpbTHR.Text = "Target Heart Rate"
        '
        'lblTargetFormula
        '
        Me.lblTargetFormula.AutoSize = True
        Me.lblTargetFormula.Location = New System.Drawing.Point(10, 28)
        Me.lblTargetFormula.Name = "lblTargetFormula"
        Me.lblTargetFormula.Size = New System.Drawing.Size(154, 17)
        Me.lblTargetFormula.TabIndex = 0
        Me.lblTargetFormula.Text = "Heart Rate = 220 - age"
        '
        'gpbBAC
        '
        Me.gpbBAC.BackColor = System.Drawing.SystemColors.Control
        Me.gpbBAC.Controls.Add(Me.lblMaleBAC)
        Me.gpbBAC.Controls.Add(Me.lblFemaleBAC)
        Me.gpbBAC.Location = New System.Drawing.Point(42, 828)
        Me.gpbBAC.Name = "gpbBAC"
        Me.gpbBAC.Size = New System.Drawing.Size(401, 98)
        Me.gpbBAC.TabIndex = 12
        Me.gpbBAC.TabStop = False
        Me.gpbBAC.Text = "BAC Formula (Widmark Formula)"
        '
        'lblMaleBAC
        '
        Me.lblMaleBAC.AutoSize = True
        Me.lblMaleBAC.Location = New System.Drawing.Point(15, 61)
        Me.lblMaleBAC.Name = "lblMaleBAC"
        Me.lblMaleBAC.Size = New System.Drawing.Size(351, 17)
        Me.lblMaleBAC.TabIndex = 1
        Me.lblMaleBAC.Text = "Male: [Alcohol consumed (g) / (Weight (g) x .63)] x 100"
        '
        'lblFemaleBAC
        '
        Me.lblFemaleBAC.AutoSize = True
        Me.lblFemaleBAC.Location = New System.Drawing.Point(15, 28)
        Me.lblFemaleBAC.Name = "lblFemaleBAC"
        Me.lblFemaleBAC.Size = New System.Drawing.Size(367, 17)
        Me.lblFemaleBAC.TabIndex = 0
        Me.lblFemaleBAC.Text = "Female: [Alcohol consumed (g) / (Weight (g) x .55)] x 100"
        '
        'gpbAlcohol
        '
        Me.gpbAlcohol.BackColor = System.Drawing.SystemColors.Control
        Me.gpbAlcohol.Controls.Add(Me.lblMetricWeightGrams)
        Me.gpbAlcohol.Controls.Add(Me.lblEnglishWeightGrams)
        Me.gpbAlcohol.Controls.Add(Me.lblAlcoholContent)
        Me.gpbAlcohol.Location = New System.Drawing.Point(42, 938)
        Me.gpbAlcohol.Name = "gpbAlcohol"
        Me.gpbAlcohol.Size = New System.Drawing.Size(401, 111)
        Me.gpbAlcohol.TabIndex = 13
        Me.gpbAlcohol.TabStop = False
        Me.gpbAlcohol.Text = "Measurements Used to Calculate BAC"
        '
        'lblAlcoholContent
        '
        Me.lblAlcoholContent.AutoSize = True
        Me.lblAlcoholContent.Location = New System.Drawing.Point(15, 27)
        Me.lblAlcoholContent.Name = "lblAlcoholContent"
        Me.lblAlcoholContent.Size = New System.Drawing.Size(269, 17)
        Me.lblAlcoholContent.TabIndex = 0
        Me.lblAlcoholContent.Text = "Alcohol Content in a Standard Drink: 14 g"
        '
        'lblEnglishWeightGrams
        '
        Me.lblEnglishWeightGrams.AutoSize = True
        Me.lblEnglishWeightGrams.Location = New System.Drawing.Point(15, 54)
        Me.lblEnglishWeightGrams.Name = "lblEnglishWeightGrams"
        Me.lblEnglishWeightGrams.Size = New System.Drawing.Size(270, 17)
        Me.lblEnglishWeightGrams.TabIndex = 1
        Me.lblEnglishWeightGrams.Text = "Body Fat to Grams (English): lbs x 453.39"
        '
        'lblMetricWeightGrams
        '
        Me.lblMetricWeightGrams.AutoSize = True
        Me.lblMetricWeightGrams.Location = New System.Drawing.Point(15, 81)
        Me.lblMetricWeightGrams.Name = "lblMetricWeightGrams"
        Me.lblMetricWeightGrams.Size = New System.Drawing.Size(247, 17)
        Me.lblMetricWeightGrams.TabIndex = 2
        Me.lblMetricWeightGrams.Text = "Body Fat to Grams (Metric): kg x 1000"
        '
        'frmGlossary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(506, 511)
        Me.Controls.Add(Me.gpbAlcohol)
        Me.Controls.Add(Me.gpbBAC)
        Me.Controls.Add(Me.gpbTHR)
        Me.Controls.Add(Me.gpbBMI)
        Me.Controls.Add(Me.gpbDCN)
        Me.Controls.Add(Me.gpbBMR)
        Me.Controls.Add(Me.gpbActivity)
        Me.Controls.Add(Me.gpbAbbreviations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGlossary"
        Me.Text = "Glossary"
        Me.gpbAbbreviations.ResumeLayout(False)
        Me.gpbAbbreviations.PerformLayout()
        Me.gpbActivity.ResumeLayout(False)
        Me.gpbActivity.PerformLayout()
        Me.gpbBMR.ResumeLayout(False)
        Me.gpbBMR.PerformLayout()
        Me.gpbDCN.ResumeLayout(False)
        Me.gpbDCN.PerformLayout()
        Me.gpbBMI.ResumeLayout(False)
        Me.gpbBMI.PerformLayout()
        Me.gpbTHR.ResumeLayout(False)
        Me.gpbTHR.PerformLayout()
        Me.gpbBAC.ResumeLayout(False)
        Me.gpbBAC.PerformLayout()
        Me.gpbAlcohol.ResumeLayout(False)
        Me.gpbAlcohol.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBMR As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblTHR As Label
    Friend WithEvents lblBAC As Label
    Friend WithEvents gpbAbbreviations As GroupBox
    Friend WithEvents gpbActivity As GroupBox
    Friend WithEvents lblSedentary As Label
    Friend WithEvents lblLight As Label
    Friend WithEvents lblModerate As Label
    Friend WithEvents lblExtra As Label
    Friend WithEvents lblVery As Label
    Friend WithEvents gpbBMR As GroupBox
    Friend WithEvents lblWomenMetricBMR As Label
    Friend WithEvents lblWomenEngBMR As Label
    Friend WithEvents lblCentimeters As Label
    Friend WithEvents lblKilograms As Label
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents lblMenMetricBMR As Label
    Friend WithEvents lblMenEngBMR As Label
    Friend WithEvents gpbDCN As GroupBox
    Friend WithEvents lblDCN As Label
    Friend WithEvents lblLightFormula As Label
    Friend WithEvents lblSedentaryFormula As Label
    Friend WithEvents lblExtraFormula As Label
    Friend WithEvents lblVeryFormula As Label
    Friend WithEvents lblModerateFormula As Label
    Friend WithEvents gpbBMI As GroupBox
    Friend WithEvents lblBMIEnglish As Label
    Friend WithEvents lblMeters As Label
    Friend WithEvents lblBMIMetric As Label
    Friend WithEvents gpbTHR As GroupBox
    Friend WithEvents lblTargetFormula As Label
    Friend WithEvents gpbBAC As GroupBox
    Friend WithEvents lblFemaleBAC As Label
    Friend WithEvents lblGrams As Label
    Friend WithEvents lblMaleBAC As Label
    Friend WithEvents gpbAlcohol As GroupBox
    Friend WithEvents lblAlcoholContent As Label
    Friend WithEvents lblEnglishWeightGrams As Label
    Friend WithEvents lblMetricWeightGrams As Label
End Class
