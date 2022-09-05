using ClassRoomNet60;

Random random = new Random();

ClassRoom @class = new ClassRoom();

@class.ClassName = "Zealand-3B-2022E";
@class.SemesterStart = new DateTime(2022, 9, 1);

@class.Students.Add(new Student("Hannibal", random.Next(1, 12), random.Next(1, 31)));
@class.Students.Add(new Student("Patrik", random.Next(1, 12), random.Next(1, 31)));
@class.Students.Add(new Student("Mikkel", random.Next(1, 12), random.Next(1, 31)));
@class.Students.Add(new Student("Emil", random.Next(1, 12), random.Next(1, 31)));
