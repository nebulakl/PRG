// Copyright 2022, Honpan Lung
// SPDX-License-Identifier: GPL-3.0-or-later

namespace UnitConverter
{
    public partial class UnitConverterUI : Form
    {
        private readonly UnitConverterLib unitConverter = new();

        public UnitConverterUI()
        {
            InitializeComponent();
            PopulateRadioButtons();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTargetValue();
        }

        private void comboBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTargetValue();
        }

        private void PopulateRadioButtons()
        {
            List<RadioButton> radioButtonsCategory = new();
            for (int i = 0; i < unitConverter.GetCategoryCounts(); i++)
            {
                radioButtonsCategory.Add(new RadioButton());
                groupBoxType.Controls.Add(radioButtonsCategory[i]);
                radioButtonsCategory[i].AutoSize = true;
                radioButtonsCategory[i].Location = new Point(7, 20 + i * 24);
                radioButtonsCategory[i].Name = unitConverter.GetCategoryStrings()[i];
                radioButtonsCategory[i].Size = new Size(85, 17);
                radioButtonsCategory[i].TabIndex = i;
                radioButtonsCategory[i].TabStop = true;
                radioButtonsCategory[i].Text = unitConverter.GetCategoryStrings()[i];
                radioButtonsCategory[i].UseVisualStyleBackColor = true;
                radioButtonsCategory[i].CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                unitConverter.SelectCategory(rb.TabIndex);
                textConvertType.Text = "Convert " + unitConverter.GetCurrentCategoryString();
                textBoxSource.Enabled = false;
                textBoxTarget.Enabled = false;
                textBoxSource.Text = "";
                textBoxTarget.Text = "";
                comboBoxSource.Items.Clear();
                comboBoxTarget.Items.Clear();

                //populate dropdown menu
                foreach (string unit in unitConverter.GetCurrentCategoryUnits())
                {
                    comboBoxSource.Items.Add(unit);
                    comboBoxTarget.Items.Add(unit);
                }

                // this assume each category has at least 2 units
                comboBoxSource.SelectedIndex = 0;
                comboBoxTarget.SelectedIndex = 1;
                textBoxSource.Enabled = true;
                textBoxTarget.Enabled = true;
                textBoxSource.Focus();
            }
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            UpdateTargetValue();
        }

        private void UpdateTargetValue()
        {
            if (textBoxSource.Text != "")
            {
                unitConverter.SelectUnitSource(comboBoxSource.SelectedIndex);
                unitConverter.SelectUnitTarget(comboBoxTarget.SelectedIndex);
                try
                {
                    textBoxTarget.Text = Convert.ToString(unitConverter.Convert(Convert.ToDouble(textBoxSource.Text)));
                }
                catch (FormatException)
                {
                    textBoxTarget.Text = "Input must be a valid quantity.";
                }
                textBoxSource.Focus();
            }
        }
    }
}