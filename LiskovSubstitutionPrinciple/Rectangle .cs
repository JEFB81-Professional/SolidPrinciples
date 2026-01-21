namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea() => Width * Height;
    }
}
