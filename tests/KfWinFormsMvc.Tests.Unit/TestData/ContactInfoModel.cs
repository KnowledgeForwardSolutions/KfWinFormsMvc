// Ignore Spelling: Signup

namespace KfWinFormsMvc.Tests.Unit.TestData;

public class ContactInfoModel : ModelBase
{
   private String _emailAddress = String.Empty;
   private String _phoneNumber = String.Empty;
   private Boolean _subscribeToEmailOffers;
   private Boolean _subscribeToTextOffers;

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

   public Boolean SubscribeToTextOffers
   {
      get => _subscribeToTextOffers;
      set => SetProperty(ref _subscribeToTextOffers, value);
   }

   public void ClearAll()
   {
      _emailAddress = String.Empty;
      _phoneNumber = String.Empty;
      _subscribeToEmailOffers = false;
      _subscribeToTextOffers = false;

      NotifyAllPropertiesChanged();
   }
}
