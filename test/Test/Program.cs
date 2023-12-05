namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Job> persons = new List<Job> { 
                new Administrator("surname", "birthday"), 
                new Student("surname", "birthday", "faculty", "group"), 
                new Teacher("surname", "birthday", "faculty", "position", 1.5), 
                new Manager("surname", "birthday", "faculty", "position")
            };
            
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine($"{persons[0].position} wages {persons[0].calculateWages()}");
            Console.WriteLine($"{persons[1].position} wages {persons[1].calculateWages()}");
            Console.WriteLine($"{persons[2].position} wages {persons[2].calculateWages()}");
            Console.WriteLine($"{persons[3].position} wages {persons[3].calculateWages()}");
        }
    }
    interface IEmployee
    {
        public double calculateWages();
    }

    abstract class Person
    {
        public string surname { get; protected set; }
        public string birthday { get; protected set; }
        public Person(string surname, string birthday)
        {
            this.surname = surname;
            this.birthday = birthday;
        }
        public abstract override string ToString();
    }

    abstract class Job : Person, IEmployee
    {
        public string position { get; protected set; }
        public string placeOfWork { get; protected set; }
        public double experience { get; protected set; }
        protected double baseRate { get; set; }
        public Job(string surname, string birthday) : base(surname, birthday) {}
        public double calculateWages()
        {
            return baseRate * experience;
        }
    }

    class Administrator : Job
    {
        public Administrator(string surname, string birthday) : base(surname, birthday)
        {
            this.position = "Administrator";
            this.placeOfWork = "laboratory";
            this.experience = 1.0;
            this.baseRate = 100;
        }
        public override string ToString()
        {
            return $"surname : {surname}, birthday: {birthday}, place of work: {placeOfWork}\n";
        }
    }

    class Student : Job
    {
        public string faculty;
        public string group;
        public Student(string surname, string birthday, string faculty, string group) : base(surname, birthday)
        {
            this.position = "Student";
            this.placeOfWork = "faculty";
            this.faculty = faculty;
            this.group = group;
            this.experience = 0;
            this.baseRate = 0;
        }
        public override string ToString()
        {
            return $"surname: {surname}, birthday: {birthday}, faculty: {faculty}, group: {group}\n";
        }
    }

    class Teacher : Job
    {
        public string faculty;
        public Teacher(string surname, string birthday, string faculty, string position, double experience) : base(surname, birthday)
        {
            this.position = position;
            this.placeOfWork = "faculty";
            this.faculty = faculty;
            this.experience = experience;
            this.baseRate = 100;
        }
        public override string ToString()
        {
            return $"surname : {surname}, birthday: {birthday}, faculty: {faculty}, position: {position}, experience: {experience}\n";
        }
    }

    class Manager : Job
    {
        public string faculty;
        public Manager(string surname, string birthday, string faculty, string position) : base(surname, birthday)
        {
            this.position = position;
            this.placeOfWork = "faculty";
            this.faculty = faculty;
            this.experience = 1.0;
            this.baseRate = 100;
        }
        public override string ToString()
        {
            return $"surname : {surname}, birthday: {birthday}, faculty: {faculty}, position: {position}\n";
        }
    }
}