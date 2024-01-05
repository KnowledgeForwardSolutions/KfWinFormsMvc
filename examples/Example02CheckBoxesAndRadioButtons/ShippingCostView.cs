namespace Example02CheckBoxesAndRadioButtons;

#pragma warning disable IDE0290 // Use primary constructor
public class ShippingCostView : TextView<ContactAndShippingModel>
{
   public ShippingCostView(ContactAndShippingModel model, Label control)
      : base(model, control, nameof(model.ShippingSpeed)) { }

   // Note: bound to ShippingSpeed property to get change notifications, but
   // override to display shipping cost.
   public override void ModelBoundPropertyChanged()
      => _control.Text = $"${_model.ShippingCost:0.00}";
}
