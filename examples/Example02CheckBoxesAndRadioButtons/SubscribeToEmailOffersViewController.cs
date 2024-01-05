namespace Example02CheckBoxesAndRadioButtons;

public class SubscribeToEmailOffersViewController : CheckBoxViewController<ContactAndShippingModel>
{
   public SubscribeToEmailOffersViewController(ContactAndShippingModel model, CheckBox control)
      : base(model, control, nameof(model.SubscribeToEmailOffers))
      => RegisterPropertyChangedAction(nameof(model.EmailAddress), Model_EmailAddressChanged);

   public void Model_EmailAddressChanged()
      => _control.Enabled = !String.IsNullOrWhiteSpace(_model.EmailAddress);
}
