namespace KfWinFormsMvc.Tests.Unit.TestData;

public class ShippingInfoModel : ModelBase
{
   private ShippingSpeed _shippingSpeed;

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
      set => SetProperty(
         ref _shippingSpeed, 
         value,
         nameof(ShippingSpeed),
         nameof(ShippingCost));
   }

   public void ClearAll()
   {
      _shippingSpeed = ShippingSpeed.None;

      NotifyAllPropertiesChanged();
   }
}
