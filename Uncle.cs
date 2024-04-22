

namespace Uncle_s_Pay
{
    public class Uncle
    {
        public String Name { get; set; }
        public int NumberOfKids { get; set; }


        public decimal CalculateFees(int PearlFees, int EbokuFees)
        {
            int totalFees = PearlFees + EbokuFees;

            Console.WriteLine($"Fees paid by {Name} for Pearl and Eboku are {totalFees}");

            return totalFees;
        }

    }
    }