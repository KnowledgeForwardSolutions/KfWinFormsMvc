// Ignore Spelling: Sms

namespace Example02CheckBoxesAndRadioButtons;

public class SubscribeToSmsTextOffersViewController : CheckBoxViewController<ContactAndShippingModel>
{
   public SubscribeToSmsTextOffersViewController(ContactAndShippingModel model, CheckBox control)
      : base(model, control, nameof(model.SubscribeToSmsTextOffers))
      => RegisterPropertyChangedAction(nameof(model.PhoneNumber), Model_PhoneNumberChanged);

   public void Model_PhoneNumberChanged()
      => _control.Enabled = !String.IsNullOrWhiteSpace(_model.PhoneNumber);
}

