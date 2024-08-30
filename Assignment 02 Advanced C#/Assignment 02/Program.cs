using System.Collections;

namespace Assignment_02
{
    internal class Program
    {
        static ArrayList reverse(ArrayList list)
        {
            ArrayList result = new ArrayList(list.Count);
            for (int i = list.Count - 1; i >= 0; i--)
            {   
                   result.Add(list[i]);
            }
            return result;
        }

        static int FindFirstNonRepeatedChar(string Word)
        {
            Dictionary<char , int> DictionaryCount = new Dictionary<char , int>();

            for (int i = 0; i < Word.Length; i++)
            {
                char c = Word[i];
                if (DictionaryCount.ContainsKey(c))
                {
                    DictionaryCount[c]++;
                }
                else
                {
                    DictionaryCount[c] = 1;
                }
            }

            for (int i = 0;i < Word.Length; i++)
            {
                if (DictionaryCount[Word[i]] == 1)
                {
                    return i;
                }
                
            }
            return -1;

        }
        static void Main(string[] args)
        {
            #region Question 1
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //ArrayList result =  reverse(list);

            //foreach (int item in result)
            //{
            //    Console.Write($" {item}");
            //}
            #endregion


            #region Question 2
            //List<int> lits = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> EvenList = new List<int>();
            //foreach (int item in lits)
            //{
            //    if (item % 2 == 0)
            //    {
            //        EvenList.Add(item);
            //    }
            //}

            //foreach (int even in EvenList)
            //{
            //    Console.Write($" {even}");
            //} 
            #endregion


            #region Question 3

            #endregion


            #region Question 4
            //string word = "Google";
            //int Count = FindFirstNonRepeatedChar(word);
            //Console.WriteLine(Count);
            #endregion




        }
    }
}
