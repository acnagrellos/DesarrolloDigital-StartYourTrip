namespace ClasesObjetos
{
    public class Persona
    {
        public static int MAX_AGE = 18;

        private int _age;

        public Persona(string name, string surname, int age)
        {
            this._age = age;
            this.Name = name;
            this.Surname = surname;
            this.Money = 0;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public decimal Money { get; set; }

        public string GetCompleteName() 
        {
            return $"{this.Name} {this.Surname}";
        }

        public string GetAgeMessage() => $"La edad de {this.GetCompleteName()} es {this._age}";

        public void AddMoney(decimal amount) 
        {
            this.Money += amount;
        }
    }
}
