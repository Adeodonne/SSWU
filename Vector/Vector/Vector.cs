using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        int[] arr;

        public int this[int index]
        {
            get
            { 
                if(index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set 
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        public Vector() { }

        public void RandomInitialization(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
        }

        public void RandomInitialization()
        {

            Random random = new Random();
            int x;
            for (int i = 0; i < arr.Length; i++)
            {
                while(arr[i] == 0)
                {
                    x = random.Next(1, arr.Length + 1);
                    bool isExist = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (x == arr[j])
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        arr[i] = x;
                        break;
                    }
                }
            }
        }

        public Pair[] CalculateFreq()
        {
            
            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pairs[i] = new Pair(0,0);

            }
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if(arr[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = arr[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public bool IsPalindrom()
        {
            if (arr.Length == 1 || arr.Length == 0) 
            {
                return true;
            }

            for (int i = 0; i < arr.Length / 2; i++) 
            {
                if (arr[i] != arr[arr.Length - i - 1]) 
                {
                    return false;
                }
            }

            return true;
        }

        public void Reverse() 
        {
            if (arr.Length == 1 || arr.Length == 0)
            {
                return;
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temporary = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temporary;
            }
        }

        public int[] FindTheLongestSequence()
        {
            int answerNumber = arr[0];
            int longestSequenceCount = 1;

            int curentNumber = arr[0];
            int currentLongestSequanceCount = 1;

            for (int i = 1; i < arr.Length; i++) 
            {
                if (arr[i] == curentNumber)
                {
                    currentLongestSequanceCount++;
                }
                else 
                {
                    curentNumber = arr[i];
                    currentLongestSequanceCount = 1;
                }

                if (currentLongestSequanceCount > longestSequenceCount)
                {
                    answerNumber = curentNumber;
                    longestSequenceCount = currentLongestSequanceCount;
                }
            }

            return new int[] { answerNumber, longestSequenceCount };
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }
    }
}
