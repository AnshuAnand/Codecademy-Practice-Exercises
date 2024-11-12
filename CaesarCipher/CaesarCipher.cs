namespace CaesarCipher;

class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

        Console.WriteLine("Enter a secret message");

        string userInput = Console.ReadLine().ToLower();

        char[] secretMessage = userInput.ToCharArray();
        int secretMessageLength = secretMessage.Length;
        char[] encryptedMessage = new char[secretMessageLength];

        for (int i = 0; i < secretMessage.Length; i++)
        {
            char letter = secretMessage[i];
            if (Char.IsSymbol(letter) || Char.IsPunctuation(letter)){
                letter = secretMessage[i+1];
                i++;
            }
            int positionInAlphabet = Array.IndexOf(alphabet, letter);
            int incrementByThree = (positionInAlphabet + 3) % alphabet.Length;
            char encryptedLetter = alphabet[incrementByThree];
            encryptedMessage[i] = encryptedLetter;
        }

        string msgString = String.Join("",encryptedMessage);

        Console.WriteLine(msgString);

    }
}
