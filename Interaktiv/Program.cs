Console.WriteLine("Är du lång?");
string tall = Console.ReadLine();

// if (tall == "ja" || tall == "JA" || tall == "Ja" || tall == "jA")

if (tall.ToLower() == "ja")
{
  Console.WriteLine("Kul för dig!");
}
else if (tall == "kanske")
{
  Console.WriteLine("okej?");
}
else
{
  Console.WriteLine("trist...");
}





Console.ReadLine();