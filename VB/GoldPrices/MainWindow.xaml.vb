Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Resources
Imports System.Xml.Linq

Namespace GoldPrices

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Function CreateDataSource() As List(Of GoldPrice)
            Dim document As XDocument = GoldPrices.DataLoader.LoadXmlFromResources("/Data/GoldPrices.xml")
            Dim goldPrices As List(Of GoldPrice) = New List(Of GoldPrice)()
            If document IsNot Nothing Then
                For Each element As XElement In document.Element("GoldPrices").Elements()
                    Dim [date] As Date = Convert.ToDateTime(element.Element("Date").Value, CultureInfo.InvariantCulture)
                    Dim price As Double = Convert.ToDouble(element.Element("Price").Value, CultureInfo.InvariantCulture)
                    goldPrices.Add(New GoldPrice([date], price))
                Next
            End If

            Return goldPrices
        End Function

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = CreateDataSource()
        End Sub
    End Class

    Public Class GoldPrice

        Private ReadOnly dateField As Date

        Private ReadOnly priceField As Double

        Public ReadOnly Property [Date] As Date
            Get
                Return dateField
            End Get
        End Property

        Public ReadOnly Property Price As Double
            Get
                Return priceField
            End Get
        End Property

        Public Sub New(ByVal [date] As Date, ByVal price As Double)
            dateField = [date]
            priceField = price
        End Sub
    End Class

    Public Module DataLoader

        Public Function LoadXmlFromResources(ByVal fileName As String) As XDocument
            Try
                Dim uri As Uri = New Uri(fileName, UriKind.RelativeOrAbsolute)
                Dim info As StreamResourceInfo = Application.GetResourceStream(uri)
                Return XDocument.Load(info.Stream)
            Catch
                Return Nothing
            End Try
        End Function
    End Module
End Namespace
