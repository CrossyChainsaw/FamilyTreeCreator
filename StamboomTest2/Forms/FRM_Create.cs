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
            string nextFreeID = Person.GetNextFreeID();
            string firstName = CB_FirstName.Text;
            string lastName = UsefullStaticMethods.ExtractLastName(CB_LastName);
            string gender = UsefullStaticMethods.ExtractGender(CB_Gender);
            string birthYear = UsefullStaticMethods.ExtractBirthYear(TB_BirthYear);
            string ExSpouseID = UsefullStaticMethods.ExtractSpouse(CB_ExSpouse);
            string spouseID = UsefullStaticMethods.ExtractSpouse(CB_Spouse);
            string fatherID = UsefullStaticMethods.ExtractParent(CB_Father);
            string motherID = UsefullStaticMethods.ExtractParent(CB_Mother);

            Person p = new Person(nextFreeID, firstName, lastName, gender, birthYear, TB_DeathYear.Text, ExSpouseID, spouseID, fatherID, motherID);
            Person.CreatePerson(p);
            MessageBox.Show("Created: " + p.ToString());
            RefreshDataInControls();
        }
        private void FRM_Create_Load(object sender, EventArgs e)
        {
            EmptyAllControls();
            RefreshDataInControls();
        }

        void EmptyAllControls()
        {
            foreach (var item in this.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox g = (GroupBox)item;
                    foreach (var gc in g.Controls)
                    {
                        if (gc is ComboBox)
                        {
                            ComboBox c = (ComboBox)gc;
                            c.Text = "";
                            c.SelectedItem = null;
                        }
                        if (gc is TextBox)
                        {
                            TextBox c = (TextBox)gc;
                            c.Text = "";
                        }
                    }
                }
            }
        }

        void RefreshDataInControls()
        {
            // Refresh after button click
            // Load in all FirstNames and LastNames (since the sames names are tend to be used a lot)
            List<Person> personList = Person.LoadAllPersons();
            foreach (Person person in personList)
            {
                CB_FirstName.Items.Add(person.FirstName);
                CB_P1_FirstName.Items.Add(person.FirstName);
                CB_P2_FirstName.Items.Add(person.FirstName);
            }
            foreach (Person person in personList)
            {
                CB_LastName.Items.Add(person.LastName);
                CB_P1_LastName.Items.Add(person.LastName);
                CB_P2_LastName.Items.Add(person.LastName);
            }
            // Genders
            foreach (var item in Enum.GetValues(typeof(Genders)))
            {
                CB_Gender.Items.Add(item);
                CB_P1_Gender.Items.Add(item);
                CB_P2_Gender.Items.Add(item);
            }
            // Ex-Spouse, Spouse, Father, Mother
            foreach (Person person in personList)
            {
                CB_ExSpouse.Items.Add(person);
                CB_Spouse.Items.Add(person);
                CB_Father.Items.Add(person);
                CB_Mother.Items.Add(person); // also loads in males !!!
                CB_P1_ExSpouse.Items.Add(person);
                CB_P1_Father.Items.Add(person);
                CB_P1_Mother.Items.Add(person); // also loads in males !!!
                CB_P1_ExSpouse.Items.Add(person);
                CB_P2_Father.Items.Add(person);
                CB_P2_Mother.Items.Add(person); // also loads in males !!!
            }
        }

        private void BTN_CreateCouple_Click(object sender, EventArgs e)
        {
            string firstPersonID = Person.GetNextFreeID();
            string secondPersonID = (Convert.ToInt32(firstPersonID) + 1).ToString();

            // P1
            string firstName = CB_P1_FirstName.Text;
            string lastName = UsefullStaticMethods.ExtractLastName(CB_P1_LastName);
            string gender = UsefullStaticMethods.ExtractGender(CB_P1_Gender);
            string birthYear = UsefullStaticMethods.ExtractBirthYear(TB_P1_BirthYear);
            string deathYear = TB_P1_DeathYear.Text;
            string exSpouseID = UsefullStaticMethods.ExtractSpouse(CB_P1_ExSpouse);
            string fatherID = UsefullStaticMethods.ExtractParent(CB_P1_Father);
            string motherID = UsefullStaticMethods.ExtractParent(CB_P1_Mother);

            Person p = new Person(firstPersonID, firstName, lastName, gender, birthYear, deathYear, exSpouseID, secondPersonID, fatherID, motherID);
            Person.CreatePerson(p);

            // P2
            string firstName2 = CB_P2_FirstName.Text;
            string lastName2 = UsefullStaticMethods.ExtractLastName(CB_P2_LastName);
            string gender2 = UsefullStaticMethods.ExtractGender(CB_P2_Gender);
            string birthYear2 = UsefullStaticMethods.ExtractBirthYear(TB_P2_BirthYear);
            string deathYear2 = TB_P2_DeathYear.Text;
            string exSpouseID2 = UsefullStaticMethods.ExtractSpouse(CB_P2_ExSpouse);
            string fatherID2 = UsefullStaticMethods.ExtractParent(CB_P2_Father);
            string motherID2 = UsefullStaticMethods.ExtractParent(CB_P2_Mother);

            Person p2 = new Person(secondPersonID, firstName2, lastName2, gender2, birthYear2, deathYear2, exSpouseID2, firstPersonID, fatherID2, motherID2);
            Person.CreatePerson(p2);


            MessageBox.Show("Created Couple: " + p.ToString() + " & " + p2.ToString());
            RefreshDataInControls();
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            EmptyAllControls();
            RefreshDataInControls();
        }
    }
}