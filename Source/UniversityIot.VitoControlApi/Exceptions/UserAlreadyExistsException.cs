﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityIot.VitoControlApi.Exceptions
{
    [Serializable]
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException() { }
        public UserAlreadyExistsException(string message) : base(message) { }
        public UserAlreadyExistsException(string message, Exception inner) : base(message, inner) { }
        protected UserAlreadyExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}