Dim client As New System.Net.WebClient
Dim api = "http://localhost:8090/api/cutTransition"

client.Headers.Add("Content-Type", "application/json")
client.UploadString(api, "POST", "")