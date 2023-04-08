namespace Ch04Ex02PrimeFactorsLib
{
    public static class PrimeFactorsLib
    {
        public static string PrimeFactors(int input)
        {
            if (input <= 1) return "Input must be > 1";

            int denom = 2;
            int remainder = input;
            List<int> primeList = new List<int>();

            while(remainder > 1)
            {
                if(remainder % denom != 0)
                {
                    denom++;
                    continue;
                }

                remainder = remainder / denom;
                primeList.Add(denom);

            }

            return String.Join(" x ", primeList);
        }
    }
}