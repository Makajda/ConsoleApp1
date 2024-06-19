
namespace ConsoleApp1;
internal abstract class Shape {
    const float penWidth = 5f;
    protected Brush FillBrush => new SolidBrush(FillColor);
    protected Pen BorderPen => new(new SolidBrush(BorderColor), penWidth);
    /// <summary>
    /// метод вывода на Graphics;
    /// </summary>
    public abstract void Draw(Graphics graphics, int x, int y);
    /// <summary>
    /// метод проверки лежит ли заданная точка внутри примитива;
    /// </summary>
    public abstract bool IsInside(int x, int y);
    /// <summary>
    /// цвет заливки примитива;
    /// </summary>
    public Color FillColor { get; set; } = Color.FromArgb(0, 255, 0);
    /// <summary>
    /// цвет окантовки (рамки) примитива;
    /// </summary>
    public Color BorderColor { get; set; } = Color.FromArgb(255, 0, 0);
    /// <summary>
    /// ширина и высота;
    /// </summary>
    public Size Size { get; set; } = new(100, 100);
}
