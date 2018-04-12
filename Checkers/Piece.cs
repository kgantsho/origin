using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public class Piece : IPiece
    {
       virtual public IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

       virtual public void Move(int destination)
        {
            throw new NotImplementedException();
        }

       virtual public IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public Piece(Color c, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = c;
        }
        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }


    }
}
