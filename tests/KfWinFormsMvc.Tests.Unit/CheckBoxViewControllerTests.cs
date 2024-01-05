namespace KfWinFormsMvc.Tests.Unit;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
public class CheckBoxViewControllerTests
{
   #region Constructor Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void CheckBoxViewController_Constructor_ShouldCreateObject_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();
      var propertyName = nameof(model.SubscribeToEmailOffers);

      // Act.
      var sut = new CheckBoxViewController<ContactInfoModel>(model, control, propertyName);

      // Assert.
      sut.Should().NotBeNull();
   }

   [Fact]
   public void CheckBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenModelIsNull()
   {
      // Arrange.
      ContactInfoModel model = null!;
      var control = new CheckBox();
      var propertyName = nameof(model.SubscribeToEmailOffers);

      var act = () => _ = new CheckBoxViewController<ContactInfoModel>(model, control, propertyName);
      var expectedMessage = Messages.NullModelMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(model))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void CheckBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenControlIsNull()
   {
      // Arrange.
      var model = new ContactInfoModel();
      CheckBox control = null!;
      var propertyName = nameof(model.SubscribeToEmailOffers);

      var act = () => _ = new CheckBoxViewController<ContactInfoModel>(model, control, propertyName);
      var expectedMessage = Messages.NullControlMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(control))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void CheckBoxViewController_Constructor_ShouldThrowArgumentNullException_WhenBoundPropertyNameIsNull()
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();
      String boundPropertyName = null!;

      var act = () => _ = new CheckBoxViewController<ContactInfoModel>(model, control, boundPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void CheckBoxViewController_Constructor_ShouldThrowArgumentException_WhenBoundPropertyNameIsEmpty(String boundPropertyName)
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();

      var act = () => _ = new CheckBoxViewController<ContactInfoModel>(model, control, boundPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void CheckBoxViewController_Constructor_ShouldThrowInvalidOperationException_WhenBoundPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();
      var boundPropertyName = "RandomPropertyName";

      var act = () => _ = new CheckBoxViewController<ContactInfoModel>(model, control, boundPropertyName);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, boundPropertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   #endregion

   #region Binding Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void CheckBoxViewController_Binding_ShouldUpdateControl_WhenModelPropertyChanges()
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();
      var propertyName = nameof(model.SubscribeToEmailOffers);
      var sut = new CheckBoxViewController<ContactInfoModel>(model, control, propertyName);

      // Act.
      model.SubscribeToEmailOffers = true;

      // Assert.
      control.Checked.Should().BeTrue();
   }

   [Fact]
   public void CheckBoxViewController_Binding_ShouldUpdateModel_WhenCheckedChanges()
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();
      var propertyName = nameof(model.SubscribeToEmailOffers);
      var sut = new CheckBoxViewController<ContactInfoModel>(model, control, propertyName);

      // Act.
      control.Checked = true;

      // Assert.
      model.SubscribeToEmailOffers.Should().BeTrue();
   }

   [Fact]
   public void CheckBoxViewController_Binding_ShouldUpdateControl_WhenModelUpdatesAllProperties()
   {
      // Arrange.
      var model = new ContactInfoModel();
      var control = new CheckBox();
      var propertyName = nameof(model.SubscribeToEmailOffers);
      var sut = new CheckBoxViewController<ContactInfoModel>(model, control, propertyName);
      control.Checked = true;

      // Act.
      model.ClearAll();

      // Assert.
      control.Checked.Should().BeFalse();

      #endregion
   }
}