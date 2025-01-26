namespace Framework.Entities
{
    public class CharEntity : Entity
    {
        private const char DefaultEmptyChar = '\0';
        
        public char Symbol { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CharEntity entity)
            {
                return Equals(entity);
            }
        
            return false;
        }

        public override int GetHashCode()
        {
            return Symbol.GetHashCode();
        }

        private bool Equals(CharEntity other)
        {
            if (other.Symbol == DefaultEmptyChar || Symbol == DefaultEmptyChar)
            {
                return false;
            }
            
            return Symbol == other.Symbol;
        }
    }
}