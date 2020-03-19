using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Planungsboard.Presentation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private List<Visual> visuals;
        private double teamLabelWidth;

        public MainViewModel()
        {
            LoadedCommand = new RelayCommand(Execute);

            this.DisplayQuarters = new List<string>()
            {
                "Q1-2020",
                "Q2-2020",
                "Q3-2020",
                "Q4-2020",
            };

            this.DisplayTeams = new List<string>()
            {
                "Dev-Team #1",
                "Dev-Team #2",
                "Dev-Team #3",
                "Dev-Team #4",
                "Dev-Team #5",
            };


            this.Teams = new List<Team>()
            {
                new Team()
                {
                    Name = "Dev-Team #1",
                    Visuals = CreateDebugData_Visuals(),
                },
                new Team()
                {
                    Name = "Dev-Team #2",
                    Visuals = CreateDebugData_Visuals(),
                },
            };

            this.Quarters = new List<Quarter>()
            {
                new Quarter()
                {
                    Name = "Q1-2020",
                    Teams = new List<Team>()
                    {
                        new Team()
                        {
                            Name = "Dev-Team #1",
                            Cards = new List<Card>()
                            {
                                new Card()
                                {
                                    Id = "1234"
                                },
                                new Card()
                                {
                                    Id = "1234"
                                },
                            }
                        },
                        new Team()
                        {
                            Name = "Dev-Team #2",
                            Cards = new List<Card>()
                            {
                                new Card()
                                {
                                    Id = "2432"
                                },
                                new Card()
                                {
                                    Id = "2432"
                                },
                            }
                        },
                    }
                },
                new Quarter()
                {
                    Name = "Q2-2020",
                    Teams = new List<Team>()
                    {
                        new Team()
                        {
                            Name = "Dev-Team #1",
                            Cards = new List<Card>()
                            {
                                new Card()
                                {
                                    Id = "3244"
                                },
                                new Card()
                                {
                                    Id = "3244"
                                },
                            }
                        },
                        new Team()
                        {
                            Name = "Dev-Team #2",
                            Cards = new List<Card>()
                            {
                                new Card()
                                {
                                    Id = "5435"
                                },
                                new Card()
                                {
                                    Id = "5435"
                                },
                            }
                        },
                    }
                },
            };

            this.Visuals = CreateDebugData_Visuals();
        }

        public double TeamLabelWidth
        {
            get => teamLabelWidth;
            set => base.Set(ref teamLabelWidth, value);
        }

        private static List<Visual> CreateDebugData_Visuals()
        {
            return new List<Visual>()
            {
                new Visual()
                {
                    LeftMargin = 1,
                    RightMargin = 2,
                    Id = "123",
                },
                new Visual()
                {
                    LeftMargin = 0,
                    RightMargin = 0,
                    Id = "456",
                },
                new Visual()
                {
                    LeftMargin = 2,
                    RightMargin = 1,
                    Id = "789",
                },
                new Visual()
                {
                    LeftMargin = 3,
                    RightMargin = 0,
                    Id = "234",
                },
            };
        }

        private void Execute()
        {
            //this.Visuals = new List<Visual>(){
            //    new Visual()
            //    {
            //        LeftMargin = 1,
            //        RightMargin = 2,
            //        Id = "123",
            //    },
            //    new Visual()
            //    {
            //        LeftMargin = 0,
            //        RightMargin = 0,
            //        Id = "456",
            //    },
            //    new Visual()
            //    {
            //        LeftMargin = 2,
            //        RightMargin = 1,
            //        Id = "789",
            //    },
            //    new Visual()
            //    {
            //        LeftMargin = 3,
            //        RightMargin = 0,
            //        Id = "234",
            //    },
            //};
        }

        public List<Visual> Visuals
        {
            get => visuals;
            set => base.Set(ref visuals, value);
        }

        public List<string> DisplayTeams { get; set; }


        public List<Quarter> Quarters { get; set; }
        public List<String> DisplayQuarters { get; set; }


        public List<Team> Teams { get; set; }

        public RelayCommand LoadedCommand { get; set; }
    }


    public class Visual
    {
        public double LeftMargin { get; set; }
        public double RightMargin { get; set; }
        public string Id { get; set; }
    }

    public class Quarter
    {
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
    }

    public class Team
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public List<Visual> Visuals { get; set; }
    }

    public class Card
    {
        public string Id { get; set; }
        public List<Quarter> ActiveQuarterNames { get; set; }
    }
}