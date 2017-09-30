﻿using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.MenuBar
{
    class HelpStrip : ToolStripMenuItem
    {
        ToolStripMenuItem aboutStrip;
        ToolStripMenuItem helpStrip;

        public HelpStrip(XCommand command)
        {
            Name = "Help";
            aboutStrip = new ToolStripMenuItem("About..", null);
            helpStrip = new ToolStripMenuItem("Show help..", null);

            DropDownItems.Add(helpStrip);
            DropDownItems.Add(aboutStrip);
        }
    }
}
