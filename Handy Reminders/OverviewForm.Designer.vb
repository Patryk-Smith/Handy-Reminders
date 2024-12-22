<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverviewForm
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
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("ListViewGroup", HorizontalAlignment.Left)
        Panel_CreateNewReminder = New Panel()
        ComboBox_AMPM = New ComboBox()
        CheckBox_Saturday = New CheckBox()
        CheckBox_Friday = New CheckBox()
        CheckBox_Thursday = New CheckBox()
        CheckBox_Wednesday = New CheckBox()
        CheckBox_Tuesday = New CheckBox()
        CheckBox_Monday = New CheckBox()
        CheckBox_Sunday = New CheckBox()
        Label_Name = New Label()
        TextBox_Name = New TextBox()
        Label5 = New Label()
        TextBox_ReminderMessage = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        CheckBox_Repeating = New CheckBox()
        Label2 = New Label()
        TextBox_Time = New TextBox()
        Button_AddReminder = New Button()
        Button_New = New Button()
        Label1 = New Label()
        ListView_ScheduledReminders = New ListView()
        ColumnHeader_Name = New ColumnHeader()
        Panel_CreateNewReminder.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_CreateNewReminder
        ' 
        Panel_CreateNewReminder.Controls.Add(ComboBox_AMPM)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Saturday)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Friday)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Thursday)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Wednesday)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Tuesday)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Monday)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Sunday)
        Panel_CreateNewReminder.Controls.Add(Label_Name)
        Panel_CreateNewReminder.Controls.Add(TextBox_Name)
        Panel_CreateNewReminder.Controls.Add(Label5)
        Panel_CreateNewReminder.Controls.Add(TextBox_ReminderMessage)
        Panel_CreateNewReminder.Controls.Add(Label4)
        Panel_CreateNewReminder.Controls.Add(Label3)
        Panel_CreateNewReminder.Controls.Add(CheckBox_Repeating)
        Panel_CreateNewReminder.Controls.Add(Label2)
        Panel_CreateNewReminder.Controls.Add(TextBox_Time)
        Panel_CreateNewReminder.Controls.Add(Button_AddReminder)
        Panel_CreateNewReminder.Location = New Point(376, 56)
        Panel_CreateNewReminder.Name = "Panel_CreateNewReminder"
        Panel_CreateNewReminder.Size = New Size(352, 271)
        Panel_CreateNewReminder.TabIndex = 2
        ' 
        ' ComboBox_AMPM
        ' 
        ComboBox_AMPM.FormattingEnabled = True
        ComboBox_AMPM.Items.AddRange(New Object() {"AM", "PM"})
        ComboBox_AMPM.Location = New Point(93, 158)
        ComboBox_AMPM.Name = "ComboBox_AMPM"
        ComboBox_AMPM.Size = New Size(52, 23)
        ComboBox_AMPM.TabIndex = 12
        ' 
        ' CheckBox_Saturday
        ' 
        CheckBox_Saturday.AutoSize = True
        CheckBox_Saturday.Location = New Point(151, 110)
        CheckBox_Saturday.Name = "CheckBox_Saturday"
        CheckBox_Saturday.Size = New Size(72, 19)
        CheckBox_Saturday.TabIndex = 10
        CheckBox_Saturday.Text = "Saturday"
        CheckBox_Saturday.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Friday
        ' 
        CheckBox_Friday.AutoSize = True
        CheckBox_Friday.Location = New Point(87, 110)
        CheckBox_Friday.Name = "CheckBox_Friday"
        CheckBox_Friday.Size = New Size(58, 19)
        CheckBox_Friday.TabIndex = 9
        CheckBox_Friday.Text = "Friday"
        CheckBox_Friday.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Thursday
        ' 
        CheckBox_Thursday.AutoSize = True
        CheckBox_Thursday.Location = New Point(7, 110)
        CheckBox_Thursday.Name = "CheckBox_Thursday"
        CheckBox_Thursday.Size = New Size(74, 19)
        CheckBox_Thursday.TabIndex = 8
        CheckBox_Thursday.Text = "Thursday"
        CheckBox_Thursday.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Wednesday
        ' 
        CheckBox_Wednesday.AutoSize = True
        CheckBox_Wednesday.Location = New Point(229, 85)
        CheckBox_Wednesday.Name = "CheckBox_Wednesday"
        CheckBox_Wednesday.Size = New Size(87, 19)
        CheckBox_Wednesday.TabIndex = 7
        CheckBox_Wednesday.Text = "Wednesday"
        CheckBox_Wednesday.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Tuesday
        ' 
        CheckBox_Tuesday.AutoSize = True
        CheckBox_Tuesday.Location = New Point(154, 85)
        CheckBox_Tuesday.Name = "CheckBox_Tuesday"
        CheckBox_Tuesday.Size = New Size(69, 19)
        CheckBox_Tuesday.TabIndex = 6
        CheckBox_Tuesday.Text = "Tuesday"
        CheckBox_Tuesday.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Monday
        ' 
        CheckBox_Monday.AutoSize = True
        CheckBox_Monday.Location = New Point(78, 85)
        CheckBox_Monday.Name = "CheckBox_Monday"
        CheckBox_Monday.Size = New Size(70, 19)
        CheckBox_Monday.TabIndex = 5
        CheckBox_Monday.Text = "Monday"
        CheckBox_Monday.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_Sunday
        ' 
        CheckBox_Sunday.AutoSize = True
        CheckBox_Sunday.Location = New Point(7, 85)
        CheckBox_Sunday.Name = "CheckBox_Sunday"
        CheckBox_Sunday.Size = New Size(65, 19)
        CheckBox_Sunday.TabIndex = 4
        CheckBox_Sunday.Text = "Sunday"
        CheckBox_Sunday.UseVisualStyleBackColor = True
        ' 
        ' Label_Name
        ' 
        Label_Name.AutoSize = True
        Label_Name.Location = New Point(7, 23)
        Label_Name.Name = "Label_Name"
        Label_Name.Size = New Size(39, 15)
        Label_Name.TabIndex = 17
        Label_Name.Text = "Name"' 
        ' TextBox_Name
        ' 
        TextBox_Name.Location = New Point(7, 41)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(147, 23)
        TextBox_Name.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 20
        Label5.Text = "Message"' 
        ' TextBox_ReminderMessage
        ' 
        TextBox_ReminderMessage.Location = New Point(7, 202)
        TextBox_ReminderMessage.Name = "TextBox_ReminderMessage"
        TextBox_ReminderMessage.Size = New Size(309, 23)
        TextBox_ReminderMessage.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 19
        Label4.Text = "Time of Day"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 18
        Label3.Text = "Day of Week"' 
        ' CheckBox_Repeating
        ' 
        CheckBox_Repeating.AutoSize = True
        CheckBox_Repeating.Location = New Point(237, 177)
        CheckBox_Repeating.Name = "CheckBox_Repeating"
        CheckBox_Repeating.Size = New Size(79, 19)
        CheckBox_Repeating.TabIndex = 13
        CheckBox_Repeating.Text = "Repeating"
        CheckBox_Repeating.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(111, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 15)
        Label2.TabIndex = 16
        Label2.Text = "Create New Reminder"' 
        ' TextBox_Time
        ' 
        TextBox_Time.Location = New Point(7, 158)
        TextBox_Time.Name = "TextBox_Time"
        TextBox_Time.Size = New Size(80, 23)
        TextBox_Time.TabIndex = 11
        TextBox_Time.Text = "HH:MM"' 
        ' Button_AddReminder
        ' 
        Button_AddReminder.Location = New Point(212, 231)
        Button_AddReminder.Name = "Button_AddReminder"
        Button_AddReminder.Size = New Size(104, 23)
        Button_AddReminder.TabIndex = 15
        Button_AddReminder.Text = "Add Reminder"
        Button_AddReminder.UseVisualStyleBackColor = True
        ' 
        ' Button_New
        ' 
        Button_New.Location = New Point(376, 27)
        Button_New.Name = "Button_New"
        Button_New.Size = New Size(75, 23)
        Button_New.TabIndex = 1
        Button_New.Text = "New..."
        Button_New.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 15)
        Label1.TabIndex = 98
        Label1.Text = "Scheduled Reminders"' 
        ' ListView_ScheduledReminders
        ' 
        ListView_ScheduledReminders.Columns.AddRange(New ColumnHeader() {ColumnHeader_Name})
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup_Reminders"
        ListView_ScheduledReminders.Groups.AddRange(New ListViewGroup() {ListViewGroup1})
        ListView_ScheduledReminders.HeaderStyle = ColumnHeaderStyle.None
        ListView_ScheduledReminders.Location = New Point(12, 27)
        ListView_ScheduledReminders.Name = "ListView_ScheduledReminders"
        ListView_ScheduledReminders.Size = New Size(358, 316)
        ListView_ScheduledReminders.TabIndex = 99
        ListView_ScheduledReminders.UseCompatibleStateImageBehavior = False
        ListView_ScheduledReminders.View = View.List
        ' 
        ' ColumnHeader_Name
        ' 
        ColumnHeader_Name.Text = "Name"' 
        ' OverviewForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button_New)
        Controls.Add(Label1)
        Controls.Add(ListView_ScheduledReminders)
        Controls.Add(Panel_CreateNewReminder)
        Name = "OverviewForm"
        Text = "OverviewForm"
        Panel_CreateNewReminder.ResumeLayout(False)
        Panel_CreateNewReminder.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel_CreateNewReminder As Panel
    Friend WithEvents CheckBox_Repeating As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Time As TextBox
    Friend WithEvents Button_AddReminder As Button
    Friend WithEvents Button_New As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView_ScheduledReminders As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_ReminderMessage As TextBox
    Friend WithEvents Label_Name As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents CheckBox_Saturday As CheckBox
    Friend WithEvents CheckBox_Friday As CheckBox
    Friend WithEvents CheckBox_Thursday As CheckBox
    Friend WithEvents CheckBox_Wednesday As CheckBox
    Friend WithEvents CheckBox_Tuesday As CheckBox
    Friend WithEvents CheckBox_Monday As CheckBox
    Friend WithEvents CheckBox_Sunday As CheckBox
    Friend WithEvents ComboBox_AMPM As ComboBox
    Friend WithEvents ColumnHeader_Name As ColumnHeader
End Class
