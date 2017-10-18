﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Appointed.Views
{
    /// <summary>
    /// Interaction logic for InputText.xaml
    /// </summary>
    public partial class InputText : UserControl
    {
        private string _hint = "";

        public string Hint
        {
            get => _hint;

            set
            {
                bool update = TextField.Text == _hint;
                _hint = value;

                if(update)
                    TextField.Text = _hint;
            }
        }
        private Brush _forground = Brushes.Black;
        private Brush _hintForground = Brushes.Gray;
        public Brush Forground
        {
            get => _forground;

            set
            {
                _forground = value;
            }
        }
        public Brush HintForground
        {
            get => _hintForground;

            set
            {
                _hintForground = value;

                if(!TextField.IsInitialized)
                {
                    TextField.Foreground = _hintForground;
                }

            }
        }

        public InputText()
        {
            InitializeComponent();

            ShowHintText(TextField);
        }

        private void TextField_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == Hint)
            {
                textBox.Text = "";
                textBox.Foreground = Forground;
            }
        }

        private void TextField_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            ShowHintText(textBox);
        }

        private void ShowHintText(TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = Hint;
                textBox.Foreground = HintForground;
            }
        }
    }
}
