Console.Write("Ingrese la cantidad de variables");

int N = int.Parse(Console.ReadLine());
int contador = 0;
for (int i = 0; i < N; i++) {
    Console.WriteLine("Ingrese una variable");
    int num = int.Parse(Console.ReadLine());
    if (num >= 1000) {
        contador++;
    }
}
Console.WriteLine($"La cantidad de valores mayor igual a 1000 es {contador}");