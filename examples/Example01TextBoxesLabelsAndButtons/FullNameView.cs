namespace Example01TextBoxesLabelsAndButtons;

public class FullNameView : TextView<PersonModel>
{
   public FullNameView(PersonModel model, Label label)
      : base(model, label, nameof(PersonModel.FirstName))
   {
      RegisterPropertyChangedAction(
         nameof(_model.LastName),
         ApplyModelBoundPropertyChange);
   }

   public override void ApplyModelBoundPropertyChange()
   {
      var hasFirstName = !String.IsNullOrEmpty(_model.FirstName);
      var hasLastName = !String.IsNullOrEmpty(_model.LastName);

      _control.Text = hasFirstName && hasLastName
         ? $"{_model.LastName}, {_model.FirstName}"
         : hasFirstName ? _model.FirstName : _model.LastName;
   }
}
