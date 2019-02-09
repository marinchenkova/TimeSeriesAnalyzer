﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TimeSeriesAnalyzer.Model
{
    public interface IDataService
    {
        IEnumerable<Point> GetData();
    }
}
