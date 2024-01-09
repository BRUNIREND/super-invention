namespace ModelStud
{
    public class Student: IDomainObject
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public int ID { get; set; }
        public string Group { get; set; }
        public Student() { }
        
        /// <summary>
        /// Конструктор студента.
        /// </summary>
        /// 
        public Student(string name, string spec, string group)
        {
            Name = name;
            Speciality = spec;
            Group = group;
        }
    }
}