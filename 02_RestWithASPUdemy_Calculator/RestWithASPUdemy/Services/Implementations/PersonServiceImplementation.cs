using RestWithASPUdemy.Model;

namespace RestWithASPUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 9; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;

        }

        public Person FindById(long id)
        {
            return new Person 
            {
                Id = IncrementAndGet(),
                FirstName = "Flavio",
                LastName = "Cruz",
                Address = "Ilhavo - Aveiro - Portugal",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName",
                Address = "some Address",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
