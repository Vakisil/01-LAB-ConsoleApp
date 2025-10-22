using ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        ElektronickiUredjaji elektronickiUredjaji = new PametniTelefon("tablet", "Samsung", 2022, "Android");

        elektronickiUredjaji.IspisiInformacije();
    }
}