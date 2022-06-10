// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

using static PCShopRevisited.Inventory;

namespace PCShopRevisited
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);

        public void UnregisterObserver(IObserver o);

        public void NotifyObservers(ComponentType cType);
    }

    public interface IObserver
    {
        public void Update(ComponentType cType);
    }
}