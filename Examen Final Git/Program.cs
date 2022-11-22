using Ejercicio_1__Examen_Final_POO;
using System;

namespace Ejercicio_1_Examen_Final_POO;

class Program
{
    static void Main(string[] args)
    {
        //Realice un programa en consola en el cual pueda generar distintos tipos de vehículos con los siguientes miembros
        //marca, modelo, color, placa, tipo de transmisión y potencia motor.  Cree los siguientes vehículos: Autobús que
        //también tiene datos de numero de asientos, cantidad de neumáticos y numero de velocidades. Motocicleta que también
        //tiene peso máximo y un indicador de si tiene compartimiento en el asiento. Vehículo particular que tiene datos de
        //tipo tapicería (cuero, tela), sunroof y tipo vehículo (sedan, hatchback). Analice la jerarquía de clases y los la
        //distribución de los datos en las mismas (datos comunes y datos específicos). Implemente en cada una un comportamiento
        //de arrancar (el cual solo debe imprimir un mensaje). Imprima los datos de cada tipo, cree 3 instancias.
        
        Autobus autobus = new Autobus();

        Autobus autobus1 = new Autobus();
        autobus1.Marca = "Mercedez Benz";
        autobus1.Modelo = "2000";
        autobus1.Color = "Amarillo";
        autobus1.Placa = "P-456PCH";
        autobus1.TipoTransmision = "Trasera";
        autobus1.PotenciaMotor = "200";
        autobus1.CantidadAsientos = "24";
        autobus1.CantidadNeumaticos = "4";
        autobus1.CantidadVelocidades = "5";
        autobus1.MostrarDatos();

        Motocicleta motocicleta = new Motocicleta();

        Motocicleta motocicleta1 = new Motocicleta();
        motocicleta1.Marca = "YAMAHA";
        motocicleta1.Modelo = "2003";
        motocicleta1.Color = "Negra";
        motocicleta1.Placa = "P-930KHC";
        motocicleta1.TipoTransmision = "Trasera";
        motocicleta1.PotenciaMotor = "200";
        motocicleta1.PesoMaximo = "162Kg";
        motocicleta1.ComportamientoAsiento = "SI";
        motocicleta1.MostrarDatos(); 


    }
}
