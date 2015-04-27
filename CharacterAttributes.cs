namespace CSCD349Project
{
    public class CharacterAttributes
    {
        // private feilds
        private int _Health;
        private int _BaseHealth;

        // properties
        public int _health
        {
            get{return _Health;}
            set
            {
                if(value <= 0)
                    _Health = 0;
                if(value >= _BaseHealth)
                    _Health = _BaseHealth;
            }
        }
        public int _basehealth
        {
            get{return _BaseHealth;}
            set
            {
                if (value < 0)
                    _BaseHealth = 0;
                else
                    _BaseHealth = value;
                
            }
        }

        public int _baseStrength
        {
            get { return _base; }
            set
            {
                if (value < 0)
                    _BaseHealth = 0;
                else
                    _BaseHealth = value;

            }
        }
        
        
        
        public CharacterAttributes()
        {
            _health = 0;
        }


    }
}