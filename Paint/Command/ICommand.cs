﻿using Paint.Command.ActionInterface;
using Paint.Command.Actions;
using Paint.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         IAction ActiveFigure { get; }
         IAction SelectPage { get; }
         IAction RemoveAllPages { get; }

         IAction ChangeLanguage { get; }

         IAction LoadCloud { get; }
         IAction SaveCloud { get; }

         IAction AddPlugin { get; }
         IAction RemovePlugin { get; }

         IAction ChangeSkin { get; }

         IData Data { get; set; }
    }
}
