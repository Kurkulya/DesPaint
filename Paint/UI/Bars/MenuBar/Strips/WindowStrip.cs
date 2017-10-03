﻿using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar.Strips
{
    class WindowStrip : ToolStripMenuItem
    {
        ToolStripMenuItem renameStrip;
        ToolStripMenuItem closeStrip;
        ToolStripMenuItem closeAllStrip;

        int _pageIndex = 2;

        public WindowStrip(XCommand command)
        {
            Text = "Window";

            renameStrip = new ToolStripMenuItem("Rename", null, command.RenamePage.Action);
            closeStrip = new ToolStripMenuItem("Close", null, command.RemovePage.Action);
            closeAllStrip = new ToolStripMenuItem("CloseAll", null, command.RemoveAllPages.Action);

            DropDownItems.Add(renameStrip);
            DropDownItems.Add(new ToolStripSeparator());


            DropDownItems.Add(new ToolStripSeparator());
            DropDownItems.Add(closeStrip);
            DropDownItems.Add(closeAllStrip);
        }
    }
}