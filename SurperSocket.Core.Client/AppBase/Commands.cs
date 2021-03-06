﻿using System;
using System.ComponentModel;

namespace SuperSocketClient.AppBase
{
    /// <summary>
    /// 自定义命令
    /// </summary>
    public enum CustomCommand : ushort
    {
        [Description("用于测试的命令")]
        Test = 1000,

        [Description("心跳检测")]
        Heartbeat = 1001
    }
}