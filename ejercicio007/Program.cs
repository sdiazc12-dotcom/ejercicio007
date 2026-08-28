namespace EjAlexySergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> DescripList = new List<string>();
            List<decimal> MonList = new List<decimal>();

            string opcion = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine("[[]]Registro De Control de Gastos Personales[[]]");
                Console.WriteLine();
                Console.WriteLine("Opcion 1: Agregar Gastos");
                Console.WriteLine("Opcion 2: Listar Gastos ");
                Console.WriteLine("Opcion 3: Buscar Gastos");
                Console.WriteLine("Opcion 4: Salir");
                Console.Write("Eliga Una Opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese La Descripcion");
                        string Descrip = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(Descrip))
                        {
                            Console.WriteLine("Datos Invalidos");
                        }
                        Descrip = Descrip.Trim();

                        Console.WriteLine("Ingrese el monto");
                        bool Montook = decimal.TryParse(Console.ReadLine(), out decimal Monto);
                        if (!Montook || Monto <= 0)
                        {
                            Console.WriteLine("Datos Invalidos");
                        }

                        DescripList.Add(Descrip);
                        MonList.Add(Monto);

                        Console.WriteLine("Datos Agregados");
                        break;
                    case "2":
                        Console.WriteLine();
                        int Element = DescripList.Count;
                        decimal Total = 0;
                        if (Element <= 0)
                        {
                            Console.WriteLine("No hay gastos");
                        }

                        for (int indice = 0; indice < Element; indice++)
                        {
                            Console.WriteLine($"Posicion: {indice + 1} Descripcion: {DescripList[indice]} - {MonList[indice]}");
                            Total = Total + MonList[indice];
                        }
                        Console.WriteLine($"Total: Q{Total}");
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el Gasto Que desee Buscar");
                        string Bus = Console.ReadLine();
                        Bus = Bus.ToLower();
                        bool Coincidencia = false;
                        if (string.IsNullOrWhiteSpace(Bus))
                        {
                            Console.WriteLine("Error");
                        }
                        for (int indice = 0; indice < DescripList.Count; indice++)
                        {
                            if (DescripList[indice].ToLower().Contains(Bus))
                            {
                                Console.WriteLine($"Gasto Encontrado {DescripList[indice]} - Q{MonList[indice]}");
                                Coincidencia = true;
                            }
                            if (!Coincidencia)
                            {
                                Console.WriteLine("Sin coincidencias");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saliendo");
                        break;
                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;





                }

            }
            while (opcion != "4");
        }
    }
}