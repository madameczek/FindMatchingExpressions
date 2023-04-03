using System.Text;

namespace ExpressionProcessor.DataModels;

public enum OperationType
{
    Add,
    Substract,
    Multiplicate,
    Divide
}

public class Expression
{
    public List<int> Numbers { get; set; } = new();
    public List<OperationType> Operations { get; set; } = new();
    public int? CalculatedResult { get; set; }
    public bool ErrorOccured { get; set; }

    public Expression Clone()
    {
        var clone = (Expression)MemberwiseClone();
        clone.Numbers = new List<int>(Numbers);
        clone.Operations = new List<OperationType>(Operations);
        return clone;
    }

    public override string ToString()
    {
        if (!Operations.Any()) return Numbers.FirstOrDefault().ToString();
        
        var sb = new StringBuilder();
        var position = 0;

        while (position < Operations.Count)
        {
            sb.Append(Numbers[position]);
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (Operations[position])
            {
                case OperationType.Add:
                    sb.Append(" + ");
                    break;
                case OperationType.Substract:
                    sb.Append(" - ");
                    break;
                case OperationType.Multiplicate:
                    sb.Append(" * ");
                    break;
                case OperationType.Divide:
                    sb.Append(" / ");
                    break;
            }
            ++position;
        }
        sb.Append(Numbers.Last());
        
        return sb.ToString();
    }
}