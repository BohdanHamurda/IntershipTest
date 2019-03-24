using System;

namespace InternshipTest
{
    public class Knowledge
    {
        public uint level { get; }
        private const int MAX_LEVEL = 100;
        public Knowledge(uint level) // нехай рівень знань буде від 1 до 100
        {
            try
            {
                if (level > MAX_LEVEL)
                    throw new Exception("Level too high");
                else
                    this.level = level;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
