Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
// Test Data
daysUntilExpiration = 0;

string message;

// Create an if-else statement that displays a message about when the subscription will expire.
if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5) )
{
   message = "Your subscription will expire soon. Renew now!";
   Console.WriteLine(message);    
}
else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
{
    message = $"Your subscription expires in {daysUntilExpiration} days.";
    Console.WriteLine(message);
    discountPercentage = 10;
}
else if (daysUntilExpiration == 1) {
    message = "Your subscription expires within a day!";
    Console.WriteLine(message);
    discountPercentage = 20;
}
else
{
    message = "Your subscription has expired.";
    Console.WriteLine(message);
}

// Create a separate if statement that displays a discount offer.

if (discountPercentage > 0) 
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}