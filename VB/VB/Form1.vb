Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Threading

Namespace ThreadingReport
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents button1 As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(20, 28)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(173, 20)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Request report show"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(20, 83)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(280, 20)
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = "You can type here while a report is being prepared"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(390, 160)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			ReportCreatorForm.CreateReport(GetType(XtraReport1))
		End Sub
	End Class
End Namespace
