// Ignore Spelling: Rgb

namespace Example03Lists;

public partial class MainForm : Form
{
   private readonly DiceModel _model;
   private readonly DropDownListViewController<DiceModel, DieType> _selectedDieTypeViewController;
   private readonly NumberOfSidesView _numberOfSidesView;
   private readonly ColorSelectionViewController _colorSelectionViewController;
   private readonly RgbView _rgbView;
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
      _colorSelectionViewController = new(_model, _colorsListBox);
      _rgbView = new RgbView(_model, _rgbDisplayLabel);
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

   private void _clearAllButton_Click(object sender, EventArgs e)
   {

   }
}
