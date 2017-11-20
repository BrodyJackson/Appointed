using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Appointed.Classes
{
    public interface ITextMask
    {
        string FormatText(string input);
    }

    public class DateMask : ITextMask
    {
        public string FormatText(string input)
        {
            input = new string(input.Where(x => Char.IsDigit(x) || x == '-').ToArray());

            StringBuilder stringBuilder = new StringBuilder();

            if (input.Length > 0 && !(input[0] == '-')) stringBuilder.Append(input[0]);
            if (input.Length > 1 && !(input[1] == '-')) stringBuilder.Append(input[1]);
            if (input.Length > 2 && !(input[2] == '-')) stringBuilder.Append(input[2]);
            if (input.Length > 3 && !(input[3] == '-')) stringBuilder.Append(input[3]);

            if (input.Length > 4) stringBuilder.Append("-");
            if (input.Length > 4 && input[4] == '-') input = input.Remove(4, 1);

            if (input.Length > 4 && !(input[4] == '-')) stringBuilder.Append(input[4]);
            if (input.Length > 5 && !(input[5] == '-')) stringBuilder.Append(input[5]);

            if (input.Length > 6) stringBuilder.Append("-");
            if (input.Length > 6 && input[6] == '-') input = input.Remove(6, 1);

            if (input.Length > 6 && !(input[6] == '-')) stringBuilder.Append(input[6]);
            if (input.Length > 7 && !(input[7] == '-')) stringBuilder.Append(input[7]);

            return stringBuilder.ToString();
        }
    }

    public class PostalCodeMask : ITextMask
    {
        public string FormatText(string input)
        {
            input = new String(input.Where(x => Char.IsLetterOrDigit(x)).ToArray());

            StringBuilder stringBuilder = new StringBuilder();

            if (input.Length > 0 && Char.IsLetter(input[0])) stringBuilder.Append(input[0]);
            if (input.Length > 1 && Char.IsDigit(input[1])) stringBuilder.Append(input[1]);
            if (input.Length > 2 && Char.IsLetter(input[2])) stringBuilder.Append(input[2]);

            if (input.Length > 3) stringBuilder.Append(" ");

            if (input.Length > 3 && Char.IsDigit(input[3])) stringBuilder.Append(input[3]);
            if (input.Length > 4 && Char.IsLetter(input[4])) stringBuilder.Append(input[4]);
            if (input.Length > 5 && Char.IsDigit(input[5])) stringBuilder.Append(input[5]);

            return stringBuilder.ToString().ToUpper();
        }
    }

    public class HealthCareIDMask : ITextMask
    {
        public string FormatText(string input)
        {
            input = new String(input.Where(x => Char.IsDigit(x)).ToArray());

            StringBuilder stringBuilder = new StringBuilder();

            if (input.Length > 0) stringBuilder.Append(input[0]);
            if (input.Length > 1) stringBuilder.Append(input[1]);
            if (input.Length > 2) stringBuilder.Append(input[2]);
            if (input.Length > 3) stringBuilder.Append(input[3]);
            if (input.Length > 4) stringBuilder.Append(input[4]);

            if (input.Length > 5) stringBuilder.Append("-");

            if (input.Length > 5) stringBuilder.Append(input[5]);
            if (input.Length > 6) stringBuilder.Append(input[6]);
            if (input.Length > 7) stringBuilder.Append(input[7]);

            return stringBuilder.ToString();
        }
    }


    public class PhoneNumberWithExtMask : ITextMask
    {
        public string FormatText(string input)
        {
            input = new String(input.Where(x => Char.IsDigit(x)).ToArray());

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(new PhoneNumberMask().FormatText(input));

            if (input.Length > 10) stringBuilder.Append("+");

            if (input.Length > 10) stringBuilder.Append(input[10]);
            if (input.Length > 11) stringBuilder.Append(input[11]);
            if (input.Length > 12) stringBuilder.Append(input[12]);

            return stringBuilder.ToString();

        }
    }

    public class PhoneNumberMask : ITextMask
    {

        public string FormatText(string input)
        {
            input = new String(input.Where(x => Char.IsDigit(x)).ToArray());

            StringBuilder stringBuilder = new StringBuilder();

            if (input.Length > 0) stringBuilder.Append("(");

            if (input.Length > 0) stringBuilder.Append(input[0]);
            if (input.Length > 1) stringBuilder.Append(input[1]);
            if (input.Length > 2) stringBuilder.Append(input[2]);

            if (input.Length > 3) stringBuilder.Append(") ");

            if (input.Length > 3) stringBuilder.Append(input[3]);
            if (input.Length > 4) stringBuilder.Append(input[4]);
            if (input.Length > 5) stringBuilder.Append(input[5]);

            if (input.Length > 6) stringBuilder.Append("-");

            if (input.Length > 6) stringBuilder.Append(input[6]);
            if (input.Length > 7) stringBuilder.Append(input[7]);
            if (input.Length > 8) stringBuilder.Append(input[8]);
            if (input.Length > 9) stringBuilder.Append(input[9]);

            return stringBuilder.ToString();

        }

    }
}
