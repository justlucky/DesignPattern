﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05.工厂方法模式
{
    public class IPhoneFactory : IMobileFactory
    {
        public Mobile Create()
        {
            return new IPhone();
        }
    }
}
