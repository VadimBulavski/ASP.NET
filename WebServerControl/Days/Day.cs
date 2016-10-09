using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    [Serializable]
    public class Day
    {
        public string Name { get; set; }
        public Color FontColor { get; set; }
        public FontStyle FontStyle { get; set; }
    }
}
