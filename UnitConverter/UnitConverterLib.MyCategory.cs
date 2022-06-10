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

        // define a base unit for this category
        // during a conversion, the source unit will first convert to this base unit
        // and then convert to the target unit
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

        // example unit when they have an offset relationship
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

        // you can also apply custom formulae
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