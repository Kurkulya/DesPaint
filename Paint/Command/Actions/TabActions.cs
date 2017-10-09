﻿using Paint.Command.ActionInterface;
using Paint.UI.TextInput;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class TabActions
    {
        public class ActionAddPage : IAction
        {
            XCommand cmd;
            public ActionAddPage(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
                cmd.Frame.Tabs.AddPage();
            }
        }

        public class ActionSelectPage : IAction
        {
            XCommand cmd;
            public ActionSelectPage(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
                if(cmd.Frame.Tabs.PageContext == null)
                    cmd.Frame.Tabs.PageContext = cmd.ActivePlugin.GetNewContext;

                if (cmd.ActivePlugin != null)
                {
                    cmd.Frame.MenuBar.RemovePluginMenuItems();
                    cmd.Frame.ToolBar.RemovePluginToolItems();
                }

                cmd.ActivePlugin = cmd.Frame.Tabs.PageContext.Plugin;
                cmd.ActivePlugin.SetContext = cmd.Frame.Tabs.PageContext;

                cmd.Frame.MenuBar.AddPluginMenuItems(cmd.ActivePlugin.GetMenuBarItems());
                cmd.Frame.ToolBar.AddPluginToolItems(cmd.ActivePlugin.GetToolBarItems());             
            }
        }

        public class ActionRemovePage : IAction
        {
            XCommand cmd;
            public ActionRemovePage(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
                cmd.Frame.Tabs.RemovePage();
            }
        }

        public class ActionRemoveAllPages : IAction
        {
            XCommand cmd;
            public ActionRemoveAllPages(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
              
            }
        }

        public class ActionRenamePage : IAction
        {
            XCommand cmd;
            public ActionRenamePage(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
                TextInput inputForm = new TextInput();

                if (inputForm.ShowDialog() == DialogResult.OK)
                    cmd.Frame.Tabs.RenamePage(inputForm.resultTxt.Text);

                inputForm.Dispose();              
            }
        }

        public class ActionActiveFigure : IAction
        {
            XCommand cmd;
            public ActionActiveFigure(ICommand cmd)
            {
                this.cmd = cmd as XCommand;
            }
            public void Action(object sender, EventArgs e)
            {
                //if (cmd.Frame.Tab.ActiveFigure != null && figureControl == null)
                //    cmd.Frame.Tab.ActiveFigure.BorderStyle = System.Windows.Forms.BorderStyle.None;

                //cmd.Frame.Tab.ActiveFigure = figureControl;
            }
        }
    }
}
