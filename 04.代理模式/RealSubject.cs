﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.代理模式
{
    public class RealSubject: Subject
    {
        public override void DoSomething()
        {
            Console.WriteLine("在下一盘大棋....");
        }
    }
}
