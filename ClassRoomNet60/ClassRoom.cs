namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        public string ClassName { get; set; } = "";
        public List<Student> Students { get; set; } = new List<Student>();
        public DateTime SemesterStart { get; set; }

      
        public void PrintHowMenyStudentsInSeason()
        {
            var seasonCount = from s in Students
            group s by s.SeasonOfBirth() into seasongroup
            select new { season = seasongroup.Key, amount = seasongroup.Count() };
            Console.WriteLine(String.Join(',', seasonCount.Select(s => $"{s.amount} in {s.season}")));
        }

        public override string ToString()
        {
            return $"{ClassName} started the {SemesterStart} and has the following students:" +
                $"\n\t{string.Join("\n\t", Students)}";
        }
    }
}
