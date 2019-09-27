using System;

namespace OpligatoriskOpgave1
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sideTal;
        private string _isbn13;

        public Bog()
        {

        }

        public Bog(string titel, string forfatter, int sideTal, string isbn13)
        {
            Titel = titel;
            Forfatter = forfatter;
            SideTal = sideTal;
            Isbn13 = isbn13;
        }

        public string Titel
        {
            get => _titel;
            set
            {
                if (value.Length >= 2) _titel = value;
                else throw new ArgumentException();
            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set => _forfatter = value;
        }

        public int SideTal
        {
            get => _sideTal;
            set
            {
                if (value >= 10 && value <= 1000) _sideTal = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length == 13) _isbn13 = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
    }
}
