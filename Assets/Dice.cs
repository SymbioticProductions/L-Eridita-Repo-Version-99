using System;
namespace AssemblyCSharp.Assets
{
    public class Dice
    {
        public int int_Dice_Roll()
        {
            Random r = new Random();

            int int_Dice_Roll = r.Next(1, 7); //must be 7 because it only works
                                              //as less than the highest number  
            return int_Dice_Roll;
        }
    }
}
// found guidance at https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp

/* for movement initialisation try 
 * if int_Dice_Roll = (the number you need)
 *          highlight.Hex with x +- number and y +- the number
 * 
 * remember the dice visual feedback for now only needs to be a 2D dice face
*/