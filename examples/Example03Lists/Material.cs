namespace Example03Lists;

public enum Material
{
   Amethyst,
   Carnelian,
   Jade,
   Jasper,
   LapisLazuli,
   Malachite,
   Obsidian,
   Onyx,
   Opal,
   Quartz,
   TigerEye,
   Turquoise,
}

public static class MaterialsExtensions
{
   public static String GetName(this Material material)
#pragma warning disable CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
      => material switch
      {
         Material.Amethyst => "Amethyst",
         Material.Carnelian => "Carnelian",
         Material.Jade => "Jade",
         Material.Jasper => "Jasper",
         Material.LapisLazuli =>"LapisLazuli",
         Material.Malachite => "Malachite",
         Material.Obsidian => "Obsidian",
         Material.Onyx => "Onyx",
         Material.Opal => "Opal",
         Material.Quartz => "Quartz",
         Material.TigerEye => "TigerEye",
         Material.Turquoise => "Turquoise",
      };
#pragma warning restore CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
}
