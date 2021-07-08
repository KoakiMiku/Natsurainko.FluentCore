﻿using FluentCore.Service.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentCore.Model.Game
{
    public class Native : Library
    {
        public Native(Library library)
        {
            this.CheckSums = library.CheckSums;
            this.ClientReq = library.ClientReq;
            this.Downloads = library.Downloads;
            this.Name = library.Name;
            this.Natives = library.Natives;
            this.Rules = library.Rules;
            this.ServerReq = library.ServerReq;
            this.Url = library.Url;
        }

        public override string GetRelativePath()
        {
            string[] temp = Name.Split(':');
            return $"{temp[0].Replace(".", PathHelper.X)}{PathHelper.X}{temp[1]}{PathHelper.X}{temp[2]}{PathHelper.X}" +
                $"{temp[1]}-{temp[2]}-{Natives[SystemConfiguration.PlatformName.ToLower()].Replace("${arch}",SystemConfiguration.Arch)}.jar";
        }
    }
}
