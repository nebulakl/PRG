// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private class Time : Category
        {
            public Time()
            {
                Name = "Time";
                AddUnit(new Second());
                AddUnit(new Minute());
                AddUnit(new Hour());
                AddUnit(new Day());
            }
        }

        private class Second : Unit
        {
            public Second()
            {
                Name = "Second[s]";
            }
        }

        private class Hour : Second
        {
            public Hour()
            {
                Name = "Hour[h]";
                RatioToBase = 60 * 60;
            }
        }

        private class Minute : Second
        {
            public Minute()
            {
                Name = "Minute[m]";
                RatioToBase = 60;
            }
        }

        private class Day : Second
        {
            public Day()
            {
                Name = "Day[d]";
                RatioToBase = 86400;
            }
        }
    }
}