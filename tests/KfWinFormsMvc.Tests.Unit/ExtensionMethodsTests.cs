// Ignore Spelling: sut

namespace KfWinFormsMvc.Tests.Unit;

public class ExtensionMethodsTests
{
   #region GetPropertyInfo Method Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void ExtensionMethods_GetPropertyInfo_ShouldReturnValidPropertyInfo_WhenPropertyExists()
   {
      // Arrange.
      var sut = new ExtensionMethodsTestClass { ReadWriteProp = "Read/write" };
      var propertyName = nameof(ExtensionMethodsTestClass.ReadWriteProp);

      // Act.
      var propInfo = sut.GetPropertyInfo(propertyName);

      // Assert.
      propInfo.Should().NotBeNull();
      propInfo.Name.Should().Be(propertyName);
   }

   [Fact]
   public void ExtensionMethods_GetPropertyInfo_ShouldThrowInvalidOperationException_WhenPropertyIsNotFound()
   {
      // Arrange.
      var sut = new ExtensionMethodsTestClass { ReadWriteProp = "Read/write" };
      var propertyName = "NotFoundProperty";

      var act = () => _ = sut.GetPropertyInfo(propertyName);
      var expectedMessage = String.Format(Messages.PropertyNotFoundMessage, propertyName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage + "*");
   }

   #endregion

   #region GetMethodInfo Method Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void ExtensionMethods_GetMethodInfo_ShouldReturnValidMethodInfo_WhenMethodExists()
   {
      // Arrange.
      var sut = new ExtensionMethodsTestClass { ReadWriteProp = "Read/write" };
      var methodName = nameof(ExtensionMethodsTestClass.ClearWritableProperties);

      // Act.
      var methodInfo = sut.GetMethodInfo(methodName);

      // Assert.
      methodInfo.Should().NotBeNull();
      methodInfo.Name.Should().Be(methodName);
   }

   [Fact]
   public void ExtensionMethods_GetMethodInfo_ShouldThrowInvalidOperationException_WhenMethodIsNotFound()
   {
      // Arrange.
      var sut = new ExtensionMethodsTestClass { ReadWriteProp = "Read/write" };
      var methodName = "NotFoundMethod";

      var act = () => _ = sut.GetMethodInfo(methodName);
      var expectedMessage = String.Format(Messages.MethodNotFoundMessage, methodName);

      // Act/assert.
      act.Should().ThrowExactly<InvalidOperationException>()
         .WithMessage(expectedMessage + "*");
   }

   #endregion

   #region RequiresNotEmpty Method Tests
   // ==========================================================================
   // ==========================================================================

   [Fact]
   public void ExtensionMethods_RequiresNotEmpty_ShouldNotThrow_IfValueIsNotEmpty()
   {
      // Arrange.
      var sut = "I'm not empty!";

      var act = () => sut.RequiresNotEmpty("message");

      // Act/assert.
      act.Should().NotThrow();
   }

   [Fact]
   public void ExtensionMethods_RequiresNotEmpty_ShouldThrowArgumentNullException_IfValueIsNotNull()
   {
      // Arrange.
      String sut = null!;
      var expectedMessage = "message";

      var act = () => sut.RequiresNotEmpty(expectedMessage);

      // Act/assert.
      act.Should().ThrowExactly<ArgumentNullException>()
         .WithParameterName(nameof(sut))
         .WithMessage(expectedMessage + "*");
   }

   [Theory]
   [InlineData("")]
   [InlineData("\t")]
   public void ExtensionMethods_RequiresNotEmpty_ShouldThrowArgumentException_IfValueIsEmpty(String sut)
   {
      // Arrange.
      var expectedMessage = "message";

      var act = () => sut.RequiresNotEmpty(expectedMessage);

      // Act/assert.
      act.Should().ThrowExactly<ArgumentException>()
         .WithParameterName(nameof(sut))
         .WithMessage(expectedMessage + "*");
   }

   #endregion
}

public class ExtensionMethodsTestClass
{
   public String ReadWriteProp { get; set; } = default!;

   public String ReadOnlyProp { get; } = "Read-only";

   public void ClearWritableProperties() => ReadWriteProp = String.Empty;
}