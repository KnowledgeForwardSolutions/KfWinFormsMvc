namespace KfWinFormsMvc;

/// <summary>
///   Implements a one way binding from a model property to the Text property
///   of a <see cref="Control"/>.
/// </summary>
/// <remarks>
///   Initialize a new <see cref="TextView"/> object.
/// </remarks>
/// <param name="model">
///   The model containing the property to bind.
/// </param>
/// <param name="control">
///   The <see cref="Control"/> to bind to the model property.
/// </param>
/// <param name="boundPropertyName">
///   The name of the model property to bind to the <see cref="Control"/>.
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
public class TextView<M>(M model, Control control, String boundPropertyName) : PropertyBinding<M, Control>(model, control, boundPropertyName)
   where M : INotifyPropertyChanged
{
   /// <inheritdoc/>
   public override void ApplyModelBoundPropertyChange()
   {
      var value = _boundPropertyInfo.GetValue(_model);
      _control.Text = value?.ToString();
   }
}
