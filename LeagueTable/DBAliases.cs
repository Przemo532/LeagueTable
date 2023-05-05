using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTable
{
    
    partial class Team
    {
        public EntitySet<Match> MatchesGuest
        {
            get
            {
                return Matches;
        }
        }
        public EntitySet<Match> MatchesHost
        {
            get
            {
                return Matches1;
            }
        }

        public override string ToString()
        {
            return name;
        }
            
        public int ScoredGoalHostCount
        {
            get
            {
                return this.MatchesHost.Sum(m => m.GoalHost);
            }
        }

        public int ScoredGoalGuestCount
        {
            get
            {
                return this.MatchesGuest.Sum(m => m.GoalGuest);
            }
        }

        public int ScoredGoalTotalCount
        {
            get
            {
                return this.ScoredGoalGuestCount + this.ScoredGoalHostCount;
            }
        }

        public int LostGoalHostCount
        {
            get
            {
                return this.MatchesHost.Sum(m => m.GoalGuest);
            }
        }

        public int LostGoalGuestCount
        {
            get
            {
                return this.MatchesGuest.Sum(m => m.GoalHost);
            }
        }

        public int LostGoalTotalCount
        {
            get
            {
                return this.LostGoalGuestCount + this.LostGoalHostCount;
            }
        }


        public int HostLeaguePointsCount
        {
            get
            {
                return this.MatchesHost.Sum(m => m.HostLeaguePoints);
            }
        }

        public int GuestLeaguePointsCount
        {
            get
            {
                return this.MatchesGuest.Sum(m => m.GuestLeaguePoints);
            }
        }

        public int TotalLeaguePoints
        {
            get
            {
                return this.HostLeaguePointsCount + this.GuestLeaguePointsCount;
            }
        }

    }
        partial class Match
        {
            public Team TeamGuest
            {
                get
                {
                    return Team;
                }
                set
                {
                    Team = value;
                }
            }
            public Team TeamHost
            {
                get
                {
                    return Team1;
                }
                set
                {
                    Team1 = value;
                }
            }

        public int HostLeaguePoints
        {
            get
            {
                if (GoalHost > GoalGuest)
                {
                    return 3;
                }
                else if(GoalHost < GoalGuest)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public int GuestLeaguePoints
        {
            get
            {
                if (GoalGuest > GoalHost)
                {
                    return 3;
                }
                else if (GoalGuest < GoalHost)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
