public class DrawStatement : Statement
{

    public DrawStatement(Expression figure)
    {
        Figure = figure;
    }

    public DrawStatement(Expression figure, Expression message) : this(figure)
    {
        Message = message;
    }

    public Expression Figure { get; }
    public Expression? Message { get; }

    public override void BindStatement(Dictionary<string, GType> visibleVariables)
    {
        if(Figure.Bind(visibleVariables) != GType.Figure)
        {
            System.Console.WriteLine("! SEMMANTIC ERROR : Expected figure is not of type <figure>");
            return;
        }

        { var a = 1;}

        if (Message is not null)
        {
            var messageType = Message.Bind(visibleVariables);
            if (messageType != GType.String)
            {
                System.Console.WriteLine("! SEMANTIC ERROR: Expected message of type <string>");
                return;
            }
        }
    }

    public override BoundStatement GetBoundStatement(Dictionary<string, GType> visibleVariables)
    {
        BindStatement(visibleVariables);
        var boundFigure = Figure.GetBoundExpression(visibleVariables);

        if (Message is not null)
        {
            var boundMessage = Message.GetBoundExpression(visibleVariables);
            return new BoundDrawStatement(boundFigure, boundMessage);
        }

        return new BoundDrawStatement(boundFigure);
    }
}
