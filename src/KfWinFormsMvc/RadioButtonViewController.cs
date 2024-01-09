// Ignore Spelling: Unsubscribe

using System.Collections;

namespace KfWinFormsMvc;

/// <summary>
///   Implements a two way binding between a model property and a 
///   <see cref="RadioButton"/>.
/// </summary>
public class RadioButtonViewController<M,V> : PropertyBinding<M, RadioButton>
   where M : INotifyPropertyChanged
   where V : Enum
{
   private readonly V _selectedValue;

   /// <summary>
   ///   Initialize a new <see cref="RadioButtonViewController{M, V}"/> object.
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
   /// <param name="selectedValue">
   ///   The value of the model bound property associated with the control
   ///   Clicked value of <see langword="true"/>. Should not be default(V) (the
   ///   value associated with a control Clicked value of <see langword="false"/>).
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
   public RadioButtonViewController(
      M model,
      RadioButton control,
      String boundPropertyName,
      V selectedValue) : base(model, control, boundPropertyName)
   {
      if (IComparer.Equals(selectedValue, default(V)))
      {
         throw new ArgumentOutOfRangeException(nameof(selectedValue), Messages.SelectedValueOutOfRangeMessage);
      }

      _selectedValue = selectedValue;
      _control.CheckedChanged += Control_CheckedChanged;
   }

   /// <summary>
   ///   Update the control when the model property changes.
   /// </summary>
   public override void ApplyModelBoundPropertyChange()
   {
      var value = (V?)_boundPropertyInfo.GetValue(_model);
      _control.Checked = EqualityComparer<V>.Default.Equals(_selectedValue, value);
   }

   private void Control_CheckedChanged(Object? sender, EventArgs e)
   {
      var value = (V?)_boundPropertyInfo.GetValue(_model);
      if (_control.Checked && !EqualityComparer<V>.Default.Equals(_selectedValue, value))
      {
         _boundPropertyInfo.SetValue(_model, _selectedValue, null);
      }
   }
}
