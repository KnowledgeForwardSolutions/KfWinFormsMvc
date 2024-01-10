
namespace Example03Lists;

public class ColorSelectionViewController(DiceModel model, ListBox control) 
   : SingleSelectListBoxViewController<DiceModel, Color>(model, control, nameof(model.SelectedColor))
{
   private readonly List<Color> _colors = [
      Color.Red,
      Color.Orange,
      Color.Yellow,
      Color.Green,
      Color.Blue,
      Color.Indigo,
      Color.Violet,
   ];

   public override String GetItemDisplayValue(Color item) => item.Name;

   public override IEnumerable<Color> GetItems() => _colors;
}
