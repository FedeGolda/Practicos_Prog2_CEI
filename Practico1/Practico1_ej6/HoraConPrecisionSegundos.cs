using System;

public class HoraConPrecisionSegundos
{
    private int Horas;
    private int Minutos;
    private int Segundos;

    public int GetHoras()
    {
        return Horas;
    }

    public int GetMinutos()
    {
        return Minutos;
    }

    public int GetSegundos()
    {
        return Segundos;
    }

    public void SetHoras(int horas)
    {
        this.Horas = horas;
    }

    public void SetMinutos(int minutos)
    {
        this.Minutos = minutos;
    }

    public void SetSegundos(int segundos)
    {
        this.Segundos = segundos;
    }

    public HoraConPrecisionSegundos(int horas, int minutos, int segundos)
    {
        // Verificar que los valores de hora, minutos y segundos estén en rangos válidos
        if (horas < 0 || horas > 23 || minutos < 0 || minutos > 59 || segundos < 0 || segundos > 59)
        {
            throw new ArgumentException("Los valores de hora, minutos y segundos deben estar dentro de rangos válidos.");
        }

        // Establecer los valores iniciales de la hora
        Horas = horas;
        Minutos = minutos;
        Segundos = segundos;
    }

    // Método para incrementar una hora de diferentes formas
    public void Incrementar(int horas = 0, int minutos = 0, int segundos = 0)
    {
        // Convertir la hora actual a segundos y agregar los segundos, minutos y horas especificados
        int totalSegundos = Horas * 3600 + Minutos * 60 + Segundos;
        totalSegundos += horas * 3600 + minutos * 60 + segundos;

        // Asegurarse de que el valor resultante sea positivo y esté dentro de un día (86400 segundos)
        totalSegundos = (totalSegundos + 86400) % 86400;

        // Actualizar los valores de horas, minutos y segundos
        Horas = totalSegundos / 3600;
        Minutos = (totalSegundos % 3600) / 60;
        Segundos = totalSegundos % 60;
    }

    // Método para calcular la diferencia de tiempo entre dos horas
    public TimeSpan CalcularDiferencia(HoraConPrecisionSegundos otraHora)
    {
        // Crear objetos DateTime para ambas horas
        DateTime hora1 = new DateTime(1, 1, 1, Horas, Minutos, Segundos);
        DateTime hora2 = new DateTime(1, 1, 1, otraHora.Horas, otraHora.Minutos, otraHora.Segundos);

        // Asegurarse de que la segunda hora sea mayor o igual a la primera
        if (hora2 < hora1)
        {
            hora2 = hora2.AddDays(1); // Agregar un día si es necesario
        }

        // Calcular la diferencia de tiempo y devolverla como un TimeSpan
        return hora2 - hora1;
    }

    // Método para sumar dos horas
    public static HoraConPrecisionSegundos SumarHoras(HoraConPrecisionSegundos hora1, HoraConPrecisionSegundos hora2)
    {
        // Convertir ambas horas a segundos y sumarlas
        int totalSegundos = hora1.Horas * 3600 + hora1.Minutos * 60 + hora1.Segundos +
                            hora2.Horas * 3600 + hora2.Minutos * 60 + hora2.Segundos;

        // Asegurarse de que el valor resultante esté dentro de un día (86400 segundos)
        totalSegundos %= 86400;

        // Calcular las horas, minutos y segundos resultantes
        int horasResultantes = totalSegundos / 3600;
        int minutosResultantes = (totalSegundos % 3600) / 60;
        int segundosResultantes = totalSegundos % 60;

        // Crear y devolver una nueva instancia de HoraConPrecisionSegundos con los valores resultantes
        return new HoraConPrecisionSegundos(horasResultantes, minutosResultantes, segundosResultantes);
    }
}