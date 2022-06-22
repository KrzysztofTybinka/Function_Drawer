using System;

namespace Function_Drawer
{
    /// <summary>
    /// Structure containing float number and its
    /// corresponding color value.
    /// </summary>
    public struct ColorNumber
    {
        private float number;
        private string color;

        public float Number { get => number; }
        public string Color { get => color; }

        public ColorNumber(float num)
        {
            number = num;
            color = "";
            color = ConvertToColor((int)num);
        }

        /// <summary>
        /// Converts givent number in range from
        /// -1000 to 1000 into corresponding color,
        /// where -1000 is blue, 0 is green and 1000 is red. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns>String containing hexadecimal value of corresponding input.</returns>
        /// <exception cref="IndexOutOfRangeException">If number is not in range.</exception>
        private string ConvertToColor(int num)
        {
            if (num > -1000 & num <= -500)
                return ((1000 + num) * 0.51 * 256 + 255).ToString("X");
            if (num > -500 & num <= 0)
                return (255 * 256 + (num * 0.51)).ToString("X");
            if (num > 0 & num <= 500)
                return (num * 0.51 * 65536 + (255 * 256)).ToString("X");
            if (num > 500 & num <= 1000)
                return ((255 * 65536) + (1000 - num) * 0.51).ToString("X");
            throw new IndexOutOfRangeException();
        }
    }
}
