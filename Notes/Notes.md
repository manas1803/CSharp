# Content
 - [Introduction](#introduction)
 - [NullableDatatypes](#nullable-datatypes)
 - [Null Coalescing Opeartor](#null-coalescing-operator)
 - [Datatypes Conversion](#datatypes-conversion)
 - [Method Parameters](#method-parameters)
 - [Class](#class)
 - [Static and Instance Class Members](#static-and-instance-class-members)
 - [Inheritance](#inheritance)
 - [Method Hiding](#method-hiding)
 - [Polymorphism](#polymorphism)
 - [Method Hiding and Method Overriding](#method-hiding-and-method-overriding)
 - [Encapsulation](#encapsulation)
 - [Properties](#properties)
 - [Structs and Class](#structs-and-class)
 - [Interfaces](#interfaces)
 - [Explicit Interface Implementation](#explicit-interface-implementation)
 - [Abstract Class](#abstract-class)
 - [Delegates](#delegates)
 - [How Delegates are useful?](#how-delegates-are-useful?)
 - [MultiCast Delegates](#multiCast-delegates)
 - [Exception Handling](#exception-handling)
 - [Inner Exceptions](#inner-exceptions)
 - [Custom Exceptions](#custom-exceptions)
 - [Enums](#enums)
 - [Access Modifiers](#access-modifiers)
 - [Attributes](#attributes)
 - [Reflection](#reflection)
 - [Generics](#generics)
 - [The ToString and Equals Method](#the-tostring-and-equals-method)
 - [Optional Parameters in C#](#optional-parameters-in-c#)
 - [Dictionary](#dictionary)
-------------------------------------------
# **Introduction**
C# is pronounced "C-Sharp".

It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.

C# has roots from the C family, and the language is close to other popular languages like C++ and Java.

The first version was released in year 2002. The latest version, C# 8, was released in September 2019.

C# is used for:

- Mobile applications
- Desktop applications
- Web applications
- Web services
- Web sites
- Games
- VR
- Database applications

[^Top](#content)

-------------------------------------------
# **Nullable Datatypes**
In C# we data types can be divided as **Value Types** and **Reference Types**

Values Types include 
- int
- long 
- float
- double

Reference Types include 
- Classes
- delegates 
- Arrays etc

But we can also classify them as **nullable** and **non-nullable**.
> **Reference Types** can be null as we can assisgn null values to them.
But for **Value types** this is not possible directly.

For eg 
```C#
int n = null
``` 
will throw a **compile error**.

But if we really want to make value types as null we can do that by adding **'?'** with them. So **value types** are further classified as 
- Null 
- Non-nulls.

Eg 
```C#
int? j = null;
```

[^Top](#content)

------------------------------------------
# **Null Coalescing Operator**
Lets suppose we have a variable assigned as null type and another as not null type. Now if we have conditional statements that if null variable value is null then the not null variable will be 0 else it will be of same value as null variable.

We can simply achieve this by the following code :-
```C#
int? TicketsOnSale = null;
int AvailableTickets;

if(TicketsOnSale==null)
AvailableTickets=0;
else
AvailableTickets=TicketsOnSale.Value;
```
**Or we can also use cast on AvailableTickets as**

```C#
if(TicketsOnSale==null)
AvailableTickets=0;
else
AvailableTickets=(int)TicketsOnSale;
```
This converts TicketsOnSale to int type.


But can we use Tertinary Operator in this case. No, But for the same purpose we have NULL COALESCING OPERATOR.

**The above statements can be written as** 
 
```C# 
int? TicketsOnSale = null;
int AvailableTickets = TicketsOnSale ?? 0;
```

>This statement says if null then 0 else TicketsOnSale value and the **'??'** are called as NULL COALESCING OPERATOR

[^Top](#content)

-------------------------------------------
# **Datatypes Conversion**
There are two types of datatypes of conversion :-
- Implicit 
- Explicit
```C#
int i = 1000;
float f = i;
```
In this case since float is a bigger datatype so compiler does the conversion implicitly. So in this case we will have no issue but if its in reverse order then in that case we have to **explicitly convert** it.

```C#
float f = 12.8F;
int i=f;
```
This will throw **error**.

We have 2 ways of conversion :- 
1. Type Casting  
2. Using class Convert to

**Using Type Casting**
```C#
float f = 12.8F;
int i = (int)f;
```
**Using Class Convert To**
```C#
float f = 12.5F;
int t = Convert.ToInt32(f);
```

>Explicit converson results in data loss as here we will have value 12 and not 12.8

Here also the output will be same but the difference comes when we will have a large value of 'f' which will be out of bound for int. In that case type casting and Convert to class shows different results.
>**Type casting** will give a **garbage value** with a negative value
But **Convert to cast** will throw an **exception**

Now if we have a string number and we want to convert it into integral value there also we have 2 methods.
1. Parse 
2. TryParse
```C#
string num = "123";
int x = int.Parse(num);
```
So in this case the string is converted to int, but if **the value gets larger than int or string is not number entirely** then parse throws and error.
```C#
string num = "21321fh";
int x= int.Parse(num); throws error;
```
We use **tryParse** when we are not sure that string might be num or not. 

TryParse method **returns a boolean value**. If conversion is successful then we get true else false.

TryParse has 2 parameters. 
1. One parameter is string  
2. The second parameter is the variable in which we want to assign the value.
```C#
string Num = "287328";
int Result=0;
bool IsConverted = int.TryParse(Num,out Result);
```

[^Top](#content)

------------------------------------------
# **Method Parameters**
There are 4 types of Method Parameters :-
1. Value Parameter
2. Reference Parameter
3. Out Parameter
4. Params Parameter

**Value Parameter** :- In case of value parameter we simply create a copy of the parameter value so both the values are unrelated.

```C#
main(){
int i=0;
num(i);
Console.WriteLine(i);
}
public static void num(int j){
j=1122;
}
```
>So when executing this program we will not get value as 1122 but 0 because we have no reference type. So we just create a copy of i and send it to the function.

**Reference Parameter** :- In case of reference parameter we provide the address of the variable in parameter and hence when value changes of the parameter it is reflected everywhere.

```C#
main(){
int i=0;
num(ref i);
Console.WriteLine(i);
}
public static void num(ref int j){
j=1122;
}
```
>We have to use ref keyword to distinguish it with the value parameter.Here we get the output as **1122**

**Out Parameter** :- In case we want to return more than one type of value(like we want to return both sum and product of 2 numbers from a method) then for such cases we require **out** parameter.

```C#
main(){
int Sum=0;
int Product=0;
SumAndProduct(int i,int j,out Sum,out Product);
Console.WriteLine(Sum);
Console.WriteLine(Product);
}
public static void SumAndProduct(int i,int j,out int Sum,out int Product){
Sum = i+j;
Product = i*j;
}
```
>In this case we assign the value of sum and the product to the out variables.


**Array Params Parameter** :- If we want to pass an array of values as parameter we can use array params. The condition is we have to use it only once as a parameter and it should be the last parameter. One advantage of using this is that we need not to pass it as an argument when calling the function containing array params.

[^Top](#content)

------------------------------------------

# **Class**
 A class consists of data and behaviour. Class data is represented by it's fields and behaviour is represented by its methods.

 **Purpose of Class Constructor**:-
The pupose of a class constructor is to initialize class fields. A class constructor is automatically called when an instance of a class is created. 
Constructors do not have a return value and have the same name as the class.Constructors are not manadatory. If we do not provide a constructor, **a default parameter less constructor is automatically provided**. Constructors can be overloaded by the number and type of parameters.

[^Top](#content)

------------------------------------------
# **Static and Instance Class Memebers**

- When a class member includes **static modifier** than it is called as **static member** of that class. When **no static modifier** is present the member is called as **non-static member** or **instance member**.
- **Static members** are invoked using **class name** whereas instance member are invoked using the **instance of that class**.
- An instance member belongs to the instance of that class, if we have 3 different types of instances of a class we will have 3 different types of those instance members. But for static members no matter how many instances are created there is always one instance of the member.

>We use static members for those whose values will not change over any instance(like some constants). This reduces the memory usage by variables so that unneccessary instances are not created.

[^Top](#content)

------------------------------------------
# **Inheritance**
Inheritance is one of the primary pillar of OOPS. It is basically used to reuse the code and have coding more efficient. The syntax for inheritance in C# is simply using :
```C#
class x : y{

}
```
Here **class y is parent class** **inherited by class x** that is the child class.

>We cannot have multiple base class i.e. **the parent class**. 

In other words we cannot have multiple inheritance of classes in such a way. 
It is generally achieved by **interface use**. 

However we can have **multilevel inheritance** i.e. we can follow the multilevel of inheritance.

>In inheritance the **parent class or base class** gets called before the **child class**. 

So basically as soon as we create an instance of child class the constructor of parent class gets called. 

>In case we have to call a **specific constructor** of the base or parent class then in that case we **add the base keyword in the constructor** like we are adding in the class with **':' symbol**.

```C#
class A{
	A()
    {
        print("Hello World")
    }
	A(message)
    {
        print(message)
    }
}
class B : A{
	B(){
	
	}
}
``` 
Now in the above case the main constructor with no parameters will be called. But if we want to call the second constructor then

```C#
class A{
	A()
    {
        print("Hello World")
    }
	A(message)
    {
        print(message)
    }
}
class B : A{
	B():base("My message is "){
	
	}
}
```

**Important Points about inheritance** :-
1. C# supports only **single class inheritance**.
2. C# supports **multiple interface inheritance**.
3. Child class is **specialization of base** class
4. Base classes are **automatically instantiated** before derived classes.
5. Parent Class constructor **executes before** child class constructor.

[^Top](#content)

------------------------------------------
# **Method Hiding** 

If we create a **same method** in child class as parent class and then we call it, then **the method of parent class** gets hidden. 

We can also add the **new keyword** in this method of child class to avoid any warnings if we know **beforehand** that we are going to **hide a parent class** method.

If we want to show the actual hidden method of the parent class we have 3 ways for that :-

1. Call the method using the keyword **"base"** in the childClass.
2. Cast the **instantiated object** as the object of the parent class.
```C#
ChildClass cs = new ChildClass();
((ParentClass)cs).CallingTheMethod();
```
3. Instantiate the obj making it call the parent class.
```C#
ParentClass cs = new ChildClass();
cs.CallingMethod();
```
[^Top](#content)

------------------------------------------
# **Polymorphism**
1. It is one of the **primary pillars** of OOPS
2. It allows us to **invoke derieved class** methods through a **base class reference** during **run time**
3. In the **base class** the method is declared as **virtual** and in derieved class we use the keyword **override** to override the same method
4. The virtual keyword indicates that the method **can be overridden** in the derieved class

```C#
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}
```

The output for the above will be :
```
The animal makes a sound
The pig says: wee wee
The dog says: bow wow
``` 

[^Top](#content)

-------------------------------------------------------
# **Method Hiding and Method Overriding**

1. In **method overriding** the base class refernce variable pointing to a child class object will invoke the child class overridden method
2. In **method hiding** the base class refernce variable pointing to a child class object will invoke the method hidden by the child class of the base class since the refernce variable is of base class.

[^Top](#content)

-------------------------------------------------------
# **Encapsulation**
Another important pillar of OOPS concept is **encapsulation**. 

If we mark all the fields of our class as public we expose it to the risk of getting wrong values as they are set as public. But if we want to control how the values are assigned to the different variables of our class then we make use of encapsulation. 

It is achieved by using the setter and getter methods.

```C#
class Student
{
    private int _id;
    private string _name;
    private int _passmarks = 35;

    public void SetId(int ID)
        {
            if (ID <= 0)
            {
                throw new Exception("Id cannot be less than or equal to 0");
            }
            this._id = ID;
        }
    public int GetId()
        {
            return this._id;
        }

    public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            else
                this._name = Name;
        }
    public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name"  : this._name;
        }
    public int GetPassmarks()
        {
            return this._passmarks;
        }
}
```

[^Top](#content)

---
# **Properties** 
The concept of properties was introduced in C# to make a way to write **get** and **set** methods more effectively. 

The advantage of using properties is we treat get and set as public fields rather than a method.
We can rewrite the previous code as :-
```C#
class Student{
		private int _id;
        private string _name;
        private int _passmarks = 35;
        public string Email { get; set; }

        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be less than 1");
                }
                this._id = value;
            }
        }

        public string Name
        {
            get
            {
                return (string.IsNullOrEmpty(this._name)) ? "No name" : this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be null");
                this._name = value;
            }
        }
        public int Passmarks { get { return this._passmarks; } }
}
```

To call these methods we simply use them as fields like :- **obj.Id = //Enter ID here//**

In the above code the way we have wriiten the **email** it is called as **auto-implemented properties**. 
```C#
    public string Email {get;set;}
```
In such cases when we don't have any condition on type of the value then we go with this approach.

[^Top](#content)

---
# **Structs and Class**
### Similarities :-

1. Both can have **parameterized Constructors**.
2. Both have **reference type** to call them.
3. Both can have **properties** i.e. set and get.
4. Both support **interface inheritance**.

### Difference :-

1. To declare a structure we use **struct** keyword while for classes we use **class**.
2. A struct is **value type** while a class is **reference type**.
3. Struct are stored on **stacks** where as classes are stored in **heaps**.
4. When we copy a struct into another struct then a new copy of that struct is created and if we change any value in the new copy we **will not have any changes** in the original struct.While in case of class since it is **reference type** any changes in the copied class effects the original.
5. Structs doesn't have any **destructors** while classes have.
6. Structs cannot have **parameterless** constructors.
7. Struct **cannot inherit** from any class and hence doesn't implement class **inheritance** while classes can inherit other classes.

> A class or struct cannot inherit from any other struct as they are **sealed types**.To **not allow** any inheritance of a class we need to add the keyword **sealed** before the **class keyword**. Structs are by default sealed.
```C#
public sealed class A{}
```

[^Top](#content)

---
# **Interfaces**
1. We create interfaces using the **interface** keyword.
2. Just like classes interface also contains **properties,methods,delegates or events** but just there declarations and **no implementation**.
3. It is **compile time error** to provide implementation for any interface members.
4. Interface members are **public by default** and they **don't allow** explicit access modifiers.
5. If a class or structs **inherits** any inteface they should **implement all** the methods or members that are there in the interface otherwise it is a **compile time error**.
6. A class or struct can **inherit more than one** interface at a time and hence support **multiple interface inheritance**. 
7. The class have to implement all these members of interface. 
8. Intefaces **can inherit** other interfaces. We **cannot** create an **instance** of an interface, but an interface refernce variable can point to a derieved class object.

[^Top](#content)

---
# **Explicit Interface Implementation**
If we have two interfaces with **same method definition** and both are **inherited by the same class** then in that case if we want to implement both the methods then we use the **explicit method of interface implementation.**

When we have explicitly implemented the Interfaces then we **no longer** can call them using the **class reference variable** rather we need to use the **interface reference variable** for that(*or you can even cast the class reference variable with interface reference variable*).

>Access modifiers are **not allowed** while explicitly implementing the interfaces.

Syntax :-
```C#
interface I1{void print();}
interface I2{void print();}
class A: I1,I2{
	void I1.print(){//Something here}
	void I2.print(){//Something here}
} 
class Main(){
	I1 i1 = new A();     //This is one way of doing 
	I2 i2 = new A();
	i1.print();
	i2.print();
	
	A obj = new A();
	
	((I1)obj).print();		//Another way
	((I2)obj).print();
}
```
>If we want to make an interface as default interface then we need to implement that normally. Then when we call the interface without casting or without interface reference variable then we call that default interface.

[^Top](#content)

---
# **Abstract Class**
The **abstract keyword** is used to make an abstract classes.

An abstract class is **incomplete** and hence cannot be **instantiated.**

An abstract class can only be used as **base class.**

An abstract class cannot be **sealed.**

An abstract class **may contain abstract members** but not mandatory.

A non-abstract class derieved from an abstract class must provide implementations for **all inherited abstract members.**

We have to add **"override"** keyword to implement the method 

If a class inherits an abstract class there are 2 options available for that class :-

1. Provide implementation for all the abstract members inherited from the base abstract class.
2. If the class does not wish to provide implementation for all the abstract members inherited from the abstract class, then the class has to marked as abstract.

[^Top](#content)

---
# **Delegates**
A delegate is a type safe **function pointer.** By this we mean that they are basically the function pointers and type safe means if the signature of the function doesn't matches that of the delegate then it throws compile time error.

A delegate is similar to class. You can create an instance of it and when you do so,you pass in the function name as a parameter to the delegate constructor and it is to **this function** the delegate will point to.

Eg :-
```C#
delegate void HelloFromTheDelegate(string strMessage);
class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            HelloFromTheDelegate del = new HelloFromTheDelegate(p.HelloWorld);
            del("Hello World");
        }
        public void HelloWorld(string strName)
        {
            Console.WriteLine(strName);
        }
	}
```

[^Top](#content)

---
# **How Delegates are useful?**

In future we sometime want some **generic type of reusable code** so that anyone can use that so we can make use of delegates in such a situation.

Lets take an example of employee class where we have a condition according to which we will promote the employees but in future it may change so we need a generic code for such a purpose.

Eg :-
```C#
delegate bool IsPromatable(Employee emp);
class Employee{
	prop ID;
	prop Name;
	prop Salary;
	prop Experience;
	
	public void PromotingEmployees(List<Employee> employeelist,IsPromatable isElig)
    {
		foreach(Employee emp in employeelist){
			if(isElig(emp)){
			Console.WriteLine("Employee promoted is {0}",emp.Name);
			}
		}
	}
}
```

This is the generic code we will be using for the same purpose again and again. Now we need a method to which this delegate will point and that method will have our logic.

```C#
class program{
    main()
    {
        List of employee made here;
        program p = new program();
        IsPromatable isp = new IsPromatable(p.IsPromote);
        Employee e = new Employee();
        e.PromotingEmployees(List of employees,isp);
    }
    public bool IsPromote(Employee emp)
        {
	        if(condition)
                return true;
	        return false;
        }
}
```

[^Top](#content)

---
# **MultiCast Delegates**
It is a delegate that has reference to **more than one function.** 

When you invoke a multicast delegate, all the functions the delegate is pointing to, are invoked.


There are 2 approaches to create a multicast delegate.Depending on the approach we can use :-
1. \+ or += to register a method with delegate
2. \- or -= to remove that delegate from the list.

Eg :-
```C#
// C# program to illustrate the 
// Multicasting of Delegates 
using System; 

class rectangle { 
	
// declaring delegate 
public delegate void rectDelegate(double height, 
								double width); 

	// "area" method 
	public void area(double height, double width) 
	{ 
		Console.WriteLine("Area is: {0}", (width * height)); 
	} 

	// "perimeter" method 
	public void perimeter(double height, double width) 
	{ 
		Console.WriteLine("Perimeter is: {0} ", 2 * (width + height)); 
	} 


// Main Method 
public static void Main(String []args) 
{ 
	
	// creating object of class 
	// "rectangle", named as "rect" 
	rectangle rect = new rectangle(); 

	// these two lines are normal calling 
	// of that two methods 
	// rect.area(6.3, 4.2); 
	// rect.perimeter(6.3, 4.2); 

	// creating delegate object, name as "rectdele" 
	// and pass the method as parameter by 
	// class object "rect" 
	rectDelegate rectdele = new rectDelegate(rect.area); 
	
	// also can be written as 
	// rectDelegate rectdele = rect.area; 

	// call 2nd method "perimeter" 
	// Multicasting 
	rectdele += rect.perimeter; 

	// pass the values in two method 
	// by using "Invoke" method 
	rectdele.Invoke(6.3, 4.2); 
	Console.WriteLine(); 
	
	// call the methods with 
	// different values 
	rectdele.Invoke(16.3, 10.3); 
} 
} 
```
The output for the above code is 
```
Area is: 26.46
Perimeter is: 21 

Area is: 167.89
Perimeter is: 53.2 
```		
We can also create more than one delegates to reference to one of the method and then simply add them.

This will output all of the methods that has been called.

 
>If the delegate has a return type and if the delegate is multicast delegate then in that case the value returned by the last method that has been pointed by the delegated is retained as the actual value returned even though we may have multiple functions being pointed by that delegate. Even if we have an out parameter in the functions being pointed the last pointed function's output parameter will store the actual value at the end.

>Multicast delegates makes implementation of observer design pattern very simple. Observer pattern is also called as publish subscribe pattern.

[^Top](#content)

---
# **Exception Handling**
An exception is an unforseen error that occurs when a program is running

Examples :-

ArrayIndexOutOfBound, FileNotFound are some of the common exceptions.

An exception is the **base class** for all the other exceptions. 

It contains methods like **exception.message** or **stacktrace** that are very helpful to determine which type of exceptions are we dealing with and the line of that exception. 

We can also specific the actual type of exception if we are sure about the type of the exception else we need to use the **Exception class** that is the base class for all the exception.

We use **try catch finally block** to handle any exceptions. We use finally block to restore any resources that might have been open before the exception occured.

[^Top](#content)

---
# **Inner Exceptions**
The inner exception property returns the **Exception instance** that caused the current exception. 

To retain the original exception pass it as a parameter to the **constructor** of the current exception.

Always check if **inner exception** is even passed or not i.e. if it is null or not because then it will also throw a null exception. 

To get the type of exception we use the method **GetType().**

Eg :- 
```C#
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ExceptionHandling
    {
        public void InnerExceptionHandled()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int divide = a / b;
                    Console.WriteLine("The result is {0}", divide);
                }
                catch (Exception ex)
                {
                    string filepath = @"D:\Practice\C#\CSharpBasics\Docs\logss.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException("The file was not found ", filepath, ex);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The current Exception is {0}",e.GetType().Name);
                Console.WriteLine("The inner Exception is {0}",e.InnerException.GetType().Name);
            }
        }
    }
}
```
[^Top](#content)

---
# **Custom Exceptions**
1. Create a class that derieves from System.Exception class as the parent or base class.
2. The next step involves creating constructor with same parameters as present in base class. By this we can make our exception class more effective.
3. We can pass a string message to the constructor and thus the exception can print a message of its own.
4. We can also make a constructor to create inner exception just by overloading the constructor present in the base class.
5. Similarily if we want to create an exception of our own to be used on other projects we need to serialize that and that can be done by overloading the serializing constructor and by adding Serialization keyword above the constructor.

Eg:-
```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class CustomException
    {
        public void ExceptionPrinting()
        {
            throw new UserAlreadyLoggedInException("User already logged in");
        }
        
    }

    [Serializable]
    class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message,Exception innerException) : base(message, innerException)
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info,context)
        {

        }
    }
}

```

>  Always try to use tryparse and other such ways rather than using exception handling for small issues as it leads to exception abuse

[^Top](#content)

---
# **Enums**
1. If a program uses set of integral numbers, consider replacing them with enums and thus making them **more readable and maintainable.**
2. Enums are **enumerations**
3. They are **strongly typed constants**
4. An **explicit cast is needed** to convert from enum type to integral type.
5. An enum of one type **cannot be assigned** to an enum of other type implicitly though the values may be same
6. The default values given to enums is **int**
7. We can change this default value by **inheriting any of the datatype** to the enum we created
8. Enums are **value types**
9. By default the values assigned to the enums **start with 0.** We can change that according to our use by assigning the values to the enums inside the declaration.
10. We can use **static methods of enum like Enum.GetValues**(Enum name here ) to get the values of the enum, and similarly **Enum.GetNames(Enum name here)** to get the names of the enum values.The return type of these methods is **array of int[]** and **array of string[]** respectively.

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Enums
    {
        public void PrintEnums()
        {
            string[] enumList = Enum.GetNames(typeof(MyEnums));
            int[] valueEnums = Enum.GetValues(typeof(MyEnums));
        }
    }
    public enum MyEnums
    {
        Batman,
        Superman,
        WonderWoman
    }
}
```
[^Top](#content)

---
# **Access Modifiers**

We have types and type members. 

Types are generally class, struct,interface, etc whereas the members inside them are called type members.

Types can only be either public or internal as access modifiers. Where Type members can be private internal and internal protected also.

We have 5 kinds of access modifiers for C# :-
1) Public
2) Private
3) Protected
4) Internal
5) Internal Protected

**Public Access Modifier** means that it is acccessible to all and everywhere. 

For **Private Access Modifier** the accessibility is limited to only that type in which it is declared. 
> Note any types cannot be private so any of its member may be private therefore the private member in such a case is only accessible to those memebers inside that type.

In case of **Protected Access Modifier** the accessibility is same as private with the difference that if that type containing protected member is inherited by any other type then it will be accessible to the inheriting type also.

**Internal Access Modifier**
In C# we have concept of Assembly. Any Project we create gets converted to assembly and these assemblies are of two types :-
1. .exe files in case of console application
2. .dll files in case of libarary or web approach

Now if in a solution we have suppose 2 projects and in one of the projects we have a method inside the class as internal then that method is only accessible to the types and type members of that project which will create one assembly. But that will not accessible to the other project and hence these modifiers are called internal modifiers.

> A member with internal access modifier is available anywhere with in the containing assembly. It's a complie time error to access an internal member from outside the containing assesmly.

**Protected Internal**
Now if again we have 2 projects in a solution. Out of which one has the type containing internal protected method then if we inherit this type in any other assemblies type then we can access that. In short it is mix of protected and internal modifiers.

>We can use all the access modifiers with the type members but for types we can only use 2 access modifiers public and internal.

[^Top](#content)

---

# **Attributes**
Lets take an example to understand this.
Suppose we create one class of calculator and we have a method to add 2 numbers. It will run perfectly fine

```C#
public static int Add(int FirstNumber,int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
```

But in future we want a method which can add 3 numbers and then one which can add 10 numbers and so on.

So each time we cannot add more parameters right. So the better part is that we create one parameter as list of integers and pass that as parameter where we can add as many numbers as we want.

```C#
public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int num in Numbers)
            {
                Sum += num;
            }
            return Sum;
        }
```

But the old method will still be in use in many projects and if we remove that we will break the code so in order to tell the new users to use the new method rather than the old one we use one of the attribute *OBSOLETE*

> Attributes are basically the text or information that is added before a method that tells us that what that method means

```C#
    class AttributeExplained
    {
        [Obsolete("Use the method Add(List<int> Numbers)")]
        public static int Add(int FirstNumber,int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int num in Numbers)
            {
                Sum += num;
            }
            return Sum;
        }
    }
```

> All the attribute methods are derieved from attribute class.

> If we add obsolete attribute to a method then at runtime its throws a warning if we are stillusing the same method

> For Obsolete attribute if we want to provide more information and not just that the method is obsolete then we call other constructors which pass a string of message where we can display anything we want.

> We have one more overloaded method for obsolete that is the error part which is bool. It is false by default if we make it true then if we are using the obsolete method it throws an error.

[^Top](#content)

---
# **Reflection**
Sometimes we want the information regarding the content of our class after compile time at run time. To get all the information regarding our classes in such case we use the reflection.

When we build our program we create 2 files .exe and .dll. These are called assembly files. They store the contents of our code. The class names, methods, constructors etc etc.

So through reflection we can access all this data.

In reflection what we do is we create an instance of Type. Type is present in System.Type.

Then using that instance we can access all the things regarding that type.

To make it simpler 
- First we create instance of type
- Then we assign the value to type, i.e. the type of which we want the data and it is the class basically.
- And then using the ConstructorInfo, MethodInfo, PropertiesInfo and other such methods we get the data

WHY WE REQUIRE REFLECTION

- For late binding. Late binding is the process in which we use the instance of the class at runtime and create it at that time.
- For Tools like WebAsp.net where on dragging the button we get all the properties of button at left hand side

The code for reflection is 

```C#
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace CSharpComplete
{
    public class MainClass
    {
        public void Printing()
        {
            Type T = Type.GetType("CSharpComplete.ReflectionExplained");
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine();
            Console.WriteLine("Properties list for ReflectionExplained class is ");

            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("Name of property is "+ property.Name + " and property type is " + property.PropertyType);
            }

            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine();
            Console.WriteLine("Methods list for ReflectionExplained class is ");

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Name of method is " + method.Name + " and method type is " + method.ReturnType);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            Console.WriteLine();
            Console.WriteLine("Constructors list for ReflectionExplained class is ");

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("Name of constructor is " + constructor.ToString());
            }
        }
    }
    public class ReflectionExplained
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private int _marks;

        ReflectionExplained()
        {

        }
        ReflectionExplained(int marks)
        {
            this._marks = marks;
        }

        public void Print()
        {
            Console.WriteLine("Hello World");
        }
        public void Run()
        {
            Console.WriteLine("Lets run");
        }
    }
}

```

> For reflection in place of T.GetType we can also have typeof(ClassNameHere)

[^Top](#content)

---

# **Generics**
Generics are way of making the class or method generic to use without specifying the data type beforehand but at time while using the code.

Suppose we have a method of AreEquals which takes two parameters and evaluates whether the two values are equal or not.

Now we can make the parameter datatype as string but then in future if we want to calculate for int then how to use the same method.

So in such case we have 2 options :- 
- Make the parameter datatypes as object
- Make the parameter datatypes as generic

If the datatypes are object it causes the problem of boxing and unboxing again and again and thus resulting in slow performance.

So we create generic datatypes for the parameters.

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    public class GenericExplained
    {
        public void Print()
        {
            Calculate calc = new Calculate();
            bool value = calc.AreEqual<string>("A","B");
            if (value)
            {
                Console.WriteLine("Are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
    public class Calculate
    {
        public bool AreEqual<T>(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}

```

> The 'T' here represents the generic type that can be anything and hence the method is generic. We have to use .Equals method because its generic

We can also make the class as generic too.In that case we apply the generic code to the class and then while calling the method in the class name we give the datatype we want.

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    public class GenericExplained
    {
        public void Print()
        {
            Calculate<int> calc = new Calculate<int>();
            bool val = calc.AreEqual(20, 20);
            int result = calc.HelloWorld(30, 55);

            if (val)
            {
                Console.WriteLine("The result from hellow world is {0}",result);
            }
            else
            {
                Console.WriteLine("No result");
            }
        }
    }
    public class Calculate<T>
    {
        public bool AreEqual(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
        public T HelloWorld(T value1,T value2)
        {
            if (value1.Equals(value2))
                return value1;
            else
                return value2;
        }

    }
}

```

[^Top](#content)

---

# **The ToString and Equals Method**
When we create an instance of a class or create any type(generic for any type), the System.Object gives us with 4 inbuilt methods 
- ToString()
- Equals()
- GetHashCode()
- GetType()

Out of these 4 the first 3 are virtual methods and we can override them.

WHEN TO OVERRIDE THE METHODS :-

**The ToString() method**
 Suppose we create a class and its instance as Customer class and we wish to get the toString value for the instance.

 By default we will get the type value for the following case.

But suppose we want to print something else in the above case then we overide the method and simply return the value we want to display.

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OverridingInBuiltClasses
    {
        public void Print()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Manas";
            C1.LastName = "Pant";
            Console.WriteLine(C1.ToString());
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}

```

**The Equals Method**
Suppose we created 2 instances of a class and if we try to check there equality through "==" then it comes as false because they are different references.

But even if we use the equals inbuilt method it shows false even though the values are same.

To avoid this we can override the equals method such that it checks for the value.

```C#
    using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OverridingInBuiltClasses
    {
        public void Print()
        {
            Customer c1 = new Customer();
            c1.FirstName = "Manas";
            c1.LastName = "Pant";
            //Console.WriteLine(c1.ToString());

            Customer c2 = new Customer();
            c2.FirstName = "Manas";
            c2.LastName = "Pant";
            //Console.WriteLine(c2.ToString());

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));

        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // public override string ToString()
        // {
        //     return this.FirstName + " " + this.LastName;
        // }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }
    }
}

```
> Once we have done the equals override we need to override the getHascode also so that the hashcode doesn't change(This thows a warning message in code)

```C#
public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
```

### **Important Notes Regarding String**

1. There is difference between Convert.ToString() and .ToString() method. For the first case when we try to convert a datatype with null value to string it makes it ""(empty string) but the latter method throws an exception.

```C#
// This case throws exception

int? i = null;
string str = i.ToString();

// This case makes the str as empty
int? i = null;
string str = Convert.ToString(i);

```

2. There is difference between string class and stringBuilder class. The first one is mutable so when we concat the same instance again and again we keep on creating garbage instances thus filling up the heap and slowing the process. StringBuilder whereas is mutable and for string builder we can't directly use '+' sign for concatenation. We use the .append method for it.

```C#
// In this case we will create 10001 instances of string object 
//but will use only one and thus creating garbage
string str = "Manas";
for(int i=1;i<10000;i++){
    str+=Convert.ToString(i);
}

StringBuilder str = new StringBuilder("Manas");
for(int i=1;i<10000;i++){
    str.Append(Convert.ToString(i));
}
```

[^Top](#content)

---

# **Optional Parameters in C#**
 Many a times we want to pass optonal Parameters in function methods in C#. For that purpose we have 4 ways to do :-

 1. Using Optional Parameter
 2. Using Method Overloading
 3. Specifying Parameter Defaults
 4. Using Optional Attribute

### **Optional Parameter**

In this case we pass the parameters with optional params being passed at last and thus when we execute the program if we don't specify the optional part it is taken as null.

> The last parameter should always be the optional parameter

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterUsingParams
    {
        public void Print()
        {
            OptionalParameterUsingParams op = new OptionalParameterUsingParams();
            op.AddNumbers(10, 20,30,60);
        }
        public void AddNumbers(int FirstNumber,int SecondNumber,params object[] RestOfNumbers)
        {
            int sum = FirstNumber + SecondNumber;
            if (RestOfNumbers != null)
            {
                foreach(int i in RestOfNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }
}

```

### **Method Overloading**

We can use method overloading also. Now we know that the main issue is that we will have 2 numbers but after that we are not sure.

So we can pass 'null' while sending data. But we can't be sure to send null everytime so we make another method overloading this one and making there the null call

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterUsingMethodOverloading
    {
        public void Print()
        {
            OptionalParameterUsingMethodOverloading oop = new OptionalParameterUsingMethodOverloading();
            oop.AddNumbers(10, 20);
            
        }
        public void AddNumbers(int FirstNumber, int SecondNumber)
        {
            OptionalParameterUsingMethodOverloading o = new OptionalParameterUsingMethodOverloading();
            o.AddNumbers(FirstNumber, SecondNumber, null);
        }
        public void AddNumbers(int FirstNumber, int SecondNumber, int[] RestOfNumbers)
        {
            int sum = FirstNumber + SecondNumber;
            if (RestOfNumbers != null)
            {
                foreach (int i in RestOfNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

```

### **Specifying Parameter Defaults**

We can also use the above method. It is very important and useful concept. We can apply this in any methods and for any number of parameters.

```C#
public void MethodName(int a = 10,int b = 20,int c)
```

Now here c is the required parameter but for a and b we have given a default value so if we don't specify them then we take that value

Using this to solve the above problem

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterBySpecifyingDefaultParameterValue
    {
        public void Print()
        {
            OptionalParameterBySpecifyingDefaultParameterValue od = new OptionalParameterBySpecifyingDefaultParameterValue();
            od.AddNumbers(10, 20,new int []{ 30,40});
        }
        public void AddNumbers(int FirstNumber, int SecondNumber, int [] RestOfNumbers=null)
        {
            int sum = FirstNumber + SecondNumber;
            if (RestOfNumbers != null)
            {
                foreach (int i in RestOfNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

```

### **Using Optional Attribute**

We can also use the Optional Attribute for the purpose. We just need to call that attribute through defined class and then add the attribute before the parameter we want to make optional.

```C#
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterUsingOptionalAttribute
    {
        public void Print()
        {
            OptionalParameterUsingOptionalAttribute ooa = new OptionalParameterUsingOptionalAttribute();
            ooa.AddNumbers(10, 20);
        }
        public void AddNumbers(int FirstNumber, int SecondNumber, [Optional] int[] RestOfNumbers)
        {
            int sum = FirstNumber + SecondNumber;
            if (RestOfNumbers != null)
            {
                foreach (int i in RestOfNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

```

[^Top](#content)

---

# **Dictionary**
A dictionary is one the collection used for inserting and storing data.

1. A dictionary is a collection of (key,value) pairs.
2. Dictionary class is present in System.Collections.Generic namespace
3. When creating a dictionary we need specify the type for key and value.
4. Dictionary provides fast lookups for values using keys
5. Keys in the dictionary must be unique.

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class DictionaryExplained
    {
        public void Print()
        {
            Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
            
            Employee e1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Manas",
                Salary = 30000
            };

            Employee e2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Arjun",
                Salary = 40000
            };

            Employee e3 = new Employee()
            {
                EmpId = 103,
                EmpName = "Atul",
                Salary = 50000
            };
            
            employeeDictionary.Add(e1.EmpId,e1);
            employeeDictionary.Add(e2.EmpId,e2);
            employeeDictionary.Add(e3.EmpId,e3);

            foreach(KeyValuePair<int,Employee> empData in employeeDictionary)
            {
                Console.WriteLine("The employee id is {0}",empData.Key);
                
                Console.WriteLine("The employee name is " + employeeDictionary[empData.Key].EmpName + " and the salary of employee is " + employeeDictionary[empData.Key].Salary);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            }
        }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }
}

```
> The key for dictionary should be unique

Important methods in Dictionary are :-
1. TryGetValue
2. Count and Count()
3. Remove()
4. Clear
5. Converting Array or List to Dictionary

### **TryGetValue**
The first method we are looking is the tryGetValue.

As the name suggest its functionality is similar to tryParse like it also returns boolean and it also checks whether the key we mentioned there is present or not.

If key is there then it returns the output in the out parameter we pass.

```C#
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class DictionaryTryGet
    {
        public void Print()
        {
            Dictionary<int, Employees> employeeDictionary = new Dictionary<int, Employees>();

            Employees e1 = new Employees()
            {
                EmpId = 101,
                EmpName = "Manas",
                Salary = 30000
            };

            Employees e2 = new Employees()
            {
                EmpId = 102,
                EmpName = "Arjun",
                Salary = 40000
            };

            Employees e3 = new Employees()
            {
                EmpId = 103,
                EmpName = "Atul",
                Salary = 50000
            };

            employeeDictionary.Add(e1.EmpId, e1);
            employeeDictionary.Add(e2.EmpId, e2);
            employeeDictionary.Add(e3.EmpId, e3);

            Employees e4 = new Employees();
            Console.WriteLine("Please enter the key for which to search for data in dictionary");
            int key = Convert.ToInt32(Console.ReadLine());
            if(!employeeDictionary.TryGetValue(key,out e4))
            {
                Console.WriteLine("Enter the employee name and employee salary");
                employeeDictionary.Add(key, new Employees() { EmpId = key, EmpName = Console.ReadLine(), Salary = Convert.ToInt32(Console.ReadLine()) });
            }
            else
            {
                Console.WriteLine("The Employee exists and the details are");
            }

            foreach (KeyValuePair<int, Employees> empData in employeeDictionary)
            {
                Console.WriteLine("The employee id is {0}", empData.Key);

                Console.WriteLine("The employee name is " + employeeDictionary[empData.Key].EmpName + " and the salary of employee is " + employeeDictionary[empData.Key].Salary);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            }
        }
        class Employees
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public int Salary { get; set; }
        }
    }
}

```
### **Count**
We have two types of count method. The first one is a property which simply returns us the count of values in dictionary

The second one is a method of LINQ which can be overloaded with condition according to which we want the count of values.

```C#
int counter = employeeDictionary.Count;
            int linqCounter = employeeDictionary.Count(kvp=>kvp.Value.Salary>35000);

            Console.WriteLine(counter);
            Console.WriteLine(linqCounter);

```

### **Remove**

Remove method is used to remove a data value from dictionary whose key is specified as a parameter

If key doesn't match it doesn't throw any error

```C#
employeeDictionary.Remove(keyHere);
```

### **Clear**

The clear method clears all the values in a dictionary making it empty.

```C#
employeeDictionary.Clear();
```

[^Top](#content)

---
