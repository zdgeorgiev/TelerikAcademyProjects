﻿#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.Controls.Grid;
using System.Windows;
using Syncfusion.Windows.Controls.Cells;

namespace AmazeOn.Content.Store
{
    public class RequestTreeItemsBehavior : Behavior<GridTreeControl>
    {
        StoreViewModel viewModel = null;

        /// <summary>
        /// Called when [attached].
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            viewModel = this.AssociatedObject.DataContext as StoreViewModel;
            this.AssociatedObject.RequestTreeItems += new GridTreeRequestTreeItemsHandler(InternalGrid_RequestTreeItems);
        }

        /// <summary>
        /// Handles the RequestTreeItems event of the InternalGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="Syncfusion.Windows.Controls.Grid.GridTreeRequestTreeItemsEventArgs"/> instance containing the event data.</param>
        void InternalGrid_RequestTreeItems(object sender, GridTreeRequestTreeItemsEventArgs args)
        {
            //when ParentItem is null, you need to set args.ChildList to be the root items...
            if (args.ParentItem == null)
            {
                //get the root list - get all employees who have no boss 
                //get all employees whose boss's id is -1 (no boss)
                args.ChildList = viewModel.CarDetails.Where(x => x.ReportsTo == -1);
            }
            else //if ParentItem not null, then set args.ChildList to the child items for the given ParentItem.
            {   //get the children of the parent object
                CarInfo car = args.ParentItem as CarInfo;
                if (car != null)
                {
                    //get all employees that report to the parent employee
                    args.ChildList = viewModel.CarDetails.Where(x => x.ReportsTo == car.ID);
                }
            }
        }

        /// <summary>
        /// Called when [detaching].
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.RequestTreeItems -= new GridTreeRequestTreeItemsHandler(InternalGrid_RequestTreeItems);
        }
    }
}
