using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StamboomTest2.Classes
{
    internal class Person
    {

        public string? ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? BirthYear { get; set; }
        public string? DeathYear { get; set; }
        public string? ExSpouseID { get; set; }
        public string? SpouseID { get; set; }
        public string? FatherID { get; set; }
        public string? MotherID { get; set; }
        public Person(string id, string firstName, string lastName, string gender, string? birthYear = null, string? deathYear = null, string? exSpouseID = null, string? spouseID = null, string? fatherID = null, string? motherID = null)
        {
            ID = id; // get highest id and do +1 // of pak persons.count = id
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            BirthYear = birthYear;
            DeathYear = deathYear;
            ExSpouseID = exSpouseID;
            SpouseID = spouseID;
            FatherID = fatherID;
            MotherID = motherID;
        }
        public string GetLifeSpan()
        {
            // DeathYear
            if (DeathYear == "-1")
            {
                DeathYear = "";
            }
            else if (DeathYear == null)
            {
                DeathYear = "?";
            }
            // BirthYear
            if (BirthYear == null)
            {
                BirthYear = "?";
            }
            return BirthYear + " - " + DeathYear;
        }
        internal string GetExSpouse()
        {
            string TB_Text;
            Person exSpouse = FindPersonByID(ExSpouseID);
            if (ExSpouseID == "?")
            {
                TB_Text = "?";
            }
            else if (exSpouse != null)
            {
                TB_Text = exSpouse.ToString();
            }
            else
            {
                TB_Text = "";
            }
            return TB_Text;
        }
        public string GetSpouse()
        {
            string TB_Text;
            Person spouse = FindPersonByID(SpouseID);
            if (SpouseID == "?")
            {
                TB_Text = "?";
            }
            else if (spouse != null)
            {
                TB_Text = spouse.ToString();
            }
            else
            {
                TB_Text = "None";
            }
            return TB_Text;
        }
        public string GetFather()
        {
            string TB_Text;
            Person father = FindPersonByID(FatherID);
            if (father != null)
            {
                TB_Text = father.ToString();
            }
            else
            {
                TB_Text = "?";
            }
            return TB_Text;
        }
        public string GetPaternalGrandfather()
        {
            // get your father id, check your fathers father id ez
            Person father = FindPersonByID(this.FatherID);
            if (father == null)
            {
                return "?";
            }
            Person grandFather = FindPersonByID(father.FatherID);
            if (grandFather != null)
            {
                return grandFather.ToString();
            }
            else{
                return "?";
            }
        }
        public string GetPaternalGrandmother()
        {
            // get your father id, check your fathers father id ez
            Person father = FindPersonByID(this.FatherID);
            if (father == null)
            {
                return "?";
            }
            Person grandmother = FindPersonByID(father.MotherID);
            if (grandmother != null)
            {
                return grandmother.ToString();
            }
            else
            {
                return "?";
            }
        }
        public string GetMaternalGrandmother()
        {
            // get your father id, check your fathers father id ez
            Person mother = FindPersonByID(this.MotherID);
            if (mother == null)
            {
                return "?";
            }
            Person grandMother = FindPersonByID(mother.MotherID);
            if (grandMother != null)
            {
                return grandMother.ToString();
            }
            else
            {
                return "?";
            }
        }
        public string GetMaternalGrandfather()
        {
            // get your father id, check your fathers father id ez
            Person mother = FindPersonByID(this.MotherID);
            if (mother == null)
            {
                return "?";
            }
            Person grandFather = FindPersonByID(mother.FatherID);
            if (grandFather != null)
            {
                return grandFather.ToString();
            }
            else
            {
                return "?";
            }
        }
        public string GetMother()
        {
            string TB_Text;
            Person mother = FindPersonByID(MotherID);
            if (mother != null)
            {
                TB_Text = mother.ToString();
            }
            else
            {
                TB_Text = "?";
            }
            return TB_Text;
        }
        public string GetChildren()
        {
            List<Person> personList = Person.LoadAllPersons();
            List<Person> children = new List<Person>();
            foreach (Person person in personList)
            {
                if (person.FatherID == this.ID && person.MotherID == this.SpouseID)
                {
                    children.Add(person);
                }
                else if (person.MotherID == this.ID && person.FatherID == this.SpouseID)
                {
                    children.Add(person);
                }
            }

            string TB_Children = "";
            foreach (Person child in children)
            {
                TB_Children += child.ToString();
                TB_Children += "\n";
            }
            return TB_Children;
        }
        public string GetExChildren()
        {
            List<Person> personList = Person.LoadAllPersons();
            List<Person> children = new List<Person>();
            foreach (Person person in personList)
            {
                if (person.FatherID == this.ID && person.MotherID == this.ExSpouseID)
                {
                    children.Add(person);
                }
                else if (person.MotherID == this.ID && person.FatherID == this.ExSpouseID)
                {
                    children.Add(person);
                }
            }

            string TB_Children = "";
            foreach (Person child in children)
            {
                TB_Children += child.ToString();
                TB_Children += "\n";
            }
            return TB_Children;
        }
        public string GetSiblings()
        {
            // if its parent id is ? it should inst return nothing
            List<Person> siblings = new List<Person>();
            List<Person> personList = Person.LoadAllPersons();
            foreach (Person person in personList)
            {
                if((FatherID == "?" | FatherID == null) && (MotherID == "?" | MotherID == null))
                {
                    return "";
                }
                if (person.FatherID == this.FatherID && person.MotherID == this.MotherID)
                {
                    siblings.Add(person);
                }
            }

            string TB_Siblings = "";
            foreach (Person sib in siblings)
            {
                TB_Siblings += sib.ToString();
                TB_Siblings += "\n";
            }
            return TB_Siblings;
        }
        public string GetHalfSiblings()
        {
            List<Person> siblings = new List<Person>();
            List<Person> personList = Person.LoadAllPersons();
            foreach (Person person in personList)
            {
                if ((FatherID == "?" | FatherID == null) && (MotherID == "?" | MotherID == null))
                {
                    return "";
                }
                if (person.FatherID == this.FatherID ^ person.MotherID == this.MotherID)
                {
                    siblings.Add(person);
                }
            }

            string TB_Siblings = "";
            foreach (Person sib in siblings)
            {
                TB_Siblings += sib.ToString();
                TB_Siblings += "\n";
            }
            return TB_Siblings;
        }
        public override string ToString()
        {
            if (FirstName == "?" && LastName == "?")
            {
                Person spouse = Person.FindPersonByID(SpouseID);
                return FirstName + " (Spouse of " + spouse.FirstName + ")";
            }
            if (LastName == "-1")
            {
                return FirstName;
            }
            if (LastName == null)
            {
                LastName = "?";
            }
            return FirstName + " " + LastName;
        }
        public static void EditPerson(Person p)
        {
            List<Person> personList = Person.LoadAllPersons();

            //int id = 0;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].ID == p.ID)
                {
                    personList[i] = p;
                    //id = i;
                    break;
                }
            }
            FamilyTreeDataObject f = new FamilyTreeDataObject(personList);
            var jsonString = JsonConvert.SerializeObject(f);
            File.WriteAllText("../../../Data/Persons.json", jsonString);
        }
        public static void CreatePerson(Person p)
        {
            List<Person> personList = LoadAllPersons();
            personList.Add(p);
            FamilyTreeDataObject f = new FamilyTreeDataObject(personList);
            var jsonString = JsonConvert.SerializeObject(f);
            File.WriteAllText("../../../Data/Persons.json", jsonString);
        }
        public static string GetNextFreeID()
        {
            // get id of the last person
            List<Person> personList = Person.LoadAllPersons();
            Person lastPerson = personList.Last();
            return (Convert.ToInt32(lastPerson.ID) + 1).ToString();
        }
        public static List<Person> LoadAllPersons()
        {
            List<Person> personList = new List<Person>();
            using (StreamReader s = new StreamReader("../../../Data/Persons.json"))
            {
                string jsonData = s.ReadToEnd();
                JObject jsonObject = JsonConvert.DeserializeObject<JObject>(jsonData);
                var allPersons = jsonObject["Persons"];
                foreach (var person in allPersons)
                {
                    Person p = new Person((string)person["ID"], (string)person["FirstName"], (string)person["LastName"], (string)person["Gender"], (string)person["BirthYear"], (string)person["DeathYear"], (string)person["ExSpouseID"], (string)person["SpouseID"], (string)person["FatherID"], (string)person["MotherID"]);
                    personList.Add(p);
                }
            }
            return personList;
        }
        public static Person FindPersonByID(string id)
        {
            List<Person> personList = LoadAllPersons();
            foreach (Person person in personList)
            {
                if (person.ID == id)
                {
                    return person;
                }
            }
            return null;
        }
    }
}

// s - 015F
// S - 015E
// g - 011F
// G - 011E
// c - 00E7
// C - 00C7
// i - 0131
// I - 0049
