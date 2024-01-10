// Ignore Spelling: Rgb

namespace Example03Lists;

public class RgbView(DiceModel model, Label control)
   : TextView<DiceModel>(model, control, nameof(model.SelectedColor))
{
   public override void ApplyModelBoundPropertyChange()
   {
      if (_model.SelectedColor is null)
      {
         _control.Text = String.Empty;
         return;
      }

      var color = _model.SelectedColor!.Value;
      _control.ForeColor = color;
      _control.Text = $"{color.R},{color.G},{color.B}";
   }
}
