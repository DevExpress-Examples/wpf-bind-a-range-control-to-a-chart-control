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
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Function CreateDataSource() As List(Of GoldPrice)
			Dim document As XDocument = DataLoader.LoadXmlFromResources("/Data/GoldPrices.xml")
			Dim goldPrices As New List(Of GoldPrice)()
			If document IsNot Nothing Then
				For Each element As XElement In document.Element("GoldPrices").Elements()
					Dim [date] As DateTime = Convert.ToDateTime(element.Element("Date").Value, CultureInfo.InvariantCulture)
					Dim price As Double = Convert.ToDouble(element.Element("Price").Value, CultureInfo.InvariantCulture)
					goldPrices.Add(New GoldPrice([date], price))
				Next element
			End If
			Return goldPrices
		End Function
		Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.DataContext = CreateDataSource()
		End Sub
	End Class
	Public Class GoldPrice
'INSTANT VB NOTE: The field date was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private ReadOnly date_Conflict As DateTime
'INSTANT VB NOTE: The field price was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private ReadOnly price_Conflict As Double
		Public ReadOnly Property [Date]() As DateTime
			Get
				Return date_Conflict
			End Get
		End Property
		Public ReadOnly Property Price() As Double
			Get
				Return price_Conflict
			End Get
		End Property
		Public Sub New(ByVal [date] As DateTime, ByVal price As Double)
			Me.date_Conflict = [date]
			Me.price_Conflict = price
		End Sub
	End Class
	Public Module DataLoader
		Public Function LoadXmlFromResources(ByVal fileName As String) As XDocument
			Try
				Dim uri As New Uri(fileName, UriKind.RelativeOrAbsolute)
				Dim info As StreamResourceInfo = Application.GetResourceStream(uri)
				Return XDocument.Load(info.Stream)
			Catch
				Return Nothing
			End Try
		End Function
	End Module
End Namespace
