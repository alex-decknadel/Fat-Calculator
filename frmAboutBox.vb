'***************************************************************
' Programming Memester: Decknadel, Alex
' Chemeketa Community College
' Date: 03/21/2017
' Class: CIS133VB                 
' Assignment: Fat Calculator (Final Project)
' Filename: frmAboutBox.vb
' Description: Display an about box with application information.
'***************************************************************
Public NotInheritable Class frmAboutBox

    '***************************************************************
    ' Purpose: Display assembly information from the project's application properties.
    ' Assumes: Read project's assembly information.
    ' Returns: Fills in labels with data from assembly information.
    ' Effects: Displays information to the user.
    '***************************************************************
    Private Sub frmAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    '***************************************************************
    ' Purpose: Close the form.
    ' Inputs: Click button.
    ' Effects: Closes the form.
    '***************************************************************
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        OKButton.Click
        Me.Close()
    End Sub
End Class
