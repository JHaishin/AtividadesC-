class Program {
    static void Main(string[]args) {
        Console.WriteLine("Digite um número para a matriz: ");
        int n = int.Parse(Console.ReadLine());
        int [,] mat = new int [n,n];

        for (int i=0; i < n; i++) {
            string[] values = Console.ReadLine().Split(' ');

            for (int o = 0; o< n; o++) {
                mat[i,o]= int.Parse(values[o]);
            }
        }

        Console.WriteLine("Diagonal: ");
        for (int i=0; i<n; i++) {
            Console.WriteLine(mat[i,i] + " ");
        
        }

        Console.WriteLine();
        int count = 0;
        for (int i = 0; i < n; i++) {
            for (int o = 0; o< n; o++) {
                if (mat[i,o] < 0) {
                    count++;
                }
            }
        }

        Console.WriteLine("Os números negativos:" + count);

    }
}