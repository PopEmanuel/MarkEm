﻿using System;

namespace Org.Webelopers.Api.Models.Persistence.Contracts
{
    public class SemesterContractDto
    {
        public Guid Id { get; set; }
        public Guid ContractId { get; set; }
        public short Semester { get; set; }
        public Guid? OptionalCourseId { get; set; }
        public string OptionalCourseName { get; set; }
    }
}
