﻿using System;

namespace Difi.Oppslagstjeneste.Klient.Domene.Exceptions
{
    public class ValideringsException : SendException
    {
        public ValideringsException(string message)
            : base(message, null)
        {
        }

        public ValideringsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}