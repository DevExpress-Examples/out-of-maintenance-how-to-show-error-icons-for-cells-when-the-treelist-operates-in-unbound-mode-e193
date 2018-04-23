Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication767
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Function GetError(ByVal value As Object, ByVal column As TreeListColumn, ByVal node As TreeListNode) As String
			If value Is Nothing Then
				Return "value is null"
			End If
			If Not(TypeOf value Is Integer) Then
				Return String.Empty
			End If

			If CInt(Fix(value)) Mod 2 = 0 Then
				Return "value is even"
			End If
			If CInt(Fix(value)) < 10 Then
				Return "value < 10"
			End If
			Return String.Empty
		End Function

		Private Sub SetError(ByVal cellInfo As BaseEditViewInfo, ByVal errorIconText As String)
			If errorIconText = String.Empty Then
				Return
			End If
			cellInfo.ErrorIconText = errorIconText
			cellInfo.ShowErrorIcon = True
			cellInfo.FillBackground = True
			cellInfo.ErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Critical)
		End Sub

		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
			Dim [error] As String = GetError(e.CellValue, e.Column, e.Node)
			SetError(e.EditViewInfo, [error])
			e.EditViewInfo.CalcViewInfo(e.Graphics)
		End Sub

		Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
			treeList1.InvalidateNode(e.OldNode)
			treeList1.InvalidateNode(e.Node)
		End Sub

		Private Sub treeList1_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs) Handles treeList1.ShowingEditor
				Dim [error] As String = GetError(treeList1.FocusedNode.GetValue(treeList1.FocusedColumn), treeList1.FocusedColumn, treeList1.FocusedNode)
				If [error] = String.Empty Then
					Return
				End If
				treeList1.SetColumnError(treeList1.FocusedColumn, [error])
				treeList1.InvalidateCell(treeList1.FocusedNode, treeList1.FocusedColumn)
		End Sub
	End Class

End Namespace