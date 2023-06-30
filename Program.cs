using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;

namespace C_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
                    // Numeric Types
                    int age = 25;
                    long population = 789_000_000L;
                    float pi = 3.14f;
                    double gravity = 9.8;
                    decimal price = 9.99m;

                    // Boolean Type
                    bool isTrue = true;
                    bool isFalse = false;

                    // Character Type
                    char grade = 'A';

                    // String Type
                    string name = "John Doe";

                    // Date and Time Types
                    DateTime currentDate = DateTime.Now;
                    TimeSpan duration = TimeSpan.FromMinutes(30);
                    // Arrays
                    int[] numbers = { 1, 2, 3, 4, 5 };

                    // Enumerations
                       DayOfWeek today = DayOfWeek.Wednesday;

                        // Other Types
                        object obj = "Hello";
                        dynamic dynamicVar = 10;
                    // Output
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine("Population: " + population);
                    Console.WriteLine("Pi: " + pi);
                    Console.WriteLine("Gravity: " + gravity);
                    Console.WriteLine("Price: " + price);
                    Console.WriteLine("Is True: " + isTrue);
                    Console.WriteLine("Is False: " + isFalse);
                    Console.WriteLine("Grade: " + grade);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Current Date: " + currentDate);
                    Console.WriteLine("Duration: " + duration);
                    Console.WriteLine("Numbers: " + string.Join(", ", numbers));
                    Console.WriteLine("Today: " + today);
                    Console.WriteLine("Object: " + obj);
                    Console.WriteLine("Dynamic Variable: " + dynamicVar);

                    // Wait for user input
                    Console.ReadLine();
            #endregion DataTypes



            #region Variable
            //// Declaring and Initializing Variables
            //int age = 25;
            //double salary = 50000.50;
            //string name = "John Doe";
            //bool isActive = true;

            //// Modifying Variables
            //age = 30;
            //salary += 10000.25;
            //name = "Jane Smith";
            //isActive = false;

            //// Printing Variable Values
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Salary: " + salary);
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Active: " + isActive);

            //// Variable Interpolation
            //Console.WriteLine($"Age: {age}, Salary: {salary}, Name: {name}, Active: {isActive}");

            //// Implicit and Explicit Variable Types
            //var phoneNumber = "123-456-7890"; // Implicitly typed variable
            //int count = 5; // Explicitly typed variable

            //Console.WriteLine("Phone Number: " + phoneNumber);
            //Console.WriteLine("Count: " + count);

            //// Constants
            //const double PI = 3.14159;
            //const string GREETING = "Hello";

            //Console.WriteLine("PI: " + PI);
            //Console.WriteLine("Greeting: " + GREETING);

            //// Wait for user input
            //Console.ReadLine();
            #endregion


            #region Operators

            //// Arithmetic Operators
            //int a = 10;
            //int b = 5;
            //int sum = a + b; // Addition
            //int difference = a - b; // Subtraction
            //int product = a * b; // Multiplication
            //int quotient = a / b; // Division
            //int remainder = a % b; // Modulo

            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + difference);
            //Console.WriteLine("Product: " + product);
            //Console.WriteLine("Quotient: " + quotient);
            //Console.WriteLine("Remainder: " + remainder);

            //// Assignment Operators
            //int x = 10;
            //x += 5; // Equivalent to: x = x + 5
            //Console.WriteLine("x: " + x);

            //// Comparison Operators
            //int num1 = 10;
            //int num2 = 20;
            //bool isEqual = num1 == num2; // Equality
            //bool isNotEqual = num1 != num2; // Inequality
            //bool isGreater = num1 > num2; // Greater than
            //bool isLess = num1 < num2; // Less than
            //bool isGreaterOrEqual = num1 >= num2; // Greater than or equal to
            //bool isLessOrEqual = num1 <= num2; // Less than or equal to

            //Console.WriteLine("Is Equal: " + isEqual);
            //Console.WriteLine("Is Not Equal: " + isNotEqual);
            //Console.WriteLine("Is Greater: " + isGreater);
            //Console.WriteLine("Is Less: " + isLess);
            //Console.WriteLine("Is Greater or Equal: " + isGreaterOrEqual);
            //Console.WriteLine("Is Less or Equal: " + isLessOrEqual);

            //// Logical Operators
            //bool isTrue = true;
            //bool isFalse = false;
            //bool andResult = isTrue && isFalse; // Logical AND
            //bool orResult = isTrue || isFalse; // Logical OR
            //bool notResult = !isTrue; // Logical NOT

            //Console.WriteLine("AND Result: " + andResult);
            //Console.WriteLine("OR Result: " + orResult);
            //Console.WriteLine("NOT Result: " + notResult);

            //// Increment and Decrement Operators
            //int counter = 0;
            //counter++; // Increment by 1
            //counter--; // Decrement by 1

            //Console.WriteLine("Counter: " + counter);

            //// Conditional Operator (Ternary Operator)
            //int age = 25;
            //string message = (age >= 18) ? "Adult" : "Minor";
            //Console.WriteLine("Message: " + message);

            //// Null-Coalescing Operator
            //string username = null;
            //string displayName = username ?? "Anonymous";
            //Console.WriteLine("Display Name: " + displayName);

            //// Wait for user input
            //Console.ReadLine();

            #endregion



            #region if loop
            #region if
            //int number = 10;
            //if (number > 5) { Console.WriteLine("The number is greater than 5."); }

            #endregion if



            #region if else
            //int number = 3;
            //if (number > 5) { Console.WriteLine("The number is greater than 5."); }
            //else { Console.WriteLine("The number is less than or equal to 5."); }

            #endregion if else



            #region if else if else
            //int number = 7;
            //if (number > 10) { Console.WriteLine("The number is greater than 10."); }
            //else if (number > 5) { Console.WriteLine("The number is greater than 5 but less than or equal to 10."); }
            //else { Console.WriteLine("The number is less than or equal to 5."); }

            #endregion if else if else

            //int num = 25;

            //if (num > 0)
            //{
            //    Console.WriteLine("The number is positive.");

            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is odd.");
            //    }

            //    if (IsPerfectSquare(num))
            //    {
            //        Console.WriteLine("The number is a perfect square.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is not a perfect square.");
            //    }
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("The number is negative.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is zero.");
            //}

            //// Wait for user input
            //Console.ReadLine();



            #endregion if loop



            #region loop

            #region for
            //for (int i = 0; i < 5; i++)
            //{
            //    // Code to be executed repeatedly
            //    //Console.WriteLine("Iteration: " + i);
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //int rows = 5;

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}

            //// Wait for user input
            //Console.ReadLine();

            #endregion for



            #region while
            //int i = 0;
            //while (i < 5)
            //{
            //   // Code to be executed repeatedly
            //    Console.WriteLine("Iteration: " + i);
            //    i++;
            //}




            #endregion while




            #region do while
            //int i = 5;
            //do
            //{      // Code to be executed repeatedly
            //    Console.WriteLine("Iteration: " + i);
            //    i++;
            //} while (i < 5);



            #endregion do while

            #region nested while
            //bool isRunning = true;

            //while (isRunning)
            //{
            //    Console.WriteLine("Traffic Signal System");

            //    // Set the green signal for North-South direction
            //    Console.WriteLine("North-South: Green");
            //    Console.WriteLine("East-West: Red");
            //    Console.WriteLine();

            //    int seconds = 10;
            //    while (seconds > 0)
            //    {
            //        Console.WriteLine($"Time remaining: {seconds} seconds");
            //        Thread.Sleep(1000); // Delay for 1 second
            //        seconds--;
            //    }

            //    Console.WriteLine();

            //    // Set the green signal for East-West direction
            //    Console.WriteLine("North-South: Red");
            //    Console.WriteLine("East-West: Green");
            //    Console.WriteLine();

            //    seconds = 8;
            //    while (seconds > 0)
            //    {
            //        Console.WriteLine($"Time remaining: {seconds} seconds");
            //        Thread.Sleep(1000); // Delay for 1 second
            //        seconds--;
            //    }

            //    Console.WriteLine();

            //    // Set the yellow signal for both directions
            //    Console.WriteLine("North-South: Yellow");
            //    Console.WriteLine("East-West: Yellow");
            //    Console.WriteLine();

            //    seconds = 3;
            //    while (seconds > 0)
            //    {
            //        Console.WriteLine($"Time remaining: {seconds} seconds");
            //        Thread.Sleep(1000); // Delay for 1 second
            //        seconds--;
            //    }

            //    Console.WriteLine();

            //    // Repeat the cycle
            //}
            #endregion






            #region foreach
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int number in numbers)
            //{        // Code to be executed for each element
            //    Console.WriteLine("Number: " + number);
            //}


            //List<string> students = new List<string>
            //    {
            //        "John",
            //        "Alice",
            //        "Michael",
            //        "Emma"
            //    };

            //Console.WriteLine("List of Students:");
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //// Wait for user input
            //Console.ReadLine();


            #endregion foreach




            #endregion loop




            #region class

            //Person person = new Person();
            //person.Name = "John";
            //person.Age = 25;
            //person.SayHello();


            //person.Name = "Marry";
            //person.Age = 32;
            //person.SayHello();

            //Car myCar = new Car("Toyota", "Camry", 2022, "Silver");

            //myCar.Start();
            //myCar.DisplayInfo();

            //Console.WriteLine();

            //myCar.Stop();
            //myCar.DisplayInfo();

            //// Wait for user input
            //Console.ReadLine();


            #endregion class



            #region inheritance
            //Dog dog = new Dog();
            //dog.Name = "Buddy";
            //dog.Age = 3;

            //dog.Eat();   // Inherited method from Animal class
            //dog.Sleep(); // Inherited method from Animal class
            //dog.Bark();  // Method specific to Dog class

            //Console.WriteLine();

            //Cat cat = new Cat();
            //cat.Name = "Whiskers";
            //cat.Age = 5;

            //cat.Eat();   // Inherited method from Animal class
            //cat.Sleep(); // Inherited method from Animal class
            //cat.Meow();  // Method specific to Cat class




            //In the example above, we have a base class Animal with properties Name and Age,
            //and methods Eat() and Sleep(). The derived classes Dog and Cat inherit from the
            //Animal class using the : symbol.

            //The Dog class has an additional method Bark(), and the Cat class has an additional
            //method Meow(). In the Main method, we create instances of Dog and Cat classes and
            //demonstrate how they can access the inherited methods from the Animal class as well
            //as their own specific methods.

            #endregion inheritance





            #region interface
            ////interface
            //MediaPlayer mediaPlayer = new MediaPlayer();
            //mediaPlayer.Play();  // Implements Play() from IPlayable
            //mediaPlayer.Pause(); // Implements Pause() from IPlayable
            //mediaPlayer.Stop();  // Implements Stop() from IPlayable

            //Console.WriteLine();

            //VideoPlayer videoPlayer = new VideoPlayer();
            //videoPlayer.Play();  // Implements Play() from IPlayable
            //videoPlayer.Pause(); // Implements Pause() from IPlayable
            //videoPlayer.Stop();  // Implements Stop() from IPlayable


            //decimal paymentAmount = 99.99m;

            //// Process payment via PayPal
            //IPaymentProcessor paypalProcessor = new PayPalPaymentProcessor();
            //paypalProcessor.ProcessPayment(paymentAmount);

            //Console.WriteLine();

            //// Process payment via Stripe
            //IPaymentProcessor stripeProcessor = new StripePaymentProcessor();
            //stripeProcessor.ProcessPayment(paymentAmount);

            //// Wait for user input
            //Console.ReadLine();


            #endregion interface




            #region abstract class
            // abstract class
            //Circle circle = new Circle(5);
            //circle.Display(); // Uses Display() from the abstract class
            //Console.WriteLine();
            //Rectangle rectangle = new Rectangle(4, 6);
            //rectangle.Display(); // Uses Display() from the abstract class


            #endregion abstract class




            #region static class
            //static class
            //int sum = MathUtils.Add(5, 3);       // Accessing static method
            //int difference = MathUtils.Subtract(10, 4);  // Accessing static method

            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + difference);

            #endregion static class



            #region structure
            //structure
            //Point point = new Point(5, 3);
            //point.Display();  // Accessing method of the structure

            //// Modifying individual fields
            //point.X = 10;
            //point.Y = 7;

            //point.Display();

            #endregion structure





            #region enum
            ////enum
            //DayOfWeek today = DayOfWeek.Wednesday;

            //Console.WriteLine("Today is: " + today);
            //Console.WriteLine("Day of week (integer value): " + (int)today);

            //if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            //{
            //    Console.WriteLine("It's the weekend!");
            //}
            //else
            //{
            //    Console.WriteLine("It's a weekday.");
            //}

            #endregion enum




            #region array
            ////aray
            //int[] numbers;
            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[5]; // Creates an array of size 5 with default values (0 for integers)
            //int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            //int thirdElement = numbers3[2]; // Index 2 represents the third element
            //numbers3[0] = 10; // Modifying the first element to be 10
            //int arrayLength = numbers3.Length;
            //for (int i = 0; i < numbers3.Length; i++)
            //{
            //    Console.WriteLine(numbers3[i]);
            //}
            #endregion array



            #region Collection

            ////Collection

            #region List<T>
            //// List<T>

            //var salmons = new List<string>();
            //salmons.Add("chinook");
            //salmons.Add("coho");
            //salmons.Add("pink");
            //salmons.Add("sockeye");
            /////var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            //// Iterate through the list.
            //foreach (var salmon in salmons)
            //{
            //    Console.Write(salmon + " ");
            //}

            //var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// Remove odd numbers.
            //for (var index = numbers.Count - 1; index >= 0; index--)
            //{
            //    if (numbers[index] % 2 == 1)
            //    {
            //        // Remove the element by specifying
            //        // the zero-based index in the list.
            //        numbers.RemoveAt(index);
            //    }
            //}

            //// Iterate through the list.
            //// A lambda expression is placed in the ForEach method
            //// of the List(T) object.
            //numbers.ForEach(
            //    number => Console.Write(number + " "));

            #endregion List<T>




            //IterateThroughList();


            #region Dictionary<TKey, TValue>
            ////
            //// Create a dictionary with string keys and int values

            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //// Add key-value pairs to the dictionary
            //ages.Add("Alice", 25);
            //ages.Add("Bob", 30);
            //ages.Add("Charlie", 35);

            //// Access values using keys
            //Console.WriteLine(ages["Alice"]);    // Output: 25
            //Console.WriteLine(ages["Bob"]);      // Output: 30
            //Console.WriteLine(ages["Charlie"]);  // Output: 35

            //// Modify a value
            //ages["Bob"] = 32;

            //// Iterate over the key-value pairs
            //foreach (KeyValuePair<string, int> pair in ages)
            //{
            //    Console.WriteLine(pair.Key + ": " + pair.Value);
            //}
            //// Output: Alice: 25, Bob: 32, Charlie: 35

            //// Check if a key exists in the dictionary
            //bool containsKey = ages.ContainsKey("Bob");
            //Console.WriteLine(containsKey);  // Output: True

            //// Remove a key-value pair
            //ages.Remove("Charlie");

            //// Check the number of key-value pairs in the dictionary
            //int count = ages.Count;
            //Console.WriteLine(count);  // Output: 2

            //// Clear all key-value pairs from the dictionary
            //ages.Clear();

            //// Check if the dictionary is empty
            //bool isEmpty = ages.Count == 0;
            //Console.WriteLine(isEmpty);  // Output: True

            #endregion Dictionary<TKey, TValue>


            #region HashSet<T> example

            ////HashSet<T> example
            //// Create a HashSet of strings
            //HashSet<string> fruits = new HashSet<string>();

            //// Add elements to the set
            //fruits.Add("Apple");
            //fruits.Add("Banana");
            //fruits.Add("Orange");

            //// Check if an element exists in the set
            //bool contains = fruits.Contains("Apple");
            //Console.WriteLine(contains);  // Output: True

            //// Iterate over the elements
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
            //// Output: Apple, Banana, Orange

            //// Remove an element
            //fruits.Remove("Banana");

            //// Check the number of elements in the set
            //int count = fruits.Count;
            //Console.WriteLine(count);  // Output: 2

            //// Clear all elements from the set
            //fruits.Clear();

            //// Check if the set is empty
            //bool isEmpty = fruits.Count == 0;
            //Console.WriteLine(isEmpty);  // Output: True

            #endregion HashSet<T> example






            #region Queue<T> example

            //Queue<T> example
            // Create a Queue of integers
            //Queue<int> numbers = new Queue<int>();

            //// Enqueue elements to the queue
            //numbers.Enqueue(10);
            //numbers.Enqueue(20);
            //numbers.Enqueue(30);

            //// Access the first element in the queue
            //int firstNumber = numbers.Peek();
            //Console.WriteLine(firstNumber);  // Output: 10

            //// Dequeue elements from the queue
            //int dequeuedNumber1 = numbers.Dequeue();
            //int dequeuedNumber2 = numbers.Dequeue();

            //Console.WriteLine(dequeuedNumber1);  // Output: 10
            //Console.WriteLine(dequeuedNumber2);  // Output: 20

            //// Enqueue another element
            //numbers.Enqueue(40);

            //// Check the number of elements in the queue
            //int count = numbers.Count;
            //Console.WriteLine(count);  // Output: 2

            //// Iterate over the elements
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //// Output: 30, 40

            //// Clear all elements from the queue
            //numbers.Clear();

            //// Check if the queue is empty
            //bool isEmpty = numbers.Count == 0;
            //Console.WriteLine(isEmpty);  // Output: True

            #endregion Queue<T> example





            #region Stack<T>  example

            //Stack<T> example
            // Create a Stack of integers
            //Stack<int> numbers = new Stack<int>();

            //// Push elements onto the stack
            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);

            //// Access the top element of the stack
            //int topNumber = numbers.Peek();
            //Console.WriteLine(topNumber);  // Output: 30

            //// Pop elements from the stack
            //int poppedNumber1 = numbers.Pop();
            //int poppedNumber2 = numbers.Pop();

            //Console.WriteLine(poppedNumber1);  // Output: 30
            //Console.WriteLine(poppedNumber2);  // Output: 20

            //// Push another element onto the stack
            //numbers.Push(40);

            //// Check the number of elements in the stack
            //int count = numbers.Count;
            //Console.WriteLine(count);  // Output: 2

            //// Iterate over the elements
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //// Output: 40, 10

            //// Clear all elements from the stack
            //numbers.Clear();

            //// Check if the stack is empty
            //bool isEmpty = numbers.Count == 0;
            //Console.WriteLine(isEmpty);  // Output: True


            #endregion Stack<T>  example





            #region LinkedList<T>  example
            //LinkedList<T> example
            // Create a LinkedList of strings
            //LinkedList<string> names = new LinkedList<string>();

            //// Add elements to the linked list
            //names.AddLast("Alice");
            //names.AddLast("Bob");
            //names.AddLast("Charlie");

            //// Access elements in the linked list
            //LinkedListNode<string> firstNode = names.First;
            //LinkedListNode<string> lastNode = names.Last;

            //Console.WriteLine(firstNode.Value);  // Output: Alice
            //Console.WriteLine(lastNode.Value);   // Output: Charlie

            //// Insert an element after a specific node
            //LinkedListNode<string> insertNode = names.Find("Bob");
            //names.AddAfter(insertNode, "David");

            //// Remove an element from the linked list
            //LinkedListNode<string> removeNode = names.Find("Alice");
            //names.Remove(removeNode);

            //// Iterate over the elements
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //// Output: Bob, David, Charlie

            //// Check the number of elements in the linked list
            //int count = names.Count;
            //Console.WriteLine(count);  // Output: 3

            //// Clear all elements from the linked list
            //names.Clear();

            //// Check if the linked list is empty
            //bool isEmpty = names.Count == 0;
            //Console.WriteLine(isEmpty);  // Output: True

            #endregion LinkedList<T>  example



            #endregion Collection



        }

    private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25},
            new Galaxy() { Name="Milky Way", MegaLightYears=0},
            new Galaxy() { Name="Andromeda", MegaLightYears=3}
        };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
            }

            // Output:
            //  Tadpole  400
            //  Pinwheel  25
            //  Milky Way  0
            //  Andromeda  3
        }

        static bool IsPerfectSquare(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
        }
    }

    #region class
    //class

    public class Person
    {
        // Fields (attributes)
        public string Name;
        public int Age;

        // Methods
        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }



    class Car
    {
        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public bool IsRunning { get; private set; }

        // Constructor
        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            IsRunning = false;
        }

        // Methods
        public void Start()
        {
            if (IsRunning)
            {
                Console.WriteLine("The car is already running.");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("The car has been started.");
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("The car has been stopped.");
            }
            else
            {
                Console.WriteLine("The car is already stopped.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Is Running: " + IsRunning);
        }
    }


    #endregion class



    #region inheritance
    // inheritance
    // Base class
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }

    // Derived class
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("The cat is meowing.");
        }
    }

    #endregion inheritance



    #region Interface
    // Interface
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    // Class implementing the interface
    public class MediaPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Media player is playing.");
        }

        public void Pause()
        {
            Console.WriteLine("Media player is paused.");
        }

        public void Stop()
        {
            Console.WriteLine("Media player is stopped.");
        }
    }

    // Class implementing the interface
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Video player is playing.");
        }

        public void Pause()
        {
            Console.WriteLine("Video player is paused.");
        }

        public void Stop()
        {
            Console.WriteLine("Video player is stopped.");
        }
    }




    // Interface
    interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    // Payment Gateway Implementations
    class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} via PayPal...");
            // Additional PayPal-specific logic
            Console.WriteLine("Payment processed successfully.");
        }
    }

    class StripePaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} via Stripe...");
            // Additional Stripe-specific logic
            Console.WriteLine("Payment processed successfully.");
        }
    }





    #endregion Interface


    #region abstract class
    // C# program to illustrate the
    // concept of abstract class

    // Abstract class
    public abstract class Shape
    {
        // Regular property
        public string Name { get; set; }

        // Abstract method
        public abstract double CalculateArea();

        // Regular method
        public void Display()
        {
            Console.WriteLine("Shape: " + Name);
            Console.WriteLine("Area: " + CalculateArea());
        }
    }

    // Derived class implementing the abstract class
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Derived class implementing the abstract class
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    #endregion abstract class



    #region Static class
    // Static class
    public static class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    #endregion Static class



    #region Structure class
    // Structure
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine("Point: (" + X + ", " + Y + ")");
        }
    }

    #endregion Structure class



    #region Enum class

    // Enum
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion Enum class



    #region collection
    //collection
    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }


    }

    #endregion collection


}
