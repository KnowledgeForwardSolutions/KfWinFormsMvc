namespace KfWinFormsMvc.Tests.Unit;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
public class MultiSelectListBoxViewControllerTests
{
   private const String _itemsPropertyName = nameof(DiceModel.Materials);
   private const String _selectedItemsPropertyName = nameof(DiceModel.SelectedMaterials);

   private MultiSelectListBoxViewController<DiceModel, Material> GetSystemUnderTest(DiceModel model, ListBox control)
      => new(model, control, _itemsPropertyName, _selectedItemsPropertyName);

   #region Constructor Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldCreateObject_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      // Act.
      var sut = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);

      // Assert.
      sut.Should().NotBeNull();
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldPopulateControlItems_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      // Act.
      var sut = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);

      // Assert.
      sut.Should().NotBeNull();
      control.Items.Count.Should().Be(model.Materials.Count);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenModelIsNull()
   {
      // Arrange.
      DiceModel model = null!;
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.NullModelMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(model))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenControlIsNull()
   {
      // Arrange.
      var model = new DiceModel();
      ListBox control = null!;
      var itemsPropertyName = nameof(model.Materials);
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.NullControlMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(control))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenItemsPropertyNameIsNull()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      String itemsPropertyName = null!;
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(itemsPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowArgumentException_WhenItemsPropertyNameIsEmpty(String itemsPropertyName)
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(itemsPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenSelectedItemsPropertyNameIsNull()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);
      String selectedItemsPropertyName = null!;

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(selectedItemsPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowArgumentException_WhenSelectedItemsPropertyNameIsEmpty(String selectedItemsPropertyName)
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(selectedItemsPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowInvalidOperationException_WhenItemsPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = "RandomPropertyName";
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, itemsPropertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowInvalidOperationException_WhenSelectedItemsPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);
      var selectedItemsPropertyName = "RandomPropertyName";

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, selectedItemsPropertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowInvalidOperationException_WhenItemsPropertyIsInvalidType()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Colors);
      var selectedItemsPropertyName = nameof(model.SelectedMaterials);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.InvalidItemsPropertyType;

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Constructor_ShouldThrowInvalidOperationException_WhenSelectedItemsPropertyIsInvalidType()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var itemsPropertyName = nameof(model.Materials);
      var selectedItemsPropertyName = nameof(model.Colors);

      var act = () => _ = new MultiSelectListBoxViewController<DiceModel, Material>(
         model,
         control,
         itemsPropertyName,
         selectedItemsPropertyName);
      var expectedMessage = Messages.InvalidSelectedItemsPropertyType;

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   #endregion

   #region Binding Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void MultiSelectListBoxViewController_Binding_ShouldUpdateModelSelectedItems_WhenSingleItemIsSelected()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var sut = GetSystemUnderTest(model, control);

      // Act.
      control.SelectedIndex = 2;

      // Assert.
      model.SelectedMaterials.Should().HaveCount(1);
      model.SelectedMaterials.Should().Contain(Material.Jade);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Binding_ShouldUpdateModelSelectedItems_WhenMultipleItemsAreSelected()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var sut = GetSystemUnderTest(model, control);

      // Act.
      control.SelectedIndices.Add(2);
      control.SelectedIndices.Add(3);
      control.SelectedIndices.Add(4);

      // Assert.
      model.SelectedMaterials.Should().HaveCount(3);
      model.SelectedMaterials.Should().Contain(Material.Jade);
      model.SelectedMaterials.Should().Contain(Material.Jasper);
      model.SelectedMaterials.Should().Contain(Material.LapisLazuli);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Binding_ShouldUpdateControlSelectedItems_WhenModelSingleItemSelected()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var sut = GetSystemUnderTest(model, control);

      // Act.
      model.SelectedMaterials = new List<Material>() { Material.Jade };

      // Assert.
      control.SelectedIndices.Count.Should().Be(1);
      control.SelectedIndices[0].Should().Be(2);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Binding_ShouldUpdateControlSelectedItems_WhenModelModelItemsAreSelected()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var sut = GetSystemUnderTest(model, control);

      // Act.
      model.SelectedMaterials = new List<Material>() { Material.Jade, Material.Jasper, Material.LapisLazuli };

      // Assert.
      control.SelectedIndices.Count.Should().Be(3);
      control.SelectedIndices[0].Should().Be(2);
      control.SelectedIndices[1].Should().Be(3);
      control.SelectedIndices[2].Should().Be(4);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Binding_ShouldRefreshControlItems_WhenModelUpdatesAllProperties()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var sut = GetSystemUnderTest(model, control);

      // Act.
      model.ClearAll();

      // Assert.
      control.Items.Count.Should().Be(model.Materials.Count);
   }

   [Fact]
   public void MultiSelectListBoxViewController_Binding_ShouldRefreshControlSelectedItems_WhenModelUpdatesAllProperties()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ListBox()
      {
         SelectionMode = SelectionMode.MultiExtended,
      };
      var sut = GetSystemUnderTest(model, control);
      control.SelectedIndices.Add(2);
      control.SelectedIndices.Add(3);
      control.SelectedIndices.Add(4);

      // Act.
      model.ClearAll();

      // Assert.
      control.SelectedItems.Count.Should().Be(0);
   }

   #endregion
}
