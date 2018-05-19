Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace ThreadingReport
	''' <summary>
	''' Summary description for XtraReport1.
	''' </summary>
	Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private dataset11 As ThreadingReport.Dataset1
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			''' <summary>
			''' Required for Windows.Forms Class Composition Designer support
			''' </summary>
			InitializeComponent()

			FillData()
		End Sub

		Private Sub FillData()
			Const Count As Integer = 1000
			Dim rnd As New Random()
			For i As Integer = 1 To Count
				dataset11.Sample.AddSampleRow(i, rnd.Next(3) + 1, rnd.Next(10) + 1, "Item " & i.ToString(), Math.Round(Convert.ToDecimal(rnd.NextDouble() * 100), 2), DateTime.Today.AddDays(i), DateTime.Now)
			Next i
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.dataset11 = New ThreadingReport.Dataset1()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.Height = 20
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable1
			' 
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Location = New System.Drawing.Point(0, 0)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.Size = New System.Drawing.Size(647, 20)
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow1.Size = New System.Drawing.Size(647, 20)
			Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.ID", "")})
			Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell1.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' dataset11
			' 
			Me.dataset11.DataSetName = "Dataset1"
			Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.Category", "")})
			Me.xrTableCell2.Location = New System.Drawing.Point(90, 0)
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell2.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.Subcategory", "")})
			Me.xrTableCell3.Location = New System.Drawing.Point(180, 0)
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell3.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.Name", "")})
			Me.xrTableCell4.Location = New System.Drawing.Point(270, 0)
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell4.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.Value", "")})
			Me.xrTableCell5.Location = New System.Drawing.Point(360, 0)
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell5.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.Date", "{0:d}")})
			Me.xrTableCell6.Location = New System.Drawing.Point(450, 0)
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell6.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sample.Time", "{0:T}")})
			Me.xrTableCell7.Location = New System.Drawing.Point(540, 0)
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell7.Size = New System.Drawing.Size(107, 20)
			Me.xrTableCell7.Text = "xrTableCell7"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.PageHeader.Height = 20
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.BorderWidth = 2
			Me.xrTable2.Location = New System.Drawing.Point(0, 0)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.Size = New System.Drawing.Size(647, 20)
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell13, Me.xrTableCell14})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow2.Size = New System.Drawing.Size(647, 20)
			Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell8.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell8.Text = "ID"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Location = New System.Drawing.Point(90, 0)
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell9.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell9.Text = "Category"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.Location = New System.Drawing.Point(180, 0)
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell10.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell10.Text = "Subcategory"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.Location = New System.Drawing.Point(270, 0)
			Me.xrTableCell11.Name = "xrTableCell11"
			Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell11.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell11.Text = "Name"
			Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.Location = New System.Drawing.Point(360, 0)
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell12.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell12.Text = "Value"
			Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.Location = New System.Drawing.Point(450, 0)
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell13.Size = New System.Drawing.Size(90, 20)
			Me.xrTableCell13.Text = "Date"
			Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.Location = New System.Drawing.Point(540, 0)
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell14.Size = New System.Drawing.Size(107, 20)
			Me.xrTableCell14.Text = "Time"
			Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.DataMember = "Sample"
			Me.DataSource = Me.dataset11
			Me.Version = "8.3"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		#End Region
	End Class
End Namespace
