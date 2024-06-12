namespace Starwars.Core.Entities.Filters
{
    public class FilterBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string TextToSearch { get; set; }
    }
}