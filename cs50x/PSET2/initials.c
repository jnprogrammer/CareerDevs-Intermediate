#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>

bool userWantsContinue();

int main(void)
{
    do
    {
        printf("Enter a first and last name separated with a space\n");

        string name = get_string();
        int nameLen = strlen(name);
        int tempPosition = 0;

        for(int i = 0; i < nameLen; i++)
        {
         if(name[i] == ' ')
         {
             tempPosition = i+1;
         }
         if(i == tempPosition)
         {
             printf("%c",toupper(name[i]));
             tempPosition = -1;
         }

        } printf("\n");
    }while(userWantsContinue());

}

// a function to check if the user wants to use the program again.
bool userWantsContinue(){

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

}