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
End Class
