#include <string.h>
#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>
#include <cs50.h>

int alphaPos(char);

int main(int argc, string argv[])
{

    if(argc < 2)
    {
        printf("You need to enter a number for a key when running\n");
        return 1;
    }
    int argLen = strlen(argv[1]);
    for(int i = 0; i < argLen; i++)
    {
        if(isalpha(argv[1][i]))
        {
            printf("You entered an argument that isnt a number !\n");
            return 1;
        }
    }

    int key = atoi(argv[1]);
    printf("Enter a phrase you want ceasar cipher executed apon\n");
    string phrase = get_string();
    int phraseLen = strlen(phrase);

    printf("ciphertext: ");
    for(int i = 0; i < phraseLen; i++)
    {

    if(isalpha(phrase[i]))
    {
       if(islower(phrase[i]))
       {
           //runs each letter through the key to change the letter to its encrypted character depending on if its capital or lower case.
       printf("%c",(((phrase[i] - 97 + key) % 26) + 97));
       }

       if(isupper(phrase[i]))
       {
       printf("%c",(((phrase[i] - 65 + key) % 26) + 65));
       }
     }
     else
     {
       printf("%c",phrase[i]);
     }

    }
    printf("\n");
    return 0;
}
