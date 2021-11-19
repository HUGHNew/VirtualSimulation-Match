using System;
using System.Collections.Generic;
using System.Linq;

namespace GUI {
    public static class Utility {
        public static readonly System.Drawing.Color Tranparent =
            System.Drawing.Color.FromArgb(0, 255, 255, 255);
        public static String
            ToArrayString<E>(this IEnumerable<E> array) {
            return array.Aggregate("", (x, y) => $"{x} {y}");
        }
    }
}
