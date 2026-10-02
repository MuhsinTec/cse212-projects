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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return []; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN for RotateListRight:
        // 1. Calculate the split index where the list needs to be divided.
        //    The elements to move to the front start at index: data.Count - amount.
        // 2. Extract the tail portion (the last 'amount' elements) using GetRange.
        // 3. Remove that tail portion from the original 'data' list using RemoveRange.
        // 4. Insert the extracted tail portion at the very beginning (index 0) of the 'data' list using InsertRange.
        // 5. This modifies the list in place without returning a new object.

        if (data == null || data.Count == 0 || amount <= 0)
        {
            return;
        }

        int splitIndex = data.Count - amount;

        // Get the slice of elements that need to move to the front
        List<int> tailRange = data.GetRange(splitIndex, amount);

        // Remove those elements from the end of the original list
        data.RemoveRange(splitIndex, amount);

        // Insert the removed elements at the start of the list
        data.InsertRange(0, tailRange);
    }
}
