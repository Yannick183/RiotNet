﻿namespace RiotNet.Models
{
    /// <summary>
    /// Contains league participant information representing a summoner or team.
    /// </summary>
    public class LeagueEntry
    {
        /// <summary>
        /// Gets or sets a Roman numeral representing the division that the participant is in.
        /// </summary>
        public string Division { get; set; }

        /// <summary>
        /// Gets or sets whether the participant is fresh blood.
        /// </summary>
        public bool IsFreshBlood { get; set; }

        /// <summary>
        /// Gets or sets whether the participant is on a hot streak.
        /// </summary>
        public bool IsHotStreak { get; set; }

        /// <summary>
        /// Gets or sets whether the participant is inactive.
        /// </summary>
        public bool IsInactive { get; set; }

        /// <summary>
        /// Gets or sets whether the participant is a veteran.
        /// </summary>
        public bool IsVeteran { get; set; }

        /// <summary>
        /// Gets or sets the number of league points that the participant has.
        /// </summary>
        public int LeaguePoints { get; set; }

        /// <summary>
        /// Gets or sets the number of losses that the participant has.
        /// </summary>
        public int Losses { get; set; }

        public MiniSeries MiniSeries { get; set; }

        /// <summary>
        /// Gets or sets the participant's ID.
        /// </summary>
        public string PlayerOrTeamId { get; set; }

        /// <summary>
        /// Gets or sets the participant's name.
        /// </summary>
        public string PlayerOrTeamName { get; set; }

        /// <summary>
        /// Gets or sets the number of wins that the participant has.
        /// </summary>
        public int Wins { get; set; }
    }
}