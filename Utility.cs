using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;

namespace GUI {
    public static class Utility {
        public static readonly System.Drawing.Color Tranparent =
            System.Drawing.Color.FromArgb(0, 255, 255, 255);
        public static readonly System.Drawing.Color SelectedColor =
            //System.Drawing.Color.FromArgb(127, 0x52,0xE8,0xFF);
            System.Drawing.Color.FromArgb(127, 0x38,0xFF,0x4F);
        public static String
            ToArrayString<E>(this IEnumerable<E> array) {
            return array.Aggregate("", (x, y) => $"{x} {y}");
        }
        /// <summary>
        /// 透明度调整
        /// </summary>
        /// <param name="image"></param>
        /// <param name="opacity">  0.1  -- 1 </param>
        /// <returns></returns>
        public static Image ToTransparent(Image image, float opacity) {
            if (opacity >= 1 || opacity < 0) return image;//透明度应在0.1 - 1之间
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            using (var g = Graphics.FromImage(bitmap)) {
                var matrix = new ColorMatrix { Matrix33 = opacity };
                var attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                var rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                g.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bitmap;
        }
    }
}
