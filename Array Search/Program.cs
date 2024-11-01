// See https://aka.ms/new-console-template for more information

int myValue;
int arrayMiddle;
int arrayMiddleNumber;

int[] myArray = new int[9];
myArray[0] = 21;
myArray[1] = 3;
myArray[2] = 2;
myArray[3] = 58;
myArray[4] = 1;
myArray[5] = 7;
myArray[6] = 9;
myArray[7] = 42;
myArray[8] = 50;

Array.Sort(myArray);

myValue = Convert.ToInt16(Console.ReadLine());

int arrayLength = myArray.Length;
arrayMiddle = arrayLength / 2;
arrayMiddleNumber = myArray[arrayMiddle];
SearchArray(1,ref myValue, ref arrayMiddle, ref arrayMiddleNumber, ref myArray, ref arrayLength);

static void SearchArray(int arrayNumber, ref int myValue, ref int arrayMiddle, ref int arrayMiddleNumber, ref int[] myArray, ref int arrayLength)
{

    if (myValue > arrayMiddleNumber)
    {
        for (int i = 0; i < arrayMiddle; i++)
        {
            if (myValue == myArray[arrayNumber])
            {
                Console.WriteLine("Found value" + arrayNumber + "column");
            }
            else
            {
                if (arrayNumber < arrayMiddle)
                {
                    arrayNumber++;
                }
            }
        }
    }
    else
    {
        arrayNumber = arrayMiddleNumber;
        for (int i = 0; i < arrayMiddle; i++)
        {
            if (myValue == myArray[arrayNumber])
            {
                Console.WriteLine("Found value" + arrayNumber + "column");
            }
            else
            {
                if (arrayNumber < arrayMiddle)
                {
                    arrayNumber++;
                }
            }
        }
    }
}
