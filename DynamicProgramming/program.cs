using static System.Console;

#region Max

#region UseCase

//WriteLine(InEfficientMax(new[] { 1, 2, 3, 4 }));
WriteLine(EfficientMax(new[] { 1, 2, 3, 4 }));

ReadLine();

#endregion

/*When we then run our code, we’ll see the word, RECURSION, printed to our
terminal 15 times.
Now, we do need some of those calls, but not all of them. We do need to calculate
max([4]), for example, but one such function call is enough to get the
computed result. But here, we call that function eight times.*/
//O(2^N)
int InEfficientMax(int[] numbers)
{
    WriteLine("RECURSION");

    if (numbers.Length == 1)
        return numbers[0];

    if (numbers[0] > InEfficientMax(numbers[1..]))
        return numbers[0];

    return InEfficientMax(numbers[1..]);
}

/*Thankfully, there’s an easy way to eliminate all these extra recursive calls.
We’ll call max only once within our code, and save the result to a variable*/

int EfficientMax(int[] numbers)
{
    WriteLine("RECURSION");

    if (numbers.Length == 1)
        return numbers[0];

    //Calculate the max of the remainder of the array
    //and store it inside a variable:
    int maxOfReminder = EfficientMax(numbers[1..]);

    if (numbers[0] > maxOfReminder)
        return numbers[0];

    return maxOfReminder;
}

#endregion