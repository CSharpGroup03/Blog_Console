using System;
using System.Collections.Generic;

namespace SocialNetwork
{
    public class SelectOption : Post
    {
        public IList<KeyValuePair<int, string>> Valores = new List<KeyValuePair<int, string>>();

        public SelectOption()
        {
            Valores.Add(new KeyValuePair<int, string>(0, "Exit"));
            Valores.Add(new KeyValuePair<int, string>(1, "Post"));
            Valores.Add(new KeyValuePair<int, string>(2, "Comment"));
        }

        public void SetFunction(int number)
        {
            switch (number)
            {
                case 0: Console.ReadKey();
                    break;
                case 1:
                    {
                        
                    } 
                    break;
                case 2: //comment
                    break;
            }

        }

    }
}
