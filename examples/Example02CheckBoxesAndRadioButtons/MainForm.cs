// Ignore Spelling: Sms

namespace Example02CheckBoxesAndRadioButtons;

public partial class MainForm : Form
{
   private readonly ContactAndShippingModel _model;

   private readonly TextViewController<ContactAndShippingModel> _emailAddressViewController;
   private readonly SubscribeToEmailOffersViewController _subscribeToEmailOffersViewController;
   private readonly TextViewController<ContactAndShippingModel> _phoneNumberViewController;
   private readonly SubscribeToSmsTextOffersViewController _subscribeToSmsTextOffersViewController;
   private readonly RadioButtonViewController<ContactAndShippingModel, ShippingSpeed> _groundShippingViewController;
   private readonly RadioButtonViewController<ContactAndShippingModel, ShippingSpeed> _secondDayAirShippingViewController;
   private readonly RadioButtonViewController<ContactAndShippingModel, ShippingSpeed> _overnightShippingViewController;
   private readonly ShippingCostView _shippingCostView;
   private readonly ClickController<ContactAndShippingModel> _clearAllController;

   public MainForm()
   {
      InitializeComponent();

      _model = new();

      _emailAddressViewController = new(_model, _emailAddressTextBox, nameof(_model.EmailAddress));
      _subscribeToEmailOffersViewController = new(_model, _subscribeToEmailOffersCheckBox);
      _phoneNumberViewController = new(_model, _phoneNumberTextBox, nameof(_model.PhoneNumber));
      _subscribeToSmsTextOffersViewController = new(_model, _subscribeToSmsTextOffersCheckBox);
      _groundShippingViewController = new(
         _model,
         _groundShippingRadioButton,
         nameof(_model.ShippingSpeed),
         ShippingSpeed.Ground);
      _secondDayAirShippingViewController = new(
         _model,
         _secondDayAirShippingRadioButton,
         nameof(_model.ShippingSpeed),
         ShippingSpeed.SecondDayAir);
      _overnightShippingViewController = new(
         _model,
         _overnightShippingRadioButton,
         nameof(_model.ShippingSpeed),
         ShippingSpeed.Overnight);
      _shippingCostView = new(_model, _shippingCostDisplayLabel);
      _clearAllController = new(_model, _clearAllButton, nameof(_model.ClearAll));

      _model.NotifyAllPropertiesChanged();
   }
}
