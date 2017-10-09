﻿using Paint.Command.ActionInterface;
using PluginInterface;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class PluginActions
    {
        public class ActionAddPlugin : IAction
        {
            XCommand cmd;
            public ActionAddPlugin(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
                cmd.Frame.LeftToolBox.AddPluginElement(
                    cmd.PluginManager.CreatePluginElement((sender as ToolStripMenuItem).Name));
            }
        }

        public class ActionRemovePlugin : IAction
        {
            XCommand cmd;
            public ActionRemovePlugin(ICommand cmd)
            {
                this.cmd = cmd as XCommand; 
            }
            public void Action(object sender, EventArgs e)
            {
                if (cmd.ActivePlugin != null)
                {
                    cmd.Frame.MenuBar.RemovePluginMenuItems();
                    cmd.Frame.ToolBar.RemovePluginToolItems();
                }
                cmd.Frame.LeftToolBox.RemovePluginElement((sender as ToolStripMenuItem).Name);
                cmd.ActivePlugin = null;
            }
        }

        public class ActionSetActivePlugin
        {
            XCommand cmd;
            public ActionSetActivePlugin(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(IPlugin plugin)
            {
                if (cmd.ActivePlugin != null)
                {
                    cmd.Frame.MenuBar.RemovePluginMenuItems();
                    cmd.Frame.ToolBar.RemovePluginToolItems();
                }
                cmd.Frame.MenuBar.AddPluginMenuItems(plugin.GetMenuBarItems());
                cmd.Frame.ToolBar.AddPluginToolItems(plugin.GetToolBarItems());

                cmd.ActivePlugin = plugin;

                if (cmd.Frame.Tabs.PageContext == null)
                {
                    cmd.Frame.Tabs.PageContext = cmd.ActivePlugin.GetNewContext;
                    cmd.ActivePlugin.SetContext = cmd.Frame.Tabs.PageContext;
                }


            }
        }             
    }
}
