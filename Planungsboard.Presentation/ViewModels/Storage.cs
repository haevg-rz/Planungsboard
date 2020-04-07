using System.Collections.Generic;

namespace Planungsboard.Presentation.ViewModels
{
    public class Storage
    {
        public IEnumerable<Card> BacklogCards { get; set; }
        public IEnumerable<Card> FutureCards { get; set; }
        public IEnumerable<Team> Teams { get; set; }
    }
}