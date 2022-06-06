// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private class Temperature : Category
        {
            public Temperature()
            {
                Name = "Temperature";
                AddUnit(new Celsius());
                AddUnit(new Fahrenheit());
                AddUnit(new Kelvin());
                AddUnit(new Rankine());
            }
        }

        private class Celsius : Unit
        {
            public Celsius()
            {
                Name = "Celsius[°C]";
            }
        }

        private class Fahrenheit : Celsius
        {
            public Fahrenheit()
            {
                Name = "Fahrenheit[°F]";
            }

            public override double FromBase(double source)
            {
                return source * 9 / 5 + 32;
            }

            public override double ToBase(double source)
            {
                return (source - 32) * 5 / 9;
            }
        }

        private class Kelvin : Celsius
        {
            public Kelvin()
            {
                Name = "Kelvin[K]";
            }

            public override double FromBase(double source)
            {
                return source + 273.15;
            }

            public override double ToBase(double source)
            {
                return source - 273.15;
            }
        }

        private class Rankine : Celsius
        {
            public Rankine()
            {
                Name = "Rankine[°R]";
            }

            public override double FromBase(double source)
            {
                return (source + 273.15) * 9 / 5;
            }

            public override double ToBase(double source)
            {
                return (source - 491.67) * 5 / 9;
            }
        }
    }
}