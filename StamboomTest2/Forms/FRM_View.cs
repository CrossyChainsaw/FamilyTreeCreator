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
    public partial class FRM_View : Form
    {
        public FRM_View()
        {
            InitializeComponent();
        }

        void FRM_View_Load(object sender, EventArgs e)
        {
            List<Person> persons = Person.LoadAllPersons();
            CB_Persons.DataSource = persons;
        }

        void CB_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person p = (Person)CB_Persons.SelectedItem;
            // Gender 
            TB_Gender.Text = p.Gender;
            // LifeSpan
            TB_LifeSpan.Text = p.GetLifeSpan();
            // Ex-Spouse
            TB_ExSpouse.Text = p.GetExSpouse();
            // Spouse
            TB_Spouse.Text = p.GetSpouse();
            // Father
            TB_Father.Text = p.GetFather();
            // Mother
            TB_Mother.Text = p.GetMother();
        }
    }
}
// List<SomeType> s = new List<SomeType> { new SomeType { value = "5", text = "five" },...};