// // ways of creating an instance of a class (object)
// // Shape recta = new Shape();

// // recta.type = "Rectangle";
// // recta.color = "Blue";

// Shape recta = new Shape("rectangle", "blue");

// // Shape circ = new Shape()
// // {
// //     type= "circle",
// //     color = "red"
// // };

// Shape circ = new Shape("circle", "red");



Car ferrari = new Car();
ferrari.make = "ferrari";
ferrari.model = "sf25";
ferrari.year = 2025;
ferrari.NumberOfDoors = 4;

ferrari.StartEngine();
ferrari.Drive();
ferrari.StopEngine();

Motorcycle ducatti = new Motorcycle();
ducatti.make = "ducatti";
ducatti.model = "sf25";
ducatti.year = 2025;
ducatti.type = "racing";

ducatti.StartEngine();
ducatti.Ride();
ducatti.StopEngine();

Truck scania = new Truck();
scania.make = "scania";
scania.model = "sf25";
scania.year = 2025;
scania.loadCapacity = 4;

scania.StartEngine();
scania.LoadCargo();
scania.StopEngine();

