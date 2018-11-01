using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braille___NLP
{
    class Braille
    {

        char character;

        string value;

        //To Be Able Not To Generate Characters Again
        static int N_G = 0;

        public static List<Braille> Characters_Set = new List<Braille>();

        public char Character
        {
            get
            {
                return character;
            }

            set
            {
                character = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Braille(char Character, string Value)
        {
            this.character = Character;
            this.value = Value;
        }

        //Generator
        private void Generate()
        {
            //Basic Letters Generated
            Characters_Set.Add(new Braille('a', "1"));
            Characters_Set.Add(new Braille('b', "13"));
            Characters_Set.Add(new Braille('c', "12"));
            Characters_Set.Add(new Braille('d', "124"));
            Characters_Set.Add(new Braille('e', "14"));
            Characters_Set.Add(new Braille('f', "123"));
            Characters_Set.Add(new Braille('g', "1234"));
            Characters_Set.Add(new Braille('h', "134"));
            Characters_Set.Add(new Braille('i', "23"));
            Characters_Set.Add(new Braille('j', "234"));
            Characters_Set.Add(new Braille('k', "15"));
            Characters_Set.Add(new Braille('l', "135"));
            Characters_Set.Add(new Braille('m', "125"));
            Characters_Set.Add(new Braille('n', "1245"));
            Characters_Set.Add(new Braille('o', "145"));
            Characters_Set.Add(new Braille('p', "1235"));
            Characters_Set.Add(new Braille('q', "12345"));
            Characters_Set.Add(new Braille('r', "1345"));
            Characters_Set.Add(new Braille('s', "235"));
            Characters_Set.Add(new Braille('t', "2345"));
            Characters_Set.Add(new Braille('u', "156"));
            Characters_Set.Add(new Braille('v', "1356"));
            Characters_Set.Add(new Braille('w', "2346"));
            Characters_Set.Add(new Braille('x', "1256"));
            Characters_Set.Add(new Braille('y', "12456"));
            Characters_Set.Add(new Braille('z', "1456"));

            //Basic Numbers Generated
            Characters_Set.Add(new Braille('1', "1"));
            Characters_Set.Add(new Braille('2', "13"));
            Characters_Set.Add(new Braille('3', "12"));
            Characters_Set.Add(new Braille('4', "124"));
            Characters_Set.Add(new Braille('5', "14"));
            Characters_Set.Add(new Braille('6', "123"));
            Characters_Set.Add(new Braille('7', "1234"));
            Characters_Set.Add(new Braille('8', "134"));
            Characters_Set.Add(new Braille('9', "23"));
            Characters_Set.Add(new Braille('0', "234"));

            //Basic Marks Generated
            Characters_Set.Add(new Braille('.', "346"));
            Characters_Set.Add(new Braille(',', "3"));
            Characters_Set.Add(new Braille(';', "35"));
            Characters_Set.Add(new Braille(':', "34"));
            Characters_Set.Add(new Braille('!', "345"));
            Characters_Set.Add(new Braille('(', "3456"));
            Characters_Set.Add(new Braille(')', "3456"));
            Characters_Set.Add(new Braille('?', "356"));
            Characters_Set.Add(new Braille('"', "456"));
            Characters_Set.Add(new Braille('*', "45")); //Special Case Double
            Characters_Set.Add(new Braille('-', "56"));
            Characters_Set.Add(new Braille('\'', "5")); 
        }

        public Braille()
        {
            if (N_G == 0)
            {
                Generate();
                N_G += 1;
            }
        }

        //Language Understanding
        public static List<Braille> Understanding(string Text)
        {
            //Prepare Data Structure
            Braille B = new Braille();
            List<Braille> Content = new List<Braille>();
            List<char[]> Total_Character = new List<char[]>();

            //Split Total Text Into Words
            string[] Words = Text.Split(' ');

            //Count Words
            foreach (var item in Words)
            {
                Total_Character.Add(item.ToCharArray());
            }

            //Check Each Single Word
            for (int i = 0; i < Total_Character.Count; i++)
            {
                char[] Letters = Total_Character[i];
                int Number_Of_Uppers = 0;
                bool Upper_Case = false;
                int N_Uppers = 0;
                int Zero_Time = 0;

                //Search If All Uppers ()
                foreach (var item in Letters)
                {
                    if (item.ToString() == item.ToString().ToUpper())
                    {
                        N_Uppers += 1;
                    }
                }

                //If All Upper
                if (N_Uppers == Letters.Length)
                {
                    Upper_Case = true;
                }

                //Search For Availablity
                foreach (var letter in Letters)
                {
                    foreach (var Character in Characters_Set)
                    {
                        string Up = Character.character.ToString().ToUpper();
                        Braille Upper = new Braille('U', "6");
                        
                        //Case Character Not Declared Or Not Found []
                        Braille Not_Found = new Braille('N', "123456");

                        //Basic Case For Digit
                        if (Char.IsDigit(Character.character) && letter == Character.character)
                        {
                            Braille Digit = new Braille('U', "2456");
                            Content.Add(Digit);
                            Content.Add(Character);
                            break;
                        }

                        //Basic Case For Each Letter
                        if (letter == Character.character)
                        {
                            if (letter == '*')
                            {
                                Content.Add(Character);
                            }
                            Content.Add(Character);
                            break;
                        }

                        //Case All Upper
                        if (letter.ToString() == Character.character.ToString().ToUpper() && Upper_Case == true && N_Uppers > 1)
                        {
                            if (Zero_Time == 0)
                            {
                                Content.Insert(Content.Count, Upper);
                                Content.Insert(Content.Count, Upper);
                                Content.Add(Character);
                                Zero_Time += 1;
                                break;
                            }
                            else
                            {
                                Content.Add(Character);
                                break;
                            }
                        }

                        //Case For Basic Upper
                        if (letter.ToString() == Character.character.ToString().ToUpper() && Upper_Case == false)
                        {
                            Content.Add(Upper);
                            Content.Add(Character);
                            Number_Of_Uppers += 1;
                            break;
                        }

                        //Case For Basic Upper If It's Only One Letter
                        if (letter.ToString() == Character.character.ToString().ToUpper() && Upper_Case == true && N_Uppers == 1)
                        {
                            Content.Add(Upper);
                            Content.Add(Character);
                            Number_Of_Uppers += 1;
                            break;
                        }

                    }
                }
            }
            return Content;
        }

        //Check The Operation
        public static List<int> Operations(List<Braille> Data)
        {
            List<int> Contents = new List<int>();
            foreach (var item in Data)
            {
                Contents.Add(int.Parse(item.value));
            }
            return Contents;
        }
        
    }
}
