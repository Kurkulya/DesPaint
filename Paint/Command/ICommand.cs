﻿using Paint.Command.ActionInterface;
using PluginInterface;

namespace Paint.Command
{
    public interface ICommand
    {
         IAction SaveAs { get; }
         IAction Open { get; }
         IAction Status { get; }
         IAction Save { get; }

         IAction AddPage { get; }
         IAction RemovePage { get; }
         IAction RenamePage { get; }
         IAction SelectPage { get; }
         IAction RemoveAllPages { get; }

         IAction ChangeLanguage { get; }

         IAction LoadCloud { get; }
         IAction SaveCloud { get; }

         IAction AddPlugin { get; }
         IAction RemovePlugin { get; }

         IAction ChangeSkin { get; }

         IPluginContext ActivePluginContext { get; set; }
         IPlugin ActivePlugin { get; set; }

    }
}
