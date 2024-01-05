namespace KfWinFormsMvc.Tests.Unit;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
public class RadioButtonViewControllerTests
{
   #region Constructor Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void RadioButtonViewController_Constructor_ShouldCreateObject_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = ShippingSpeed.Overnight;

      // Act.
      var sut = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         propertyName,
         selectedValue);

      // Assert.
      sut.Should().NotBeNull();
   }

   [Fact]
   public void RadioButtonViewController_Constructor_ShouldThrowArgumentNullException_WhenModelIsNull()
   {
      // ArrangeShippingInfoModel
      ShippingInfoModel model = null!;
      var control = new RadioButton();
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = ShippingSpeed.Overnight;

      var act = () => _ = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         propertyName,
         selectedValue);
      var expectedMessage = Messages.NullModelMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(model))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void RadioButtonViewController_Constructor_ShouldThrowArgumentNullException_WhenControlIsNull()
   {
      // Arrange.
      var model = new ShippingInfoModel();
      RadioButton control = null!;
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = ShippingSpeed.Overnight;

      var act = () => _ = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         propertyName,
         selectedValue);
      var expectedMessage = Messages.NullControlMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(control))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void RadioButtonViewController_Constructor_ShouldThrowArgumentNullException_WhenBoundPropertyNameIsNull()
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      String boundPropertyName = null!;
      var selectedValue = ShippingSpeed.Overnight;

      var act = () => _ = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         boundPropertyName,
         selectedValue);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void RadioButtonViewController_Constructor_ShouldThrowArgumentException_WhenBoundPropertyNameIsEmpty(String boundPropertyName)
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var selectedValue = ShippingSpeed.Overnight;

      var act = () => _ = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         boundPropertyName,
         selectedValue);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void RadioButtonViewController_Constructor_ShouldThrowInvalidOperationException_WhenBoundPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var boundPropertyName = "RandomPropertyName";
      var selectedValue = ShippingSpeed.Overnight;

      var act = () => _ = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         boundPropertyName,
         selectedValue);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, boundPropertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void RadioButtonViewController_Constructor_ShouldThrowArgumentOutOfRangeException_WhenSelectedValueParameterIsDefault()
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = default(ShippingSpeed);

      var act = () => _ = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         propertyName,
         selectedValue);
      var expectedMessage = Messages.SelectedValueOutOfRangeMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentOutOfRangeException>()
         .WithMessage(expectedMessage + "*");
   }

   #endregion

   #region Binding Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void RadioButtonViewController_Binding_ShouldSetControlCheckedTrue_WhenModelPropertyChangesToSelectedValue()
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = ShippingSpeed.Overnight;
      var sut = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model, 
         control, 
         propertyName,
         selectedValue);

      // Act.
      model.ShippingSpeed = ShippingSpeed.Overnight;

      // Assert.
      control.Checked.Should().BeTrue();
   }

   [Theory]
   [InlineData(ShippingSpeed.None)]
   [InlineData(ShippingSpeed.Ground)]
   public void RadioButtonViewController_Binding_ShouldSetControlCheckedFalse_WhenModelPropertyChangesToSelectedValue(ShippingSpeed shippingSpeed)
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = ShippingSpeed.Overnight;
      var sut = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         propertyName,
         selectedValue);
      model.ShippingSpeed = ShippingSpeed.Overnight;

      // Act.
      model.ShippingSpeed = shippingSpeed;

      // Assert.
      control.Checked.Should().BeFalse();
   }

   [Theory]
   [InlineData(ShippingSpeed.None)]
   [InlineData(ShippingSpeed.Ground)]
   public void RadioButtonViewController_Binding_ShouldSetModelValueToSelectedValue_WhenControlIsCheckedByUser(ShippingSpeed shippingSpeed)
   {
      // Arrange.
      var model = new ShippingInfoModel();
      var control = new RadioButton();
      var propertyName = nameof(model.ShippingSpeed);
      var selectedValue = ShippingSpeed.Overnight;
      var sut = new RadioButtonViewController<ShippingInfoModel, ShippingSpeed>(
         model,
         control,
         propertyName,
         selectedValue);
      model.ShippingSpeed = shippingSpeed;

      // Act.
      control.PerformClick();

      // Assert.
      model.ShippingSpeed.Should().Be(selectedValue);
   }

   #endregion
}
