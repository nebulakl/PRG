// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private abstract class Unit
        {
            protected string Name = "";
            protected double RatioToBase = 1;

            public virtual double FromBase(double source)
            {
                return source / RatioToBase;
            }

            public virtual double ToBase(double source)
            {
                return source * RatioToBase;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}