﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Qustion_3
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
