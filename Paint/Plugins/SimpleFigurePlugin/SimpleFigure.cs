﻿using Paint.Command;
using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Plugins.SimpleFigurePlugin
{
    class SimpleFigure : IPlugin
    {
        public string Name => "Simple Figure";

        Data _data;
        public IData Data => _data;

        Command.Command command;

        public SimpleFigure(XCommand command)
        {
            _data = new Data();
            this.command = new Command.Command(command);
        }

        public List<ToolStripMenuItem> GetMenuBarItems()
        {
            return new List<ToolStripMenuItem>() { new FigureMenuStrip(command) };
        }

        public UserControl GetPropertyEditor()
        {
            throw new NotImplementedException();
        }

        public ToolStripItem[] GetToolBarItems()
        {
            FigureToolStrip paintStrip = new FigureToolStrip(command);
            return paintStrip.StripList;
        }

        public IData GetNewData()
        {
            return new Data();
        }
    }
}
