Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class ApiConnect
    Public Shared pAPI_URL As String

    Public Shared Function getToken(ByVal API_URL As String, ByVal dictData As Dictionary(Of String, Object)) As String
        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte
        Dim api As String = API_URL

        Try
            webClient.Headers("content-type") = "application/json"
            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))
            resByte = webClient.UploadData(api, "post", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            Dim json As JObject = JObject.Parse(resString)
            webClient.Dispose()
            Return json.SelectToken("token")

        Catch ex As Exception
            Return ""

            Console.WriteLine(ex.Message)
        End Try
        Return False
    End Function

    Friend Function getToken() As String
        Throw New NotImplementedException()
    End Function

    Public Shared Function getDatafromAPI(ByVal API_URL As String,
                                          ByVal strRoute As String,
                                          ByVal methodType As String,
                                          ByVal token As String) As DataTable
        Try
            Dim json As JObject
            Dim dt As New DataTable
            Dim request = TryCast(System.Net.WebRequest.Create(API_URL & strRoute), System.Net.HttpWebRequest)
            request.Method = methodType

            If API_URL <> "" Then

                request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " & token & " ")
                request.ContentLength = 0

                Using response = TryCast(request.GetResponse(), System.Net.HttpWebResponse)
                    Using reader = New System.IO.StreamReader(response.GetResponseStream())
                        json = JObject.Parse(reader.ReadToEnd())
                        Dim jsonArray As JArray = json.SelectToken("results")
                        dt = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(jsonArray.ToString)
                    End Using
                End Using
            Else
                MsgBox("User & password ไม่ถูกต้อง", MsgBoxStyle.Critical)
            End If

            Return dt
        Catch ex As Exception
            Return Nothing

        End Try
    End Function

    Public Shared Function addDataToAPI(ByVal API_URL As String,
                                 ByVal strToken As String,
                                  ByVal strRoute As String,
                                  ByVal methodType As String,
                                 ByVal dictData As Dictionary(Of String, Object)) As Boolean
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte
        Dim json As JObject

        Try
            '     For i As Integer = 1 To 1000
            Dim webClient As New WebClient()
            '   Dim request = TryCast(System.Net.WebRequest.Create(API_URL & "users/info"), System.Net.HttpWebRequest)
            Dim t As String = strToken

            webClient.Headers("content-type") = "application/json"
            webClient.Headers.Add(HttpRequestHeader.Authorization, "Bearer " & t & " ")
            reqString = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))


            resByte = webClient.UploadData(API_URL & strRoute, methodType, reqString)
            resString = Encoding.Default.GetString(resByte)
            json = JObject.Parse(resString)

            If json.SelectToken("statusCode") = "200" Then
                MsgBox("success", MsgBoxStyle.Information)
                Return True

            Else
                Return False
                MsgBox("Error", MsgBoxStyle.Critical)

            End If

        Catch ex As Exception
            MsgBox("Error", ex.Message)
            Return False
        End Try

    End Function

    Public Shared Function updateDataToAPI(ByVal API_URL As String,
                                    ByVal strToken As String,
                                     ByVal strRoute As String,
                                     ByVal methodType As String,
                                    ByVal dictData As Dictionary(Of String, Object),
                                    ByVal strCondition As String) As Boolean
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte
        Dim json As JObject

        Try
            '     For i As Integer = 1 To 1000
            Dim webClient As New WebClient()
            '   Dim request = TryCast(System.Net.WebRequest.Create(API_URL & "users/info"), System.Net.HttpWebRequest)
            Dim t As String = strToken

            webClient.Headers("content-type") = "application/json"
            webClient.Headers.Add(HttpRequestHeader.Authorization, "Bearer " & t & " ")
            reqString = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))


            resByte = webClient.UploadData(API_URL & strRoute & strCondition, methodType, reqString)
            resString = Encoding.Default.GetString(resByte)
            json = JObject.Parse(resString)

            If json.SelectToken("statusCode") = "200" Then
                MsgBox("success", MsgBoxStyle.Information)
                Return True

            Else
                MsgBox("Error", MsgBoxStyle.Critical)
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error", ex.Message)
            Return False
        End Try

    End Function

    Public Shared Function deleleteDataToAPI(ByVal API_URL As String,
                                     ByVal strToken As String,
                                     ByVal strRoute As String,
                                     ByVal strCondition As String) As Boolean

        Dim client As New HttpClient()
        Try
            Dim t As String = strToken
            client.BaseAddress = New Uri(API_URL)
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", t)
            Dim respone = client.DeleteAsync(strRoute & strCondition).Result
            If respone.StatusCode = 200 Then
                MsgBox("success", MsgBoxStyle.Information)
                Return True
            Else
                MsgBox("Error", MsgBoxStyle.Critical)
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error", ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function queryDataAPI(ByVal API_URL As String,
                                    ByVal strToken As String,
                                     ByVal strRoute As String,
                                     ByVal methodType As String,
                                    ByVal dictData As Dictionary(Of String, Object)) As DataTable

        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte
        Dim json As JObject
        Dim dt As New DataTable

        Try
            Dim webClient As New WebClient()
            Dim t As String = strToken

            webClient.Headers("content-type") = "application/json"
            webClient.Headers.Add(HttpRequestHeader.Authorization, "Bearer " & t & " ")
            reqString = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))


            resByte = webClient.UploadData(API_URL & strRoute, methodType, reqString)
            resString = Encoding.Default.GetString(resByte)
            json = JObject.Parse(resString)
            ' MsgBox(json)

            If json.SelectToken("statusCode") = "200" Then

                Dim jsonArray As JArray = json.SelectToken("results")
                dt = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(jsonArray.ToString)

                Return dt

            Else
                MsgBox("Error", MsgBoxStyle.Critical)
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error", ex.Message)
            Return Nothing
        End Try
    End Function

End Class
