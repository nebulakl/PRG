// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private class Mass : Category
        {
            public Mass()
            {
                Name = "Mass";
                AddUnit(new Kilogram());
                AddUnit(new Gram());
                AddUnit(new Tonne());
                AddUnit(new Pound());
                AddUnit(new Ounce());
            }
        }

        private class Kilogram : Unit
        {
            public Kilogram()
            {
                Name = "Kilogram[kg]";
            }
        }

        private class Gram : Kilogram
        {
            public Gram()
            {
                Name = "Gram[g]";
                RatioToBase = 0.001;
            }
        }

        private class Tonne : Kilogram
        {
            public Tonne()
            {
                Name = "Tonne[t]";
                RatioToBase = 1000;
            }
        }

        private class Pound : Kilogram
        {
            public Pound()
            {
                Name = "Pound[lb]";
                RatioToBase = 0.45359237;
            }
        }

        private class Ounce : Kilogram
        {
            public Ounce()
            {
                Name = "Ounce[oz]";
                RatioToBase = 0.0283495231;
            }
        }
    }
}