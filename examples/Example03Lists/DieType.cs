namespace Example03Lists;

public enum DieType
{
   D4,
   D6,
   D8,
   D12,
   D20
}

#pragma warning disable CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
public static class DieTypeExtensions
{
   public static Int32 NumberOfSides(this DieType dieType)
   => dieType switch
   {
      DieType.D4 => 4,
      DieType.D6 => 6,
      DieType.D8 => 8,
      DieType.D12 => 12,
      DieType.D20 => 20,
   };

   public static String GetName(this DieType dieType)
   => dieType switch
   {
      DieType.D4 => "Tetrahedron",
      DieType.D6 => "Cube",
      DieType.D8 => "Octahedron",
      DieType.D12 => "Dodecahedron",
      DieType.D20 => "Icosahedron",
   };
#pragma warning restore CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
}
