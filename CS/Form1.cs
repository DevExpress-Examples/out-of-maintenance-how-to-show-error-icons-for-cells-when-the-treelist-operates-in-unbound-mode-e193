using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Drawing;

namespace WindowsApplication767 {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetError(object value, TreeListColumn column, TreeListNode node)
        {
            if (value == null) return "value is null";
            if (!(value is int)) return string.Empty; ;
            if ((int)value % 2 == 0) return "value is even";
            if ((int)value < 10) return "value < 10";
            return string.Empty;
        }

        void SetError(BaseEditViewInfo cellInfo, string errorIconText)
        {
            if (errorIconText == string.Empty) return;
            cellInfo.ErrorIconText = errorIconText;
            cellInfo.ShowErrorIcon = true;
            cellInfo.FillBackground = true;
            cellInfo.ErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Critical);
        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            string error = GetError(e.CellValue, e.Column, e.Node);
            SetError(e.EditViewInfo, error);
            e.EditViewInfo.CalcViewInfo(e.Graphics);
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            treeList1.InvalidateNode(e.OldNode);
            treeList1.InvalidateNode(e.Node);
        }

        private void treeList1_ShowingEditor(object sender, CancelEventArgs e)
        {
            {
                string error = GetError(treeList1.FocusedNode.GetValue(treeList1.FocusedColumn), treeList1.FocusedColumn, treeList1.FocusedNode);
                if (error == string.Empty) return;
                treeList1.SetColumnError(treeList1.FocusedColumn, error);
                treeList1.InvalidateCell(treeList1.FocusedNode, treeList1.FocusedColumn);
            }
        }
    }

}