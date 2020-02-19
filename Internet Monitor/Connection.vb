Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions
Public Class Connection
    Private Adapters As NetworkInterface()
    Public Sub New()
        ' Konstruktor za objekte
    End Sub
    Private Function IsInIEArray(ByVal arr As NetworkInterfaceType(), ByVal match As NetworkInterfaceType) As Boolean
        For Each IEType As NetworkInterfaceType In arr
            If IEType = match Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function GetInterface() As List(Of NetworkInterface)
        Adapters = NetworkInterface.GetAllNetworkInterfaces
        Dim IEList As New List(Of NetworkInterface)
        Dim IEFilter As NetworkInterfaceType() = {NetworkInterfaceType.Ethernet, NetworkInterfaceType.Ppp, NetworkInterfaceType.Wireless80211}
        For Each adapter As NetworkInterface In Adapters
            If IsInIEArray(IEFilter, adapter.NetworkInterfaceType) Then
                IEList.Add(adapter) ' Doda IE na seznam, ce je povezava ethernet/peer-to-peer/wireless 802.11e
            End If
        Next
        Return IEList
    End Function
    Public Function FetchExternalIP() As String
        Try
            Dim ExternalIP As String
            ExternalIP = New Net.WebClient().DownloadString("http://checkip.dyndns.org/")
            ExternalIP = New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return "No connection!"
        End Try
    End Function
End Class
