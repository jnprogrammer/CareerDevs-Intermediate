#include <stdio.h>
#include <cs50.h>

int main(void)
{
    // widenColumn when != 0 will add additional hashes to the base colum of the pyramid
    int height = 0, widenColumn = 0, tempHt = 0;
    do
    {
        printf("Please enter a non negative number smaller than 23 \n");
        height = get_int();
    }
    while(height >23 || height < 0);
    //Set tempHt to height
    tempHt = height;

    for(int j = 0; j < height; j++)
    {
       // installs spaces n times, n = height minus one.
       for(int i = height - j; i > 1; i--)
       {
           printf(" ");
       }
       //installs #
       for(int x = 0 ;x <= j + widenColumn; x++)
       {
          printf("#");
       }
       //prints the double spaces
       printf("  ");

       //Makes sure that the correct number of # are printed per line
       //tempHt uses height, tempHt-- reduces the varaible by one each run through the loop
       //making it take longer before it returns to the orginal value of height which is when the loop stops.
       tempHt--;
       for(int i = tempHt; i < height - widenColumn; i++)
       {
          printf("#");
       }
       printf("\n");
    }
}
