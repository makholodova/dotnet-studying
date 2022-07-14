namespace FirstWebApplication.Models;

public static class MobileContext
{
    public static List<Phone> Phones { get; private set; }
       public static List<Order> Orders { get; private set; }
    
      static MobileContext()
      {
          
          new Phone
          {
              Name = "iPhone X",
              Company = "Apple",
              Price = 600
          };
          new Phone
          {
              Name = "Samsung Galaxy Edge",
              Company = "Samsung",
              Price = 550
          };
          new Phone
          {
              Name = "Pixel 3",
              Company = "Google",
              Price = 500
          };

      }


}