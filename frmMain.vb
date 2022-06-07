'***************************************************************
' Programming Memester: Decknadel, Alex
' Chemeketa Community College
' Date: 03/21/2017
' Class: CIS133VB                 
' Assignment: Fat Calculator (Final Project)
' Filename: frmMain.vb
' Description: This program will calculate the Basal Metabolic Rate,
'              Body Mass Index, Target Heart Rate, and Blood Alcohol,
'              Content using either the English system or Metric
'              system based on the user's input.
'***************************************************************
Public Class frmMain
    ' Class-level constant declarations.
    Const decSedCal As Decimal = 1.2        ' Sedentary factor for BMR
    Const decLightCal As Decimal = 1.375    ' Lightly active factor for BMR
    Const decModCal As Decimal = 1.55       ' Moderately active factor for BMR

    Const decVeryCal As Decimal = 1.725     ' Very active factor for BMR
    Const decExtraCal As Decimal = 1.9      ' Extra active factor for BMR

    Const decMale As Decimal = 0.68         ' Male factor for BAC
    Const decFemale As Decimal = 0.55       ' Female factor for BAC
    Const intAlcohol As Integer = 14        ' Alcohol content of drink in grams
    Const decConvert As Decimal = 453.59    ' Conversion for English weight

    ' Class-level variable declarations.
    Dim intBMR As Integer                   ' Calculation for BMR
    Dim decDCN As Decimal                   ' Calculation for DCN
    Dim decBMI As Decimal                   ' Calculation for BMI

    Dim intAge As Integer                   ' Age variable
    Dim intWeight As Integer                ' Weight variable
    Dim intHeight As Integer                ' Height variable
    Dim intHeartRate As Integer             ' Heart Rate variable
    Dim intConsumed As Integer              ' Number of standard drinks consumed
    Dim intHours As Integer                 ' Hours passed variable

    Dim decDose As Decimal                  ' Amount of alcohol ingested
    Dim decBodyGrams As Integer             ' Body weight in grams
    Dim decBAC As Decimal                   ' Calculation for BAC

    '***************************************************************
    ' Purpose: Change form text and menu option to English and clear form.
    ' Inputs: Click on menu item.
    ' Effects: Change text on form, check metric, and clear form.
    '***************************************************************
    Private Sub mnuOptionsEnglish_Click(sender As Object, e As EventArgs) Handles _
        mnuOptionsEnglish.Click
        ' Change text on form.
        lblWeight.Text = "Weight (lbs):"
        lblHeight.Text = "Height (in):"

        ' Uncheck the Metric option.
        mnuOptionsMetric.Checked = False

        ' Clear form.
        ClearForm()
    End Sub

    '***************************************************************
    ' Purpose: Change form text and menu option to Metric and clear form.
    ' Inputs: Click on menu item.
    ' Effects: Change text on form, check metric, and clear form.
    '***************************************************************
    Private Sub mnuOptionsMetric_Click(sender As Object, e As EventArgs) Handles _
        mnuOptionsMetric.Click
        ' Change text on form.
        lblWeight.Text = "Weight (kg):"
        lblHeight.Text = "Height (cm):"

        ' Uncheck the English option.
        mnuOptionsEnglish.Checked = False

        ' Clear form.
        ClearForm()
    End Sub

    '***************************************************************
    ' Purpose: Bring up the About window.
    ' Inputs: Click on menu item.
    ' Effects: Displays a window with application information.
    '***************************************************************
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles _
        mnuHelpAbout.Click
        Dim frmAboutBox As New frmAboutBox
        frmAboutBox.ShowDialog()
    End Sub

    '***************************************************************
    ' Purpose: Display a glossary to guide users.
    ' Inputs: Click on menu item.
    ' Effects: Displays a window with glossary.
    '***************************************************************
    Private Sub mnuHelpGlossary_Click(sender As Object, e As EventArgs) Handles _
        mnuHelpGlossary.Click
        Dim frmGlossary As New frmGlossary
        frmGlossary.ShowDialog()
    End Sub

    '***************************************************************
    ' Purpose: Close the form.
    ' Inputs: Click button.
    ' Effects: Closes the form.
    '***************************************************************
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
        mnuFileExit.Click
        Me.Close()
    End Sub

    '***************************************************************
    ' Purpose: Calculate and display the results.
    ' Inputs: Text box inputs, click on button.
    ' Assumes: Call on functions to calculate results.
    ' Effects: Results dislayed in Results group box, or error message shows.
    '***************************************************************
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles _
        btnCalculate.Click
        ' Input validation.
        If Validation() = True Then
            ' Get results.
            intBMR = CalculateBMR()
            decDCN = CalculateDCN()
            decBMI = CalculateBMI()
            intHeartRate = CalculateTarget()
            decBAC = CalculateBAC()

            ' Show results.
            lblBMR.Text = intBMR.ToString()
            lblDCN.Text = decDCN.ToString()
            lblBMI.Text = decBMI.ToString("n1")
            lblTarget.Text = intHeartRate.ToString()
            lblBAC.Text = decBAC.ToString("n3")
        End If
    End Sub

    '***************************************************************
    ' Purpose: Clears the form.
    ' Inputs: Click button.
    ' Effects: Clears the form.
    '***************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles _
        btnClear.Click
        ClearForm()
    End Sub

    '***************************************************************
    ' Purpose: Close the form.
    ' Inputs: Click button.
    ' Effects: Closes the form.
    '***************************************************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click
        Me.Close()
    End Sub

    '***************************************************************
    ' Purpose: Validate the user's input.
    ' Assumes: Test conversion of user input into variables, test radio
    '          button selection, test combo box selection.
    ' Returns: Create message boxes for errors found.
    ' Effects: Returns true or false.
    '***************************************************************
    Function Validation()
        ' Convert text box inputs.
        Try
            intWeight = CInt(txtWeight.Text)
            intHeight = CInt(txtHeight.Text)
            intAge = CInt(txtAge.Text)
            intConsumed = CInt(txtConsumed.Text)
            intHours = CInt(txtHours.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers in the text boxes.")
            Return False
        End Try

        ' Check to see if gender is selected.
        If (radMale.Checked = False) And (radFemale.Checked = False) Then
            MessageBox.Show("Please select a gender. " &
                            "Gender fluidity does not apply here.")
            Return False
        End If

        ' Check combo box selections.
        If cboActivity.SelectedIndex = -1 Then
            MessageBox.Show("Please select an activity level.")
            Return False
        ElseIf cboBeverage.SelectedIndex = -1 Then
            MessageBox.Show("Please select a beverage.")
            Return False
        End If

        Return True
    End Function

    '***************************************************************
    ' Purpose: Calculate the BMR of the user.
    ' Assumes: Check for errors, test condition of options selection,
    '          check the selected radio button.
    ' Returns: Assigns value to intBMR depending on option and radio button.
    ' Effects: BMR is calculated for the user or error message displays.
    '***************************************************************
    Function CalculateBMR()
        ' Check which system is checked.
        If mnuOptionsEnglish.Checked = True Then
            ' Check which gender is selected.
            If radFemale.Checked = True Then
                ' Calculate the BMR.
                intBMR = 655 + (4.35 * intWeight) + (4.7 * intHeight) -
                    (4.7 * intAge)
            ElseIf radMale.Checked = True Then
                intBMR = 66 + (6.23 * intWeight) + (12.7 * intHeight) -
                    (6.8 * intAge)
            End If
        ElseIf mnuOptionsMetric.Checked = True Then
            ' Check which gender is selected.
            If radFemale.Checked = True Then
                ' Calculate the BMR.
                intBMR = 655 + (9.6 * intWeight) + (1.8 * intHeight) -
                    (4.7 * intAge)
            ElseIf radMale.Checked = True Then
                intBMR = 66 + (13.7 * intWeight) + (5 * intHeight) -
                    (6.8 * intAge)
            End If
        Else
            ' Display error message.
            MessageBox.Show("There was an error calculating your BMR.")
        End If

        Return intBMR
    End Function

    '***************************************************************
    ' Purpose: Calculate the DCN of the user.
    ' Assumes: Test combo box selection with case statement.
    ' Returns: Assign value to decDCN depending on selection.
    ' Effects: DNC is calculated for the user or error message displays.
    '***************************************************************
    Function CalculateDCN()
        Select Case (cboActivity.SelectedIndex)
            Case 0                              ' Sedentary is selected.
                decDCN = intBMR * decSedCal
            Case 1                              ' Lightly active is selected.
                decDCN = intBMR * decLightCal
            Case 2                              ' Moderately active is selected.
                decDCN = intBMR * decModCal
            Case 3                              ' Very active is selected.
                decDCN = intBMR * decVeryCal
            Case 4                              ' Extra active is selected.
                decDCN = intBMR * decExtraCal
            Case Else                           ' Display error message.
                MessageBox.Show("There was an error calculating your DCN.")
        End Select

        Return decDCN
    End Function

    '***************************************************************
    ' Purpose: Calculate the BMI of the user.
    ' Assumes: Test options selection.
    ' Returns: Assign value to intBMI depending on selection.
    ' Effects: BMI is calculated for the user or error message displays.
    '***************************************************************
    Function CalculateBMI()
        If mnuOptionsEnglish.Checked = True Then
            ' Calculate the English BMI.
            decBMI = (intWeight * 703) / (intHeight * intHeight)
        ElseIf mnuOptionsMetric.Checked = True Then
            ' Calculate the Metric BMI.
            decBMI = intWeight / ((intHeight / 100) * (intHeight / 100))
        Else
            ' Display error message.
            MessageBox.Show("There was an error calculating your BMI.")
        End If

        Return decBMI
    End Function

    '***************************************************************
    ' Purpose: Calculate the heart rate of the user.
    ' Assumes: Subtract user's age from 220.
    ' Returns: Assign value to intHeartRate.
    ' Effects: Target Heart Rate is calculated or error message is displayed.
    '***************************************************************
    Function CalculateTarget()
        Try
            ' Calculate heart rate.
            intHeartRate = 220 - intAge
        Catch ex As Exception
            ' Display error message.
            MessageBox.Show("There was an error in calculating your Heart Rate.")
        End Try

        Return intHeartRate
    End Function

    '***************************************************************
    ' Purpose: Calculate the BAC of the user.
    ' Assumes: Test option selected, check gender, calculate alcohol dose
    '          through multiplication of drinks consumed and the constant
    '          for grams of alcohol, conver body weight to grams,
    '          calculate BAC with Widmark formula, test calculated BAC.
    ' Returns: Assign value to decBAC depending on selections.
    ' Effects: BAC is calculated and returned.
    '***************************************************************
    Function CalculateBAC()
        ' Calculate the alchohol consumed.
        decDose = intConsumed * intAlcohol

        ' Convert weight to grams.
        If mnuOptionsEnglish.Checked = True Then
            decBodyGrams = intWeight * decConvert
        ElseIf mnuOptionsMetric.Checked = True Then
            decBodyGrams = intWeight * 1000
        Else
            MessageBox.Show("There was an error calculating the " &
                            "body weight in grams.")
        End If

        ' Calculate the BAC.
        If radFemale.Checked = True Then
            decBAC = (decDose / (decBodyGrams * decFemale)) * 100 -
               (intHours * 0.015)
        ElseIf radMale.Checked = True Then
            decBAC = (decDose / (decBodyGrams * decMale)) * 100 -
                (intHours * 0.015)
        Else
            MessageBox.Show("There was an error calculating the BAC.")
        End If

        ' Ensure no negative BAC.
        If decBAC < 0 Then
            decBAC = 0
        End If

        Return decBAC
    End Function

    '***************************************************************
    ' Purpose: Clears the form.
    ' Effects: Clears the form.
    '***************************************************************
    Sub ClearForm()
        ' Clear all calculation labels.
        lblBAC.Text = String.Empty
        lblBMI.Text = String.Empty
        lblBMR.Text = String.Empty
        lblTarget.Text = String.Empty
        lblDCN.Text = String.Empty

        ' Clear text and combo boxes.
        cboActivity.SelectedIndex = -1
        cboBeverage.SelectedIndex = -1
        txtAge.Clear()
        txtConsumed.Clear()
        txtHeight.Clear()
        txtHours.Clear()
        txtWeight.Clear()
    End Sub
End Class