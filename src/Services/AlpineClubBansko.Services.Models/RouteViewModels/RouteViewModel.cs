﻿using AlpineClubBansko.Data.Models;
using AlpineClubBansko.Services.Mapping.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlpineClubBansko.Services.Models.RouteViewModels
{
    public class RouteViewModel : IMapTo<Route>, IMapFrom<Route>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string TimeNeeded { get; set; }

        public User Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Story Story { get; set; }

        public Album Album { get; set; }

        public List<LocationViewModel> Locations { get; set; }

        public string RoutePoints
        {
            get
            {
                if (Locations.Count == 0) return string.Empty;
                return $"{Locations.FirstOrDefault().Name} - {Locations.LastOrDefault().Name}";
            }
        }

        public int Rating { get; set; }
    }
}