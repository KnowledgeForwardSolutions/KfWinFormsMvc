namespace KfWinFormsMvc.Tests.Unit;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
public class TextViewControllerTests
{
   #region Constructor Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void TextViewController_Constructor_ShouldCreateObject_WhenAllParametersAreValid()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();
      var propertyName = nameof(PersonModel.FirstName);

      // Act.
      var sut = new TextViewController<PersonModel>(model, control, propertyName);

      // Assert.
      sut.Should().NotBeNull();
   }

   [Fact]
   public void TextViewController_Constructor_ShouldThrowArgumentNullException_WhenModelIsNull()
   {
      // Arrange.
      PersonModel model = null!;
      var control = new TextBox();
      var propertyName = nameof(PersonModel.FirstName);

      var act = () => _ = new TextViewController<PersonModel>(model, control, propertyName);
      var expectedMessage = Messages.NullModelMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(model))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void TextViewController_Constructor_ShouldThrowArgumentNullException_WhenControlIsNull()
   {
      // Arrange.
      var model = new PersonModel();
      TextBox control = null!;
      var propertyName = nameof(PersonModel.FirstName);

      var act = () => _ = new TextViewController<PersonModel>(model, control, propertyName);
      var expectedMessage = Messages.NullControlMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(control))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void TextViewController_Constructor_ShouldThrowArgumentNullException_WhenBoundPropertyNameIsNull()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();
      String boundPropertyName = null!;

      var act = () => _ = new TextViewController<PersonModel>(model, control, boundPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void TextViewController_Constructor_ShouldThrowArgumentException_WhenBoundPropertyNameIsEmpty(String boundPropertyName)
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();

      var act = () => _ = new TextViewController<PersonModel>(model, control, boundPropertyName);
      var expectedMessage = Messages.EmptyPropertyNameMessage;

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(boundPropertyName))
         .WithMessage(expectedMessage + "*");
   }

   [Fact]
   public void TextViewController_Constructor_ShouldThrowInvalidOperationException_WhenBoundPropertyNameDoesNotExist()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();
      var boundPropertyName = "RandomPropertyName";

      var act = () => _ = new TextViewController<PersonModel>(model, control, boundPropertyName);
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
   public void TextViewController_Binding_ShouldUpdateControl_WhenModelPropertyChanges()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();
      var propertyName = nameof(PersonModel.FirstName);
      var sut = new TextViewController<PersonModel>(model, control, propertyName);

      // Act.
      model.FirstName = "John";

      // Assert.
      control.Text.Should().Be("John");
   }

   [Fact]
   public void TextViewController_Binding_ShouldUpdateModel_WhenControlTextChanges()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();
      var propertyName = nameof(PersonModel.FirstName);
      var sut = new TextViewController<PersonModel>(model, control, propertyName);

      // Act.
      control.Text = "Paul";

      // Assert.
      model.FirstName.Should().Be("Paul");
   }

   [Fact]
   public void TextViewController_Binding_ShouldUpdateControl_WhenModelUpdatesAllProperties()
   {
      // Arrange.
      var model = new PersonModel();
      var control = new TextBox();
      var propertyName = nameof(PersonModel.FirstName);
      var sut = new TextViewController<PersonModel>(model, control, propertyName);
      control.Text = "George";

      // Act.
      model.ClearAll();

      // Assert.
      control.Text.Should().Be(String.Empty);

      #endregion
   }
}
