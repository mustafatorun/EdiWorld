﻿using EdiFileProcess.Attributes;

namespace EdiFileProcess.Models.Segments
{
    [EdiSegment(Path = "Q7")]
    public class Q7Segment
    {
        [EdiValue("X(1)", Order = 0, Description = "")]
        public string LadingExceptionCode { get; set; }

        [EdiValue("X(3)", Order = 1, Description = "")]
        public string PackagingFormCode { get; set; }

        [EdiValue("X(7)", Order = 2, Description = "")]
        public string LadingQuantity { get; set; }
    }
}