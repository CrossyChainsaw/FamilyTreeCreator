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
        Person currentPerson = null;
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
            CB_Spouse.Text = p.GetSpouse();
            CB_Father.Text = p.GetFather();
            CB_Mother.Text = p.GetMother();
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            // First Name 
            string firstName = TB_FirstName.Text;
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

            currentPerson.FirstName = firstName;
            currentPerson.LastName = lastName;
            currentPerson.Gender = gender;
            currentPerson.BirthYear = TB_YearOfBirth.Text;
            currentPerson.DeathYear = TB_DeathYear.Text;
            currentPerson.SpouseID = spouseID;
            currentPerson.FatherID = fatherID;
            currentPerson.MotherID = motherID;
            Person.EditPerson(currentPerson);
            MessageBox.Show("Edited: " + firstName + " " + lastName);
        }
    }
}
