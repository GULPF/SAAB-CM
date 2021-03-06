﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Saab.CBRN.Wcf.DataContracts
{
    public class AP2CeData
    {
        private int _barCount;
        private double _volumeConcentration;

        [DataMember]
        public int BarCount
        {
            get { return _barCount; }
            set { _barCount = value; }
        }

        [DataMember]
        public double VolumeConcentration
        {
            get { return _volumeConcentration; }
            set { _volumeConcentration = value;  }
        }
    }
}
