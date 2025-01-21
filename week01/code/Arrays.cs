public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        /*
        - first I have to create an array of size 'length'.
        - second I have to Loop through the array, setting each element to the multiple of 'number'.
        - and then it will return the filled array.
        */

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        /*
        Here I have to ensure 'amount' is within valid bounds by using modulo.
        after that extract the last 'amount' elements from the list.
        then Remove these elements from their original positions.
        lastly Insert them at the beginning of the list.
        */

        int n = data.Count;
        amount %= n;
        if (amount == 0) return;

        List<int> rotatedPart = data.GetRange(n - amount, amount);
        data.RemoveRange(n - amount, amount);
        data.InsertRange(0, rotatedPart);


        /*
        for the RotateListRight function:
        - we first determine the number of rotations needed. Since rotating by the list size results in the same list,
        we use modulo to reduce unnecessary rotations.
        - if the amount is zero after modulo, we return early as no changes are needed.
        - we extract the last 'amount' elements from the list using GetRange().
        - these extracted elements are removed from the original list using RemoveRange().
        - finally, we insert the extracted elements at the beginning using InsertRange().
        */
    }
}
