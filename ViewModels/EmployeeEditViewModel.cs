using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class EmployeeEditViewModel: EmployeeCreateViewModel
    {

        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
