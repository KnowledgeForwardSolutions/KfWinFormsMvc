namespace KfWinFormsMvc;

/// <summary>
///   Abstract base class for a MVC model, with built-in support for 
///   <see cref="INotifyPropertyChanged"/> interface.
/// </summary>
public abstract class ModelBase : INotifyPropertyChanged
{
   public event PropertyChangedEventHandler? PropertyChanged = default!;

   protected Boolean SetProperty<T>(
      ref T storage,
      T value,
      [CallerMemberName] String propertyName = null!)
   {
      if (EqualityComparer<T>.Default.Equals(storage, value))
      {
         return false;
      }

      storage = value;
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

      return true;
   }

   protected Boolean SetProperty<T>(
      ref T storage,
      T value,
      params String[] propertyNames)
   {
      if (EqualityComparer<T>.Default.Equals(storage, value))
      {
         return false;
      }

      storage = value;
      foreach (var name in propertyNames)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
      }

      return true;
   }

   protected void NotifyPropertyChanged(String propertyName)
   {
      ArgumentNullException.ThrowIfNull(nameof(propertyName));

      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
   }
}
