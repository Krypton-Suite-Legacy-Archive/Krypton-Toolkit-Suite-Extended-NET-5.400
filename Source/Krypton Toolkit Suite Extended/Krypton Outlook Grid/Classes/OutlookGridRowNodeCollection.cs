﻿//--------------------------------------------------------------------------------
// Copyright (C) 2013-2015 JDH Software - <support@jdhsoftware.com>
//
// This program is provided to you under the terms of the Microsoft Public
// License (Ms-PL) as published at https://kryptonoutlookgrid.codeplex.com/license
//
// Visit http://www.jdhsoftware.com and follow @jdhsoftware on Twitter
//
//--------------------------------------------------------------------------------
using System.Collections.Generic;

namespace KryptonOutlookGrid.Classes
{
    /// <summary>
    /// List of IOutlookGridGroups
    /// </summary>
    public class OutlookGridRowNodeCollection
    {
        #region "Variables"
        private OutlookGridRow _parentNode;
        private List<OutlookGridRow> subNodes;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookGridRowNodeCollection"/> class.
        /// </summary>
        /// <param name="parentNode">The parent node.</param>
        public OutlookGridRowNodeCollection(OutlookGridRow parentNode)
        {
            _parentNode = parentNode;
            subNodes = new List<OutlookGridRow>();
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets the parent node.
        /// </summary>
        /// <value>
        /// The parent node.
        /// </value>
        public OutlookGridRow ParentNode
        {
            get
            {
                return _parentNode;
            }
            internal set
            {
                _parentNode = value;
            }
        }

        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <value>
        /// The nodes.
        /// </value>
        public List<OutlookGridRow> Nodes
        {
            get
            {
                return subNodes;
            }
        }


        /// <summary>
        /// Gets the number of groups
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get
            {
                return subNodes.Count;
            }
        }

        #endregion

        #region "Public methods"


        /// <summary>
        /// Gets the <see cref="OutlookGridRow"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="OutlookGridRow"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns>The IOutlookGridGroup.</returns>
        public OutlookGridRow this[int index]
        {
            get
            {
                return subNodes[index];
            }
        }

        /// <summary>
        /// Adds the specified row.
        /// </summary>
        /// <param name="row">The row.</param>
        public void Add(OutlookGridRow row)
        {
            row.ParentNode = _parentNode;
            row.NodeLevel = ParentNode.NodeLevel + 1; //Not ++
            subNodes.Add(row);
        }

        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public void Sort()
        {
            subNodes.Sort();
        }

        /// <summary>
        /// Sorts the specified comparer.
        /// </summary>
        /// <param name="comparer">The comparer.</param>
        internal void Sort(OutlookGridRowComparer comparer)
        {
            subNodes.Sort(comparer);
        }

        /// <summary>
        /// Gets the Index of a row
        /// </summary>
        /// <param name="row">The OutlookGrid row.</param>
        /// <returns></returns>
        public int IndexOf(OutlookGridRow row)
        {
            return subNodes.IndexOf(row);
        }

        #endregion

        #region "Internals"

        /// <summary>
        /// Clears all subnodes.
        /// </summary>
        internal void Clear()
        {
            _parentNode = null;
            //If a group is collapsed the rows will not appear. Then if we clear the group the rows should not remain "collapsed"
            for (int i = 0; i < subNodes.Count; i++)
            {
                subNodes[i].Collapsed = false;
            }
            subNodes.Clear();
        }

        #endregion
    }
}