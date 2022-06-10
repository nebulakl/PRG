// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace PCShopRevisited
{
    public partial class Inventory : ISubject
    {
        private readonly List<Item>[] inventory;
        private readonly List<IObserver> observers;

        public Inventory()
        {
            inventory = new List<Item>[Enum.GetNames(typeof(ComponentType)).Length];
            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i] = new List<Item>();
            }
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void UnregisterObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers(ComponentType cType)
        {
            foreach (var o in observers)
            {
                o.Update(cType);
            }
        }

        public List<Item> GetItemsOfType(ComponentType cType)
        {
            return inventory[(int)cType];
        }

        public void AddItem(ComponentType cType, string Name, double Price)
        {
            inventory[(int)cType].Add(new Item(Name, Price));
            NotifyObservers(cType);
        }
    }
}