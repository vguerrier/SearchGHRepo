Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Http
Imports System.Text.Json
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module LstPRActives
    'Public Const authKey As String = ":skpg3rox6mgo3sn5dxj7fxqx7e5jwahxvmkz2gbj2jrlpbheerda" '10/01/2023 16:08 'bien penser à ajouter ":" en premier avant de coder en 64
    'Public Const authKey As String = ":mxkag2tjyr7tc3kf42e3ldxvlvyh3dcoxog5z73v7mqkvnp32zvq" '29/06/2023 11:36 (fin 27/06/2024) 'bien penser à ajouter ":" en premier avant de coder en 64
    Public Const authKey As String = ":d6nnvzjde335c4u3f3hm2ybiem2fmcmujqmpvucpse72r3f7viaa" '29/08/2023 17:02 (fin 26/08/2024)

    Public Structure ProjectRepositories
        Public name As String
        Public isDisabled As Boolean

    End Structure
    Public Structure PullRequests
        Public CqCard As String
        Public therepository As repository
        Public pullRequestId As String
        Public status As String
        Public thecreatedBy As createdBy
        Public creationDate As String
        Public title As String
        Public description As String
        Public sourceRefName As String
        Public targetRefName As String
        Public mergeStatus As String
        Public isDraft As Boolean
        Public mergeId As String
        Public thelastMergeSourceCommit As Lastmergesourcecommit
        Public thelastMergeTargetCommit As Lastmergetargetcommit
        Public thelastMergeCommit As Lastmergecommit
        Public thereviewers As reviewers()
        Public url As String
        Public thecompletionOptions As Completionoptions
        Public supportsIterations As Boolean
        Public theautoCompleteSetBy As Autocompletesetby


    End Structure

    Public Structure repository
        Public id As String
        Public name As String
        Public url As String
        Public theproject As project

    End Structure

    Public Structure project
        Public id As String
        Public name As String
        Public state As String
        Public visibility As String
        Public lastUpdateTime As String
    End Structure



    Public Structure createdBy
        Public displayName As String
        Public url As String
        'Public links
        Public id As String
        Public uniquename As String
        Public imageurl As String
        Public descriptor As String

    End Structure

    Public Structure Lastmergesourcecommit
        Public commitId As String
        Public url As String
    End Structure
    Public Structure Lastmergetargetcommit
        Public commitId As String
        Public url As String
    End Structure
    Public Structure Lastmergecommit
        Public commitId As String
        Public url As String
    End Structure
    Public Structure reviewers
        Public displayName As String
        Public isRequired As Boolean
    End Structure
    Public Structure Completionoptions
        Public mergeCommitMessage As String
        Public deleteSourceBranch As Boolean
        Public mergeStrategy As String
        Public transitionWorkItems As Boolean
        'Public autoCompleteIgnoreConfigIds
    End Structure
    Public Structure Autocompletesetby
        Public displayName As String
        Public url As String
        'Public links
        Public uniqueName As String
        Public descriptor As String
    End Structure

    Public Function GetPRInfo(SubProduct As String, PRId As String) As String
        Dim authKey64 As String

        Dim ApiUrlPR As String
        Dim i As Integer
        Dim TabPrj As String()
        Dim TabRep As ProjectRepositories()
        Dim prj As String
        Dim Status As String

        TabPrj = GetProjects()
        Status = "Not Found"

        prj = ProjectsRepo(SubProduct)
        If prj <> "" And prj <> "Not Found" Then
            TabRep = GetRepositories(prj)
            i = 0
            For Each rep In TabRep
                If rep.name <> "" And rep.isDisabled = False Then
                    i = i
                    'https://dev.azure.com/seyc/GOLDCentral/_apis/git/repositories/central/pullRequests/93956
                    ApiUrlPR = "https://dev.azure.com/seyc/" + prj + "/_apis/git/repositories/" + rep.name + "/pullrequests/" + PRId
                    authKey64 = Base64Encode(authKey)
                    Dim request As HttpWebRequest = DirectCast(WebRequest.Create(ApiUrlPR), HttpWebRequest)

                    request.Method = "GET"
                    request.ContentType = "application/json"
                    request.UserAgent = "Visual Studio/15.0"
                    request.Headers.Add("Authorization", "Basic " & authKey64)
                    On Error GoTo ErrorR
                    Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                    Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
                    'Console.WriteLine(responseString)
                    'Dim p = MessageBox.Show(responseString)

                    If response.StatusCode Then
                        'Dim json As String = Await response.Content.ReadAsStringAsync()

                        Dim myObj As Dictionary(Of String, Object)

                        myObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseString)
                        If myObj("status") <> "" Then
                            Status = myObj("status")
                        End If
                    End If
                End If
