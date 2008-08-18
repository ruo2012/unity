﻿//===============================================================================
// Microsoft patterns & practices
// Unity Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEventBroker
{
    [AttributeUsage(AttributeTargets.Event, Inherited = true)]
    public class PublishesAttribute : PublishSubscribeAttribute
    {
        public PublishesAttribute(string publishedEventName) : base(publishedEventName)
        {
        }
    }
}
