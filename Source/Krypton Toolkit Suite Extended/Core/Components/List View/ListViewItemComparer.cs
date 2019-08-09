﻿using System;
using System.Collections;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    public class ListViewItemComparer : IComparer
    {
        // Fields
        private int col;

        // Methods
        public ListViewItemComparer()
        {
            this.col = 0;
        }

        public ListViewItemComparer(int column)
        {
            this.col = column;
        }

        public int Compare(object x, object y)
        {

            //we do not want errors
            // ERROR: Not supported in C#: OnErrorStatement


            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }

    }

    //From Z to A
    public class ListViewItemComparerReverser : IComparer
    {
        // Implements the manual sorting of items by columns.

        private int col;

        public ListViewItemComparerReverser()
        {
            col = 0;
        }

        public ListViewItemComparerReverser(int column)
        {
            col = column;
        }

        // Calls CaseInsensitiveComparer.[Compare] with the parameters reversed.
        public int Compare(object x, object y)
        {
            return new CaseInsensitiveComparer().Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
        }
        //IComparer.[Compare]

    }

    public class ListViewColumn
    {
        private int _ColumnNumber = -1;

        public int ColumnNumber
        {
            get { return _ColumnNumber; }
            set { _ColumnNumber = value; }
        }

        public int DefaultColumnNumber
        {
            get { return -1; }
        }
    }
}