/*Matriz Aleatoria
static void RandomArray()
{   
    int valorMinimo = 25;
    int valorMaximo = 0;
    int suma = 0;
    int []numbers = new int [10];
    Random rand = new Random();
    for( int i=0; i<numbers.Length; i++){
        numbers[i]= rand.Next(5,25);
        if(numbers[i]>valorMaximo){
            valorMaximo = numbers[i];
        }
        if(numbers[i]<valorMinimo){
            valorMinimo = numbers[i];
        }
        Console.WriteLine($"El numero es: {numbers[i]}");
        suma = numbers[i] + suma;
    }
    Console.WriteLine($"La suma total es: {suma}");
    Console.WriteLine($"El valor minimo es: {valorMinimo}");
    Console.WriteLine($"El valor maximo es: {valorMaximo}");
}
RandomArray();

//Lanzamiento de Moneda

static string TossCoin(string estado="")
{   
    int moneda = 0;
    string resultado = "";
    Console.WriteLine("¡Tirando una moneda!");
    Random rand = new Random();
    moneda = rand.Next(0,2);
    if(moneda == 1){
        Console.WriteLine("Ha salido cara");
        resultado = "cara";
    }else{
        Console.WriteLine("Ha salido cruz");
        resultado = "cruz";
    }

    return resultado;    
}
string estado = TossCoin();
Console.WriteLine(estado);

//Nombres
Construye una función Nombres que devuelva una lista de cadenas. En esta función:​

Se requiere: 
Crea una lista con los valores Todd, Tiffany, Charlie, Ginebra, Sydney. ​
Devuelve una lista que solo incluya nombres de más de 5 caracteres. 
*/ 
static void Nombres(List<string> nombre)
{
    List<string>caracteres = new List<string>();
    for( int i=0; i<nombre.Count; i++){
        if(nombre[i].Length>5){
            Console.WriteLine(nombre[i]);
        }
    } 
    
}
List<string>nombres = new List<string>{"Todd", "Tiffany", "Charlie", "Ginebra", "Sydney"};
Nombres(nombres);