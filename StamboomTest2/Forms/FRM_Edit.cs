using Newtonsoft.Json;
using StamboomTest2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StamboomTest2.Forms
{
    public partial class FRM_Edit : Form
    {
        Person currentPerson;
        public FRM_Edit()
        {
            InitializeComponent();
        }

        private void FRM_Edit_Load(object sender, EventArgs e)
        {
            // Genders
            foreach (var item in Enum.GetValues(typeof(Genders)))
            {
                CB_Gender.Items.Add(item);
            }
            List<Person> personList = Person.LoadAllPersons();
            foreach (Person p in personList)
            {
                CB_Edit.Items.Add(p);
                CB_ExSpouse.Items.Add(p);
                CB_Spouse.Items.Add(p);
                CB_Father.Items.Add(p);
                CB_Mother.Items.Add(p);
            }
        }

        private void CB_Edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load in person data
            Person p = (Person)CB_Edit.SelectedItem;
            currentPerson = p;
            TB_FirstName.Text = p.FirstName;
            CB_LastName.Text = p.LastName;
            CB_Gender.Text = p.Gender;
            TB_YearOfBirth.Text = p.BirthYear;
            TB_DeathYear.Text = p.DeathYear;
            CB_ExSpouse.Text = p.GetExSpouse();
            CB_Spouse.Text = p.GetSpouse();
            CB_Father.Text = p.GetFather();
            CB_Mother.Text = p.GetMother();
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            string firstName = TB_FirstName.Text;
            string lastName = UsefullStaticMethods.ExtractLastName(CB_LastName);
            string gender = UsefullStaticMethods.ExtractGender(CB_Gender);
            string ExSpouseID = UsefullStaticMethods.ExtractSpouse(CB_ExSpouse);
            string spouseID = UsefullStaticMethods.ExtractSpouse(CB_Spouse);
            string fatherID = UsefullStaticMethods.ExtractParent(CB_Father);
            string motherID = UsefullStaticMethods.ExtractParent(CB_Mother);

            currentPerson.FirstName = firstName;
            currentPerson.LastName = lastName;
            currentPerson.Gender = gender;
            currentPerson.BirthYear = TB_YearOfBirth.Text;
            currentPerson.DeathYear = TB_DeathYear.Text;
            currentPerson.ExSpouseID = ExSpouseID;
            currentPerson.SpouseID = spouseID;
            currentPerson.FatherID = fatherID;
            currentPerson.MotherID = motherID;

            Person.EditPerson(currentPerson);
            MessageBox.Show("Edited: " + currentPerson.ToString());
        }
    }
}
