namespace Example02CheckBoxesAndRadioButtons;

public class ShippingCostView(ContactAndShippingModel model, Label control)
   : TextView<ContactAndShippingModel>(model, control, nameof(model.ShippingSpeed))
{
   // Note: bound to ShippingSpeed property to get change notifications, but
   // override to display shipping cost.
   public override void ApplyModelBoundPropertyChange()
      => _control.Text = $"${_model.ShippingCost:0.00}";
}
