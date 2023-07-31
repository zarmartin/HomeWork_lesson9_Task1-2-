
using HomeWork_lesson9_Task1_2_;

public class Program
{
    public static void Main(string[] args)
    {
        var carTiresCollection = new LabelObjectCollection<CarTires>();


        carTiresCollection.Add(new CarTires { RadialWidth = 205, Label = "Hankook" });

        carTiresCollection.Add(new CarTires { RadialWidth = 215, Label = "Michlen" });

        carTiresCollection.Add(new CarTires { RadialWidth = 195, Label = "Belshina" });

        carTiresCollection.Add(new CarTires { RadialWidth = 185, Label = "Kama" });

        carTiresCollection.Add(new CarTires { RadialWidth = 205, Label = "Bridgestone" });

        carTiresCollection.OutputLabel();

    }
}
