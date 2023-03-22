namespace MiniGames.GameForms
{
    internal class Snake
    {
        private List<Label> body;

        Direction direction,preDirection;

        enum Direction { UP, DOWN, LEFT, RIGHT }

        public Snake(List<Label> snakeBody)
        {
            body = snakeBody;
            direction = Direction.RIGHT;
            preDirection = Direction.RIGHT;
        }

        public Point GetHead()
        {
            return body[0].Location;
        }

        public void Move()
        {
            if((direction == Direction.UP&&preDirection==Direction.DOWN)||
                (direction == Direction.DOWN && preDirection == Direction.UP)||
                (direction == Direction.RIGHT && preDirection == Direction.LEFT)||
                (direction == Direction.LEFT && preDirection == Direction.RIGHT))
            {
                direction = preDirection;
                Move();
                return;
            }

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
            preDirection = direction;
        }

        public void Turn(char key)
        {
            switch (char.ToUpper(key))
            {
                case 'W':                   
                    direction = Direction.UP;
                    break;
                case 'A':                  
                    direction = Direction.LEFT;
                    break;
                case 'S':
                    direction = Direction.DOWN;
                    break;
                case 'D':
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
