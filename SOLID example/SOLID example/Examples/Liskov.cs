using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SOLID_example.Examples
{
    public class Liskov
    {

        void Start()
        {
            List<string> namesList = new List<string>();
            //adding
            namesList.Add("Bob");
            namesList.Add("Brad");
            //removing
            namesList.Remove("Bob");
            //etc
            namesList.Clear();

            #region Example
            
            ReadOnlyCollection<string> namesReadOnlyCollection = new ReadOnlyCollection<string>(namesList);
            namesReadOnlyCollection.Add("Bob");
            namesReadOnlyCollection.Remove("Brad");

            namesReadOnlyCollection.MethodThatDoesNotExist();

            #endregion

        }


    }
}
