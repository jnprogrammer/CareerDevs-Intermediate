#include <string.h>
#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>
#include <cs50.h>


void vigenere(string,string);
int alphaPos(char letter);
string applyKey(string, string);
bool userWantsContinue();



int main(int argc, string argv[])
{

   do
   {
       string phrase = " ";
       string keyPhrase = " ";
       char orginalPhrase[100];
       int len = 0;

       if(argc < 2)
        {
            printf("You need to enter a word for a key when running\n");
            return 1;
        }
       if(argc > 2)
        {
            printf("you entered in more than one argument\n");
            return 1;
        }
        len = strlen(argv[1]);
        for(int i = 0; i < len; i++)
        {
            if(!isalpha(argv[1][i]))
            {
                printf("You used a char that isn't a number or letter !\n");
                return 1;
            }
        }
       printf("Enter in a phrase you want encrypted with a Vigenere Algorithm\n");
       phrase = get_string();
       keyPhrase = argv[1];


       strcpy(orginalPhrase, phrase);
       //printf("%s", applyKey(keyPhrase, phrase));
       vigenere(orginalPhrase,applyKey(keyPhrase,phrase));

   }while(userWantsContinue());
   return 0;
}

string applyKey(string key, string phrase)
{
    int len = strlen(phrase),
        modKey = 0,
        keyLen = strlen(key),
        phraseLoc = 0;

    for(int i = 0; i < len; i++)
    {
         if(isalpha(phrase[i]))
        {
           if (phraseLoc >= keyLen)
           {
             phraseLoc = 0;
           }
           modKey = phraseLoc % keyLen;
           phrase[i] = key[modKey];
           phraseLoc++;
        }
    }
    return phrase;
}

void vigenere(string phrase, string newPhrase)
{
    int len = strlen(phrase), key = 0;

    for(int i = 0; i < len; i++)
    {
        if(isalpha(phrase[i]))
        {

           if(isupper(phrase[i]))
           {
           key = alphaPos(newPhrase[i]);
           printf("%c",((phrase[i] - 65 + key) % 26) + 65);
           }

           if(islower(phrase[i]))
           {
           key = alphaPos(newPhrase[i]);
           printf("%c",((phrase[i] - 97 + key) % 26) + 97);
           }
        }
        else
        {
            printf("%c",phrase[i]);
        }
    }
   printf("\n");
}

int alphaPos(char letter)
{
    int holderChar = letter , alPos = 0;
    if((letter >= 65 && letter <= 90))
    {
      alPos = holderChar - 65;
     //printf("%c is: %d in the Alphabet\n",letter,alPos);
     return alPos;
    }
    if((letter >= 97 && letter <= 122))
    {
       alPos = holderChar - 97;
    // printf("%c is: %d in the Alphabet\n",letter,alPos);
     return alPos;
    }
    else
    {
        return alPos = 0; // error case
    }
}

// a function to check if the user wants to use the program again.
bool userWantsContinue(){
	string userInput = " ";
	bool isValidInput = false;

	do{
		printf("Would you like to do another? \n");
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
