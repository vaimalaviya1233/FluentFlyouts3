﻿using H.NotifyIcon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeKit.Flyouts.Interfaces
{
    public interface IIconManager
    {
        public TaskbarIcon FlyoutIcon { get; set; }

        public bool Initialize();

        public void Dispose();
    }
}
