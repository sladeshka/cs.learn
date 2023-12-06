namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Job> persons = new List<Job> { 
                new Administrator("surname", "birthday"), 
                new Student("surname", "birthday", "faculty", "group", Grants.Excellent),
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
        #region Fields
        public string surname { get; protected set; }
        public string birthday { get; protected set; }
        #endregion

        #region Constructors
        public Person(string surname, string birthday)
        {
            this.surname = surname;
            this.birthday = birthday;
        }
        #endregion

        #region Methods
        public abstract override string ToString();
        #endregion
    }

    abstract class Job : Person, IEmployee
    {
        #region Fields
        public string position { get; protected set; }
        public string placeOfWork { get; protected set; }
        public double experience { get; protected set; }
        protected double baseRate { get; set; }
        #endregion

        #region Constructors
        public Job(string surname, string birthday) : base(surname, birthday) {}
        #endregion

        #region Methods
        public double calculateWages()
        {
            return baseRate * experience;
        }
        #endregion
    }

    class Administrator : Job
    {
        #region Constructors
        public Administrator(string surname, string birthday) : base(surname, birthday)
        {
            this.position = "Administrator";
            this.placeOfWork = "laboratory";
            this.experience = 1.0;
            this.baseRate = 100;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"surname : {surname}, birthday: {birthday}, place of work: {placeOfWork}\n";
        }
        #endregion
    }

    class Student : Job
    {
        #region Fields
        public string faculty;
        public string group;
        #endregion

        #region Constructors
        public Student(string surname, string birthday, string faculty, string group, Grants grant) : base(surname, birthday)
        {
            this.position = "Student";
            this.placeOfWork = "faculty";
            this.faculty = faculty;
            this.group = group;
            this.experience = (double)grant;
            this.baseRate = 10;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"surname: {surname}, birthday: {birthday}, faculty: {faculty}, group: {group}\n";
        }
        #endregion
    }

    class Teacher : Job
    {
        #region Fields
        public string faculty;
        #endregion

        #region Constructors
        public Teacher(string surname, string birthday, string faculty, string position, double experience) : base(surname, birthday)
        {
            this.position = position;
            this.placeOfWork = "faculty";
            this.faculty = faculty;
            this.experience = experience;
            this.baseRate = 100;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"surname : {surname}, birthday: {birthday}, faculty: {faculty}, position: {position}, experience: {experience}\n";
        }
        #endregion
    }

    class Manager : Job
    {
        #region Fields
        public string faculty;
        #endregion

        #region Constructors
        public Manager(string surname, string birthday, string faculty, string position) : base(surname, birthday)
        {
            this.position = position;
            this.placeOfWork = "faculty";
            this.faculty = faculty;
            this.experience = 1.0;
            this.baseRate = 100;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"surname : {surname}, birthday: {birthday}, faculty: {faculty}, position: {position}\n";
        }
        #endregion
    }

    enum Grants
    {
        Not,
        Good,
        Excellent,
    }
}