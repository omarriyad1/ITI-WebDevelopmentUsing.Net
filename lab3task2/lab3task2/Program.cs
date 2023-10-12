class PersonClass
    {
        public string Name { get; set; }
    }

    struct PersonStruct
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Example with a class
            PersonClass personClass = new PersonClass();
            personClass.Name = "John";
            PersonClass modifiedPersonClass = ModifyClass(personClass);
            Console.WriteLine($"Original Class: {personClass.Name}"); // Output:Mary
            Console.WriteLine($"Modified Class: {modifiedPersonClass.Name}"); // Output:Mary

            Console.WriteLine();

            // Example with a struct
            PersonStruct personStruct = new PersonStruct();
            personStruct.Name = "John";
            PersonStruct modifiedPersonStruct = ModifyStruct(personStruct);
            Console.WriteLine($"Original Struct: {personStruct.Name}"); // Output:John
            Console.WriteLine($"Modified Struct: {modifiedPersonStruct.Name}"); // Output:Mary
        }

        static PersonClass ModifyClass(PersonClass person)
        {
            person.Name = "Mary";
            return person;
        }

        static PersonStruct ModifyStruct(PersonStruct person)
        {
            person.Name = "Mary";
            return person;
        }
    }
