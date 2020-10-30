using System;
using System.Numerics;

namespace EmptyBox.Foundation
{
    /// <summary>
    /// Describes the width and height of an object.
    /// </summary>
    public struct Size : IEquatable<Size>
    {
        public static bool operator ==(Size x, Size y)
        {
            return x.Height == y.Height && x.Width == y.Width;
        }

        public static bool operator !=(Size x, Size y)
        {
            return x.Height != y.Height || x.Width != y.Width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Initializes a new instance of the Size struct and assigns it an initial width and height.
        /// </summary>
        /// <param name="width">Initial width</param>
        /// <param name="height">Initial height</param>
        public Size(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override bool Equals(object obj)
        {
            return obj is Size size && Equals(size);
        }

        public override int GetHashCode()
        {
            return 47 ^ Height.GetHashCode() ^ Width.GetHashCode();
        }

        public bool Equals(Size other)
        {
            return Height == other.Height && Width == other.Width;
        }

        public Vector2 ToVector2()
        {
            return new Vector2((float)Width, (float)Height);
        }

        public Vector<double> ToVector()
        {
            return new Vector<double>(new[] { Width, Height });
        }
    }
}