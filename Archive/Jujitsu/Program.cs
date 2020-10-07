	using System;

namespace Jujitsu
{
    class Program
    {
        static void Main(string[] args)
        {
            // This only creates an object.
            JujitsuRanks bjjranks = new JujitsuRanks();

		//				bjjranks.ReturnRankColor('black');
            bjjranks.GetUserName();
            bjjranks.GetUserAge();
						bjjranks.GetUserRank();
        }
    }
}
