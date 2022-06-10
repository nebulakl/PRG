// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private class Length : Category
        {
            public Length()
            {
                Name = "Length";
                AddUnit(new Meter());
                AddUnit(new Millimeter());
                AddUnit(new Kilometer());
                AddUnit(new Feet());
                AddUnit(new Inch());
            }
        }

        private class Meter : Unit
        {
            public Meter()
            {
                Name = "Meter[m]";
            }
        }

        private class Kilometer : Meter
        {
            public Kilometer()
            {
                Name = "Kilometer[km]";
                RatioToBase = 1000;
            }
        }

        private class Millimeter : Meter
        {
            public Millimeter()
            {
                Name = "Millimeter[mm]";
                RatioToBase = 0.001;
            }
        }

        private class Feet : Meter
        {
            public Feet()
            {
                Name = "Feet[ft]";
                RatioToBase = 0.3048;
            }
        }

        private class Inch : Meter
        {
            public Inch()
            {
                Name = "Inch[in]";
                RatioToBase = 0.0254;
            }
        }
    }
}