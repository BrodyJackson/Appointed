using Appointed.Classes;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Appointed.Views.Controls
{
    /// <summary>
    /// Interaction logic for InputText.xaml
    /// </summary>
    public partial class InputText : UserControl
    {
        public enum MASK { NONE, PHONENUMBER, PHONENUMBER_WITHEXT, HEALTHID, POSTAL, DATE}

        public MASK Mask { get; set; }

        private ITextMask _textMask;

        private Brush _defaultBorder;

        private string _hint = "";

        public bool Valid { get; private set; }

        public string Hint
        {
            get { return _hint; }

            set
            {
                bool update = TextField.Text == _hint;
                _hint = value;

                if (update)
                    TextField.Text = _hint;
            }
        }


        private Brush _forground = Brushes.Black;
        private Brush _hintForground = Brushes.Gray;

        public Brush Forground
        {
            get { return _forground; }

            set
            {
                _forground = value;
            }
        }

        public Brush HintForground
        {
            get { return _hintForground; }

            set
            {
                _hintForground = value;

                if (!TextField.IsInitialized)
                {
                    TextField.Foreground = _hintForground;
                }

            }
        }

        public InputText()
        {
            InitializeComponent();

            _defaultBorder = TextField.BorderBrush;
            Valid = true;

            TextField.TextChanged += TextField_TextChanged;
            TextField.TextChanged += TextField_ApplyTextMask;

            ShowHintText(TextField);

            Loaded += InputTextLoaded;

        }

        public void MarkValid()
        {
            TextField.BorderBrush = _defaultBorder;
            Valid = true;
        }

        public void MarkInvalid()
        {
            TextField.BorderBrush = Brushes.Red;
            Valid = false;
        }

        private void InputTextLoaded(object sender, RoutedEventArgs e)
        {
            switch (Mask)
            {
                case MASK.PHONENUMBER:
                    _textMask = new PhoneNumberMask();
                    break;
                case MASK.PHONENUMBER_WITHEXT:
                    _textMask = new PhoneNumberWithExtMask();
                    break;
                case MASK.HEALTHID:
                    _textMask = new HealthCareIDMask();
                    break;
                case MASK.POSTAL:
                    _textMask = new PostalCodeMask();
                    break;
                case MASK.DATE:
                    _textMask = new DateMask();
                    break;
                default:
                    break;
            }
        }

        private void TextField_ApplyTextMask(object sender, TextChangedEventArgs e)
        {
            TextField.CaretIndex = TextField.Text.Length;

            if(_textMask != null && TextField.Text != _hint)
            {
                TextField.Text = _textMask.FormatText(TextField.Text);
            }
        }

        private void TextField_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == Hint)
            {
                ShowHintText(textBox);
            }
            else
            {
                textBox.Foreground = Forground;
            }
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

        public void ShowHintText(TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = Hint;
                textBox.Foreground = HintForground;
            }
        }
    }
}
