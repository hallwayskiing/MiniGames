namespace MiniGames.GameForms
{
    internal class Snake
    {
        private List<Label> body;

        Direction direction;

        enum Direction { UP, DOWN, LEFT, RIGHT }

        public Snake(List<Label> snakeBody)
        {
            body = snakeBody;
            direction = Direction.RIGHT;
        }

        public Point GetHead()
        {
            return body[0].Location;
        }

        public void Move()
        {
            for (int i = body.Count - 1; i > 0; i--)
                body[i].Location = body[i - 1].Location;

            Point pos = GetHead();
            switch (direction)
            {
                case Direction.UP:
                    body[0].Location = new Point(pos.X, pos.Y - 15);
                    break;
                case Direction.DOWN:
                    body[0].Location = new Point(pos.X, pos.Y + 15);
                    break;
                case Direction.LEFT:
                    body[0].Location = new Point(pos.X - 15, pos.Y);
                    break;
                case Direction.RIGHT:
                    body[0].Location = new Point(pos.X + 15, pos.Y);
                    break;
            }

        }

        public void Turn(char key)
        {
            switch (char.ToUpper(key))
            {
                case 'W':
                    if (direction != Direction.DOWN)
                        direction = Direction.UP;
                    break;
                case 'A':
                    if (direction != Direction.RIGHT)
                        direction = Direction.LEFT;
                    break;
                case 'S':
                    if (direction != Direction.UP)
                        direction = Direction.DOWN;
                    break;
                case 'D':
                    if (direction != Direction.LEFT)
                        direction = Direction.RIGHT;
                    break;
            }
        }

        public void GrowWith(Label label)
        {
            label.AutoSize = true;
            label.Text = "█";
            label.Location = body[^1].Location;
            body.Add(label);
        }

        public void CheckBody()
        {
            Point head = GetHead();
            for (int i = 1; i < body.Count; i++)
            {
                if (head.Equals(body[i].Location))
                    throw new Exception("Crash into yourself!");
            }
        }
    }
}
