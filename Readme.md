<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568789/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T397808)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/GoldPrices/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GoldPrices/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/GoldPrices/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/GoldPrices/MainWindow.xaml.vb))
<!-- default file list end -->
# How To: Bind a Range Control to a Chart Control 


<p>This example demonstrates how to use a Range Control for navigation within a Chart Control.</p>
<p><br><br></p>


<h3>Description</h3>

<p>To do this, create a chart client for the Range Control. Then specify a&nbsp;client&nbsp;data source using the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ItemsSourcetopic">ChartRangeControlClient.ItemsSource</a>&nbsp;content&nbsp;property. Define which data fields will be used to obtain chart client arguments and values using&nbsp;the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ArgumentDataMembertopic">ChartRangeControlClient.ArgumentDataMember</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsRangeControlClientChartRangeControlClient_ValueDataMembertopic">ChartRangeControlClient.ValueDataMember</a>&nbsp;properties. To manage data ranges within the Chart Control using the Range Control, bind the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsRange_MinValuetopic">Range.MinValue</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsRange_MaxValuetopic">Range.MaxValue</a>&nbsp;property values of the Chart Control visual range to the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfEditorsRangeControlRangeControl_SelectionRangeStarttopic">RangeControl.SelectionRangeStart</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfEditorsRangeControlRangeControl_SelectionRangeEndtopic">RangeControl.SelectionRangeEnd</a>&nbsp;property values respectively. Also, bind the&nbsp;<strong>Range.MinValue</strong>&nbsp;and&nbsp;<strong>Range.MaxValue</strong>&nbsp;property values of the whole range to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfEditorsRangeControlRangeControl_VisibleRangeStarttopic">RangeControl.VisibleRangeStart</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfEditorsRangeControlRangeControl_VisibleRangeEndtopic">RangeControl.VisibleRangeEnd</a>&nbsp;property values.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-bind-a-range-control-to-a-chart-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-bind-a-range-control-to-a-chart-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
