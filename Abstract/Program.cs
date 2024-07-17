using Abstract.Car;

var sportsCar = new SportsCar();
var superSportsCar = new SuperSportsCar();

Console.WriteLine("sports car: " +　sportsCar.Run() + " sports car open door: " + sportsCar.OpenDoor());
Console.WriteLine("sports car: " + superSportsCar.Run() + " sports car open door: " + superSportsCar.OpenDoor());
