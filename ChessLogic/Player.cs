namespace ChessLogic
{
    public enum Player
    {
        None, //we can set the winning player to
        //none in case of a draw
        White,
        Black
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            switch (player)
            {
                case Player.White:
                    return Player.Black;
                case Player.Black:
                    return Player.White;
                default:
                    return Player.None;

            }
        }
    }

}
