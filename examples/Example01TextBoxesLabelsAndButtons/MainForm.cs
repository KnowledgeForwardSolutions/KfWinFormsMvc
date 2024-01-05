namespace Example01TextBoxesLabelsAndButtons;

public partial class MainForm : Form
{
   private readonly PersonModel _model;
   private readonly TextViewController<PersonModel> _firstNameViewController;
   private readonly TextViewController<PersonModel> _lastNameViewController;
   private readonly TextView<PersonModel> _fullNameView;
   private readonly ClickController<PersonModel> _clearAllController;

   public MainForm()
   {
      InitializeComponent();

      _model = new PersonModel();
      _firstNameViewController = new(_model, _firstNameTextBox, nameof(_model.FirstName));
      _lastNameViewController = new(_model, _lastNameTextBox, nameof(_model.LastName));
      _fullNameView = new FullNameView(_model, _fullNameDisplayLabel);
      _clearAllController = new(_model, _clearAllButton, nameof(_model.ClearAll));

      _model.NotifyAllPropertiesChanged();
   }
}
