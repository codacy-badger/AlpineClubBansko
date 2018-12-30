﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlpineClubBansko.Data.Models
{
    public class StoryComment : BaseComment
    {
        public string StoryId { get; set; }
        public virtual Story Story { get; set; }
    }
}
