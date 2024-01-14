namespace Example03Lists;

public class SelectedMaterialsView(DiceModel model, Label control)
   : TextView<DiceModel>(model, control, nameof(model.SelectedMaterials))
{
   public override void ApplyModelBoundPropertyChange()
      => _control.Text = _model.SelectedMaterials.Count > 0
         ? String.Join(", ", _model.SelectedMaterials.Select(x => x.GetName()).ToList())
         : String.Empty;
}
