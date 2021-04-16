using Prototype.ConcreteColor;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorManager = new ColorManager();

            colorManager["red"] = new Color(255, 0, 0);
            colorManager["light"] = new SpecifiedColor(1000);

            var color1 = colorManager["red"].Clone() as Color;
            var color2 = colorManager["light"].Clone() as SpecifiedColor;

            color1.Show();
            color2.Show();
        }
    }
}
