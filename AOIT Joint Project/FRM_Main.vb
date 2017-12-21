Imports System.IO

Public Class FRM_Main

#Region "Global Vars"
    Dim dblBirths As Double
    Dim dblDeaths As Double
    Dim dblTotalBirths As Double
    Dim dblTotalDeaths As Double
    Dim dblImmigrants As Double
    Dim dblEmigrants As Double
    Dim dblTotalPop As Double
#End Region

#Region "UI"
    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Application.Exit()
    End Sub
#End Region

#Region "Calculations"
    Private Sub btnCBR_Click(sender As Object, e As EventArgs) Handles btnCBR.Click
        Try
            If dblBirths = Nothing Then
                dblBirths = InputBox("How many births per 1,000 people per day?")
                lblBirths.Text = "Births: " & dblBirths
            End If

            txtOutput.Text &= "The crude birth rate is: " & Math.Round((dblBirths * 365), 4) / 1000 & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnCDR_Click(sender As Object, e As EventArgs) Handles btnCDR.Click
        Try
            If dblDeaths = Nothing Then
                dblDeaths = InputBox("How many deaths per 1,000 people per day?")
                lblDeaths.Text = "Deaths: " & dblDeaths
            End If

            txtOutput.Text &= "The crude death rate is: " & Math.Round((dblDeaths * 365) / 1000, 4) & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnABR_Click(sender As Object, e As EventArgs) Handles btnABR.Click
        Try
            If dblTotalBirths = Nothing Then
                dblTotalBirths = InputBox("How many births are there for the entire population per day?")
                lblTotalBirths.Text = "Total Births: " & dblTotalBirths
            End If

            If dblTotalPop = Nothing Then
                dblTotalPop = InputBox("What is the total population?")
                lblTotalPop.Text = "Total Population: " & dblTotalPop
            End If

            txtOutput.Text &= "The actual birth rate is: " & Math.Round(((dblTotalBirths * 365) * 100 / dblTotalPop), 4) & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnADR_Click(sender As Object, e As EventArgs) Handles btnADR.Click
        Try
            If dblTotalDeaths = Nothing Then
                dblTotalDeaths = InputBox("How many deaths are there for the entire population per day?")
                lblTotalDeaths.Text = "Total Deaths: " & dblTotalDeaths
            End If

            If dblTotalPop = Nothing Then
                dblTotalPop = InputBox("What is the total population?")
                lblTotalPop.Text = "Total Population: " & dblTotalPop
            End If

            txtOutput.Text &= "The actual death rate is: " & Math.Round(((dblTotalDeaths * 365)) * 100 / dblTotalPop, 4) & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnPopDensity_Click(sender As Object, e As EventArgs) Handles btnPopDensity.Click
        Try
            Dim intArea As Integer = InputBox("What is the area (square miles) of the land the population inhabits?")

            If dblTotalPop = Nothing Then
                dblTotalPop = InputBox("What is the total population?")
                lblTotalPop.Text = "Total Population: " & dblTotalPop
            End If

            txtOutput.Text &= "The population density is: " & Math.Round(dblTotalPop / intArea, 4) & " people per square mile" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnNaPopGrowth_Click(sender As Object, e As EventArgs) Handles btnNaPopGrowth.Click
        Try
            If dblImmigrants = Nothing Then
                dblImmigrants = InputBox("How many people immigrate per day?")
                lblImmigrants.Text = "Immigrants: " & dblImmigrants
            End If

            If dblEmigrants = Nothing Then
                dblEmigrants = InputBox("How many people emigrate per day?")
                lblEmigrants.Text = "Emigrants: " & dblEmigrants
            End If

            If dblDeaths = Nothing Then
                dblDeaths = InputBox("How many people die per day?")
                lblDeaths.Text = "Deaths: " & dblDeaths
            End If

            If dblBirths = Nothing Then
                dblBirths = InputBox("How many people are born per day?")
                lblBirths.Text = "Births: " & dblDeaths
            End If

            txtOutput.Text &= "The population growth of the county is: " & Math.Round((((dblBirths + dblImmigrants) - (dblDeaths + dblEmigrants)) / 10), 4) & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnGPopGrowth_Click(sender As Object, e As EventArgs) Handles btnGPopGrowth.Click
        Try
            Dim dblGBirths As Double = InputBox("What is the global birth rate?")
            Dim dblGDeaths As Double = InputBox("What is the global death rate?")

            dblGBirths = (dblGBirths * 365) / 1000
            dblGDeaths = (dblGDeaths * 365) / 1000

            txtOutput.Text &= "The global population growth rate is: " & Math.Round(((dblGBirths - dblGDeaths) / 10)) & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnNePopGrowth_Click(sender As Object, e As EventArgs) Handles btnNePopGrowth.Click
        Try
            If dblBirths = 0 Then
                dblBirths = InputBox("How many people are born per day?")
                lblBirths.Text = "Births: " & lblBirths.Text
            End If

            If dblDeaths = 0 Then
                dblDeaths = InputBox("How many people die per day?")
                lblDeaths.Text = "Deaths: " & lblDeaths.Text
            End If

            If dblTotalPop = Nothing Then
                dblTotalPop = InputBox("What is the total population?")
                lblTotalPop.Text = "Total Population: " & dblTotalPop
            End If

            txtOutput.Text &= "The population's net population growth is: " & Math.Round((((dblBirths * 365) - (dblDeaths * 365)) / dblTotalPop) * 100, 4) & "%" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnDblTime_Click(sender As Object, e As EventArgs) Handles btnDblTime.Click
        Try
            Dim dblNum As Double

            If dblTotalPop = Nothing Then
                dblTotalPop = InputBox("What is the total population?")
                lblTotalPop.Text = "Total Population: " & dblTotalPop
            End If

            If dblDeaths = Nothing Then
                dblDeaths = InputBox("How many people die per day?")
                lblDeaths.Text = "Deaths: " & dblDeaths
            End If

            If dblBirths = Nothing Then
                dblBirths = InputBox("How many people are born per day?")
                lblBirths.Text = "Births: " & dblDeaths
            End If

            dblNum = (((dblBirths * 365) - (dblDeaths * 365)) / dblTotalPop) * 100

            txtOutput.Text &= "The doubling time of the population is: " & Math.Round(70 / dblNum, 4) & " years" & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnFuture_Click(sender As Object, e As EventArgs) Handles btnFuture.Click
        Try
            Dim dblNum As Double
            Dim dblNatality As Double
            Dim dblFatality As Double

            If dblImmigrants = Nothing Then
                dblImmigrants = InputBox("How many people immigrate per day?")
                lblImmigrants.Text = "Immigrants: " & dblImmigrants
            End If

            If dblEmigrants = Nothing Then
                dblEmigrants = InputBox("How many people emigrate per day?")
                lblEmigrants.Text = "Emigrants: " & dblEmigrants
            End If

            If dblDeaths = Nothing Then
                dblDeaths = InputBox("How many people die per day?")
                lblDeaths.Text = "Deaths: " & dblDeaths
            End If

            If dblBirths = Nothing Then
                dblBirths = InputBox("How many people are born per day?")
                lblBirths.Text = "Births: " & dblDeaths
            End If

            If dblTotalPop = Nothing Then
                dblTotalPop = InputBox("What is the total population?")
                lblTotalPop.Text = "Total Population: " & dblTotalPop
            End If

            dblNatality = (dblTotalPop / (1000 * dblBirths))
            dblFatality = (dblTotalPop / (1000 * dblDeaths))

            dblNum = dblTotalPop + (dblNatality - dblFatality) + (dblImmigrants - dblEmigrants)

            txtOutput.Text &= "The future population is: " & Math.Round(dblNum, 4) & vbCrLf

        Catch ex As Exception
            MsgBox("Please enter numerical values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dblBirths = Nothing
        dblDeaths = Nothing
        dblTotalBirths = Nothing
        dblTotalDeaths = Nothing
        dblImmigrants = Nothing
        dblEmigrants = Nothing
        dblTotalPop = Nothing

        lblBirths.Text = "Births: N/A"
        lblDeaths.Text = "Deaths: N/A"
        lblTotalBirths.Text = "Total Births: N/A"
        lblTotalDeaths.Text = "Total Deaths: N/A"
        lblImmigrants.Text = "Immigrants: N/A"
        lblEmigrants.Text = "Emigrants: N/A"
        lblTotalPop.Text = "Total Population: N/A"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sfd As New SaveFileDialog
        sfd.Title = "Select Output Location"
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, txtOutput.Text)
        End If
    End Sub
#End Region

End Class
