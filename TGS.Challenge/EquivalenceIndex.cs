namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
        //step 1: get total value of the array
        var totalValue = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
          totalValue = totalValue + numbers[i];
        }
        
        // step 2 initialize left sum and iterate through the array
        var leftValue = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
          // step 3: calculate right sum
          // right value = total value - left value - current element
          int rightValue = totalValue - leftValue - numbers[i];
          
          //check if right value and left value are equal
          if (rightValue == leftValue)
          {
            return i;
          }
          
          // update leftvalue for next iteration
          leftValue = leftValue + numbers[i];
        }
        
        return -1;
      }
    }
}
