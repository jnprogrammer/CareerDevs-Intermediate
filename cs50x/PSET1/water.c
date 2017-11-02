#include<stdio.h>
#include<cs50.h>



int main(void)
{
    // ozPerBottle = 16; 1 minute in shower spits out 1.5 gal, 1.5gl = 128oz
    // a typical bottle of water is 16 oz thus 1 minute = 16oz

    // ozPerMin = 192; 128oz * 1.5gl = 192oz per min

    int min,ozPerBottle, ozPerMin, ozWater, answer;

    ozPerBottle = 16;
    ozPerMin = 192;
    min = get_int("Yo, how many minutes you spend in the shower?\nMinutes:");
    ozWater = min * ozPerBottle;
    ozPerMin = ozPerMin * min;
    answer = ozPerMin / ozPerBottle;
    printf("Bottles: %i\n",answer);


}