﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;

namespace calculator.Parser.Exceptions
{
    public class SyntaxException : Exception
    {
        public SyntaxException(string message) : base(message) { }
    }
}