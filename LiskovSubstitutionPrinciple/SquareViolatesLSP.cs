namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class Square : RectangleViolatesLSP
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}