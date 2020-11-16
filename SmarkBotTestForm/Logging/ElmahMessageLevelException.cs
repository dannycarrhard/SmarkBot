using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmarkBotTestForm
{
    public class ElmahMessageLevelException : Exception
    {
        public ElmahMessageLevelException(string Message) : base(Message)
        { }
    }
}