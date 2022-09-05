namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {

        }

        public override string ToString()
        {
            return $"{ClassName} started the {SemesterStart} and has the following students:" +
                $"\n\t{string.Join("\n\t", Students)}";
        }
    }
}
