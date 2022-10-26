bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{
// start
int num1;
int num2;
int reverse = 0;
bool checkValid;

// Creat num1 (enter data); num2 (store first data), reverse (store reversed data), checkValid(check if entered data is a number)


// Start a Do with Output question, and input number with validation.
do{
Console.Write("Enter numbers, we will reverse them for you: ");
checkValid = int.TryParse(Console.ReadLine(), out num1);

// if its false, output enter valid data, and ask again.
if(checkValid==false)
{
    Console.WriteLine("Please enter valid data, only numbers are accepted.");
}

}while(checkValid==false);

num2=num1;

// use num2 to save original data.
// start a while. It will get and store the reminder of num, it will store this in the reverse, and we will devide num/10 to get the next reminder.


while(num1>0)
{
    int remainder = num1%10;
  
    reverse = (reverse*10)+ remainder;
    num1 = num1/10;
}

// output num2 stores as first entered value, and the reverse value.
Console.WriteLine($"Your number input was: {num2} and the reverse for it is: {reverse}");

// Extra Credit: String Values

int len1 = 0;
string reverse2 = "";

// start an int with lenght 0 and reverse string "".

Console.Write("Enter string values, we will reverse them for you: ");
string word1 = Console.ReadLine();

// ask for a string value, and get the lenght - 1. -1 because in position we start in 0. and length gives all the whole number.

len1 = word1.Length-1;

// start a while when lenght is greater or equal than 0, we will be substracting 1.
// we will store in reverse2 the actual amount and the letter in the character lenght word.

while(len1>=0)
{
    reverse2 = reverse2 + word1[len1];
    len1--;
}
Console.WriteLine($"Your string values input was: {word1} and the reverse for it is: {reverse2}");

// output the actual word, and the reverse of it.


validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}


