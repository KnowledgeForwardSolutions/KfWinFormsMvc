namespace KfWinFormsMvc.Tests.Unit;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
public class DropDownListViewControllerTests
{
   #region Constructor Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void DropDownListViewController_Constructor_ShouldCreateObject_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.DieTypes);

      // Act.
      var sut = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);

      // Assert.
      sut.Should().NotBeNull();
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowArgumentNullException_WhenModelIsNull()
   {
      // Arrange.
      DiceModel model = null!;
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.DieTypes);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.NullModelMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(model))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowArgumentNullException_WhenControlIsNull()
   {
      // Arrange.
      var model = new DiceModel();
      ComboBox control = null!;
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.DieTypes);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.NullControlMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(control))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowArgumentNullException_WhenBoundPropertyNameIsNull()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      String boundPropertyName = null!;
      var itemsPropertyName = nameof(model.DieTypes);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void DropDownListViewController_Constructor_ShouldThrowArgumentException_WhenBoundPropertyNameIsEmpty(String boundPropertyName)
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var itemsPropertyName = nameof(model.DieTypes);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowInvalidOperationException_WhenBoundPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = "RandomPropertyName";
      var itemsPropertyName = nameof(model.DieTypes);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, boundPropertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowInvalidOperationException_WhenItemsPropertyNameIsNull()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      String itemsPropertyName = null!;

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.ItemsPropertyIsNotDefined;

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void DropDownListViewController_Constructor_ShouldThrowArgumentException_WhenItemsPropertyNameIsEmpty(String itemsPropertyName)
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.EmptyItemsPropertyName;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(itemsPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowInvalidOperationException_WhenItemsPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = "RandomPropertyName";

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, itemsPropertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void DropDownListViewController_Constructor_ShouldThrowInvalidOperationException_WhenItemsPropertyIsInvalidType()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.Colors);

      var act = () => _ = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      var expectedMessage = Messages.InvalidItemsPropertyType;

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   #endregion

   #region Binding Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void DropDownListViewController_Binding_ShouldUpdateControl_WhenModelBoundPropertyChanges()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.DieTypes);
      var sut = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);

      // Act.
      model.SelectedDieType = DieType.D20;

      // Assert.
      control.SelectedIndex.Should().Be(4);
   }

   [Fact]
   public void DropDownListViewController_Binding_ShouldUpdateModel_WhenControlSelectedIndexChanges()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.DieTypes);
      var sut = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);

      // Act.
      control.SelectedIndex = 1;

      // Assert.
      model.SelectedDieType.Should().Be(DieType.D6);
   }

   [Fact]
   public void DropDownListViewController_Binding_ShouldUpdateControlSelectedIndex_WhenModelUpdatesAllProperties()
   {
      // Arrange.
      var model = new DiceModel();
      var control = new ComboBox()
      {
         DisplayMember = nameof(DieInfo.Description),
         DropDownStyle = ComboBoxStyle.DropDownList,
         ValueMember = nameof(DieInfo.DieType)
      };
      var boundPropertyName = nameof(model.SelectedDieType);
      var itemsPropertyName = nameof(model.DieTypes);
      var sut = new DropDownListViewController<DiceModel, DieType>(
         model,
         control,
         boundPropertyName,
         itemsPropertyName);
      control.SelectedIndex = 1;

      // Act.
      model.ClearAll();

      // Assert.
      control.SelectedIndex.Should().Be(-1);

      #endregion
   }
}
