﻿//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;
using AlexaAppKit.Slu;

namespace AlexaAppKit.Speechlet
{
    public class IntentRequest : SpeechletRequest
    {
        public IntentRequest(string requestId, Intent intent)  : base(requestId) {
            Intent = intent;
        }

        public virtual Intent Intent {
            get;
            private set;
        }
    }
}