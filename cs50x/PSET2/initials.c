#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>

//bool userWantsContinue();

int main(void)
{
   /* do
    { */  //Uncomment the doWhile, userWantsContinue() funtion and prototype to add a reuse function, was taken out to pass the CS50 bot
        printf("Enter a first and last name separated with a space\n");

        string name = get_string();
        int nameLen = strlen(name);
        int position = 0;

        //This forloop looks for the beginning of each name and a space
        // when a space is found it moves position over 1
        for(int i = 0; i < nameLen; i++)
        {

         if(name[i] == ' ')
         {
             position = i+1;
         }
         // if i is equal to position it assumes it has found a name and prints the charater located at name[i] and prints it then set position to negative one
         // to ensure the process can repeat as needed
         if(i == position)
         {
             printf("%c",toupper(name[i]));
             position = -1;
         }

        } printf("\n");
    //}while(userWantsContinue());

}

// a function to check if the user wants to use the program again.
/*bool userWantsContinue(){

	string userInput = " ";
	bool isValidInput = false;

	do{
		printf("Would you like to do this again? \n");
		printf("Enter y for yes and enter n for no\n");
		userInput = get_string();

		isValidInput = (strncmp(userInput,"n",1)) || (strncmp(userInput,"y",1));
		if (!isValidInput)
		{
			printf("Enter y or n \n");
		}
	} while (!isValidInput);

	return (strncmp(userInput,"n",1));

}*/