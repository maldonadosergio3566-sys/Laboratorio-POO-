namespace Ejercicio_4
{
    internal class Program
    {
        class Computo
        {
            public int CodigoEquipo;
            public string Marca;
            public string Modelo;
            public string Tipo;
            public int RAM;
            public int CapacidadAlmacenamiento;
            public string SistemaOperativo;
            public string NombrePropietario;
            public string Estado;
            public Computo(int codigoequipo, string marca, string modelo, string tipo, int ram, int capacidadalmacenamiento, string sistemaoperativo, string nombrepropietario, string estado)
            {
                CodigoEquipo = codigoequipo;
                Marca = marca;
                Modelo = modelo;
                Tipo = tipo;
                RAM = ram;
                CapacidadAlmacenamiento = capacidadalmacenamiento;
                SistemaOperativo = sistemaoperativo;
                NombrePropietario = nombrepropietario;
                Estado = estado;


            }
            public void mostrarDatos()
            {
                Console.WriteLine("==================DATOS DEL EQUIPO===================");
                Console.WriteLine($"CodigoEquipo: {CodigoEquipo}");
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine($"Modelo: {Modelo}");
                Console.WriteLine($"Tipo: {Tipo}");
                Console.WriteLine($"RAM: {RAM} GB");
                Console.WriteLine($"CapacidadAlmacenamiento: {CapacidadAlmacenamiento} GB/SSD");
                Console.WriteLine($"SistemaOperativo: {SistemaOperativo}");
                Console.WriteLine($"NombrePropietario: {NombrePropietario} ");
                Console.WriteLine($"Estado: {Estado}");
               
            }
            public void AumentarMemoria(int ram)
            {
                RAM = RAM + ram;
            }
            public void ModificarPropietario(string NuevoPropietario)
            {
                NombrePropietario = NuevoPropietario;
            }
            public void ModificarEstado(string NuevoEstado)
            {
                Estado = NuevoEstado;
            }

        }
        
        static void Main(string[] args)
        {

            Dictionary<int, Computo> EquipoComputo = new Dictionary<int, Computo>();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("===================THE MENU====================");
                Console.WriteLine("1..Registrar un equipo");
                Console.WriteLine("2.. Mostrar todos los Equipos");
                Console.WriteLine("3..Buscar un equipo por codigo.");
                Console.WriteLine("4..Aumentar memoria RAM");
                Console.WriteLine("5..Cambiar Responsable.");
                Console.WriteLine("6..Cambiar estado del equipo");
                Console.WriteLine("7..Eliminar un equipo");
                Console.WriteLine("8..Salir del programa");
                Console.WriteLine("Ingrese opcion:");
                Console.WriteLine("================================================");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Codigo del Equipo:");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        if (EquipoComputo.ContainsKey(codigo))
                        {
                            Console.WriteLine("No se puede agregar codigos repetidos");
                        }
                        else
                        {
                            
                            Console.WriteLine("ingrese la marca:");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Infrese el Modelo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("ingrese el Tipo de equipo");
                            string tipo = Console.ReadLine();
                            Console.WriteLine("Ingrese la RAM");
                            int ram = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese La capacidad de almacenamiento.");
                            int capacidadalmacenamiento = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese el sistema operativo.");
                            string sistemaoperativo = Console.ReadLine();
                            Console.WriteLine("Nombre del propietario");
                            string nombrepropietario = Console.ReadLine();
                            Console.WriteLine("Ingrese el estado");
                            string estado = Console.ReadLine();
                            Computo ComputoT = new Computo(codigo, marca, modelo, tipo, ram, capacidadalmacenamiento, sistemaoperativo, nombrepropietario, estado);
                            EquipoComputo.Add(codigo, ComputoT);
                            Console.WriteLine("El equipo se ha guardado exitosamente.");
                        }
                        break;
                    case 2:
                        if (EquipoComputo.Count == 0)
                        {
                            Console.WriteLine("Error no se han encontrado equipos registrados");
                        }
                        else
                        {
                            Console.WriteLine("============Lista de Equipos de Computo=================");
                            foreach (var Equipos in EquipoComputo.Values)
                            {
                                Equipos.mostrarDatos();
                            }
                            Console.WriteLine("=========================================================");
                        }

                        break;
                    case 3:

                        if (EquipoComputo.Count == 0)
                        {
                            Console.WriteLine("Error no hay equipos registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el codigo del equipo:");
                            int buscar = int.Parse(Console.ReadLine());
                            if (EquipoComputo.ContainsKey(buscar))
                            {
                                EquipoComputo[buscar].mostrarDatos();
                            }
                            else
                            {
                                Console.WriteLine("Error el equipo no se encuentra en la base de datos.");
                            }
                        }
                        break;
                    case 4:
                        if (EquipoComputo.Count > 0)
                        {
                            Console.WriteLine("Ingrese el codigo del equipo ha modificar.");
                            int modificar = int.Parse(Console.ReadLine());
                            if (EquipoComputo.ContainsKey(modificar))
                            {
                                Console.WriteLine("Ingrese la cantidad de memoria ha aumentar");
                                int aumentar = int.Parse(Console.ReadLine());
                                EquipoComputo[modificar].AumentarMemoria(aumentar);
                                Console.WriteLine("Memoria modificada con exito");
                            }
                            else
                            {
                                Console.WriteLine("Error el equipo ingresado no se ecuentra en la base de datos");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error no hay equipos resgistrados");
                        }
                        break;
                    case 5:
                        if (EquipoComputo.Count == 0)
                        {
                            Console.WriteLine(" Error no hay equipos registrados");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el codigo del equipo del propietario ha modificar");
                            int modificar = int.Parse(Console.ReadLine());
                            if (EquipoComputo.ContainsKey(modificar))
                            {
                                Console.WriteLine("ingrese el nuevo propietario");
                                string nuevoPropietario = Console.ReadLine();
                                EquipoComputo[modificar].ModificarPropietario(nuevoPropietario);
                                Console.WriteLine("Propietario modificado con exito.");
                            }
                            else
                            {
                                Console.WriteLine("Error el codigo no se encuentra en la base de datos");
                            }
                        }

                        break;
                    case 6:
                        if (EquipoComputo.Count == 0)
                        {
                            Console.WriteLine("Error no hay equipos registrados en la base de datos");
                        }
                        else
                        {
                            Console.WriteLine("ingrese el codigo del equipo al cual desea modificar su estado.");
                            int cambiar =int.Parse(Console.ReadLine());
                            if (EquipoComputo.ContainsKey(cambiar))
                            {
                                Console.WriteLine("Ingrese el nuevo estado del equipo");
                                string nuevoEstado = Console.ReadLine();
                                EquipoComputo[cambiar].ModificarEstado(nuevoEstado);
                                Console.WriteLine("El estado ha sido modificado exitosamente");
                            }
                        }
                        break;
                    case 7:
                        if (EquipoComputo.Count == 0)
                        {
                            Console.WriteLine("Erro no hay equipos regritrados");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el codigo del equipo a eliminar");
                                int eliminar = int.Parse(Console.ReadLine());
                            if (EquipoComputo.Remove(eliminar))
                            {
                                Console.WriteLine("Equipo Eliminado exitosamente");
                            }
                            else
                            {
                                Console.WriteLine("Error codigo inexistente en la base de datos");
                            }
                        }
                        Console.WriteLine("Saliendo del programa gracias por usar nuestra base de datos");
                        break;
                    default:
                        Console.WriteLine(" opcion inexitente en el menu");
                        break;              
                }
                if (opcion != 8)
                {
                    Console.WriteLine("Precione enter para continuar");
                    Console.ReadKey();
                }
            } while (opcion != 8);
            Console.WriteLine("=====Gracias por usar nuestro codigo=======.");


        }
    }
}
