﻿using Paint.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.ToolBar
{
    public class ToolBar : ToolStrip
    {
        FileStrip fileStrip;
        CloudStrip cloudStrip;
        
        public ToolBar(XCommand command)
        {
            Dock = DockStyle.Top;
            BackColor = Color.White;

            fileStrip = new FileStrip(command);
            cloudStrip = new CloudStrip(command);

            Items.AddRange(fileStrip.FileStripList);
            Items.Add(new ToolStripSeparator());
            Items.AddRange(cloudStrip.CloudStripList);
            Items.Add(new ToolStripSeparator());
        }
        
    }
}
