public class NegationExpression : BinaryExpression
{
    public NegationExpression(Expression left, Expression right)
        : base(left, right) { }

    public override SyntaxKind Kind => throw new NotImplementedException();

    protected override GType Bind(Dictionary<VariableSymbol, GType> visibleVariables)
    {
        throw new NotImplementedException();
    }
}
