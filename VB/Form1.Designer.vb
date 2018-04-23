Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication767
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
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { 123, 312, 213123}, -1)
			Me.treeList1.AppendNode(New Object() { 231, 213123, 123}, -1)
			Me.treeList1.AppendNode(New Object() { 213321, Nothing, 123}, -1)
			Me.treeList1.AppendNode(New Object() { Nothing, 123123, Nothing}, -1)
			Me.treeList1.AppendNode(New Object() { 123123, 123312, 213312}, -1)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.Size = New System.Drawing.Size(565, 442)
			Me.treeList1.TabIndex = 1
'			Me.treeList1.CustomDrawNodeCell += New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(Me.treeList1_CustomDrawNodeCell);
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged);
'			Me.treeList1.ShowingEditor += New System.ComponentModel.CancelEventHandler(Me.treeList1_ShowingEditor);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "treeListColumn2"
			Me.treeListColumn2.FieldName = "treeListColumn2"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "treeListColumn3"
			Me.treeListColumn3.FieldName = "treeListColumn3"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 2
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(565, 442)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace

