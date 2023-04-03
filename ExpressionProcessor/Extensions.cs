namespace ExpressionProcessor;

public static class Extensions
{
    public static int ToNumber(this IEnumerable<int> numbers) => int.Parse(string.Concat(numbers));
}