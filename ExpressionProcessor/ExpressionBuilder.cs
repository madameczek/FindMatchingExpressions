using ExpressionProcessor.DataModels;
using Expression = ExpressionProcessor.DataModels.Expression;

namespace ExpressionProcessor;

public class ExpressionBuilder
{
    private List<Expression> Expressions { get; } = new();
    
    public List<Expression> GetExpressions(ICollection<int> numbers)
    {
        CreateExpressions(numbers);
        return Expressions;
    }
    
    private void CreateExpressions(ICollection<int> numbers, Expression? expression = null)
    {
        if (!numbers.Any()) return;

        if (expression is null)
        {
            var newExpression = new Expression();
            newExpression.Numbers.Add(numbers.ToNumber());
            Expressions.Add(newExpression);
            if (numbers.Count == 1) return;
        }

        var position = 0;

        while (position < numbers.Count - 1)
        {
            ++position;

            var leftHandNumbers = numbers.Take(position);
            var partialExpressions = GetPartialExpressions(leftHandNumbers.ToNumber(), 
                expression ??= new Expression());
            
            foreach (var partialExpression in partialExpressions)
            {
                var newExpression = partialExpression.Clone();
                var rightHandNumbers = numbers.Skip(position).ToList();
                newExpression.Numbers.Add(rightHandNumbers.ToNumber());
                Expressions.Add(newExpression);

                CreateExpressions(rightHandNumbers.ToArray(), partialExpression);
            }
        }
    }

    private static IEnumerable<Expression> GetPartialExpressions(int number, Expression expression)
    {
        var newExpressions = new List<Expression>();
        foreach (var operation in Enum.GetValues<OperationType>())
        {
            var newExpression = expression.Clone();
            newExpression.Numbers.Add(number);
            newExpression.Operations.Add(operation);
            newExpressions.Add(newExpression);
        }
        return newExpressions;
    }
}