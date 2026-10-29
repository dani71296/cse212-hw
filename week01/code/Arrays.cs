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
        // We have two variables: number and length and we want number to multiply length times.
        // For that, we need to create an array with the length size, start a for cycle 
        // with a new variable where it iterates since 0 up to length, and if this new variable 
        // is < than length, we multiply number by that new variable and return the result.

        // create an array of size length
        double[] resultado = new double[length];

        // create a for cycle to iterate from 0 to length
        for (int i = 0; i < length; i++)
        {
            // multiply the number by the position and save it
            resultado[i] = number * (i + 1);
        }

        // return the result
        return resultado;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    // We want to loop 'amount' times. In each loop, we take the last element 
    // of the list, remove it from the end, and insert it at the beginning (index 0) 
    // so the rest of the list shifts automatically.
    {
        //  Loop 'amount' times to rotate the list step by step
        for (int i = 0; i < amount; i++)
        {
            //  get the last element of the list
            int lastElement = data[data.Count - 1];

            //  remove the last element from its current position
            data.RemoveAt(data.Count - 1);

            //  insert that last element at the beginning of the list (index 0)
            data.Insert(0, lastElement);
        }
    }
}
