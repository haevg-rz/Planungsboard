using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation.DesignData
{
    public class DesignDataCard : Card
    {
        public DesignDataCard()
        {
            var rnd = new Random();
            var alpha = "qwertzuioplkjhgfdsayxcvbnm";
            this.Effort = rnd.Next(1, 10) ^ 2;
            this.Id = rnd.Next(10000, 99999).ToString();
            this.Title = alpha.OrderBy(c => Guid.NewGuid()).Take(rnd.Next(3, 5)).Select(c => c.ToString()).Aggregate((s, s1) => s + s1).ToUpper();
        }
    }
}
