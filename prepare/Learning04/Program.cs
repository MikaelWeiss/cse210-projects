using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

class Vehicle {
    protected string make;
    protected string model;
    protected int miles;

    public Vehicle(string make, string model, int miles) {
        this.make = make;
        this.model = model;
        this.miles = miles;
    }
}

class Car : Vehicle {
    private int doors;
    private int seats;

    public Car(string make, string model, int miles, int doors, int seats) : base(make, model, miles) {
        this.doors = doors;
        this.seats = seats;
    }
}

class Truck : Vehicle {
    private int towingCapacity;

    public Truck(string make, string model, int miles, int towingCapacity) : base(make, model, miles) {
        this.towingCapacity = towingCapacity;
    }
}

class Motercycle : Vehicle {
    private int topSpeed;

    private Motercycle(string make, string model, int miles, int topSpeed) : base(make, model, miles) {
        this.topSpeed = topSpeed;
    }
    public Motercycle(int topSpeed) : this("Harley-Davidson", "Softail", 0, topSpeed){
        this.topSpeed = topSpeed;
    }
}

class Person {
    string name;
    string address;
    string phoneNumber;

    public Person(string name, string address, string phoneNumber) {
        this.name = name;
        this.address = address;
        this.phoneNumber = phoneNumber;
    }
}

class Student : Person {
    string studentID;

    private Student(string name, string address, string phoneNumber) : base(name, address, phoneNumber) { }

    public Student(string studentID) : this("John Doe", "1234 Elm St", "555-5555") {
        this.studentID = studentID;
    }
}