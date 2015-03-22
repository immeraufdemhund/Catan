namespace Catan.Models
{
    public class ResourceMarker
    {
        public int Number { get; private set; }
        public char Letter { get; private set; }

        private static char letter = 'A';

        public ResourceMarker(int number)
        {
            Number = number;
            Letter = letter++;
        }
    }
}
