namespace StickManApp
{
    internal class StickMan
    {
        private int _col;
        private int _row;
        private bool _leftArmIsUp;
        private bool _rightArmIsUp;

        public StickMan(int col, int row, bool leftArmIsUp, bool rightArmIsUp)
        {
            _col = col;
            _row = row;
            _leftArmIsUp = leftArmIsUp;
            _rightArmIsUp = rightArmIsUp;
        }


        public void Draw()
        {
            var leftArmUp = _leftArmIsUp ? '\\' : ' ';
            var rightArmUp = _rightArmIsUp ? '/' : ' ';
            var leftArmDown = !_leftArmIsUp ? '/' : ' ';
            var rightArmDown = !_rightArmIsUp ? '\\' : ' ';

            Console.SetCursorPosition(_col, _row);
            Console.WriteLine($"{leftArmUp}O{rightArmUp}");
            Console.SetCursorPosition(_col, _row + 1);
            Console.WriteLine($"{leftArmDown}|{rightArmDown}");
            Console.SetCursorPosition(_col, _row + 2);
            Console.WriteLine("/ \\");
        }
    }
}
