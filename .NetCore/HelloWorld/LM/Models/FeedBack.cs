using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public class FeedBack
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage ="请留下你的名字")]
        [StringLength(50, ErrorMessage ="名字不超过20个字")]
        public string Name { get; set; }

        [Required(ErrorMessage ="请留下你的邮箱")]
        [StringLength(50, ErrorMessage ="邮箱不能超过20个字")]
        [DataType(DataType.EmailAddress, ErrorMessage ="邮箱格式不正确")]
        public string Email { get; set; }

        [Required(ErrorMessage ="请留下你的评价")]
        [StringLength(400, ErrorMessage ="评价不能超过200个字")]
        public string Message { get; set; }
    }
}
