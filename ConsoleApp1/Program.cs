const string file = "result.png";

CreateFile();
Process.Start("mspaint.exe", file);

static void CreateFile() {
    const int size = 500;

    using Bitmap image = new(size, size);
    using Graphics graphics = Graphics.FromImage(image);

    Rect rect = new();
    Circle circle = new();
    Triangle triangle = new();

    rect.Draw(graphics, 100, 100);
    circle.Draw(graphics, 200, 200);
    triangle.Draw(graphics, 300, 300);

    image.Save(file, ImageFormat.Png);
}
