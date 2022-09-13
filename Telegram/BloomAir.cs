using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public struct BloomAir
    {
        public string _Name;

        private Color _Value;

        public string Name => _Name;

        public Color Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }

        public string ValueHex
        {
            get
            {
                return "#" + _Value.R.ToString("X2", null) + _Value.G.ToString("X2", null) + _Value.B.ToString("X2", null);
            }
            set
            {
                try
                {
                    _Value = ColorTranslator.FromHtml(value);
                }
                catch
                {
                }
            }
        }

        public BloomAir(string name, Color value)
        {
            _Name = name;
            _Value = value;
        }
    }
}
