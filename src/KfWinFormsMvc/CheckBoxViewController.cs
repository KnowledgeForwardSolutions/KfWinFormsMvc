// Ignore Spelling: Unsubscribe

namespace KfWinFormsMvc;

/// <summary>
///   Implements a two way binding between a model property and the Checked
///   property of a <see cref="CheckBox"/>.
/// </summary>
public class CheckBoxViewController<M> : PropertyBinding<M, CheckBox>
   where M : INotifyPropertyChanged
{
   /// <summary>
   ///   Initialize a new <see cref="CheckBoxViewController{M}"/> object.
   /// </summary>
   /// <param name="model">
   ///   The model containing the property to bind.
   /// </param>
   /// <param name="control">
   ///   The <see cref="CheckBox"/> to bind to the model property.
   /// </param>
   /// <param name="boundPropertyName">
   ///   The name of the model property to bind to the <see cref="CheckBox"/>.
   /// </param>
   /// <exception cref="ArgumentNullException">
   ///   <paramref name="model"/> is <see langword="null"/>.
   ///   - or -
   ///   <paramref name="control"/> is <see langword="null"/>.
   ///   - or -
   ///   <paramref name="boundPropertyName"/> is <see langword="null"/>.
   /// </exception>
   /// <exception cref="ArgumentException">
   ///   <paramref name="boundPropertyName"/> is <see cref="String.Empty"/> or 
   ///   all whitespace characters.
   /// </exception>
   public CheckBoxViewController(
      M model,
      CheckBox control,
      String boundPropertyName) : base(model, control, boundPropertyName)
      => _control.CheckedChanged += Control_CheckedChanged;

   /// <summary>
   ///   Update the control when the model property changes.
   /// </summary>
   public override void ApplyModelBoundPropertyChange()
   {
      var value = (Boolean?)_boundPropertyInfo.GetValue(_model);
      _control.Checked = value ?? false;
   }

   /// <inheritdoc/>
   public override void UnsubscribeFromEvents()
   {
      _control.CheckedChanged -= Control_CheckedChanged;
      base.UnsubscribeFromEvents();
   }

   private void Control_CheckedChanged(Object? sender, EventArgs e)
      => _boundPropertyInfo.SetValue(_model, _control.Checked, null);
}
