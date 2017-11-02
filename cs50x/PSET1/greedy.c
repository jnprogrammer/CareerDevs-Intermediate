#include <stdio.h>
#include <math.h>
#include <cs50.h>

//Greedy problem:
// My solution.

//
int main(void)
{
     int quarters = 0, nickels = 0, dimes = 0, pennies = 0;
     float changeOwed;
     float q25, d10, n05, p01;
     q25 = .25f;
     d10 = .10f;
     n05 = 0.5f;
     p01 = .01f;


      changeOwed = get_float("How much are you Owed?\n");

      // Takes changeOwed amount and subtracts the base value till the remaining amount is less than the base
      //Quarters
      if(changeOwed > q25)
      {
         do
         {
             changeOwed = changeOwed - q25;
             quarters++;
         }while(changeOwed >= q25);
      }

      if(changeOwed > d10)
      {
         do
         {
             changeOwed = changeOwed - d10;
             dimes++;

         }while(changeOwed >= d10);
      }

      if(changeOwed > n05)
      {
         do
         {
             changeOwed = changeOwed - n05;
             nickels++;
         }while(changeOwed >= n05);
      }

      if(changeOwed > p01)
      {
         do
         {
			 changeOwed = changeOwed - p01;
             pennies++;
         }while(changeOwed >= p01);
      }

      printf("Amount left: %f",changeOwed);
      printf("\nYou have recieved:\n %i Quarters\n %i dimes\n %i nickels\n %i pennies\n", quarters, dimes, nickels, pennies);

}