ErrorR:
                On Error GoTo - 1
            Next
        End If
        GetPRInfo = Status
    End Function
    'Public Function LstPRActive() As PullRequests()
    Public Function LstPRActive(SubProduct As String, card As String) As PullRequests()
        'Public Function LstPRActive() As PullRequests()
        'Product = Repo
        'Product = "Central V5.10 Maint"
        'SubProduct = Project
        'SubProduct = "GMD V6.00"
        'card = "GCENT23010192"

        Dim authKey64 As String

        Dim ApiUrlPR As String
        Dim i As Integer
        Dim TabPR As PullRequests()
        Dim TabPrj As String()
        Dim TabRep As ProjectRepositories()
        Dim NbRev As Integer
        Dim RevRequired As String
        Dim RevOpt As String
        Dim Nbr As Integer
        'Dim ThePr As PullRequests
        Dim prj As String
        Dim Tprj As String() = {"GOLDCentral", "GOLDMasterData", "GOLD Functional Administration", "GOLDCentralOperations", "GOLDStoreOperations", "GOLDStoreMobility"}

        TabPrj = GetProjects()
        'correspondance produit => repos
        'on recherche dans la table subproduct
        'le champ NAME va nous donner le Projet et le repo
        'exemple : NAME = GMD V6.00 =>
        'Project = GOLDMasterData
        'Repo = gmd
        prj = ProjectsRepo(SubProduct)
        i = 0
        'on parcours les projets
        For Each prj In Tprj
            'ReDim TabPR(0)
            If prj <> "" And prj <> "Not Found" Then
                'ApiUrlPR = "https://dev.azure.com/seyc/" + prj + "/_apis/git/repositories/central/pullrequests?searchCriteria.status=active"
                ' on parcours les repositories de chaque projets
                TabRep = GetRepositories(prj)

                For Each rep In TabRep
                    If rep.name <> "" And rep.isDisabled = False Then
                        i = i

                        ApiUrlPR = "https://dev.azure.com/seyc/" + prj + "/_apis/git/repositories/" + rep.name + "/pullrequests?searchCriteria.status=active"

                        authKey64 = Base64Encode(authKey)
                        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(ApiUrlPR), HttpWebRequest)

                        request.Method = "GET"
                        request.ContentType = "application/json"
                        request.UserAgent = "Visual Studio/15.0"
                        request.Headers.Add("Authorization", "Basic " & authKey64)
                        On Error GoTo ErrorR
                        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                        Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
                        'Console.WriteLine(responseString)
                        'Dim p = MessageBox.Show(responseString)

                        If response.StatusCode Then
                            'Dim json As String = Await response.Content.ReadAsStringAsync()

                            Dim myObj As Dictionary(Of String, Object)

                            myObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseString)
                            If myObj("value").Count = 0 Then
                                ReDim Preserve TabPR(i + myObj("value").Count)
                            Else
                                ReDim Preserve TabPR(i + myObj("value").Count - 1)
                            End If

                            For Each kvp In myObj("value")
                                If card = ExtractGCENTCode(kvp("title")) Or card = ExtractGCENTCode(kvp("description")) Or card = ExtractGCENTCode(kvp("sourceRefName")) Then
                                    '0-Project
                                    TabPR(i).therepository.theproject.name = prj
                                    'Dim LVITime As New ListViewItem(prj)
                                    '1-Repositoy.name
                                    TabPR(i).therepository.name = rep.name
                                    'LVITime.SubItems.Add(TabPR(i).therepository.name)
                                    '2-pullRequestId
                                    TabPR(i).pullRequestId = kvp("pullRequestId")
                                    'LVITime.SubItems.Add(TabPR(i).pullRequestId)
                                    '3-PR url
                                    TabPR(i).url = "https://seyc.visualstudio.com/" + prj + "/_git/" + rep.name + "/pullrequest/" + TabPR(i).pullRequestId
                                    'LVITime.SubItems.Add(TabPR(i).url)
                                    'LVITime.UseItemStyleForSubItems = False
                                    'LVITime.SubItems(3).ForeColor = Color.Blue
                                    '4-CQ Card
                                    TabPR(i).title = kvp("title")
                                    TabPR(i).description = kvp("description")
                                    TabPR(i).sourceRefName = kvp("sourceRefName")

                                    TabPR(i).CqCard = ExtractGCENTCode(TabPR(i).title)
                                    If TabPR(i).CqCard = "" Then
                                        TabPR(i).CqCard = ExtractGCENTCode(TabPR(i).description)
                                    End If
                                    If TabPR(i).CqCard = "" Then
                                        TabPR(i).CqCard = ExtractGCENTCode(TabPR(i).sourceRefName)
                                    End If


                                    'LVITime.SubItems.Add(TabPR(i).CqCard)
                                    '5-Title
                                    'LVITime.SubItems.Add(TabPR(i).title)

                                    '6-Created Name - raised by
                                    TabPR(i).thecreatedBy.displayName = kvp("createdBy")("displayName")
                                    'LVITime.SubItems.Add(TabPR(i).thecreatedBy.displayName)
                                    '7-reviewers
                                    NbRev = myObj("value")(i)("reviewers").count
                                    ReDim TabPR(i).thereviewers(NbRev)
                                    Nbr = 0
                                    For Each KRV In myObj("value")(i)("reviewers")
                                        TabPR(i).thereviewers(Nbr).displayName = KRV("displayName")
                                        TabPR(i).thereviewers(Nbr).isRequired = KRV("isRequired")
                                        Nbr = Nbr + 1
                                    Next
                                    'on concatene les reviewer requis et optionels
                                    RevRequired = ""
                                    RevOpt = ""
                                    For Nbr = 0 To NbRev - 1
                                        If TabPR(i).thereviewers(Nbr).isRequired Then
                                            If RevRequired <> "" Then
                                                RevRequired = RevRequired + " ; " + TabPR(i).thereviewers(Nbr).displayName
                                            Else
                                                RevRequired = TabPR(i).thereviewers(Nbr).displayName
                                            End If
                                        Else
                                            If RevOpt <> "" Then
                                                RevOpt = RevOpt + " ; " + TabPR(i).thereviewers(Nbr).displayName
                                            Else
                                                RevOpt = TabPR(i).thereviewers(Nbr).displayName
                                            End If
                                        End If
                                    Next
                                    'LVITime.SubItems.Add(RevRequired)

                                    'LVITime.SubItems.Add(RevOpt)


                                    TabPR(i).creationDate = kvp("creationDate")
                                    TabPR(i).targetRefName = kvp("targetRefName")
                                    TabPR(i).status = kvp("status")
                                    'LVList.Items.AddRange(New ListViewItem() {LVITime})
                                    i = i + 1
                                End If
                            Next
                            i = i


                        Else
                            'pullRequest.Title = "Not Found"
                        End If
                    End If
