using System;
using System.Collections.Generic;

namespace Client.Data
{
    public class DataBaseService
    {
        public event Action OnChange;
      
        public List<Person> persons = new List<Person>() {
            { 
                new Person() {
                    Date = DateTime.Now,
                    FirstName = "Andrii",
                    SecondName = "Kurdiumov",
                    Age = 17
                }
            }
        };

        public void AddPerson(Person person) {
            persons.Add(person);
            OnChange?.Invoke();
        }
    }
}