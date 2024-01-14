namespace KfWinFormsMvc.Tests.Unit.TestData;

public class DiceModel : ModelBase
{
   private DieType? _selectedDieType = null!;
   private readonly List<Material> _selectedMaterials = [];

   public List<Color> Colors => [
      Color.Red, 
      Color.Orange,
      Color.Yellow,
      Color.Green, 
      Color.Blue,
      Color.Indigo,
      Color.Violet,
   ];

   public List<DieType> DieTypes => [
      DieType.D4,
      DieType.D6,
      DieType.D8,
      DieType.D12,
      DieType.D20,
   ];

   public IReadOnlyList<Material> Materials => [
      Material.Amethyst,
      Material.Carnelian,
      Material.Jade,
      Material.Jasper,
      Material.LapisLazuli,
      Material.Malachite,
      Material.Obsidian,
      Material.Onyx,
      Material.Opal,
      Material.Quartz,
      Material.TigerEye,
      Material.Turquoise,
   ];

   public DieType? SelectedDieType
   {
      get => _selectedDieType;
      set => SetProperty(ref _selectedDieType, value);
   }

   public IReadOnlyList<Material> SelectedMaterials
   {
      get => _selectedMaterials;
      set
      {
         _selectedMaterials.Clear();
         _selectedMaterials.AddRange(value);
         NotifyPropertyChanged(nameof(SelectedMaterials));
      }
   }

   public void ClearAll()
   {
      _selectedDieType = null;
      _selectedMaterials.Clear();

      NotifyAllPropertiesChanged();
   }
}
