using Prototype.ConcreteColor;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorManager = new ColorManager();

            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            var color1 = colorManager["red"].Clone() as Color;
            var color2 = colorManager["green"].Clone() as Color;
            var color3 = colorManager["blue"].Clone() as Color;

            color1.Show();
        }
    }
}
