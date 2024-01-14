namespace Example03Lists;

public class DiceModel : ModelBase
{
   private Color? _selectedColor = default!;
   private DieType? _selectedDieType = default!;
   private readonly List<Material> _selectedMaterials = [];

   public IReadOnlyList<DieType> DieTypes => [
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

   public Color? SelectedColor
   {
      get => _selectedColor;
      set => SetProperty(ref _selectedColor, value);
   }

   public DieType? SelectedDieType
   {
      get => _selectedDieType;
      set => SetProperty(ref _selectedDieType, value);
   }

   public void ClearAll()
   {
      _selectedDieType = null;
      _selectedColor = null;
      _selectedMaterials.Clear();

      NotifyAllPropertiesChanged();
   }

   public void D6() => SelectedDieType = DieType.D6;

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

}