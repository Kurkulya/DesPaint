﻿

using Paint.UI.TextInput;
using System;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public static class TabActions
    {
        public class ActionAddPage
        {
            XCommand cmd;
            public ActionAddPage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {                
                //cmd.Frame.Tab.AddPage(name);
                //cmd.Frame.MenuBar.AddPageStrip(cmd.Frame.Tab.SelectedTab.Text);
            }
        }

        public class ActionSelectPage
        {
            XCommand cmd;
            public ActionSelectPage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //cmd.Frame.Tab.SelectedTab = cmd.Frame.Tab.TabPages[cmd.Frame.Tab.TabPages.IndexOfKey(name)];
            }
        }

        public class ActionRemovePage
        {
            XCommand cmd;
            public ActionRemovePage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //cmd.Frame.MenuBar.RemovePageStrip(cmd.Frame.Tab.SelectedTab.Text);
                //cmd.Frame.Tab.RemovePage(cmd.Frame.Tab.SelectedTab);               
            }
        }

        public class ActionRemoveAllPages
        {
            XCommand cmd;
            public ActionRemoveAllPages(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //cmd.Frame.MenuBar.RemovePageStrip(cmd.Frame.Tab.SelectedTab.Text);
                //cmd.Frame.Tab.RemovePage(cmd.Frame.Tab.SelectedTab);               
            }
        }

        public class ActionRenamePage
        {
            XCommand cmd;
            public ActionRenamePage(XCommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                TextInput inputForm = new TextInput();
                string result = "";
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    result = inputForm.resultTxt.Text;
                    //cmd.Frame.MenuBar.RenamePageStrip(cmd.Frame.Tab.SelectedTab.Text, result);
                    //cmd.Frame.Tab.SelectedTab.Text = result;
                    //cmd.Frame.Tab.SelectedTab.Name = result;
                }
                inputForm.Dispose();              
            }
        }

        public class ActionActiveFigure
        {
            XCommand cmd;
            public ActionActiveFigure(XCommand cmd)
            {
                this.cmd = cmd;
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