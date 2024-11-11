namespace Starwars.Core.Config
{
    public interface IConfig
    {
        string Titulo { get; set; }
        string ConnectionString { get; set; }
    }
}
