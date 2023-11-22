using Wema.BIT.Models;
using static Wema.BIT.Models.AreaOfTraingle;

namespace Wema.BIT.User
{
    public class User
    {
        public static void Main(String[] args)
        {
            Triangle myTriangle = new Triangle();

            // Input base and height values
            Console.WriteLine("Enter the base of the triangle:");
            myTriangle.Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle:");
            myTriangle.Height = Convert.ToDouble(Console.ReadLine());

            // Calculate and display the area
            double area = myTriangle.CalculateArea();
            Console.WriteLine($"The area of the triangle is: {area}");

            List<UsersList> usersLists = new List<UsersList>()
            {
                new UsersList() {Id = 1, Email="faisal007@gmail.com", First_Name="Faisal",Last_Name="Ozigis"},
                new UsersList() {Id = 2, Email="Tolu001@gmial.com", First_Name="Tolu",Last_Name="Akintayo"},
                new UsersList() {Id = 3, Email="Emmaunelk@gmail.com", First_Name="Emmanuel",Last_Name="Kayode"},
                new UsersList() {Id = 4, Email="Timmy1323@gmail.com", First_Name="Timmy",Last_Name="Egbe"},
                new UsersList() {Id = 5, Email="Uche1323@gmail.com", First_Name="Uchennna",Last_Name="Morris"}
            };

            List<Payment> payments = new List<Payment>()
            {
               new Payment() {UserID = 1, PaymentId= 1, Payment_amount=126725},
               new Payment() {UserID = 2, PaymentId= 1, Payment_amount=10325},
               new Payment() {UserID = 3, PaymentId= 1, Payment_amount=78325}

            };
            for (int i = 0; i < usersLists.Count; i++)
            {
                Console.WriteLine("User Details:");
                Console.WriteLine("Id: " + usersLists[i].Id + ", First Name: " + usersLists[i].First_Name + ", Last Name: " + usersLists[i].Last_Name + ", Email: " + usersLists[i].Email);

                Console.WriteLine("Payments for User " + usersLists[i].Id + ":");
                foreach (var payment in payments)
                {
                    if (payment.UserID == usersLists[i].Id)
                    {
                        Console.WriteLine("PaymentId: " + payment.PaymentId + ", Payment Amount: " + payment.Payment_amount);
                    }
                }
                Console.WriteLine();

            }

            //Console.write("Enter a number: ");
            //   int num1 = Convert.ToInt32(Console.ReadLine());

            //  Console.write("Enter another number: ");
            //  int num2 = Convert.ToInt32(Console.ReadLine());

            // Console.writeLine(num1 + num2);

            //  Console.Readline();


        }
    }
}
    //public class Payment
    //{
       // public static void Greet()
       //{
         //   Console.WriteLine("Good Afternoon");
        //}

       // public string GreetMe()
      //{
       //    Console.WriteLine("Good Afternoon");

        //   return "Good Afternoon";
      //  }
   //}
//}


