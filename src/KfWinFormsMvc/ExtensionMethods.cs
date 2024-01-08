namespace KfWinFormsMvc;

public static class ExtensionMethods
{
   /// <summary>
   ///   Given a <paramref name="type"/>, return the generic collection item 
   ///   type. If <paramref name="type"/> is not a generic type or does not
   ///   implement <see cref="IEnumerable{}"/> then return null.
   /// </summary>
   /// <param name="type">
   ///   The <see cref="Type"/> to check.
   /// </param>
   /// <returns></returns>
   public static Type? GetCollectionElementType(this Type type)
   {
      var enumerableInterface = type.GetInterfaces()
         .FirstOrDefault(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IEnumerable<>));
      var enumerableTypeArguments = enumerableInterface?.GetGenericArguments() ?? Enumerable.Empty<Type>();
      
      return enumerableTypeArguments.FirstOrDefault();
   }

   /// <summary>
   ///   Get the <see cref="MethodInfo"/> for a public instance method.
   /// </summary>
   /// <param name="obj"></param>
   /// <param name="methodName"></param>
   /// <returns></returns>
   /// <exception cref="InvalidOperationException"></exception>
   public static MethodInfo GetMethodInfo(this Object obj, String methodName)
   {
      var methodInfo = obj.GetType().GetMethod(
         methodName,
         BindingFlags.Instance | BindingFlags.Public);

      return methodInfo ?? throw new InvalidOperationException(
         String.Format(Messages.MethodNotFoundMessage, methodName));
   }

   /// <summary>
   ///   Gets the <see cref="PropertyInfo"/> for a public instance property with
   ///   both get and set methods.
   /// </summary>
   /// <param name="obj">
   ///   The object instance.
   /// </param>
   /// <param name="propertyName">
   ///   The name of the object property.
   /// </param>
   /// <returns>
   ///   A <see cref="PropertyInfo"/> instance.
   /// </returns>
   /// <exception cref="InvalidOperationException">
   ///   The named property does not exist.
   /// </exception>
   public static PropertyInfo GetPropertyInfo(this Object obj, String propertyName)
   {
      var propertyInfo = obj.GetType().GetProperty(
         propertyName,
         BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty);

      return propertyInfo ?? throw new InvalidOperationException(
         String.Format(Messages.PropertyNotFoundMessage, propertyName));
   }

   /// <summary>
   ///   Validate that the <paramref name="str"/> is not <see langword="null"/>,
   ///   <see cref="String.Empty"/> or all whitespace characters.
   /// </summary>
   /// <param name="str">
   ///   The string to validate.
   /// </param>
   /// <param name="message">
   ///   Message to use if an exception is thrown.
   /// </param>
   /// <param name="parameterName">
   ///   Optional. The argument name to use if an exception is thrown.
   /// </param>
   /// <exception cref="ArgumentNullException">
   ///   <paramref name="str"/> is <see langword="null"/>.
   /// </exception>
   /// <exception cref="ArgumentException">
   ///   <paramref name="str"/> is <see cref="String.Empty"/> or all whitespace 
   ///   characters.
   /// </exception>
   public static void RequiresNotEmpty(
      this String str,
      String message,
      [CallerArgumentExpression(nameof(str))] String parameterName = null!)
   {
      if (str is null)
      {
         throw new ArgumentNullException(parameterName, message);
      }
      if (String.IsNullOrWhiteSpace(str))
      {
         throw new ArgumentException(message, parameterName);
      }
   }

}
