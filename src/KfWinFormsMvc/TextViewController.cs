// Ignore Spelling: Unsubscribe

namespace KfWinFormsMvc;

/// <summary>
///   Implements a two way binding between a model property and the Text
///   property of a <see cref="Control"/>.
/// </summary>
public class TextViewController<M> : ViewControllerBase<M, Control>
   where M : INotifyPropertyChanged
{
   private readonly PropertyInfo _boundPropertyInfo;

   /// <summary>
   ///   Initialize a new <see cref="TextViewController{M}"/> object.
   /// </summary>
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
   public TextViewController(
      M model,
      Control control,
      String boundPropertyName
      ) : base(model, control)
   {
      boundPropertyName.RequiresNotEmpty(Messages.EmptyPropertyNameMessage);

      _boundPropertyInfo = model.GetPropertyInfo(boundPropertyName);
      _control.TextChanged += Control_TextChanged;
      RegisterPropertyChangedAction(boundPropertyName, ModelBoundPropertyChanged);
   }

   /// <summary>
   ///   Update the control when the model property changes.
   /// </summary>
   public virtual void ModelBoundPropertyChanged()
   {
      var value = _boundPropertyInfo.GetValue(_model);
      _control.Text = value?.ToString();
   }

   /// <inheritdoc/>
   public override void UnsubscribeFromEvents()
   {
      _control.TextChanged -= Control_TextChanged;
      base.UnsubscribeFromEvents();
   }

   private void Control_TextChanged(Object? sender, EventArgs e)
      => _boundPropertyInfo.SetValue(_model, _control.Text, null);
}
