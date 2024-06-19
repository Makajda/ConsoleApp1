namespace ConsoleApp1;
internal class Triangle : Shape {
    Point[] GetPoints(int x = 0, int y = 0) {
        int w = Size.Width / 2;
        int l = (int)Math.Round(Size.Height * Math.Tan(Angle / 2 * Math.PI / 180), 0);
        return [new(x + w, y), new(x + w - l, y + Size.Height), new(x + w + l, y + Size.Height)];
    }
    public override void Draw(Graphics graphics, int x, int y) {
        var t = GetPoints(x, y);
        graphics.DrawPolygon(BorderPen, t);
        graphics.FillPolygon(FillBrush, t);
    }

    public override bool IsInside(int x, int y) {
        var t = GetPoints();
        int a = (t[1].X - x) * (t[2].Y - t[1].Y) - (t[2].X - t[1].X) * (t[1].Y - y);
        int b = (t[2].X - x) * (t[3].Y - t[2].Y) - (t[3].X - t[2].X) * (t[2].Y - y);
        int c = (t[3].X - x) * (t[1].Y - t[3].Y) - (t[1].X - t[3].X) * (t[3].Y - y);
        return ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0));
    }

    public int Angle { get; set; } = 60;
}
