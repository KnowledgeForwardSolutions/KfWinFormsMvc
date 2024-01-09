// Ignore Spelling: Unsubscribe

namespace KfWinFormsMvc;

/// <summary>
///   Binds the click event of a control to a model method. If the return type 
///   of the method is <see cref="void"/> then the method will be called 
///   synchronously. If the return type of the method is <see cref="Task"/> then 
///   the method will be called asynchronously.
/// </summary>
public class ClickController<M> : BindingBase<M, Control>
   where M : INotifyPropertyChanged
{
   private readonly MethodInfo _boundMethodInfo;

   /// <summary>
   ///   Initialize a new <see cref="ClickController{M}"/> object.
   /// </summary>
   /// <param name="model">
   ///   The model containing the method to bind.
   /// </param>
   /// <param name="control">
   ///   The <see cref="Button"/> control to bind to the model method.
   /// </param>
   /// <param name="boundMethodName">
   ///   The name of the bound method.
   /// </param>
   /// <exception cref="ArgumentNullException">
   ///   <paramref name="model"/> is <see langword="null"/>.
   ///   - or -
   ///   <paramref name="control"/> is <see langword="null"/>.
   ///   - or -
   ///   <paramref name="boundMethodName"/> is <see langword="null"/>.
   /// </exception>
   /// <exception cref="ArgumentException">
   ///   <paramref name="boundMethodName"/> is <see cref="String.Empty"/> or 
   ///   all whitespace characters.
   /// </exception>
   public ClickController(M model, Control control, String boundMethodName)
      : base(model, control)
   {
      boundMethodName.RequiresNotEmpty(Messages.EmptyMethodNameMessage);

      _boundMethodInfo = model.GetMethodInfo(boundMethodName);
      if (_boundMethodInfo.ReturnType == typeof(void))
      {
         _control.Click += Control_Click;
      }
      else if (_boundMethodInfo.ReturnType == typeof(Task))
      {
         _control.Click += Control_ClickAsync;
      }
      else
      {
         throw new InvalidOperationException(Messages.InvalidBoundMethodReturnType);
      }
    }

   /// <inheritdoc/>
   public override void UnsubscribeFromEvents()
   {
      if (_boundMethodInfo.ReturnType == typeof(void))
      {
         _control.Click -= Control_Click;
      }
      else
      {
         _control.Click -= Control_ClickAsync;
      }
      base.UnsubscribeFromEvents();
   }

   private void Control_Click(Object? sender, EventArgs e)
      => _boundMethodInfo.Invoke(_model, null);

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
   private async void Control_ClickAsync(Object? sender, EventArgs e)
      => await (Task)_boundMethodInfo.Invoke(_model, null);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
}
