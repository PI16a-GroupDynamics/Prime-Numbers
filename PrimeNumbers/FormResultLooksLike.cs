﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace MetroFramework_test_at_a_new_project
{
    public partial class FormResultLooksLike : Form
    {
        public static Dictionary<int, string> NewLInes = new Dictionary<int, string>
        {
            [-1] = string.Empty,
            [0] = string.Empty,
            [1] = Environment.NewLine,
            [2] = Environment.NewLine+Environment.NewLine
        };

        public FormResultLooksLike()
        {
            InitializeComponent();
            var str = Printing.SettingsForResult.ItemResultSeparator;
            if (str == default) // по идее, не заходили туда еще
            {
                CBoxNewLines.SelectedIndex = 1;
            }
            else
            {
                AnalizeAndApplyResultSeparator(str);
            }
        }

        private void ChangeResultSeparator(object sender = null, EventArgs e = null)
        {
            Printing.SettingsForResult.ItemResultSeparator =
                BoxResultSeparator.Text + FormResultLooksLike.NewLInes[CBoxNewLines.SelectedIndex];
            ShowChanges();
        }

        private void ShowChanges()
        {
            BoxPreview.Clear();
            var result = new Printing.ResultSaver<int>(new[]{2, 3, 5, 7, 11, 13}, Printing.SettingsForResult.ItemResultSeparator);

            BoxPreview.Text = result.ResultBuilder.ToString();
        }

        private void AnalizeAndApplyResultSeparator([NotNull] string str)
        {
            var arr = str.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            switch (arr.Length)
            {
                case 0: case 1:
                    BoxResultSeparator.Text = str;
                    CBoxNewLines.SelectedIndex = 0;
                    break;
                case 2:
                {
                    BoxResultSeparator.Text = arr[0];
                    CBoxNewLines.SelectedIndex = 1;
                    break;
                }
                case 3:
                {
                    BoxResultSeparator.Text    = arr[0];
                    CBoxNewLines.SelectedIndex = 2;
                    break;
                }
                default:
                    throw new ArgumentException("str разбилась на кол-во строк >3");
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
