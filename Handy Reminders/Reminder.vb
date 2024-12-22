Imports System.Runtime.InteropServices
Imports System.Xml
Imports System.Xml.Serialization


Public Class ListViewReminder
    Public Property UUID As String
    Public Property Title As String
    Public Property Message As String
    Public Property ReminderTime As TimeSpan
    Public Property ReminderDays As List(Of String)
    Public Property IsRepeatative As Boolean
    Public Sub New()
        MyBase.New()
        Me.UUID = New UniqueId().ToString()
        Me.Title = Nothing
    End Sub
    Public Sub New(ByVal NameOfReminder As String, ByVal ReminderMessage As String, ByVal ReminderTimeofDay As TimeSpan, ByVal ReminderDaysofWeek As List(Of String), ByVal isRepeating As Boolean)
        Me.UUID = New UniqueId().ToString()
        Me.Title = NameOfReminder
        Me.Message = ReminderMessage
        Me.ReminderTime = ReminderTimeofDay
        Me.ReminderDays = ReminderDaysofWeek
        Me.IsRepeatative = isRepeating
    End Sub
End Class
<XmlRootAttribute("Reminders",
 Namespace:="http://www.cpandl.com", IsNullable:=False)>
<XmlInclude(GetType(ListViewReminder)), XmlInclude(GetType(UniqueId)), XmlInclude(GetType(TimeSpan))>
Public Class ReminderList
    <XmlIgnore()>
    Public Property Reminders As Dictionary(Of String, ListViewReminder)

    <XmlArrayAttribute("RemindersList")>
    Public Property SerializableReminders As List(Of KeyValueElement)
    Public Sub New(ByRef ListofReminders As Dictionary(Of String, ListViewReminder))
        Reminders = ListofReminders
        SerializableReminders = New List(Of KeyValueElement)
        Serialize()
    End Sub
    Public Sub New()
        Reminders = New Dictionary(Of String, ListViewReminder)
        SerializableReminders = New List(Of KeyValueElement)
    End Sub
    Public Sub Serialize()
        SerializableReminders = New List(Of KeyValueElement)(Reminders.Count)
        For Each item As ListViewReminder In Reminders.Values
            SerializableReminders.Add(New KeyValueElement(item.UUID, item))
        Next
    End Sub
    Public Sub DeSerialize()
        Reminders = SerializableReminders.ToDictionary(Of String, ListViewReminder)(Function(Str As String) As KeyValueElement
                                                                                        Return SerializableReminders.Item(0).Key
                                                                                    End Function,
                                                                                    Function(key As KeyValueElement, value As ListViewReminder) As ListViewReminder
                                                                                        Return value
                                                                                    End Function)

        For Each item As ListViewReminder In Reminders.Values
            SerializableReminders.Add(New KeyValueElement(item.UUID, item))
        Next
    End Sub
End Class

<XmlInclude(GetType(ListViewReminder)), XmlInclude(GetType(UniqueId)), XmlInclude(GetType(TimeSpan)), XmlInclude(GetType(KeyValueElement))>
Public Class KeyValueElement
    <XmlElementAttribute(IsNullable:=False)>
    Public Key As Object
    <XmlElementAttribute(IsNullable:=False)>
    Public Value As Object
    Public Sub New()

    End Sub

    Public Sub New(mykey As Object, myValue As Object)
        Me.Key = mykey
        Me.Value = myValue
    End Sub
End Class
