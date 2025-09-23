Imports MySql.Data.MySqlClient

Public Class FrmMain

    Sub menus()


        If account_type = "Administrative" Then
            MenuAirCraft.Enabled = True

        ElseIf account_type = "direct sales employee" Then

            MenuAirCraft.Enabled = True
        ElseIf account_type = "cashier sales employee" Then
            MenuAirCraft.Enabled = False
        ElseIf account_type = "accountant" Then
            MenuAirCraft.Enabled = True
        ElseIf account_type = "sales revenue" Then
            MenuAirCraft.Enabled = True
        ElseIf account_type = "HR Officer" Then
            MenuAirCraft.Enabled = False
        ElseIf account_type = "store manager" Then
            MenuAirCraft.Enabled = True
        ElseIf account_type = "Stock manager" Then

            MenuAirCraft.Enabled = False

        End If


    End Sub
    Dim counter As Integer = 0

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconect_pool()
        myinformation.Text = store_name_arabic & " | Powered By Sameer Salih "
        menus()
        susername.Text = fullname
        sprint.Enabled = PrintPermisson
        sadd.Enabled = AddPermission
        sedit.Enabled = EditPermisson
        saddusers.Enabled = Add_usersPermission
        susername.Enabled = isActived
        sdelete.Enabled = DeletePermisson
        If Add_usersPermission = False Then MenuUsers.Enabled = False
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub MenuUsers_Click(sender As Object, e As EventArgs) Handles MenuUsers.Click
        trace("Open users Management window")

        FrmusersManagement.ShowDialog()
    End Sub

    Private Sub MenuPOS_Click(sender As Object, e As EventArgs) Handles MenuAirCraft.Click
        trace("Open Air Crafts List  : Username is :" & username)

        FrmAirCrafts.ShowDialog()
    End Sub

    Private Sub MenuCangePassowrd_Click(sender As Object, e As EventArgs) Handles MenuCangePassowrd.Click
        trace("Open Change Password Window")

        FrmChangePassword.ShowDialog()
    End Sub

    Private Sub MenuMainProductsCategory_Click(sender As Object, e As EventArgs) Handles MenuMainProductsCategory.Click
        FrmFlights.ShowDialog()

    End Sub




    Private Sub حToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حToolStripMenuItem.Click
        FrmAbout.ShowDialog()

    End Sub





    Private Sub MenuStock_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MnuBarcode_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MnuReportUsersSales_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myconect_pool()

    End Sub

    Private Sub Mnu_P_Wins_report_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MnuProductsAdded_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MnuReportSales_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MnuSellersReport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MnuUsersTrace_Click(sender As Object, e As EventArgs) Handles MnuUsersTrace.Click
        trace("Open Trace Report  : Username is :" & username)

        FrmTraceUsers.ShowDialog()

    End Sub


    Private Sub mnuStockStatus_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub MnuProductsQuantaty_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub MnuCenteralCollection_Click_1(sender As Object, e As EventArgs) Handles MnuCenteralCollection.Click
        FrmParts.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

    End Sub

    Private Sub CommandersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandersToolStripMenuItem.Click
        FrmCommanders.ShowDialog()

    End Sub

    Private Sub PailotsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PailotsToolStripMenuItem.Click
        FrmPilots.ShowDialog()

    End Sub

    Private Sub FixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixToolStripMenuItem.Click
        FrmFixing.ShowDialog()

    End Sub

    Private Sub FlightsReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlightsReportToolStripMenuItem.Click
        trace("Open Flight Report : Username is :" & username)

        Frm_Flights_Report.ShowDialog()

    End Sub

    Private Sub PartsReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsReportToolStripMenuItem.Click
        trace("try Add New Flight  : Username is :" & username)

    End Sub
End Class