ErrorR:
                Next
                i = i
            End If
        Next
        LstPRActive = TabPR
        'Next
    End Function
    Function ExtractGCENTCode(str As String) As String
        Dim pattern As String = "GCENT\d{8}"
        Dim match As Match
        ExtractGCENTCode = ""
        If str <> "" Then
            match = Regex.Match(str, pattern)
            If match.Success Then
                Return match.Value
            Else
                Return ""
            End If
        End If
    End Function

    Public Function ProjectsRepo(SubProduct As String) As String
        Dim prj As String

        prj = "Not Found"
        If InStr(SubProduct, "Central") <> 0 Then
            prj = "GOLDCentral"
        Else
            If InStr(SubProduct, "GMD") <> 0 Then
                prj = "GOLDMasterData"
            Else
                If InStr(SubProduct, "Adm") <> 0 Then
                    prj = "GOLD Functional Administration"
                Else
                    If InStr(SubProduct, "GCO") <> 0 Then
                        prj = "GOLDCentralOperations"
                    Else
                        If InStr(SubProduct, "GSO") <> 0 Then
                            prj = "GOLDStoreOperations"
                        Else
                            If InStr(SubProduct, "GSM") <> 0 Then
                                prj = "GOLDStoreMobility"
                            End If
                        End If
                    End If
                End If
            End If
        End If
        ProjectsRepo = Prj
    End Function
    Public Function GetProjects() As String()
        Dim authKey64 As String
        Dim TProjects As String()
        Dim ApiUrlProject As String
        Dim i As Integer

        ApiUrlProject = "https://dev.azure.com/seyc/_apis/projects?api-version=7.0"
        authKey64 = Base64Encode(authKey)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(ApiUrlProject), HttpWebRequest)

        request.Method = "GET"
        request.ContentType = "application/json"
        request.UserAgent = "Visual Studio/15.0"
        request.Headers.Add("Authorization", "Basic " & authKey64)

        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
        Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        'Console.WriteLine(responseString)
        'Dim p = MessageBox.Show(responseString)
        ReDim TProjects(1)
        TProjects(1) = "No Projects"
        If response.StatusCode Then
            Dim myObj As Dictionary(Of String, Object)

            myObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseString)
            ReDim TProjects(myObj("value").Count)
            i = 0
            For Each kvp In myObj("value")
                TProjects(i) = kvp("name")
                i = i + 1
            Next
        End If
        GetProjects = TProjects

    End Function

    Public Function GetRepositories(prj As String) As ProjectRepositories()
        Dim authKey64 As String
        Dim TPrep As ProjectRepositories()
        Dim ApiUrlRep As String
        Dim i As Integer

        ApiUrlRep = "https://dev.azure.com/seyc/" + prj + "/_apis/git/repositories?"
        authKey64 = Base64Encode(authKey)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(ApiUrlRep), HttpWebRequest)

        request.Method = "GET"
        request.ContentType = "application/json"
        request.UserAgent = "Visual Studio/15.0"
        request.Headers.Add("Authorization", "Basic " & authKey64)

        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
        Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        'Console.WriteLine(responseString)
        'Dim p = MessageBox.Show(responseString)
        ReDim TPrep(1)
        TPrep(1).name = "No Repositories"
        If response.StatusCode Then
            Dim myObj As Dictionary(Of String, Object)

            myObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseString)
            ReDim TPrep(myObj("value").Count)
            i = 0
            For Each kvp In myObj("value")
                TPrep(i).name = kvp("name")
                TPrep(i).isDisabled = kvp("isDisabled")
                i = i + 1
            Next
        End If
        GetRepositories = TPrep

    End Function
    Private Function Base64Encode(ByVal plainText As String) As String
        Dim plainTextBytes = Encoding.UTF8.GetBytes(plainText)
        Return Convert.ToBase64String(plainTextBytes)
    End Function
End Module
