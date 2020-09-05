using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool CheckAnagram(List<String> list1,List<String> list2)
        {
            for(int i=0;i<list1.Count;i++)
            {
                if(!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool WordPairIsAnagram(string word1, string word2) {
            if (word1.Length == word2.Length)
            {
                List<String> list = new List<String>();
                List<String> lists = new List<String>();
                for (int i = 0; i < word1.Length; i++)
                {
                    String alphabet = word1.Substring(i,1);
                    String alphabets = word2.Substring(i,1);
                    list.Add(alphabet);
                    lists.Add(alphabets);
                }
                list.Sort();lists.Sort();
                return CheckAnagram(list, lists);
                
            }
            return false;
        }
        
        public List<string> NotAnagramList(List<string> candidates,List<string> NotAnagaram)
        {
              for(int i=0;i<candidates.Count;i++)
              {
                if(!WordPairIsAnagram(word,candidates[i]))
                {
                    NotAnagaram.Add(candidates[i]);
                }
              }
            return NotAnagaram;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {

            List<string> NotAnagaram = new List<string>();
            
            NotAnagaram=NotAnagramList(candidates,NotAnagram);
            
            for(int i=0;i<NotAnagaram.Count;i++)
            {
                candidates.Remove(NotAnagaram[i]);
            }

            return candidates;
        }
    }
}
