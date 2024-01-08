namespace Example03Lists;

public partial class MainForm : Form
{
   private readonly DiceModel _model;
   private readonly DropDownListViewController<DiceModel, DieType> _selectedDieTypeViewController;
   private readonly NumberOfSidesView _numberOfSidesView;
   private readonly ClickController<DiceModel> _d6Controller;
   private readonly ClickController<DiceModel> _clearAllController;

   public MainForm()
   {
      InitializeComponent();

      _model = new DiceModel();

      _selectedDieTypeViewController = new(
         _model,
         _dieTypeComboBox,
         nameof(_model.SelectedDieType),
         nameof(_model.DieTypes));
      _numberOfSidesView = new NumberOfSidesView(_model, _numSidesDisplayLabel);
      _d6Controller = new(
         _model,
         _d6Button,
         nameof(_model.D6));
      _clearAllController = new(
         _model,
         _clearAllButton,
         nameof(_model.ClearAll));

      _model.ClearAll();
   }

   private void _d12Button_Click(object sender, EventArgs e)
   {
      _model.SelectedDieType = DieType.D12;
   }
}
