using StamboomTest2.Classes;

namespace StamboomTest2
{
    public partial class FRM_Create : Form
    {
        public FRM_Create()
        {
            InitializeComponent();
        }

        private void BTN_Done_Click(object sender, EventArgs e)
        {
            // ID
            int nextFreeID = Person.GetNextFreeID();
            // First Name 
            string firstName = CB_FirstName.Text;
            // Last Name
            string lastName;
            if (CB_LastName.SelectedItem != null)
            {
                lastName = CB_LastName.SelectedItem.ToString();
            }
            else
            {
                lastName = CB_LastName.Text;
            }
            // Gender
            string gender;
            if (CB_Gender.Text == "")
            {
                gender = "?";
            }
            else if (CB_Gender.SelectedItem == null)
            {
                MessageBox.Show("Gender has not been filled in correctly");
                return;
            }
            else
            {
                gender = CB_Gender.SelectedItem.ToString();
            }
            // Spouse
            string spouseID;
            if (CB_Spouse.SelectedItem != null)
            {
                Person spouse = (Person)CB_Spouse.SelectedItem;
                spouseID = spouse.ID;
            }
            else
            {
                spouseID = null;
            }
            // Father
            string fatherID;
            if (CB_Father.SelectedItem != null)
            {
                Person father = (Person)CB_Father.SelectedItem;
                fatherID = father.ID;
            }
            else
            {
                fatherID = null;
            }
            // Mother
            string motherID;
            if (CB_Mother.SelectedItem != null)
            {
                Person mother = (Person)CB_Mother.SelectedItem;
                motherID = mother.ID;
            }
            else
            {
                motherID = null;
            }
            Person p = new Person(nextFreeID.ToString(), firstName, lastName, gender, TB_YearOfBirth.Text, TB_DeathYear.Text, spouseID, fatherID, motherID);
            Person.CreatePerson(p);
            MessageBox.Show("Created: " + p.ToString());
        }
        private void FRM_Create_Load(object sender, EventArgs e)
        {
            // Common LastNames
            List<Person> personList = Person.LoadAllPersons();
            foreach (Person person in personList)
            {
                CB_FirstName.Items.Add(person.FirstName);
            }
            foreach (Person person in personList)
            {
                CB_LastName.Items.Add(person.LastName);
            }
            // Genders
            foreach (var item in Enum.GetValues(typeof(Genders)))
            {
                CB_Gender.Items.Add(item);
            }
            // Spouse, Father, Mother
            foreach (Person person in personList)
            {
                CB_Spouse.Items.Add(person);
                CB_Father.Items.Add(person);
                CB_Mother.Items.Add(person); // also loads in males !!!
            }
        }
    }
}