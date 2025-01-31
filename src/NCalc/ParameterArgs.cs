﻿using System;

namespace CoreCLR.NCalc
{
    public class ParameterArgs : EventArgs
    {
        private object _result;
        public object Result
        {
            get { return _result; }
            set
            {
                _result = value;
                HasResult = true;
            }
        }

        public bool HasResult { get; set; }
    }
}
