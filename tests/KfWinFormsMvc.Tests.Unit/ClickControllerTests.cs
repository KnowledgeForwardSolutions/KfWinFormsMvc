namespace KfWinFormsMvc.Tests.Unit;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
public class ClickControllerTests
{
   #region Constructor Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void ClickController_Constructor_ShouldCreateObject_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();
      var methodName = nameof(model.ClearAll);

      // Act.
      var sut = new ClickController<PersonModel>(model, control, methodName);

      // Assert.
      sut.Should().NotBeNull();
   }

   [Fact]
   public void ClickController_Constructor_ShouldThrowArgumentNullException_WhenModelIsNull()
   {
      // Arrange.
      PersonModel model = null!;
      var control = new Button();
      var methodName = nameof(model.ClearAll);

      var act = () => _ = new ClickController<PersonModel>(model, control, methodName);
      var expectedMessage = Messages.NullModelMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(model))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void ClickController_Constructor_ShouldThrowArgumentNullException_WhenControlIsNull()
   {
      // Arrange.
      var model = new PersonModel();
      Button control = null!;
      var methodName = nameof(model.ClearAll);

      var act = () => _ = new ClickController<PersonModel>(model, control, methodName);
      var expectedMessage = Messages.NullControlMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(control))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void ClickController_Constructor_ShouldThrowArgumentNullException_WhenBoundMethodNameIsNull()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();
      String boundMethodName = null!;

      var act = () => _ = new ClickController<PersonModel>(model, control, boundMethodName);
      var expectedMessage = Messages.EmptyMethodNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(boundMethodName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void ClickController_Constructor_ShouldThrowArgumentException_WhenBoundMethodNameIsEmpty(String boundMethodName)
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();

      var act = () => _ = new ClickController<PersonModel>(model, control, boundMethodName);
      var expectedMessage = Messages.EmptyMethodNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(boundMethodName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void ClickController_Constructor_ShouldThrowInvalidOperationException_WhenBoundMethodNameDoesNotExist()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();
      var boundMethodName = "RandomMethodName";

      var act = () => _ = new ClickController<PersonModel>(model, control, boundMethodName);
      var expectedMessage = String.Format(Messages.MethodNotFoundMessage, boundMethodName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   [Fact]
   public void ClickController_Constructor_ShouldThrowInvalidOperationException_WhenBoundMethodReturnTypeIsNotSupported()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();
      var boundMethodName = "GetFullName";

      var act = () => _ = new ClickController<PersonModel>(model, control, boundMethodName);
      var expectedMessage = Messages.InvalidBoundMethodReturnType;

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage);
   }

   #endregion

   #region Binding Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void ClickController_Binding_ShouldInvokeSynchronousMethod_WhenClickIsClicked()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();
      var methodName = nameof(model.ClearAll);
      var sut = new ClickController<PersonModel>(model, control, methodName);
      model.FirstName = "Ringo";

      // Act.
      control.PerformClick();

      // Assert.
      model.FirstName.Should().Be(String.Empty);
   }

   [Fact]
   public async Task ClickController_Binding_ShouldInvokeAsynchronousMethod_WhenClickIsClicked()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new Button();
      var methodName = nameof(model.ClearAllAsync);
      var sut = new ClickController<PersonModel>(model, control, methodName);
      model.FirstName = "Ringo";

      // Act.
      control.PerformClick();

      // Assert.
      // This is kind of weak because it relies on specific timing for the test
      // to succeed but it works well enough for the moment.
      model.FirstName.Should().NotBe(String.Empty);
      await Task.Delay(600);
      model.FirstName.Should().Be(String.Empty);
   }

   #endregion
}
