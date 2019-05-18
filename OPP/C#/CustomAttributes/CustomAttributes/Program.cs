using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;
using System.Text;


namespace CustomAttribute.
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
          //  Type type = foo.GetType();
            Type field = typeof(Foo);
            FieldInfo[] fieldInfo = field.GetFields();
            Console.WriteLine("Fields of project:");
            foreach (FieldInfo fInfo in fieldInfo)
            {

                Console.WriteLine(fInfo.FieldType);
            }
            Type type = typeof(Foo);
            PropertyInfo[] propertyInfo = type.GetProperties();
            Console.WriteLine("property of project:");
            foreach (PropertyInfo pInfo in propertyInfo)
            {

                Console.WriteLine(pInfo.Name);
            }
            Type constructor = typeof(Foo);
            ConstructorInfo[] constructorInfo = constructor.GetConstructors();
            Console.WriteLine("constructor of project:");
            foreach (ConstructorInfo c in constructorInfo)
            {

                Console.WriteLine(c);
            }
            Type method = typeof(Foo);
            MethodInfo[] methodInfo = method.GetMethods();
            Console.WriteLine("method of project:");
            foreach (MethodInfo c in methodInfo)
            {

                Console.WriteLine(c);
            }
            Console.WriteLine("Attribute of project:");
            foreach (MethodInfo mInfo in type.GetMethods())
            {

                foreach (Attribute attr in
                Attribute.GetCustomAttributes(mInfo))
                {

                    Console.WriteLine(attr);
                }
            }
        }
    }
}
