﻿
using Paint.Command.ActionInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Command.Actions
{
    public class FrameActions
    {
        public class ActionSaveAs : IAction
        {
            ICommand cmd;
            public ActionSaveAs(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                SaveFileDialog dlgSave = new SaveFileDialog();
                string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml" };
                dlgSave.Filter = String.Join("|", ext);
                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    //SOFactory.GetInstance(dlgSave.FileName).Save(cmd.Frame.Tab.ActivePage.DrawPanel.GetListOfFigures());
                }
            }
        }

        public class ActionSave : IAction
        {
            ICommand cmd;
            public ActionSave(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //SOFactory.GetInstance(dlgSave.FileName).Save(cmd.Frame.Tab.ActivePage.DrawPanel.GetListOfFigures());
            }
        }

        public class ActionOpen : IAction
        {
            ICommand cmd;
            public ActionOpen(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                string ext = "SO (*.json; *.xml; *.yaml)| *.json; *.xml; *.yaml";
                dlgOpen.Filter = ext;
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    //cmd.Frame.Tab.LoadPage(SOFactory.GetInstance(dlgOpen.FileName).Open());
                    //cmd.Frame.MenuBar.AddPageStrip(cmd.Frame.Tab.SelectedTab.Text);
                }
            }
        }

        public class ActionStatus : IAction
        {
            ICommand cmd;
            public ActionStatus(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
                //cmd.Point = (e as MouseEventArgs).Location;
            }
        }
    }
}
