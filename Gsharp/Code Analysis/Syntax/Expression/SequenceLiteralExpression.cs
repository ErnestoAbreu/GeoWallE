public class SequenceLiteralExpression : Expression
{
    public SequenceLiteralExpression(List<Expression> elements) : this(elements.FirstOrDefault(), elements.LastOrDefault())
    {
        Elements = elements;
    }

    public SequenceLiteralExpression(Expression start, Expression? end = null)
    {
        Start = start;
        End = end;
    }

    public override ExpressionKind Kind => ExpressionKind.SequenceLiteralExpression;

    public List<Expression> Elements { get; }
    public Expression Start { get; }
    public Expression? End { get; }

    protected override GType BindExpression(Dictionary<string, GType> visibleVariables)
    {
        var startType = Start.Bind(visibleVariables);
        if (Elements is null)
        {
            if (End is null)
                return startType;

            var endType = End.Bind(visibleVariables);
            if (endType != startType)
            {
                System.Console.WriteLine($"! SEMANTIC ERROR: Element of type {endType} in sequence of type {startType}");
                return GType.Undefined;
            }
        }
        else
        {
            foreach (var element in Elements)
            {
                var elementType = element.Bind(visibleVariables);
                if (elementType == startType)
                    continue;
                System.Console.WriteLine($"! SEMANTIC ERROR: Element of type {elementType} in sequence of type {startType}");
                return GType.Undefined;
            }
        }
        return startType;
    }

    protected override BoundExpression InstantiateBoundExpression(Dictionary<string, GType> visibleVariables)
    {
        List<BoundExpression> boundElements = new List<BoundExpression>();
        var boundStart = Start.GetBoundExpression(visibleVariables);
        if(Elements is null)
        {
            if(End is null)
                return new BoundSequenceLiteralExpression(boundStart);
            var boundEnd = End.GetBoundExpression(visibleVariables);
                return new BoundSequenceLiteralExpression(boundStart, boundEnd);
        }
        return new BoundSequenceLiteralExpression(boundElements);
    }
}
