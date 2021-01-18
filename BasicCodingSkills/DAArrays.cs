using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodingSkills
{
    public class DAArrays
    {
        public  void ArrayRotation()
        {

            int rotateBy = 3;
            int rotationDone = 0;
           int[] myArray = new int[ ]{ 1, 2, 3, 4, 5, 6, 7 };
            int[] newArray = new int[7];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (rotateBy != rotationDone)
                {
                    newArray[myArray.Length- rotateBy+i] = myArray[i];
                    rotationDone++;
                }
                else
                {
                    newArray[i- rotationDone] = myArray[i];
                }
            }
            int[] myLeftArray = ArrayLeftRotation(myArray, rotateBy, myArray.Length);
            int[] myRightArray = ArrayRightRotation(myArray, rotateBy, myArray.Length);
           
            for (int i = 0; i < myLeftArray.Length; i++)
            {

                Console.Write(myLeftArray[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < myRightArray.Length; i++)
            {

                Console.Write(myRightArray[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < newArray.Length; i++)
            {

                Console.Write(newArray[i] + " ");
            }

            Console.ReadLine();

        }

        public int[] ArrayLeftRotation(int[] myArray, int rotateBy,int length)
        {
            int[] newArray = new int[length];
            int rotationDone = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (rotateBy != rotationDone)
                {
                    newArray[rotateBy-1- rotationDone] = myArray[i];
                    rotationDone++;
                }
                else
                    newArray[i] = myArray[i];
            }
            return newArray;
        }
        public int[] ArrayRightRotation(int[] myArray, int rotateBy, int length)
        {
            int[] newArray = new int[length];
            int rotationDone = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (rotateBy != rotationDone)
                {
                    newArray[rotateBy - 1 - rotationDone] = myArray[i];
                    rotationDone++;
                }
                else
                    newArray[i] = myArray[--length];
            }
                return newArray;

        }
        
        }
}
