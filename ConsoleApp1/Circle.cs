namespace ConsoleApp1;
internal class Circle : Shape {
    int radius => Math.Min(Math.Min(Size.Width, Size.Height), Radius + Radius);
    public override void Draw(Graphics graphics, int x, int y) {
        graphics.DrawEllipse(BorderPen, x, y, radius, radius);
        graphics.FillEllipse(FillBrush, x, y, radius, radius);
    }

    public override bool IsInside(int x, int y) => x * x + y * y < radius * radius;

    public int Radius { get; set; } = 50;
}
