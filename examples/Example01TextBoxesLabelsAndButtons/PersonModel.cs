namespace Example01TextBoxesLabelsAndButtons;

public class PersonModel : ModelBase
{
   private String _firstName = String.Empty;
   private String _lastName = String.Empty;

   public String FirstName
   {
      get => _firstName;
      set => SetProperty(ref _firstName, value);
   }

   public String LastName
   {
      get => _lastName;
      set => SetProperty(ref _lastName, value);
   }

   public void ClearAll()
   {
      _firstName = String.Empty;
      _lastName = String.Empty;

      NotifyAllPropertiesChanged();
   }
}
