using System.Text;

namespace String_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============= Reverse a String =============//
            string name = "Shivani Ghadge!";
            StringBuilder rev = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                rev.Append(name[i]);
            }

            Console.WriteLine("Reversed String is: " + rev);


            //============= Check Palindrome =============//
            string str = "Madam";
            str = str.ToLower();
            StringBuilder revs = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revs.Append(str[i]);
            }
            if (revs.ToString() == str)
            {
                Console.WriteLine(str + " is a Palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not a Palindrome");
            }

            //============= Check Palindrome 2nd approch =============//

            bool isPalindrome = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine(str + " is a Palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not a Palindrome");
            }

            //============= Count vowels in string =============//

            string sentence = "Hello World, Welcome to C# programming!";
            sentence = sentence.ToLower();
            int countvowels = 0;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    countvowels++;
                }
            }
            Console.WriteLine("Number of vowels in the string: " + countvowels);


            //============= Count number of words in string =============//

            int countwords = 1;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    countwords++;
                }
            }
            Console.WriteLine("Number of words in the string: " + countwords);


            //============= Find Frequncy of each Character  =============//

            string a = "banana";
            for (int i = 0; i < a.Length; i++)
            {
                bool alreadyCounted = false;

                for (int k = 0; k < i; k++)
                {
                    if (a[i] == a[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (alreadyCounted)
                    continue;

                int freq = 0;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        freq++;
                    }
                }

                Console.WriteLine("Frequency of " + a[i] + " is: " + freq);
            }
            //============= Find first non repeating character  =============//

            string b = "swiss";
            for (int i = 0; i < b.Length; i++)
            {
                bool isRepeating = false;
                for (int j = 0; j < b.Length; j++)
                {
                    if (i != j && b[i] == b[j])
                    {
                        isRepeating = true;
                        break;
                    }
                }
                if (!isRepeating)
                {
                    Console.WriteLine("First non-repeating character is: " + b[i]);
                    break;
                }
            }

            //============= Remove duplicate character from string =============//

            string n = "programming";
            StringBuilder newn = new StringBuilder();

            for (int i = 0; i < n.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < newn.Length; j++)
                {
                    if (n[i] == newn[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    newn.Append(n[i]);
                }
            }

            Console.WriteLine("String after removing duplicates: " + newn);

            //============= Check if two strings are anagrams =============//
            string s1 = "silent";
            string s2 = "listen";

            if (s1.Length == s2.Length)
            {
                bool isAnagram = false;
                for (int i = 0; i < s1.Length; i++)
                {
                    isAnagram = false;
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (s1[i] == s2[j])
                        {
                            isAnagram = true;
                        }
                    }
                }

                if (isAnagram)
                {
                    Console.WriteLine("Anagrams");
                }
                else
                {
                    Console.WriteLine("No Anagrams");
                }
            }
            else
            {
                Console.WriteLine("No Anagrams");
            }

            //============= check anagrams 2 =============//

            bool isAnagram2 = String.Concat(s1.OrderBy(c => c)) == String.Concat(s2.OrderBy(c => c));
            Console.WriteLine(isAnagram2 ? "Anagrams" : "No Anagrams");


            //============= reverse each word in string =============//

            string strs= "Hello World";      // "olleH dlroW"
            StringBuilder result = new StringBuilder();

            string[] words = strs.Split(' ');

            for (int i = 0; i < words.Length; i++) 
            { 
                for(int j = words[i].Length - 1; j >= 0; j--)
                {
                    result.Append(words[i][j]);
                }
                result.Append(" ");
            }
            Console.WriteLine("Reversed each word: " + result.ToString());


            //=============  Find the longest word in a sentence =============//

            string sen = "coding in dotnet is interesting";

            string[] wordlist = sen.Split(' ');
            string longestword = "";

            for (int i = 0; i < wordlist.Length; i++)
            {
                if (wordlist[i].Length> longestword.Length)
                {
                    longestword = wordlist[i];
                }
            }

            Console.WriteLine("Longest word : " + longestword);


            //=============  Find Maximum occuring character =============//

            string sent = "ghdfbngnvmcgfdgnmcdggfdf";
            string maxOcc = "";
            int maxcount = 0;

            for (int i = 0; i < sent.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < sent.Length; j++)
                {
                    if (sent[i] == sent[j])
                    {
                        count++;
                    }
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    maxOcc = sent[i].ToString();
                }
            }

            Console.WriteLine("Maximum occuring character is: " + maxOcc);



        }

    }
}
