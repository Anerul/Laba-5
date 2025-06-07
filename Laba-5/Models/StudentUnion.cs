using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class StudentUnion
{
    [DisplayName("ФИО студента")]
    public string FullName { get; set; }

    [DisplayName("Номер студбилета")]
    public string StudentId { get; set; }

    [DisplayName("Дата вступления")]
    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }

    [DisplayName("Факультет")]
    public string Faculty { get; set; }

    [DisplayName("Средний балл")]
    public double AverageGrade { get; set; }

    [DisplayName("Активен в профсоюзе")]
    public bool IsActive { get; set; }
}