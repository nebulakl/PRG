// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    internal partial class UnitConverterLib
    {
        private readonly List<Category> categories = new();
        private Category currentCategory;
        private Unit unitSource;
        private Unit unitTarget;

        public UnitConverterLib()
        {
            // Add new Category here
            categories.Add(new Length());
            categories.Add(new Mass());
            categories.Add(new Time());
            categories.Add(new Temperature());
            //categories.Add(new MyCategory());

            SelectCategory(0);
            SelectUnitSource(0);
            SelectUnitTarget(1);
        }

        public double Convert(double sourceValue)
        {
            return unitTarget.FromBase(unitSource.ToBase(sourceValue));
        }

        public int GetCategoryCounts()
        {
            return categories.Count;
        }

        public List<string> GetCategoryStrings()
        {
            List<string> strings = new();
            foreach (Category c in categories)
            {
                strings.Add(c.ToString());
            }
            return strings;
        }

        public string GetCurrentCategoryString()
        {
            return currentCategory.ToString();
        }

        public List<string> GetCurrentCategoryUnits()
        {
            List<string> unitStrings = new();
            foreach (Unit unit in currentCategory.GetUnits())
            {
                unitStrings.Add(unit.ToString());
            }
            return unitStrings;
        }

        public void SelectCategory(int i)
        {
            currentCategory = categories[i];
        }

        public void SelectUnitSource(int i)
        {
            unitSource = currentCategory.GetUnit(i);
        }

        public void SelectUnitTarget(int j)
        {
            unitTarget = currentCategory.GetUnit(j);
        }
    }
}