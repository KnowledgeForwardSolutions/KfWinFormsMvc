namespace KfWinFormsMvc;

/// <summary>
///   Implements a one way binding from a model property to the Text property
///   of a <see cref="Control"/>.
/// </summary>
public class TextView<M> : ViewControllerBase<M, Control>
   where M : INotifyPropertyChanged
{
   private readonly PropertyInfo _boundPropertyInfo;

   /// <summary>
   ///   Initialize a new <see cref="TextView"/> object.
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
   public TextView(M model, Control control, String boundPropertyName)
      : base(model, control)
   {
      boundPropertyName.RequiresNotEmpty(Messages.EmptyPropertyNameMessage);

      _boundPropertyInfo = model.GetPropertyInfo(boundPropertyName);
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
}
