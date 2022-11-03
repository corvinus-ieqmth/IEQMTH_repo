using GiftFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftFactory.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color PresentColor { get; set; }
        public Color PresentRibbonColor { get; set; }

        public Toy CreateNew()
        {
            return new Present(PresentColor, PresentRibbonColor);
        }
    }
}
