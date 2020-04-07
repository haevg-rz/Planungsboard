using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Planungsboard.Presentation.Message;
using Planungsboard.Presentation.Views;

namespace Planungsboard.Presentation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.LoadedCommand = new RelayCommand(this.LoadedCommandHandling);
            this.QuarterBackCommand = new RelayCommand(this.QuarterBackCommandHandling);
            this.QuarterNextCommand = new RelayCommand(this.QuarterNextCommandHandling);
            this.NewTeamCommand = new RelayCommand(this.NewTeamCommandHandling);

            this.DisplayQuarters = new List<string>
            {
                "Q1-2020",
                "Q2-2020",
                "Q3-2020",
                "Q4-2020"
            };

            var teams = new List<Team>
            {
                new Team
                {
                    Name = "Dev-Team #1",
                    Cards = CreateDebugData_Cards(),
                    Color = "#008080"
                },
                new Team
                {
                    Name = "Dev-Team #2",
                    Cards = CreateDebugData_Cards(),
                    Color = "#E8A88A"
                },
                new Team
                {
                    Name = "Dev-Team #3",
                    Cards = CreateDebugData_Cards(),
                    Color = "#003087"
                }
            };
            teams.ForEach(team => team.SetColor());
            this.Teams = new ObservableCollection<Team>(teams);

            var backlogCards = Enumerable.Range(0, 12).Select(_ => new Card()).ToList();
            var rnd = new Random();
            var alpha = "qwertzuioplkjhgfdsayxcvbnm";
            foreach (var c in backlogCards)
            {
                c.Effort = rnd.Next(1, 10) ^ 2;
                c.Id = rnd.Next(10000, 99999).ToString();
                c.Title = alpha.OrderBy(c => Guid.NewGuid()).Take(rnd.Next(3, 5)).Select(c => c.ToString()).Aggregate((s, s1) => s + s1).ToUpper();
            }

            this.BacklogCards = new ObservableCollection<Card>(backlogCards);

            var futureCards = Enumerable.Range(0, 21).Select(_ => new Card()).ToList();
            foreach (var c in futureCards)
            {
                c.Id = rnd.Next(10000, 99999).ToString();
                c.Title = alpha.OrderBy(c => Guid.NewGuid()).Take(rnd.Next(3, 5)).Select(c => c.ToString()).Aggregate((s, s1) => s + s1).ToUpper();
            }

            this.FutureCards = new ObservableCollection<Card>(futureCards);

            MessengerInstance.Register<DropMessage>(this,this.DropMessageHandling );
        }

        private void DropMessageHandling(DropMessage dropMessage)
        {
            if (dropMessage.Card.AssignedQuarter == null || !dropMessage.Card.AssignedQuarter.Any())
            {
                dropMessage.Card.AssignedQuarter = new List<string> {this.DisplayQuarters[dropMessage.DisplayQuarterIndex]};
            }

            dropMessage.Team.Cards.Add(dropMessage.Card);
            dropMessage.Team.SetColor();

            if (this.FutureCards.Contains(dropMessage.Card))
                this.FutureCards.Remove(dropMessage.Card);

            if (this.BacklogCards.Contains(dropMessage.Card))
                this.BacklogCards.Remove(dropMessage.Card);
            
            // TODO
            this.Teams = new ObservableCollection<Team>(this.Teams);
            base.RaisePropertyChanged(() => this.Teams);
        }

        public ObservableCollection<Card> FutureCards { get; set; }

        public ObservableCollection<Card> BacklogCards { get; set; }

        private (int quarter, int year) ConvertFromQuater(string input)
        {
            var quarter = int.Parse(input[1].ToString());
            var year = int.Parse(input.Substring(3, 4));

            return (quarter, year);
        }

        #region Helper

        private static List<Card> CreateDebugData_Cards()
        {
            var debugDataCards = new List<Card>
            {
                new Card
                {
                    AssignedQuarter = new List<string> {"Q1-2020", "Q2-2020", "Q3-2020", "Q4-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q2-2020", "Q3-2020", "Q4-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q1-2020", "Q2-2020", "Q3-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q1-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q2-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q3-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q4-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q1-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q2-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q3-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q4-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q1-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q2-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q3-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q4-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q1-2020", "Q2-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q3-2020", "Q4-2020"}
                },
                new Card
                {
                    AssignedQuarter = new List<string> {"Q2-2020", "Q3-2020"}
                }
            };

            var rnd = new Random();
            var alpha = "qwertzuioplkjhgfdsayxcvbnm";
            foreach (var debugDataCard in debugDataCards)
            {
                debugDataCard.Effort = rnd.Next(1, 10) ^ 2;
                debugDataCard.Id = rnd.Next(10000, 99999).ToString();
                debugDataCard.Title = alpha.OrderBy(c => Guid.NewGuid()).Take(rnd.Next(3, 5)).Select(c => c.ToString()).Aggregate((s, s1) => s + s1).ToUpper();
            }

            return debugDataCards;
        }

        #endregion

        #region Properties

        private List<string> displayQuarters;

        public List<string> DisplayQuarters
        {
            get => this.displayQuarters;
            set => this.Set(ref this.displayQuarters, value);
        }

        public ObservableCollection<Team> Teams { get; set; }

        private double teamLabelWidth;

        public double TeamLabelWidth
        {
            get => this.teamLabelWidth;
            set => this.Set(ref this.teamLabelWidth, value);
        }

        #endregion

        #region Commands

        public RelayCommand LoadedCommand { get; set; }
        public RelayCommand QuarterNextCommand { get; set; }
        public RelayCommand QuarterBackCommand { get; set; }
        public RelayCommand NewTeamCommand { get; set; }

        #endregion

        #region Commands Handling

        private void QuarterNextCommandHandling()
        {
            var newQuarterList = new List<string>();

            foreach (var displayQuarter in this.DisplayQuarters)
            {
                var (quarter, year) = this.ConvertFromQuater(displayQuarter);
                if (quarter == 4)
                {
                    quarter = 1;
                    year += 1;
                }
                else
                {
                    quarter += 1;
                }

                newQuarterList.Add($"Q{quarter}-{year}");
            }

            this.DisplayQuarters = newQuarterList;
        }

        private void NewTeamCommandHandling()
        {
            // TODO Don't access Windows in ViewModel
            var windows = new NewGenericEntityWindows<Team>();
            windows.ShowDialog();
            if (windows.Result != null) this.Teams.Add(windows.Result);
        }

        private void QuarterBackCommandHandling()
        {
            var newQuarterList = new List<string>();

            foreach (var displayQuarter in this.DisplayQuarters)
            {
                var (quarter, year) = this.ConvertFromQuater(displayQuarter);
                if (quarter == 1)
                {
                    quarter = 4;
                    year -= 1;
                }
                else
                {
                    quarter -= 1;
                }

                newQuarterList.Add($"Q{quarter}-{year}");
            }

            this.DisplayQuarters = newQuarterList;
        }

        private void LoadedCommandHandling()
        {
        }

        #endregion
    }


    public class Card
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Effort { get; set; }
        public List<string> AssignedQuarter { get; set; }
        public string Color { get; set; } = "#FA58F4";
    }

    public class Team
    {
        public Team()
        {
            const string hex = "ABCDEF0123456789";
            this.Color = "#" + Enumerable.Range(1, 6).Select(_ => hex.OrderBy(_ => Guid.NewGuid()).First().ToString()).Aggregate((s, s1) => s + s1);
        }

        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public string Color { get; set; }

        public void SetColor()
        {
            foreach (var card in this.Cards)
            {
                card.Color = this.Color;
            }
        }
    }
}