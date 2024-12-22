Imports System.IO
Imports System.Xml
Public Module Main
    Public Property Overview As OverviewForm
    Public Property SavedReminders As Dictionary(Of String, ListViewReminder)


    Public DEFAULT_REMINDER_DIRECTORY As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString() & "\AppData\Roaming\Handy Reminders"
    Public DEFAULT_REMINDER_XML_FILE As String = DEFAULT_REMINDER_DIRECTORY & "\ReminderList.xml"

    Public Sub Main()
        Overview = New OverviewForm()
        SavedReminders = New Dictionary(Of String, ListViewReminder)

        EnsureProperFolderStructure()

        'LoadSavedRemindersFromFile()

        Dim ReminderToAdd As New ListViewReminder
        ' StartOverviewWindow()
        ReminderToAdd.Message = "Testing out a new item."
        ReminderToAdd.IsRepeatative = True
        ReminderToAdd.ReminderDays = New List(Of String) From {
                "Sunday",
                "Thursday"
            }
        ReminderToAdd.ReminderTime = GetTimeFromStringFormat("5:00")

        ReminderToAdd.Title = "My First Reminder"

        'To Show up in Listview 

        SavedReminders.Add(ReminderToAdd.UUID.ToString(), ReminderToAdd)

        SaveRemindersToFile()

    End Sub

    Public Sub EnsureProperFolderStructure()
        If Not (Directory.Exists(DEFAULT_REMINDER_DIRECTORY)) Then
            Debug.WriteLine("Creaing new directory " & DEFAULT_REMINDER_DIRECTORY & "... ")
            Directory.CreateDirectory(DEFAULT_REMINDER_DIRECTORY)
        End If

        If Not (File.Exists(DEFAULT_REMINDER_XML_FILE)) Then
            Debug.WriteLine("Creaing new file " & DEFAULT_REMINDER_XML_FILE & "... ")
            File.Create(DEFAULT_REMINDER_XML_FILE)
        End If

    End Sub

    Public Sub LoadSavedRemindersFromFile()
        Dim ReminderXMLSerializer As System.Xml.Serialization.XmlSerializer
        Dim ReminderXMLStreamReader As StreamReader
        Dim mySavedReminders As New ReminderList()
        Dim types() As Type = {
            GetType(ReminderList),
            GetType(ListViewReminder),
            GetType(List(Of KeyValueElement)),
            GetType(KeyValueElement),
            GetType(UniqueId),
            GetType(TimeSpan)
        }
        Try
            ReminderXMLSerializer = New System.Xml.Serialization.XmlSerializer(mySavedReminders.SerializableReminders.GetType(), types)
            ReminderXMLStreamReader = New System.IO.StreamReader(DEFAULT_REMINDER_XML_FILE)
            mySavedReminders.SerializableReminders = ReminderXMLSerializer.Deserialize(ReminderXMLStreamReader)
            SavedReminders = mySavedReminders.Reminders
            ReminderXMLStreamReader.Close()
        Catch ex As Exception
            Debug.WriteLine("Failed to load saved reminders!")
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Sub SaveRemindersToFile()
        Dim ReminderXMLSerializer As System.Xml.Serialization.XmlSerializer
        Dim ReminderXMLStreamWriter As StreamWriter
        Dim mySavedReminders As New ReminderList(SavedReminders)
        Dim types() As Type = {
            GetType(ReminderList),
            GetType(ListViewReminder),
            GetType(List(Of KeyValueElement)),
            GetType(KeyValueElement),
            GetType(UniqueId),
            GetType(TimeSpan)
        }

        Try
            ReminderXMLStreamWriter = New System.IO.StreamWriter(DEFAULT_REMINDER_XML_FILE)
            ReminderXMLSerializer = New System.Xml.Serialization.XmlSerializer(mySavedReminders.SerializableReminders.GetType(), types)
            ReminderXMLSerializer.Serialize(ReminderXMLStreamWriter, mySavedReminders.SerializableReminders)
            ReminderXMLStreamWriter.Close()
        Catch ex As Exception
            Debug.WriteLine("Failed to save reminders!")
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(ex.StackTrace)
            Debug.WriteLine(ex.InnerException.Message)
            Debug.WriteLine(ex.InnerException.StackTrace)
        End Try
    End Sub

    Public Function GetTimeFromStringFormat(StringToConvert As String) As TimeSpan
        Dim TimeToReturn As TimeSpan = Nothing

        Dim NewHours As Integer = Nothing
        Dim NewMinutes As Integer = Nothing

        ' TODO: Check 24 hour time vs 12 hour time and adjust AM/PM accordingly
        If (StringToConvert Like "####") Then
            NewHours = StringToConvert.Substring(0, 2)
            NewMinutes = StringToConvert.Substring(2)
        End If

        If (StringToConvert Like "##:##" Or StringToConvert Like "#:##") Then
            NewHours = StringToConvert.Split(":")(0)
            NewMinutes = StringToConvert.Split(":")(1)
        End If


        If (IsNothing(NewMinutes) Or NewMinutes = 0) Then
            Return Nothing
        End If

        TimeToReturn = New TimeSpan(NewHours, NewMinutes, 0)

        Return TimeToReturn
    End Function

    Public Function DataEnteredIsBad(TimeEntered As String, AMorPM As String) As Boolean
        If Not (TimeEntered Like "####" Or TimeEntered Like "##:##") Then
            MsgBox("Please enter the time in 'HH:MM' format or 'HHMM' format.", MsgBoxStyle.Critical, "Input Error!")
            Return False
        End If

        If Not (AMorPM Like "AM" Or AMorPM Like "PM") Then
            MsgBox("Please enter or select 'AM' or 'PM' in the form!", MsgBoxStyle.Critical, "Input Error!")
            Return False
        End If


        Return True
    End Function
End Module