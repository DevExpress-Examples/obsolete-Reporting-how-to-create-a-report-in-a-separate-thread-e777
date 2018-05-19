Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Threading
Imports System.Reflection
Imports DevExpress.XtraReports.UI

Namespace ThreadingReport
	Public Class ReportCreatorForm
		Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private WithEvents btnCancel As System.Windows.Forms.Button
		Private WithEvents timerAutoClose As System.Windows.Forms.Timer
		Private components As System.ComponentModel.IContainer

		Public Shared Sub CreateReport(ByVal reportType As Type)
			Dim form As New ReportCreatorForm(reportType)
			form.Show()
		End Sub

		Private Sub New(ByVal reportType As Type)
			If reportType Is Nothing OrElse (Not reportType.IsSubclassOf(GetType(XtraReport))) Then
				Throw New Exception("An XtraReport type expected")
			End If
			Me.reportType = reportType
			InitializeComponent()
			Text = Application.ProductName
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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.timerAutoClose = New System.Windows.Forms.Timer(Me.components)
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(13, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(174, 18)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Creating a report.  Please wait."
			' 
			' btnCancel
			' 
			Me.btnCancel.Location = New System.Drawing.Point(240, 7)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(87, 20)
			Me.btnCancel.TabIndex = 1
			Me.btnCancel.Text = "Cancel"
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click);
			' 
			' timerAutoClose
			' 
			Me.timerAutoClose.Interval = 500
'			Me.timerAutoClose.Tick += New System.EventHandler(Me.timerAutoClose_Tick);
			' 
			' ReportCreatorForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(404, 42)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "ReportCreatorForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ReportCreatorForm"
'			Me.Load += New System.EventHandler(Me.ReportCreatorForm_Load);
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private thread As Thread
		Private reportType As Type
		Private report_Renamed As XtraReport

		Public ReadOnly Property Report() As XtraReport
			Get
				If (Not IsReportReady) Then
					Return Nothing
				End If
				Return report_Renamed
			End Get
		End Property

		Public ReadOnly Property IsReportReady() As Boolean
			Get
				Return (Not thread.IsAlive) AndAlso report_Renamed IsNot Nothing
			End Get
		End Property

		Private Sub ReportCreatorForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			thread = New Thread(New ThreadStart(AddressOf CreateReport))
			thread.Start()
			timerAutoClose.Start()
		End Sub

		Private Sub CreateReport()
			Dim ci As ConstructorInfo = reportType.GetConstructor(Type.EmptyTypes)
			If ci Is Nothing Then
				Throw New Exception("The report class does not have a default constructor")
			End If
			Dim r As XtraReport = TryCast(ci.Invoke(Nothing), XtraReport)
			Thread.Sleep(0)
			r.CreateDocument()
			Thread.Sleep(0)
			report_Renamed = r
		End Sub

		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
			If Me.thread.IsAlive Then
				Me.timerAutoClose.Stop()
				Me.thread.Abort()
				Do While (Me.thread.ThreadState And ThreadState.Aborted) = 0 AndAlso (Me.thread.ThreadState And ThreadState.Stopped) = 0
					Thread.Sleep(0)
				Loop
				Me.Close()
			End If
		End Sub

		Private Sub timerAutoClose_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerAutoClose.Tick
			If thread IsNot Nothing AndAlso (thread.ThreadState And ThreadState.Stopped) > 0 Then
				timerAutoClose.Stop()
				Close()
				If Report IsNot Nothing Then
					Report.ShowPreview()
				End If
			End If
		End Sub
	End Class
End Namespace
