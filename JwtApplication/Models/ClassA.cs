using Microsoft.IdentityModel.Protocols;
using System.Net.NetworkInformation;

namespace JwtApplication.Models
{
    public class Person
    {
       public string name;
       public string address;
      //  List<Person> listPerson;

        
    }
    public class AddPerson
    {
        public static void main()
        {

            List<Person> obj = new List<Person>()
            {
                new Person{name ="rizwan",address="Bara"},
                new Person{name ="rizwan",address="Bara"},
                new Person{name ="rizwan",address="Bara"},
                new Person{name ="rizwan",address="Bara"},
                new Person{name ="rizwan",address="Bara"}
            };

            IQueryable<Person> query = obj.AsQueryable();

        }
    }



    public abstract class ClassA
    {
        public abstract string CallA();
       /* {
            return "Hye I am A";
        }*/
    }

    public abstract class ClassB : ClassA
    {
        public abstract string CallB();
        public override string CallA()
        {
            return "Hye I am A";
        }
        /*{
            return "Hye I am B";
        }*/
    }

    public class ClassC : ClassB
    {
        /*public string CallA();
         {
             return "Hye I am A";
         }*/
        

        public override string CallB()
        {
            return "Hye I am B";
        }
    }

    public class ClassD
    {
        public static void main()
        {
            ClassC objc = new ClassC();
            objc.CallA();
            objc.CallB();
        }
    }
    
}
