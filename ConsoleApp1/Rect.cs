namespace ConsoleApp1;
internal class Rect : Shape {
    public override void Draw(Graphics graphics, int x, int y) {
        graphics.DrawRectangle(BorderPen, x, y, Size.Width, Size.Height);
        graphics.FillRectangle(FillBrush, x, y, Size.Width, Size.Height);
    }

    public override bool IsInside(int x, int y) => x < Size.Width && y < Size.Height;
}

