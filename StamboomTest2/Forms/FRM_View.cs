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
            TB_Gender.Text = p.Gender;
            TB_LifeSpan.Text = p.GetLifeSpan();
            TB_ExSpouse.Text = p.GetExSpouse();
            TB_Spouse.Text = p.GetSpouse();
            TB_Father.Text = p.GetFather();
            TB_Mother.Text = p.GetMother();
            TB_Person.Text = p.ToString();
            RTB_Children.Text = p.GetChildren();
            RTB_ExChildren.Text = p.GetExChildren();
            RTB_Siblings.Text = p.GetSiblings();
            RTB_HalfSiblings.Text = p.GetHalfSiblings();
            TB_PaternalGrandfather.Text = p.GetPaternalGrandfather();
            TB_PaternalGrandmother.Text = p.GetPaternalGrandmother();
            TB_MaternalGrandfather.Text = p.GetMaternalGrandfather();
            TB_MaternalGrandmother.Text = p.GetMaternalGrandmother();
        }
    }
}
// List<SomeType> s = new List<SomeType> { new SomeType { value = "5", text = "five" },...};