﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Saab.CBRN.Wcf.DataContracts
{
    public class LCDData
    {
        private int _barCount;
        private int _substanceIndex;

        /// <summary>
        /// 0-6 bars.
        /// </summary>
        [DataMember]
        public int BarCount
        {
            get { return _barCount; }
            set { _barCount = value; }
        }

        /// <summary>
        /// G agents: 1=GA, 2=GB, 3=GD...
        /// H agents: ...
        /// </summary>
        [DataMember]
        public int SubstanceIndex
        {
            get { return _substanceIndex; }
            set { _substanceIndex = value; }
        }
    }
}
