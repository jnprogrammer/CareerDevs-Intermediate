#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>

int main(void)
{
   
    string name = get_string();
    //string temp = "Josh";
    //char * strPtn = NULL;
    int n = strlen(name);
    int hold = 0;
    for(int i = 0; i < n; i++)
    {
      //  int n = strlen(argv[i]);
     if(name[i] == ' ')
     {
         hold = i+1;
     }
     if(i == hold)
     {
         printf("%c",toupper(name[i]));
         hold = -1;
     }
     //temp =  strncat(temp,name,0);
    } printf("\n");
   //printf("%c%c\n",name[0],name[hold]);
    //strncat(theName,initials,1);
    //strncat(initials,theLast,1);
   // printf("%s\n",theName);
   // printf("%s\n",initials);
}