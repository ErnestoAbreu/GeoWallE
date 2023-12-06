public abstract class Expression : Statement
{
    public abstract SyntaxKind Kind { get; }
    public abstract GType Bind(Dictionary<string, GType> visibleVariables);
    public abstract BoundExpression GetBoundExpression(Dictionary<string, GType> visibleVariables);

    public override void Bind() => Bind();
}
