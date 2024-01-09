// Ignore Spelling: Unsubscribe

namespace KfWinFormsMvc;

/// <summary>
///   View/controller for a simple drop-down list. Binds a model list property
///   to a ComboBox datasource and model property to the ComboBox SelectedValue.
/// </summary>
/// <typeparam name="M">
///   The bound model type.
/// </typeparam>
/// <typeparam name="V">
///   The type of the items bound to the control's item collection.
/// </typeparam>
public class DropDownListViewController<M, V> : BindingBase<M, ComboBox>
   where M : INotifyPropertyChanged
{
   private readonly PropertyInfo _boundPropertyInfo;
   private readonly PropertyInfo? _itemsPropertyInfo;
   private readonly List<V> _items = [];

   /// <summary>
   ///   Initialize a new <see cref="DropDownListViewController{M, V}"/> object.
   /// </summary>
   /// <param name="model">
   ///   The model containing the property to bind.
   /// </param>
   /// <param name="control">
   ///   The <see cref="ComboBox"/> to bind to the model property.
   /// </param>
   /// <param name="boundPropertyName">
   ///   The name of the model property to bind to the <see cref="ComboBox"/>.
   /// </param>
   /// <param name="itemsPropertyName">
   ///   Optional. The name of the model property to bind to the 
   ///   <see cref="ComboBox"/>'s items collection. If <see langword="null"/>
   ///   then a fixed set of values must by supplied by the 
   ///   <see cref="GetItemDisplayValue(V)"/> method.
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
   ///   - or -
   ///   <paramref name="itemsPropertyName"/> is <see cref="String.Empty"/> or 
   ///   all whitespace characters.
   /// </exception>
   /// <exception cref="InvalidOperationException">
   ///   The model items property type is not <see cref="IEnumerable{V}"/>.
   /// </exception>
   public DropDownListViewController(
      M model,
      ComboBox control,
      String boundPropertyName,
      String? itemsPropertyName = null)
      : base(model, control)
   {
      boundPropertyName.RequiresNotEmpty(Messages.EmptyPropertyNameMessage);
      _boundPropertyInfo = model.GetPropertyInfo(boundPropertyName);

      if (itemsPropertyName is null)
      {
         _itemsPropertyInfo = null;
      }
      else
      {
         itemsPropertyName.RequiresNotEmpty(Messages.EmptyItemsPropertyName);
         _itemsPropertyInfo = model.GetPropertyInfo(itemsPropertyName);

         if (_itemsPropertyInfo.PropertyType.GetCollectionElementType() != typeof(V))
         {
            throw new InvalidOperationException(Messages.InvalidItemsPropertyType);
         }
      }

      ModelItemsPropertyChanged();

      _control.SelectedIndexChanged += Control_SelectedIndexChanged;

      RegisterPropertyChangedAction(boundPropertyName, ModelBoundPropertyChanged);
      if (itemsPropertyName is not null)
      {
         RegisterPropertyChangedAction(itemsPropertyName, ModelItemsPropertyChanged);
      }
   }

   /// <inheritdoc/>
   public override void UnsubscribeFromEvents()
   {
      _control.SelectedValueChanged -= Control_SelectedIndexChanged;
      base.UnsubscribeFromEvents();
   }

   /// <summary>
   ///   Get the display representation of the item for the control's list.
   /// </summary>
   /// <param name="item">
   ///   The item to include in the control's list.
   /// </param>
   /// <returns></returns>
   public virtual String GetItemDisplayValue(V item) => item?.ToString() ?? String.Empty;

   /// <summary>
   ///   Get the list items in the order that they should be displayed.
   /// </summary>
   /// <returns>
   ///   An enumerable list of values to populate the control's item collection.
   /// </returns>
   /// <exception cref="InvalidOperationException">
   ///   The model items property is not defined.
   /// </exception>
   public virtual IEnumerable<V> GetItems()
      => _itemsPropertyInfo is null
         ? throw new InvalidOperationException(Messages.ItemsPropertyIsNotDefined)
         : (_itemsPropertyInfo!.GetValue(_model) as IEnumerable<V>)!;

   /// <summary>
   ///   Update the control when the model property changes.
   /// </summary>
   public virtual void ModelBoundPropertyChanged()
   {
      var value = _boundPropertyInfo.GetValue(_model);
      _control.SelectedIndex = value is null ? -1 : _items.IndexOf((V)value);
   }

   public virtual void ModelItemsPropertyChanged()
   {
      _control.Items.Clear();
      _items.Clear();
      _items.AddRange(GetItems());
      _control.Items.AddRange(_items.Select(x => GetItemDisplayValue(x)).ToArray());

      ModelBoundPropertyChanged();
   }

   private void Control_SelectedIndexChanged(Object? sender, EventArgs e)
   {
      Object? value = _control.SelectedIndex != -1
         ? _items[_control.SelectedIndex]
         : null;
      _boundPropertyInfo.SetValue(_model, value, null);
   }
}
