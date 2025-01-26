namespace Entities
{
    public class CharEntity
    {
        public char Symbol { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CharEntity entity)
            {
                return Equals(entity);
            }
        
            return false;
        }

        public bool Equals(CharEntity other)
        {
            return Symbol == other.Symbol;
        }
    }
}