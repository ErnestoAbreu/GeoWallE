public enum SyntaxKind
{
    // Tokens
    EndOfFileToken,
    EndOfStatementToken,
    BadToken,
    WhiteSpaceToken,
    NumberToken,
    StringToken,
    IdentifierToken,

    // Symbol Tokens
    OpenBracketToken,
    CloseBracketToken,
    OpenParenthesisToken,
    CloseParenthesisToken,
    SemicolonToken,
    CommaToken,
    EllipsisToken,
    UnderscoreToken,

    // Operator Tokens
    PlusToken,
    MinusToken,
    StarToken,
    DivToken,
    PercentToken,
    CircumflexToken,
    AtToken,
    EqualEqualToken,
    BangEqualToken,
    GreaterEqualToken,
    LessEqualToken,
    LessToken,
    GreaterToken,
    AmpersandToken,
    PipeToken,
    EqualsToken,
    BangToken,

    // Keywords
    LetKeyword,
    InKeyword,
    IfKeyword,
    ThenKeyword,
    ElseKeyword,
    ConstantKeyword,
    ColorKeyword,
    RestoreKeyword,
    ImportKeyword,
    DrawKeyword,
    LineKeyword,
    SegmentKeyword,
    RayKeyword,
    ArcKeyword,
    CircleKeyword,
    MeasureKeyword,
    IntersectKeyword,
    CountKeyword,
    RandomsKeyword,
    PointsKeyword,
    SamplesKeyword,
    PointKeyword,
    SequenceKeyword,
    PredefinedFunctionKeyword,

    // Expressions
    LiteralExpression,
    NameExpression,
    UnaryExpression,
    BinaryExpression,
    ParenthesizedExpression,
    AssignmentExpression,
    LetInExpression,
    IfElseExpression,
    FunctionCallExpression,
    FunctionDeclarationExpression,
    PredefinedFunctionExpression,

    // Binary Expression
    AdditionExpression,
    SubtractionExpression,
    DivisionExpression,
    EqualsExpression,
    ExponentiationExpression,
    GreaterEqualExpression,
    LessEqualExpression,
    LessExpression,
    LogicalAndExpression,
    LogicalOrExpression,
    MultiplicationExpression,
    NotEqualExpression,
    RemainderExpression,

    //Unary Expressions
    IdentityExpression,
    LogicalNegationExpression,
    NegationExpression,
}
