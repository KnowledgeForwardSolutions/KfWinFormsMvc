namespace Example03Lists;

public class AvailableMaterialsViewController(DiceModel model, ListBox control)
   : MultiSelectListBoxViewController<DiceModel, Material>(
      model, 
      control, 
      nameof(model.Materials), 
      nameof(model.SelectedMaterials))
{
   public override String GetItemDisplayValue(Material item) => item.GetName();
}
