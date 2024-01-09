namespace KfWinFormsMvc;

/// <summary>
///   Abstract base class for a one-way binding of a model property to a 
///   <see cref="Control"/> property. The binding is from the model to the 
///   control, and is typically used for views that display model properties in
///   a read-only fashion.
/// </summary>
public abstract class PropertyBinding<M, C> : BindingBase<M, C>
   where M : INotifyPropertyChanged
   where C : Control
{
   protected readonly PropertyInfo _boundPropertyInfo;

   /// <summary>
   ///   Initialize a new <see cref="OneWayBinding"/> object.
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
   public PropertyBinding(M model, C control, String boundPropertyName)
      : base(model, control)
   {
      boundPropertyName.RequiresNotEmpty(Messages.EmptyPropertyNameMessage);

      _boundPropertyInfo = model.GetPropertyInfo(boundPropertyName);
      RegisterPropertyChangedAction(boundPropertyName, ApplyModelBoundPropertyChange);
   }

   /// <summary>
   ///   Update the control when the model property changes.
   /// </summary>
   public abstract void ApplyModelBoundPropertyChange();
}
