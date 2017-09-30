﻿using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.UI.DrawPanel
{
    public class DrawPanel : PictureBox
    {
        private XData _data;
        public XData Data => _data;

        public DrawPanel()
        {
            Dock = DockStyle.Fill;
        }
    }
}
