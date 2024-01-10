namespace Example03Lists;

public class DiceModel : ModelBase
{
   private Color? _selectedColor = default!;
   private DieType? _selectedDieType = default!;

   public List<DieType> DieTypes => [
      DieType.D4,
      DieType.D6,
      DieType.D8,
      DieType.D12,
      DieType.D20,
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

      NotifyAllPropertiesChanged();
   }

   public void D6() => SelectedDieType = DieType.D6;
}