namespace Example03Lists;

public class NumberOfSidesView : TextView<DiceModel>
{
   public NumberOfSidesView(DiceModel model, Label control)
      : base(model, control, nameof(model.SelectedDieType)) { }

   public override void ModelBoundPropertyChanged()
      => _control.Text = _model.SelectedDieType.HasValue
         ? $"{_model.SelectedDieType.Value.NumberOfSides()} sides"
         : String.Empty;
}
