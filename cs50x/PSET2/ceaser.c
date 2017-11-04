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
    IF(argc )

    int key = atoi(argv[1]);

    string phrase = get_string();
    int len = strlen(phrase);


   for(int i = 0; i < len; i++)
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
