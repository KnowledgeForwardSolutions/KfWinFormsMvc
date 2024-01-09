namespace Example03Lists;

public class NumberOfSidesView(DiceModel model, Label control)
   : TextView<DiceModel>(model, control, nameof(model.SelectedDieType))
{
   public override void ApplyModelBoundPropertyChange()
      => _control.Text = _model.SelectedDieType.HasValue
         ? $"{_model.SelectedDieType.Value.NumberOfSides()} sides"
         : String.Empty;
}
