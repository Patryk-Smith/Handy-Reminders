Public Class OverviewForm
    Public Property WorkingThread As System.Threading.Thread
    Public Property VisualThread As System.Threading.Thread
    Private Sub AddReminderToList(sender As Object, e As EventArgs) Handles Button_AddReminder.Click

        Dim ReminderToAdd As New ListViewReminder()

        Dim AMPMText As String = Nothing
        Try
            AMPMText = ComboBox_AMPM.SelectedText
        Catch ex1 As Exception
            Try
                AMPMText = ComboBox_AMPM.Text
            Catch ex2 As Exception
                MsgBox("Please enter AM or PM in the form!", MsgBoxStyle.Critical, "Input Error!")
            End Try
        End Try

        If DataEnteredIsBad(TextBox_Time.Text, AMPMText) Then
            Exit Sub
        End If

        ReminderToAdd.Message = TextBox_ReminderMessage.Text
        ReminderToAdd.IsRepeatative = CheckBox_Repeating.Checked
        ReminderToAdd.ReminderDays = New List(Of String)

        If (CheckBox_Sunday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Sunday")
        End If
        If (CheckBox_Monday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Monday")
        End If
        If (CheckBox_Tuesday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Tuesday")
        End If
        If (CheckBox_Wednesday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Wednesday")
        End If
        If (CheckBox_Thursday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Thursday")
        End If
        If (CheckBox_Friday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Friday")
        End If
        If (CheckBox_Saturday.Checked) Then
            ReminderToAdd.ReminderDays.Add("Saturday")
        End If

        ReminderToAdd.ReminderTime = GetTimeFromStringFormat(TextBox_Time.Text)

        ReminderToAdd.Title = TextBox_Name.Text

        'To Show up in Listview
        Dim ListViewItemToAdd As ListViewItem = New ListViewItem
        ListViewItemToAdd.Name = ReminderToAdd.UUID.ToString()
        ListViewItemToAdd.Text = ReminderToAdd.Title

        Me.ListView_ScheduledReminders.Items.Add(ListViewItemToAdd)

        Me.Panel_CreateNewReminder.Hide()
    End Sub

    Private Sub OverviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iconHandle As IntPtr = My.Resources.Resources.main_icon.GetHicon()
        Me.Icon = Icon.FromHandle(iconHandle)

        Application.EnableVisualStyles()

        Me.ListView_ScheduledReminders.Items.Clear()
        Me.Panel_CreateNewReminder.Hide()
    End Sub

    Private Sub CreateNewReminder(sender As Object, e As EventArgs) Handles Button_New.Click, Button_New.Click
        Me.Panel_CreateNewReminder.Show()
    End Sub
End Class