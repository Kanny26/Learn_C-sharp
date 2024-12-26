// La capacidad de un programa para ejecutar múltiples hilos de ejecución al mismo tiempo.

Thread hilo = new Thread(() => {
    Console.WriteLine("Hola desde otro hilo");
});
hilo.Start();

