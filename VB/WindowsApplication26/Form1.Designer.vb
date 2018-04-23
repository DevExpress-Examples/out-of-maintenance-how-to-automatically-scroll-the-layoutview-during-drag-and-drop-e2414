Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication26
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.AllowDrop = True
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 55)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(613, 273)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
'			Me.gridControl1.DragOver += New System.Windows.Forms.DragEventHandler(Me.gridControl1_DragOver);
			' 
			' layoutView1
			' 
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Name = "layoutViewCard1"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.simpleButton1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(613, 55)
			Me.panel1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 12)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(117, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Drag Me"
'			Me.simpleButton1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.simpleButton1_MouseMove);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(613, 328)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

