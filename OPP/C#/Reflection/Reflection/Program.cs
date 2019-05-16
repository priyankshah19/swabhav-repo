using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Human priyank = new Human("priyank", 22, 5.3f, 48, Genderoption.MALE);
            Human meet = new Human("meet", 23, 5.6f, 48, Genderoption.MALE);
            int i = 30;
            Printinfo(priyank);
            Printinfo(meet);
            priyank.Eat();
            Printinfo(priyank);
            Type field = typeof(Human);

            FieldInfo[] fieldInfo = field.GetFields();

            Console.WriteLine("The list of fields of the Human class are:--");

            foreach (FieldInfo fInfo in fieldInfo)

            {

                Console.WriteLine(fInfo.FieldType);

            }

            Type type = typeof(Human);

            PropertyInfo[] propertyInfo = type.GetProperties();

            Console.WriteLine("The list of properties of the Human class are:--");

            foreach (PropertyInfo pInfo in propertyInfo)

            {

                Console.WriteLine(pInfo.Name);

            }

            Type constructor = typeof(Human);

            ConstructorInfo[] constructorInfo = constructor.GetConstructors();

            Console.WriteLine("The Customer class contains the following Constructors:--");

            foreach (ConstructorInfo c in constructorInfo)

            {

                Console.WriteLine(c);

            }

            Type method = typeof(Human);

            MethodInfo[] methodInfo = method.GetMethods();

            Console.WriteLine("The Customer class contains the following Methods:--");

            foreach (MethodInfo c in methodInfo)

            {

                Console.WriteLine(c);

            }

        }
        private static void Printinfo(Human human)
        {
            Console.WriteLine("Name: {0}", human.Name);
            Console.WriteLine("Age: {0}", human.Age);
            Console.WriteLine("Height: {0}", human.Height);
            Console.WriteLine("Weight: {0}", human.Weight);
            Console.WriteLine("Gender: {0}", human.Gender);
            Console.ReadLine();
        }

    }
}
