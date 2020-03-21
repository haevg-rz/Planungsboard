using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Planungsboard.Presentation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            LoadedCommand = new RelayCommand(LoadedCommandHandling);

            this.DisplayQuarters = new List<string>()
            {
                "Q1-2020",
                "Q2-2020",
                "Q3-2020",
                "Q4-2020",
            };

            this.Teams = new List<Team>()
            {
                new Team()
                {
                    Name = "Dev-Team #1",
                    Cards = CreateDebugData_Cards(),
                },
                new Team()
                {
                    Name = "Dev-Team #2",
                    Cards = CreateDebugData_Cards(),
                },
            };
        }

        #region Properties

        public List<String> DisplayQuarters { get; set; }
        public List<Team> Teams { get; set; }
        private double teamLabelWidth;

        public double TeamLabelWidth
        {
            get => teamLabelWidth;
            set => base.Set(ref teamLabelWidth, value);
        }

        #endregion

        #region Commands

        public RelayCommand LoadedCommand { get; set; }

        #endregion

        #region Commands Handling

        private void LoadedCommandHandling()
        {
        }

        #endregion

        #region Helper

        private static List<Card> CreateDebugData_Cards()
        {
            var debugDataCards = new List<Card>()
            {
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q1-2020", "Q2-2020", "Q3-2020", "Q4-2020",},
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q2-2020", "Q3-2020", "Q4-2020",},
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q1-2020", "Q2-2020", "Q3-2020"},
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q1-2020"},
                    Id = "456",
                    Effort = 12,
                    Title = "TuFp"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q2-2020"},
                    Id = "789",
                    Effort = 12,
                    Title = "BER"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q3-2020"},
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q4-2020"},
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q1-2020"},
                    Id = "456",
                    Effort = 12,
                    Title = "TuFp"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q2-2020"},
                    Id = "789",
                    Effort = 12,
                    Title = "BER"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q3-2020"},
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q4-2020"},
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q1-2020"},
                    Id = "456",
                    Effort = 12,
                    Title = "TuFp"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q2-2020"},
                    Id = "789",
                    Effort = 12,
                    Title = "BER"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q3-2020"},
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q4-2020"},
                    Id = "234",
                    Effort = 12,
                    Title = "YQml"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q1-2020", "Q2-2020",},
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q3-2020", "Q4-2020",},
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
                new Card()
                {
                    AssignedQuarter = new List<string> {"Q2-2020", "Q3-2020",},
                    Id = "123",
                    Effort = 12,
                    Title = "TIZU"
                },
            };

            var rnd = new Random();
            var alpha = "qwertzuioplkjhgfdsayxcvbnm";
            foreach (var debugDataCard in debugDataCards)
            {
                debugDataCard.Effort = rnd.Next(1, 10)^2;
                debugDataCard.Id = rnd.Next(10000,99999).ToString();
                debugDataCard.Title = alpha.OrderBy(c => Guid.NewGuid()).Take(rnd.Next(3,5)).Select(c => c.ToString()).Aggregate((s, s1) => s+s1).ToUpper();
            }

            return debugDataCards;
        }

        #endregion
    }


    public class Card
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Effort { get; set; }
        public List<string> AssignedQuarter { get; set; }
    }

    public class Team
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}