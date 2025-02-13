﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Org.Webelopers.Api.Models.DbEntities
{
    public class OptionalCoursePreference
    {
        [Key]
        public Guid Id { get; set; }

        public short Preference { get; set; }

        [ForeignKey("Id")]
        public Guid StudentContractSemesterId { get; set; }

        [ForeignKey("Id")]
        public Guid OptionalCourseId { get; set; }

        #region References

        public virtual OptionalCourse OptionalCourse { get; set; }

        public virtual StudentContractSemester StudentContractSemester { get; set; }

        #endregion
    }
}
