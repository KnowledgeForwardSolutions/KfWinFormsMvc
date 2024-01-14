
namespace Example03Lists;

public class ColorSelectionViewController(DiceModel model, ListBox control) 
   : SingleSelectListBoxViewController<DiceModel, Color>(model, control, nameof(model.SelectedColor))
{
   public override String GetItemDisplayValue(Color item) => item.Name;

   public override IEnumerable<Color> GetItems() => [
      Color.Red,
      Color.Orange,
      Color.Yellow,
      Color.Green,
      Color.Blue,
      Color.Indigo,
      Color.Violet,
   ];
}
