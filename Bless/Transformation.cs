namespace Bless
{
    public class Transformation
    {
        const int NUM_CUBE_BYTES = 256;
        const int NUM_ACCORDANCE_BYTES = 64;
        const int NUM_EXTRACTED_BYTES = 4;

        static void Focus(ref byte[] odd, ref byte[] even, byte oddstroke, byte evenstroke)
        {
            if (odd[evenstroke] == 255)
            {
                odd[evenstroke] = 0;
            }
            else
            {
                odd[evenstroke]++;
            }

            if (even[oddstroke] == 255)
            {
                even[oddstroke] = 0;
            }
            else
            {
                even[oddstroke]++;
            }
        }

        static void ExtractFourBytes(byte[] sourceArray, int startIndex, ref byte[] destArray)
        {
            Array.Copy(sourceArray, startIndex, destArray, 0, NUM_EXTRACTED_BYTES);
        }

        static byte RotateValues(byte[] oddValue, byte[] evenValue)
        {
            byte result = 0;
            for (int i = 0; i < NUM_EXTRACTED_BYTES; i++)
            {
                byte oddBit = Convert.ToByte(oddValue[i] != 0);
                byte evenBit = Convert.ToByte(evenValue[i] != 0);
                result |= (byte)((oddBit << i) | (evenBit << (i + 4)));
            }
            return result;
        }

        static void PopulateOddEven(byte[] cube, ref byte[] odd, ref byte[] even)
        {
            for (int i = 0; i < NUM_CUBE_BYTES - 1; i += 2)
            {
                Focus(ref odd, ref even, cube[i], cube[i + 1]);
            }
        }

        public static byte[] Accordance(byte[] cube)
        {
            byte[] odd = new byte[NUM_CUBE_BYTES];
            byte[] even = new byte[NUM_CUBE_BYTES];
            byte[] accordance = new byte[NUM_ACCORDANCE_BYTES];

            PopulateOddEven(cube, ref odd, ref even);

            byte[] extractedValueOdd = new byte[NUM_EXTRACTED_BYTES];
            byte[] extractedValueEven = new byte[NUM_EXTRACTED_BYTES];

            for (int i = 0, startIndex = 0; i < NUM_ACCORDANCE_BYTES; i++)
            {
                ExtractFourBytes(odd, startIndex, ref extractedValueOdd);
                ExtractFourBytes(even, startIndex, ref extractedValueEven);

                byte generatedByte = RotateValues(extractedValueOdd, extractedValueEven);
                accordance[i] = generatedByte;

                startIndex += NUM_EXTRACTED_BYTES;
            }

            return accordance;
        }
    }
}