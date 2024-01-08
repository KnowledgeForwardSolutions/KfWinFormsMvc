namespace KfWinFormsMvc.Tests.Unit.TestData;

public class DiceModel : ModelBase
{
   private DieType? _selectedDieType = null!;

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

   public DieType? SelectedDieType
   {
      get => _selectedDieType;
      set => SetProperty(ref _selectedDieType, value);
   }

   public void ClearAll()
   {
      _selectedDieType = null;

      NotifyAllPropertiesChanged();
   }
}
