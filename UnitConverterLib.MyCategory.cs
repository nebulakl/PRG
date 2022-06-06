// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private class MyCategory : Category
        {
            // This demo category serves as a reference
            // when adding new categories
            public MyCategory()
            {
                Name = "MyCategory";
                AddUnit(new MyBaseUnit());
                AddUnit(new MyLinearUnit());
                AddUnit(new MyOffsetUnit());
                AddUnit(new MyComplexUnit());
            }
        }

        private class MyBaseUnit : Unit
        {
            public MyBaseUnit()
            {
                Name = "MyBaseUnit";
            }
        }

        // example unit when they have a linear relationship
        private class MyLinearUnit : MyBaseUnit
        {
            public MyLinearUnit()
            {
                Name = "MyLinearUnit";
                RatioToBase = 2;
            }
        }

        // example unit when they have a offset relationship
        // e.g. °C <-> °F
        private class MyOffsetUnit : MyBaseUnit
        {
            public MyOffsetUnit()
            {
                Name = "MyOffsetUnit";
            }

            public override double FromBase(double source)
            {
                return source + 2;
            }

            public override double ToBase(double source)
            {
                return source - 2;
            }
        }

        private class MyComplexUnit : MyBaseUnit
        {
            public MyComplexUnit()
            {
                Name = "MyComplexUnit";
            }

            public override double FromBase(double source)
            {
                return source * source + System.Math.PI;
            }

            public override double ToBase(double source)
            {
                return System.Math.Sqrt(source - System.Math.PI);
            }
        }
    }
}