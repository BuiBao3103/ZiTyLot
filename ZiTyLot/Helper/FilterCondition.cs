public class FilterCondition
{
    public string Column { get; set; }
    public ComparisonOperator Operator { get; set; }
    public object Value { get; set; }
}

public enum ComparisonOperator
{
    Equals,
    GreaterThan,
    LessThan,
    GreaterThanOrEqual,
    LessThanOrEqual,
    Like,
    In
}
