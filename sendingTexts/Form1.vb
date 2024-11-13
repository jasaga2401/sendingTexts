
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Public Class Form1
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Const accountSid As String = "xxx"
        Const authToken As String = "xxx"

        ' Initialize the Twilio client
        TwilioClient.Init(accountSid, authToken)

        ' Define the recipient and sender phone numbers (examples here)
        Dim toNumber As New PhoneNumber("xxx") ' Recipient's phone number
        Dim fromNumber As New PhoneNumber("xxx") ' Your Twilio phone number

        ' Send the message
        ' Change toNumber / fromNumber to the phone numbers you want to use in textboxes
        Dim message = MessageResource.Create(
            to:=toNumber,
            from:=fromNumber,
            body:="Sending message!"
        )

        ' Output the message SID to confirm success
        Console.WriteLine($"Message SID: {message.Sid}")

    End Sub
End Class
