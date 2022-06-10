// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

using static PCShopRevisited.Inventory;

namespace PCShopRevisited
{
    public partial class PCShopUI : Form, IObserver
    {
        private readonly Inventory _inventory = new();
        private int _pcCount = 0;

        public PCShopUI()
        {
            _inventory.RegisterObserver(this);
            InitializeComponent();

            _inventory.AddItem(ComponentType.CPU, "Core i3", 299.99);
            _inventory.AddItem(ComponentType.CPU, "Ryzen 5", 408.99);
            _inventory.AddItem(ComponentType.HDD, "Blue 4TB", 109.99);
            _inventory.AddItem(ComponentType.HDD, "WD 16TB", 579.99);
            _inventory.AddItem(ComponentType.RAM, "OWC 16GB", 302.49);
            _inventory.AddItem(ComponentType.RAM, "OWC 8GB", 82.00);
        }

        public void Update(ComponentType cType)
        {
            switch (cType)
            {
                case ComponentType.CPU:
                    PopulateComboBox(comboBox_cpu, _inventory.GetItemsOfType(cType));
                    break;

                case ComponentType.HDD:
                    PopulateComboBox(comboBox_hd, _inventory.GetItemsOfType(cType));
                    break;

                case ComponentType.RAM:
                    PopulateComboBox(comboBox_ram, _inventory.GetItemsOfType(cType));
                    break;

                default:
                    break;
            }
        }

        private static void PopulateComboBox(ComboBox c, List<Item> l)
        {
            c.Items.Clear();
            foreach (Item item in l)
            {
                c.Items.Add(item.ToString());
            }
        }

        private void button_compute_Click(object sender, EventArgs e)
        {
            if (comboBox_cpu.SelectedIndex != -1 &&
                comboBox_hd.SelectedIndex != -1 &&
                comboBox_ram.SelectedIndex != -1)
            {
                double totalPrice = ComputeTotalPrice();
                _pcCount++;

                if (textBox_output.Text == "")
                {
                    textBox_output.Text = "Selected PCs Cost:" + Environment.NewLine;
                }

                textBox_output.Text += "\t" +
                    String.Format("PC {0}: {1}, {2}, {3} => ${4}",
                    _pcCount,
                    _inventory.GetItemsOfType(ComponentType.CPU)[comboBox_cpu.SelectedIndex].Name,
                    _inventory.GetItemsOfType(ComponentType.HDD)[comboBox_hd.SelectedIndex].Name,
                    _inventory.GetItemsOfType(ComponentType.RAM)[comboBox_ram.SelectedIndex].Name,
                    totalPrice) + Environment.NewLine;
            }
        }

        private double ComputeTotalPrice()
        {
            return 500 +
                _inventory.GetItemsOfType(ComponentType.CPU)[comboBox_cpu.SelectedIndex].Price +
                _inventory.GetItemsOfType(ComponentType.HDD)[comboBox_hd.SelectedIndex].Price +
                _inventory.GetItemsOfType(ComponentType.RAM)[comboBox_ram.SelectedIndex].Price;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_output.Text = "";
            _pcCount = 0;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            _inventory.UnregisterObserver(this);
            Close();
        }
    }
}