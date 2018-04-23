' Developer Express Code Central Example:
' How to automatically scroll the grid during drag-and-drop
' 
' This example demonstrates how to scroll grid rows and columns when dragging an
' object near the grid's edge. See also:
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1475


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Namespace WindowsApplication26
	Public Class AutoScrollHelper
		Public Sub New(ByVal view As LayoutView)
			fGrid = view.GridControl
			fView = view
			fScrollInfo = New ScrollInfo(Me, view)
		End Sub

		Private fGrid As GridControl
		Private fView As LayoutView
		Private fScrollInfo As ScrollInfo
		Public ThresholdInner As Integer = 20
		Public ThresholdOutter As Integer = 100
		Public HorizontalScrollStep As Integer = 10
		Public Property ScrollTimerInterval() As Integer
			Get
				Return fScrollInfo.scrollTimer.Interval
			End Get
			Set(ByVal value As Integer)
				fScrollInfo.scrollTimer.Interval = value
			End Set
		End Property

		Public Sub ScrollIfNeeded()
			Dim pt As Point = fGrid.PointToClient(Control.MousePosition)
			Dim viewInfo As LayoutViewInfo = TryCast(fView.GetViewInfo(), LayoutViewInfo)
			Dim rect As Rectangle = viewInfo.ViewRects.CardsRect


			fScrollInfo.GoLeft = (pt.X > rect.Left - ThresholdOutter) AndAlso (pt.X < rect.Left + ThresholdInner)
			fScrollInfo.GoRight = (pt.X > rect.Right - ThresholdInner) AndAlso (pt.X < rect.Right + ThresholdOutter)
			fScrollInfo.GoUp = (pt.Y < rect.Top + ThresholdInner) AndAlso (pt.Y > rect.Top - ThresholdOutter)
			fScrollInfo.GoDown = (pt.Y > rect.Bottom - ThresholdInner) AndAlso (pt.Y < rect.Bottom + ThresholdOutter)
			Console.WriteLine("{0} {1} {2} {3} {4}", pt, fScrollInfo.GoLeft, fScrollInfo.GoRight, fScrollInfo.GoUp, fScrollInfo.GoDown)
		End Sub

		Friend Class ScrollInfo
			Friend scrollTimer As Timer
			Private view As LayoutView = Nothing
			Private left, right, up, down As Boolean

			Private owner As AutoScrollHelper
			Public Sub New(ByVal owner As AutoScrollHelper, ByVal view As LayoutView)
				Me.owner = owner
				Me.view = view
				Me.scrollTimer = New Timer()
				AddHandler scrollTimer.Tick, AddressOf scrollTimer_Tick
			End Sub
			Public Property GoLeft() As Boolean
				Get
					Return left
				End Get
				Set(ByVal value As Boolean)
					If left <> value Then
						left = value
						CalcInfo()
					End If
				End Set
			End Property
			Public Property GoRight() As Boolean
				Get
					Return right
				End Get
				Set(ByVal value As Boolean)
					If right <> value Then
						right = value
						CalcInfo()
					End If
				End Set
			End Property
			Public Property GoUp() As Boolean
				Get
					Return up
				End Get
				Set(ByVal value As Boolean)
					If up <> value Then
						up = value
						CalcInfo()
					End If
				End Set
			End Property
			Public Property GoDown() As Boolean
				Get
					Return down
				End Get
				Set(ByVal value As Boolean)
					If down <> value Then
						down = value
						CalcInfo()
					End If
				End Set
			End Property
			Private Sub scrollTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
				owner.ScrollIfNeeded()

				If GoDown Then
					view.VisibleRecordIndex += 1
				End If
				If GoUp Then
					view.VisibleRecordIndex -= 1
				End If
				If GoLeft Then
					view.VisibleRecordIndex -= 1
				End If
				If GoRight Then
					view.VisibleRecordIndex += 1
				End If

				If (Control.MouseButtons And MouseButtons.Left) = MouseButtons.None Then
					scrollTimer.Stop()
				End If
			End Sub
			Private Sub CalcInfo()
				If Not(GoDown AndAlso GoLeft AndAlso GoRight AndAlso GoUp) Then
					scrollTimer.Stop()
				End If

				If GoDown OrElse GoLeft OrElse GoRight OrElse GoUp Then
					scrollTimer.Start()
				End If
			End Sub
		End Class
	End Class
End Namespace
