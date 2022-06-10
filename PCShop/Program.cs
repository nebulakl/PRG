// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace PCShopRevisited
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PCShopUI());
        }
    }
}