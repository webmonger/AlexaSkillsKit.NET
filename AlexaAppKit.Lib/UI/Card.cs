﻿//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;
using System.Collections.Generic;

namespace AlexaAppKit.UI
{
    public abstract class Card
    {
        public abstract string Type {
            get;
        }

        public virtual string Title {
            get;
            set;
        }

        public virtual string Subtitle {
            get;
            set;
        }
    }
}