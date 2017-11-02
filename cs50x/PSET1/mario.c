#include <stdio.h>
#include <cs50.h>

int main(void)
{
    int h , i;
    do
    {
        printf("Please enter a non negative number smaller than 23 \n");
        h = get_int();
    }
    while(h >23 || h < 0);
   // printf("\n");


   for(int j = 0; j < h; j++)
   {
       // installs spaces
       for(i = h - j; i > 1; i++)
       {
            printf(" ");
       }
       //installs #
       for(int x = 0 ;x <= j+1; x++)
       {
           printf("#");
       }

         printf("\n");
   }
}
