namespace ChessLogic
{
    public enum Player
    {
        None,
        Black,
        White
    }

    public static class PlayerExtentions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.Black => Player.White,
                Player.White => Player.Black,
                _ => Player.None,
            };
        }
    }
}
