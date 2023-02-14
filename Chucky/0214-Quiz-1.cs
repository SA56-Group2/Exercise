using System;

namespace Quiz_0214
{
    internal class Program
    {
        static int[] minIncomeArray = new int[]
        { 20000, 30000, 40000, 80000,
            120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
        { 0.02, 0.035, 0.07, 0.115,
            0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
        { 0, 200, 550, 3350,
            7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            int annualIncome = int.Parse(Console.ReadLine());
            return annualIncome;
        }
        static int GetTaxBracket(int annualIncome)
        {
            int taxBracket = 0;
            if ((annualIncome >= 0) && (annualIncome < minIncomeArray[1])) taxBracket = -1;
            else if ((annualIncome >= minIncomeArray[0]) && (annualIncome < minIncomeArray[1]))
                taxBracket = 1;
            else if ((annualIncome >= minIncomeArray[1]) && (annualIncome < minIncomeArray[2]))
                taxBracket = 2;
            else if ((annualIncome >= minIncomeArray[2]) && (annualIncome < minIncomeArray[3]))
                taxBracket = 3;
            else if ((annualIncome >= minIncomeArray[3]) && (annualIncome < minIncomeArray[4]))
                taxBracket = 4;
            else if ((annualIncome >= minIncomeArray[4]) && (annualIncome < minIncomeArray[5]))
                taxBracket = 5;
            else if ((annualIncome >= minIncomeArray[5]) && (annualIncome < minIncomeArray[6]))
                taxBracket = 6;
            else if ((annualIncome >= minIncomeArray[6]) && (annualIncome < minIncomeArray[7]))
                taxBracket = 7;
            else if (annualIncome >= minIncomeArray[7]) taxBracket = 8;
            return taxBracket;
        }

        static double CalculateIncomeTax(int anuualIncome, double taxBracket)
        {
            double taxpayable;
            switch (taxBracket)
            {
                case -1:
                {
                    taxpayable = 0;
                    return taxpayable;
                }
                case 1:
                {
                    taxpayable = (anuualIncome - minIncomeArray[0]) * taxRateArray[0] + basePayableAmountArray[0];
                    return taxpayable;
                }
                case 2:
                {
                    taxpayable = (anuualIncome - minIncomeArray[1]) * taxRateArray[1] + basePayableAmountArray[1];
                    return taxpayable;
                }
                case 3:
                {
                    taxpayable = (anuualIncome - minIncomeArray[2]) * taxRateArray[2] + basePayableAmountArray[2];
                    return taxpayable;
                }
                case 4:
                {
                    taxpayable = (anuualIncome - minIncomeArray[3]) * taxRateArray[3] + basePayableAmountArray[3];
                    return taxpayable;
                }
                case 5:
                {
                    taxpayable = (anuualIncome - minIncomeArray[4]) * taxRateArray[4] + basePayableAmountArray[4];
                    return taxpayable;
                }
                case 6:
                {
                    taxpayable = (anuualIncome - minIncomeArray[5]) * taxRateArray[5] + basePayableAmountArray[5];
                    return taxpayable;
                }
                case 7:
                {
                    taxpayable = (anuualIncome - minIncomeArray[6]) * taxRateArray[6] + basePayableAmountArray[6];
                    return taxpayable;
                }
                case 8:
                {
                    taxpayable = (anuualIncome - minIncomeArray[7]) * taxRateArray[7] + basePayableAmountArray[7];
                    return taxpayable;
                }
            }
            return 0;
        }

        static void PrintResult(int annualIncome,double taxPayable)
        {
            Console.WriteLine("For taxable annual income of {0:C}, the tax payable amount is {1:C}",annualIncome,taxPayable);
        }
    }
}