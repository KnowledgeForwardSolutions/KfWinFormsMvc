namespace Example03Lists;

public class DiceModel : ModelBase
{
   private DieType? _selectedDieType = default!;

   public List<DieType> DieTypes => [
      DieType.D4,
      DieType.D6,
      DieType.D8,
      DieType.D12,
      DieType.D20,
   ];

   public DieType? SelectedDieType
   {
      get => _selectedDieType;
      set => SetProperty(ref _selectedDieType, value);
   }

   public void ClearAll() => SelectedDieType = null;

   public void D6() => SelectedDieType = DieType.D6;
}