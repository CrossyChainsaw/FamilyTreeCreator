using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StamboomTest2.Classes
{
    public class UsefullStaticMethods
    {
        public static string ExtractLastName(ComboBox c)
        {
            if (c.SelectedItem != null)
            {
                return c.SelectedItem.ToString();
            }
            else
            {
                return c.Text;
            }
        }
        public static string ExtractGender(ComboBox c)
        {
            if (c.Text == "")
            {
                return "?";
            }
            else if (c.SelectedItem == null)
            {
                return "?";
            }
            else
            {
                return c.SelectedItem.ToString();
            }
        }

        public static string? ExtractSpouse(ComboBox c)
        {
            if (c.Text == "?")
            {
                return "?";
            }
            else if (c.SelectedItem != null)
            {
                Person spouse = (Person)c.SelectedItem;
                return spouse.ID;
            }
            else
            {
                return null;
            }
        }

        public static string ExtractParent(ComboBox c)
        {
            if (c.SelectedItem != null)
            {
                Person mother = (Person)c.SelectedItem;
                return mother.ID;
            }
            else
            {
                return "?";
            }
        }
    }
}
