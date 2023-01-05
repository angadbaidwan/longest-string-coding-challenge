namespace LongestString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // input array of names
            string[] heroArray = {"Ant-Man", "Black Panther", "Black Widow", "Captain America", "Doctor Strange", "Hawkeye", "Hulk", "Iron Man", 
            "Luke Cage", "Moon Knight", "Ms. Marvel", "Scarlet Witch", "Spider-Man", "Thor", "Wasp" };
            

            // set longestName to first element in name array
            string longestName = heroArray[0];


            // iterate and update longestName if a name is longer than the current longest name
            foreach (string hero in heroArray)
            {
                if (hero.Length > longestName.Length)
                {
                    longestName = hero;
                }
            }

            // output longest name
            Console.WriteLine("Longest Name: " + longestName);
        }
    }
}