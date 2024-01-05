// Ignore Spelling: Sms

namespace Example02CheckBoxesAndRadioButtons;

public class ContactAndShippingModel : ModelBase
{
   private String _emailAddress = String.Empty;
   private String _phoneNumber = String.Empty;
   private Boolean _subscribeToEmailOffers = true;
   private Boolean _subscribeToSmsTextOffers = true;
   private ShippingSpeed _shippingSpeed;

   public String EmailAddress
   {
      get => _emailAddress;
      set => SetProperty(ref _emailAddress, value);
   }

   public String PhoneNumber
   {
      get => _phoneNumber;
      set => SetProperty(ref _phoneNumber, value);
   }

   public Boolean SubscribeToEmailOffers
   {
      get => _subscribeToEmailOffers;
      set => SetProperty(ref _subscribeToEmailOffers, value);
   }

   public Boolean SubscribeToSmsTextOffers
   {
      get => _subscribeToSmsTextOffers;
      set => SetProperty(ref _subscribeToSmsTextOffers, value);
   }

   public Decimal ShippingCost => ShippingSpeed switch
   {
      ShippingSpeed.Ground => 4.99M,
      ShippingSpeed.SecondDayAir => 12.85M,
      ShippingSpeed.Overnight => 29.25M,
      _ => 0
   };

   public ShippingSpeed ShippingSpeed
   {
      get => _shippingSpeed;
      set => SetProperty(ref _shippingSpeed, value);
   }

   public void ClearAll()
   {
      _emailAddress = String.Empty;
      _phoneNumber = String.Empty;
      _subscribeToEmailOffers = true;
      _subscribeToSmsTextOffers = true;
      _shippingSpeed = ShippingSpeed.None;

      NotifyAllPropertiesChanged();
   }
}
