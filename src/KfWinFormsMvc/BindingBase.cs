// Ignore Spelling: Unsubscribe

namespace KfWinFormsMvc;

/// <summary>
///   Abstract base class for an object that binds a model property to a 
///   <see cref="Control"/> property.
/// </summary>
public abstract class BindingBase<M, C> : IDisposable
   where M : INotifyPropertyChanged
   where C : Control
{
   protected C _control;
   private Boolean _disposedValue;
   private Dictionary<String, Action> _mappedProperties = [];
   protected M _model;

   /// <summary>
   ///   Initialize a new <see cref="BindingBase{M, C}"/> object.
   /// </summary>
   /// <param name="model">
   ///   The model containing the property to bind.
   /// </param>
   /// <param name="control">
   ///   The control to bind to the model property.
   /// </param>
   /// <exception cref="ArgumentNullException">
   ///   <paramref name="model"/> is <see langword="null"/>.
   ///   - or -
   ///   <paramref name="control"/> is <see langword="null"/>.
   /// </exception>
   public BindingBase(M model, C control)
   {
      _model = model ?? throw new ArgumentNullException(nameof(model), Messages.NullModelMessage);
      _control = control ?? throw new ArgumentNullException(nameof(control), Messages.NullControlMessage);

      _model.PropertyChanged += Model_PropertyChanged;
   }

   /// <inheritdoc/>
   public void Dispose()
   {
      // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
      Dispose(disposing: true);
      GC.SuppressFinalize(this);
   }

   /// <summary>
   ///   Release any held resources.
   /// </summary>
   public virtual void ReleaseResources()
   {
      _model = default!;
      _control = default!;
      _mappedProperties = default!;
   }

   /// <summary>
   ///   Unsubscribe from any subscribed events.
   /// </summary>
   public virtual void UnsubscribeFromEvents()
      => _model.PropertyChanged -= Model_PropertyChanged;

   protected virtual void Dispose(Boolean disposing)
   {
      if (!_disposedValue)
      {
         if (disposing)
         {
            UnsubscribeFromEvents();
         }

         ReleaseResources();
         _disposedValue = true;
      }
   }

   /// <summary>
   ///   Register the action to take when the named property of the model is 
   ///   changed.
   /// </summary>
   /// <param name="propertyName">
   ///   The name of the model property.
   /// </param>
   /// <param name="action">
   ///   The action to take when the property is changed.
   /// </param>
   protected void RegisterPropertyChangedAction(
      String propertyName,
      Action action)
   {
      ArgumentException.ThrowIfNullOrWhiteSpace(propertyName, nameof(propertyName));
      ArgumentNullException.ThrowIfNull(action, nameof(action));

      _mappedProperties.Add(propertyName, action);
   }

   private void Model_PropertyChanged(Object? sender, PropertyChangedEventArgs e)
   {
      if (e.PropertyName == String.Empty)
      {
         foreach(var act in _mappedProperties.Values)
         {
            act();
         }
      }

#pragma warning disable CS8604 // Possible null reference argument.
      if (_mappedProperties.TryGetValue(e.PropertyName, out var propertyChangedAction))
      {
         propertyChangedAction();
      }
#pragma warning restore CS8604 // Possible null reference argument.
   }
}
