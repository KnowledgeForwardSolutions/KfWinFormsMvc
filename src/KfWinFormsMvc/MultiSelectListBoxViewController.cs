// Ignore Spelling: Unsubscribe

namespace KfWinFormsMvc;

public class MultiSelectListBoxViewController<M, V> : BindingBase<M, ListBox>
   where M : INotifyPropertyChanged
{
   protected readonly PropertyInfo _itemsPropertyInfo;
   protected readonly PropertyInfo _selectedItemsPropertyInfo;

   private readonly List<V> _items = [];
   private Boolean _updatingSelections = false;

   public MultiSelectListBoxViewController(
      M model,
      ListBox control,
      String itemsPropertyName,
      String selectedItemsPropertyName)
      : base(model, control)
   {
      itemsPropertyName.RequiresNotEmpty(Messages.EmptyPropertyNameMessage);
      selectedItemsPropertyName.RequiresNotEmpty(Messages.EmptyPropertyNameMessage);

      _itemsPropertyInfo = model.GetPropertyInfo(itemsPropertyName);
      if (_itemsPropertyInfo.PropertyType.GetCollectionElementType() != typeof(V))
      {
         throw new InvalidOperationException(Messages.InvalidItemsPropertyType);
      }

      _selectedItemsPropertyInfo = model.GetPropertyInfo(selectedItemsPropertyName);
      if (_selectedItemsPropertyInfo.PropertyType.GetCollectionElementType() != typeof(V))
      {
         throw new InvalidOperationException(Messages.InvalidSelectedItemsPropertyType);
      }

      ApplyModelItemsPropertyChange();

      RegisterPropertyChangedAction(itemsPropertyName, ApplyModelItemsPropertyChange);
      RegisterPropertyChangedAction(selectedItemsPropertyName, ApplyModelSelectedItemsPropertyChange);

      _control.SelectedIndexChanged += Control_SelectedIndexChanged;
   }

   /// <summary>
   ///   Update the control items collection when the model's items collection
   ///   changes.
   /// </summary>
   public virtual void ApplyModelItemsPropertyChange()
   {
      _control.BeginUpdate();
      _control.Items.Clear();
      _items.Clear();
      _items.AddRange(GetItems());
      _control.Items.AddRange(_items.Select(x => GetItemDisplayValue(x)).ToArray());
      _control.EndUpdate();

      ApplyModelSelectedItemsPropertyChange();
   }

   /// <summary>
   ///   Update the control selected items when the model's selected items
   ///   collection changes.
   /// </summary>
   public virtual void ApplyModelSelectedItemsPropertyChange()
   {
      if (_updatingSelections)
      {
         return;
      }

      _updatingSelections = true;
      try
      {
         _control.SelectedIndices.Clear();
         var selections = (_selectedItemsPropertyInfo!.GetValue(_model) as IEnumerable<V>)!;
         foreach(var item in selections)
         {
            var index = _items.IndexOf(item);
            _control.SelectedIndices.Add(index);
         }
      }
      finally
      { 
         _updatingSelections = false; 
      }
   }

   /// <summary>
   ///   Get the display representation of the item for the control's list.
   /// </summary>
   /// <param name="item">
   ///   The item to include in the control's list.
   /// </param>
   /// <returns>
   ///   The display representation of the item.
   /// </returns>
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

   /// <inheritdoc/>
   public override void UnsubscribeFromEvents()
   {
      _control.SelectedIndexChanged -= Control_SelectedIndexChanged;
      base.UnsubscribeFromEvents();
   }

   private void Control_SelectedIndexChanged(Object? sender, EventArgs e)
   {
      if (_updatingSelections)
      {
         return;
      }

      _updatingSelections = true;
      try
      {
         var selectedItems = new List<V>();
         foreach(Int32 index in _control.SelectedIndices)
         {
            selectedItems.Add(_items[index]);
         }

         _selectedItemsPropertyInfo.SetValue(_model, selectedItems, null);
      }
      finally
      {
         _updatingSelections = false;
      }
   }
}
