// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private abstract class Category
        {
            protected string Name = "";
            protected List<Unit> Units = new();

            public void AddUnit(Unit u)
            {
                Units.Add(u);
            }

            public Unit GetUnit(int i)
            {
                return Units[i];
            }

            public List<Unit> GetUnits()
            {
                return Units;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}