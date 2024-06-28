namespace ChessLogic
{
    public class Queen : Piece
    {
        public override PieceType Type => PieceType.Queen;

        public override Player Color { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.East,
            Direction.North,
            Direction.NorthEast,
            Direction.NorthWest,
            Direction.South,
            Direction.SouthEast,
            Direction.SouthWest,
            Direction.West
        };


        public Queen(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Queen copy = new Queen(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
