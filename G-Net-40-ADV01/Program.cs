using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Principal;
using G_Net_40_ADV01.Default_Key_Word;
using G_Net_40_ADV01.Genaric_Class;
using G_Net_40_ADV01.Genaric_Interface;
using G_Net_40_ADV01.Genaric_Method;
using G_Net_40_ADV01.Generic_Constraints;
using G_Net_40_ADV01.Generic_Constraints.Base_Class_Constrain;
using G_Net_40_ADV01.Generic_Constraints.Interface_Constrain;
using G_Net_40_ADV01.Generic_Constraints.New__;
using G_Net_40_ADV01.Pair_Genaic_Class;

namespace G_Net_40_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // Q1: What is a generic class? Why use generics? 

            // Answer Q1:
            // What is a generic class?

            // A generic class uses type parameters that are replaced with actual types when you create an instance.
            // The type parameter T acts as a placeholder.

            //    Example: Generic Stack :

            //    internal class MyStack<T>
            //    {
            //    private T[] _items;
            //    private int _top;
            //    public int Count => _top;

            //    public MyStack(int capacity)
            //    {
            //        _items = new T[capacity];
            //        _top = 0;
            //    }
            //    //push
            //    public void Push(T item)
            //    {
            //        if (_top < _items.Length)
            //            _items[_top++] = item;
            //    }
            //    //pop
            //    public T? Pop()
            //    {
            //        if (_top > 0)
            //        {
            //            var item = _items[--_top];
            //            _items[_top] = default;
            //            return item;
            //        }
            //        return default;
            //    }
            //    //peek
            //    public T? Peek() => _items[_top - 1];

            //    //override ToString
            //    public override string ToString() => $"{_items[_top]}";
            //}

            //----------------------------------------------------------------------------------------------

            // Using the Generic Stack :
            // MyStack<int> myStack = new MyStack<int>(5);

            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);

            ////Console.WriteLine(myStack.Count);

            ////Console.WriteLine(myStack.Peek());
            ////Console.WriteLine(myStack.Count);

            //myStack.Pop();
            //Console.WriteLine(myStack.Count);
            //-----------------------------------------------------------------------------------------------

            // Why use generics ?

            // Answer:
            // Before generics, we had two bad choices: duplicate code for each type,
            // or use object and lose type safety + performance.

            // Benifites of Genarics:
            // Type Safety: الـ compiler بيكشف الأخطاء وقت الـ compile مش الـ runtime
            // Code Reuse: كود واحد بيشتغل مع أي type
            // Performance: مفيش boxing/unboxing للـ value types
            // IntelliSense : Better IDE support and discovery

            //------------------------------------------------------------------------------------------------
            #endregion

            #region Question 02
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Answer Q2:

            //var container01 = new G_Net_40_ADV01.Genaric_Class.Container<int>();

            //container01.Add(10);
            //container01.Add(20);

            //Console.WriteLine(container01.Count);   // 2
            //Console.WriteLine(container01.Get(0));  // 10
            //Console.WriteLine(container01.Get(5));  // 0 (القيمة الافتراضية)
            #endregion

            #region  Question 03

            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.


            //Answer Q3:

            //Multiple Type Parameters:
            //Generic classes can have multiple type parameters.
            //Common examples: Dictionary<TKey, TValue>, Tuple<T1, T2>

            // Apply Example : Pair<TKey, TValue>.

            //var emp01 = new Employee<int,string>(1,"Islam");
            //Console.WriteLine(emp01);
            ////----------------------------------------------------

            //Employee<int, string> emp02 = new(3, "Dina");
            //Console.WriteLine(emp02);
            #endregion


            #region Question 04

            //Q4: What is a generic method? Write Swap<T> method.

            // Answer Q4:
            // Generic Methods:
            // A generic method declares its own type parameter(s).
            // It can exist in both generic and non-generic classes.
            // The compiler often infers the type argument.


            //Apply Swap

            //int num01 = 10, num02 = 33;

            //Console.WriteLine("Before Swapping");

            //Console.WriteLine($"num01 = {num01}");
            //Console.WriteLine($"num02 = {num02}");
            //Console.WriteLine("==================================================");

            //Console.WriteLine("After Swapping");

            //Utilities.Swap(ref num01, ref num02); // 

            //Console.WriteLine($"num01 = {num01}");
            //Console.WriteLine($"num02 = {num02}");

            //-------------------------------------------------------------------------------------------


            //string name01 = "ahmed", name02 = "ali";

            //Console.WriteLine("Before Swapping");

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"name02 = {name02}");
            //Console.WriteLine("==================================================");

            //Console.WriteLine("After Swapping");

            //Utilities.Swap(ref name01, ref name02); // 

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"name02 = {name02}");
            #endregion

            #region Question 05

            //Q5: Write a generic method FindMax<T> that finds maximum value

            //Answer Q5:

            //int[] numbers = { 11, 22, 33, 4, 54, 60, 7, 81, };

            //Console.WriteLine(Utilities.FindMaxValue(numbers));
            //-----------------------------------------------------------------------------------------
            //Developer[] developers =
            //{
            //    new("Islam",9000),
            //    new("ALi",10000),
            //    new("Youssef",15000)
            //};

            //Console.WriteLine(Utilities.FindMaxValue(developers));

            #endregion

            #region Question 06

            // Q6: What is a generic interface? Write IRepository<T>. 

            //Answer Q6:

            // Generic Interfaces:
            // Generic interfaces define contracts with type parameters.
            // Classes implementing them specify the actual types.

            // Apply Genaric Interface

            //var prod01 = new G_Net_40_ADV01.Genaric_Interface.Product(111, "Iphone12Pro", 20000);
            //var prod02 = new G_Net_40_ADV01.Genaric_Interface.Product(144, "Lap-Top", 33000);
            //var prod03 = new G_Net_40_ADV01.Genaric_Interface.Product(100, "Note Book", 100);

            //ProductRepository productRepository = new ProductRepository();
            //productRepository.Add(prod01);
            //productRepository.Add(prod02);
            //productRepository.Add(prod03);

            //--------------------------------------------------------------------------------------------

            //foreach (var item in  productRepository.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------------------------

            //Console.WriteLine(productRepository.GetById(111));

            //--------------------------------------------------------------------------------------------
            //productRepository.Delete(prod01);


            //foreach (var item in productRepository.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------------------------

            //productRepository.Update(new Product(100,"Pen",12));

            //foreach (var item in productRepository.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question 07
            // Q7: What is the 'struct' constraint? Write an example.

            //Answer Q7:

            // Constraint: struct (Value Types):
            // where T : struct restricts T to value types only.
            // Useful when you need value semantics (copy, no null).

            // where T : struct => T must be a value type

            // Apply Constraint: struct 

            // var box = new ConstraintStruct<int> { Value = 42 }; // valid int is value type
            // new ConstraintStruct<string>(); //  Error - string is reference type
            #endregion

            #region Question 08

            // Q8: What is the 'class' constraint? Write an example.

            //Answer Q8:
            // Constraint: class (Reference Types):
            // where T : class restricts T to reference types only.
            // This allows T to be null and enables reference comparison.

            // where T : class => T must be a reference type

            //Appy Example about 'class' constraint:

            //var ConstrainClass = new ConstrainClass<string>();  //  string is class
            //ConstrainClass.Set("Hello");
            //// var bad = new ConstrainClass<int>();      //  int is struct!

            #endregion


            #region Question 09

            // Q9: What is the 'new()' constraint? Write an example.

            // Answer Q9:

            // Constraint: new() (Constructor):
            // where T : new() requires T to have a public parameterless constructor.
            // This allows you to create instances of T inside the generic code.

            //  where T : new () =>  T must have parameterless constructor

            // Apply Example Of Constraint: new() (Constructor)

            // People person01 = new People(1,"ali");

            //  People person02 = new();

            // this is invalid Because the Type of People That use ConstrainParameterlessConstructor
            // do not have a paramaterless constrain 

            //   var  constrainParameterlessConstructor1 = new ConstrainParameterlessConstructor<People>();  



            // if i create A parameterless constrain or remove my custom constrain this will work


            // var constrainParameterlessConstructor2 = new ConstrainParameterlessConstructor<People>();
            #endregion

            #region Question 10

            // Q10:  What is the interface constraint? Write an example.

            //Answer Q10

            // Constraint: Interface:
            // where T : IInterface requires T to implement a specific interface.
            // This enables calling interface methods on type parameter.

            // where T : IInterface => T must implement interface

            //Apply Example about Constraint: Interface:

            // Usage of Sorter<T>

            //  Sort integers
            //var intSorter = new Sorter<int>();
            //int[] numbers = { 5, 2, 9, 1, 7, 3 };
            //int[] sortedNumbers = intSorter.Sort(numbers);
            //Console.WriteLine("Sorted ints: " + string.Join(", ", sortedNumbers));

            ////  Sort strings
            //var stringSorter = new Sorter<string>();
            //string[] names = { "Ziad", "Ahmed", "Mohamed", "Bassem" };
            //string[] sortedNames = stringSorter.Sort(names);
            //Console.WriteLine("Sorted strings: " + string.Join(", ", sortedNames));

            #endregion

            #region Question 11

            // Q11: What is the base class constraint? Write an example.

            //Answer Q11:

            // where T : BaseClass => T must inherit from BaseClass

            //Apply Example about  base class constraint


            //Cat cat01 = new Cat("Cat01");

            //AnimalShelter<Cat> CatShelter = new AnimalShelter<Cat>();

            //CatShelter.AddAnimal(cat01);

            //CatShelter.MakeSound();

            ////-----------------------------------------------------------------

            //Dog dog01 = new Dog("Dot01");

            //AnimalShelter<Dog> DogShelter = new AnimalShelter<Dog>();

            //DogShelter.AddAnimal(dog01);

            //DogShelter.MakeSound();
            #endregion

            #region Question 12

            // Q12: How do you apply multiple constraints? Write an example. 

            // Answer Q12:

            // Multiple Constraints :
            // You can combine multiple constraints for a single type parameter,
            // and have different constraints for different type parameters.

            // example:

            //    public class EntityManager<T> where T : class, IEntity, new()
            //    {
            //    public T CreateAndSave()
            //    {
            //        var entity = new T();      //  new() constraint
            //        entity.Id = Guid.NewGuid(); //  IEntity constraint
            //        return entity;
            //    }
            //    }

            // Order matters: class/struct first, then interfaces, then new() last!

            #endregion

            #region Question 13
            // Q13: What does the 'default' keyword do in generics?

            // Answer Q13:

            // The default Keyword:
            // default(T) or default returns the default value for type T: null for reference types, 0/false for value types.

            //  Use default when you need to initialize or return a "zero" value without knowing the type.
            #endregion


            #region Question 14

            // Q14: Write a SafeList<T> that returns default when the index is invalid.

            // Answer Q14:

            //SafeList<int> safeList = new SafeList<int>();

            //safeList.Add(1);
            //safeList.Add(40);
            //safeList.Add(44);

            //Console.WriteLine(safeList.GetValueAt(3));
            #endregion

            #region Question 15

            // Q15: What is covariance? Explain the 'out' keyword.


            //Answer Q15:

            // Covariance (out keyword):
            // Covariance allows you to use a more derived type than originally specified.
            // Marked with out keyword.
            // T can only appear in output positions.

            // Example:


            //  class Animal
            //{
            //    public string Name { get; set; }
            //    public Animal(string name) => Name = name;
            //    public virtual void Speak() => Console.WriteLine($"{Name} makes a sound...");
            //}

            //class Dog : Animal
            //{
            //    public Dog() : base("Dog") { }
            //    public Dog(string name) : base(name) { }
            //    public override void Speak() => Console.WriteLine($"{Name} says: Woof! 🐶");
            //}

            //// ===== Interface =====
            //interface IProducer<out T>
            //{
            //    T Produce();
            //}

            //// ===== Implementations =====
            //class DogProducer : IProducer<Dog>
            //{
            //    public Dog Produce() => new Dog("Rex");
            //}


            //IProducer<Dog> dogProducer = new DogProducer();
            //Dog myDog = dogProducer.Produce();
            //myDog.Speak();


            ////  Covariance — IProducer<Dog> assigned to IProducer<Animal>
            //IProducer<Animal> producer = new DogProducer(); //  Covariance
            //Animal myAnimal = producer.Produce();
            //myAnimal.Speak();
            //// Output: Rex says: Woof! 🐶

            //// بدون covariance كان هيحصل error
            //// IProducer<Animal> x = new DogProducer(); // لو مكتبناش out
            #endregion


            #region Question 16

            // Q16: What is contravariance? Explain the 'in' keyword.

            // Answer Q16:

            // Contravariance (in keyword):
            // Contravariance allows you to use a less derived type than originally specified.
            // Marked with in keyword. T can only appear in input positions.

            //Example:


        //class Animal
        //{
        //    public string Name { get; set; }
        //    public Animal(string name) => Name = name;
        //    public virtual void Speak() => Console.WriteLine($"{Name} makes a sound...");
        //}

        //class Dog : Animal
        //{
        //    public Dog() : base("Dog") { }
        //    public Dog(string name) : base(name) { }
        //    public override void Speak() => Console.WriteLine($"{Name} says: Woof! 🐶");
        //}

        //interface IConsumer<in T>
        //{
        //    void Consume(T item);
        //}

    
        //class AnimalConsumer : IConsumer<Animal>
        //{
        //    public void Consume(Animal a) => Console.WriteLine($"Consuming animal: {a.Name}");
        //}

     
        //// usage
        //IConsumer<Animal> animalConsumer = new AnimalConsumer();
        //animalConsumer.Consume(new Animal("Cat"));


        ////  Contravariance — IConsumer<Animal> assigned to IConsumer<Dog>
        //IConsumer<Dog> dogConsumer = new AnimalConsumer(); //  Contravariance
        //        dogConsumer.Consume(new Dog("Rex"));
        
        
        ////  بدون contravariance كان هيحصل error
        //// IConsumer<Dog> x = new AnimalConsumer(); //  لو مكتبناش in
            #endregion



        }
}
}
