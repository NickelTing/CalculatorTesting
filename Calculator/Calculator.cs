namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new System.ArgumentException("Cannot divide by zero");
            }
            return a / b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }

        public bool IsPrime(int number) {
            if (number < 2) {
                return false;
            }
            for (int i = 2; i <= number / 2; i++) {
                if (number % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}