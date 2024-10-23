public class FilterCondition
{
    public string Column { get; set; }
    public CompOp Operator { get; set; }
    public object Value { get; set; }

    public FilterCondition(string column, CompOp @operator, object value)
    {
        Column = column;
        Operator = @operator;
        Value = value;
    }
}

public enum CompOp
{
    Equals,
    GreaterThan,
    LessThan,
    GreaterThanOrEqual,
    LessThanOrEqual,
    Like,
    In
}
