// See https://aka.ms/new-console-template for more information


Console.WriteLine("JEUX du plus petit ou plus grand: insérer un nombre minimum puis maximum!");
//INIT...
int min = Convert.ToInt32(Console.ReadLine());

int max = Convert.ToInt32(Console.ReadLine());

//Create random number between min and max included
Random rnd = new Random();
int randomNb = rnd.Next(min,max+1);


//PLAY.
int response;
int attempt=0;
do
{
    attempt++;
    Console.WriteLine("Deviner le nombre entre "+min+" et "+max+" compris.");
    response = Convert.ToInt32(Console.ReadLine());

    if(response < randomNb){
        Console.WriteLine("plus grand que "+response);
    }
    else if(response > randomNb){
        Console.WriteLine("plus petit que "+response);
    }
} while (response != randomNb);

Console.WriteLine("YOU WIN !  (WITH "+attempt+" ATTEMPT !)");








